// MotorControlForm.cs
using RobotDiagnostika.Logic;
using RobotDiagnostika.Serial;
using System;
using System.Windows.Forms;

namespace RobotDiagnostika.screen
{
    public partial class MotorControlForm : Form
    {
        private readonly LeftMotorController leftMotor;
        private readonly RightMotorController rightMotor;
        private readonly SerialManager serial;
        private readonly SerialDataRouter router;
        private readonly MotorChartManager leftChartManager;
        private readonly MotorChartManager rightChartManager;

        public MotorControlForm(SerialManager serial, SerialDataRouter router)
        {
            InitializeComponent();
            this.serial = serial;
            this.router = router;

            leftMotor = new LeftMotorController(btnLeftMotor, serial);
            rightMotor = new RightMotorController(btnRightMotor, serial);

            btnLeftReverse.Click += (s, e) => leftMotor.Reverse();
            btnRightReverse.Click += (s, e) => rightMotor.Reverse();

            trackLeftSpeed.Scroll += (s, e) => leftMotor.SetSpeed(trackLeftSpeed.Value);
            trackRightSpeed.Scroll += (s, e) => rightMotor.SetSpeed(trackRightSpeed.Value);

            leftChartManager = new MotorChartManager(chartLeft);
            rightChartManager = new MotorChartManager(chartRight);

            this.router.OnMotorStatus += HandleMotorStatus;

            TopMost = true; // 🧠 vždy nahoře
        }

        private void HandleMotorStatus(string line)
        {
            if (!IsHandleCreated || IsDisposed) return;

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
            router.OnMotorStatus -= HandleMotorStatus;
        }
    }
}
