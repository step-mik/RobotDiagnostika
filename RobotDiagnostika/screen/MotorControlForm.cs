using RobotDiagnostika.Logic;
using RobotDiagnostika.Serial;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace RobotDiagnostika.screen
{
    public partial class MotorControlForm : Form
    {
        private LeftMotorController leftMotor;
        private RightMotorController rightMotor;
        private SerialManager serial;
        private MotorChartManager leftChartManager;
        private MotorChartManager rightChartManager;
        private SerialDataRouter? serialRouter;

        public MotorControlForm(SerialManager serial)
        {
            InitializeComponent();
            this.serial = serial;

            leftMotor = new LeftMotorController(btnLeftMotor, serial);
            rightMotor = new RightMotorController(btnRightMotor, serial);

            // Reverz
            btnLeftReverse.Click += (s, e) => leftMotor.Reverse();
            btnRightReverse.Click += (s, e) => rightMotor.Reverse();

            // Rychlost
            trackLeftSpeed.Scroll += (s, e) => leftMotor.SetSpeed(trackLeftSpeed.Value);
            trackRightSpeed.Scroll += (s, e) => rightMotor.SetSpeed(trackRightSpeed.Value);

            // Připojení grafů
            leftChartManager = new MotorChartManager(chartLeft);
            rightChartManager = new MotorChartManager(chartRight);

            // Použít router pro příjem dat
            serialRouter = new SerialDataRouter(serial.Port);
            serialRouter.OnStatusLine += HandleStatusLine;
        }

        private void HandleStatusLine(string line)
        {
            if (!IsHandleCreated || IsDisposed)
                return;

            Invoke(() =>
            {
                if (line.StartsWith("STATUS L:") && !logBoxLeft.IsDisposed)
                {
                    int speed = ParseSpeed(line);
                    logBoxLeft.AppendText(line + Environment.NewLine);
                    leftChartManager.AddPoint(speed);
                }
                else if (line.StartsWith("STATUS R:") && !logBoxRight.IsDisposed)
                {
                    int speed = ParseSpeed(line);
                    logBoxRight.AppendText(line + Environment.NewLine);
                    rightChartManager.AddPoint(speed);
                }
            });
        }

        private int ParseSpeed(string line)
        {
            try
            {
                var parts = line.Split(' ');
                foreach (var part in parts)
                {
                    if (part.StartsWith("SPEED:"))
                        return int.Parse(part.Substring(6));
                }
            }
            catch { }

            return 0;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Odhlásit router
            serialRouter?.Detach();

            // Zavřít port (pokud je otevřený)
            if (serial?.Port?.IsOpen == true)
                serial.Port.Close();

            // Stop motory
            serial?.Send("LEFT_OFF");
            serial?.Send("RIGHT_OFF");
        }
    }
}
