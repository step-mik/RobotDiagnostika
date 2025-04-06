using RobotDiagnostika.Logic;
using RobotDiagnostika.Serial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        public MotorControlForm(SerialManager serial)
        {
            InitializeComponent();
            this.serial = serial; // ✅ nutné přiřazení!

            leftMotor = new LeftMotorController(btnLeftMotor, serial);
            rightMotor = new RightMotorController(btnRightMotor, serial);

            // Reverz
            btnLeftReverse.Click += (s, e) => leftMotor.Reverse();
            btnRightReverse.Click += (s, e) => rightMotor.Reverse();

            // Rychlost
            trackLeftSpeed.Scroll += (s, e) => leftMotor.SetSpeed(trackLeftSpeed.Value);
            trackRightSpeed.Scroll += (s, e) => rightMotor.SetSpeed(trackRightSpeed.Value);

            serial.Port.DataReceived += SerialDataReceived;

            leftChartManager = new MotorChartManager(chartLeft);
            rightChartManager = new MotorChartManager(chartRight);

        }


        private void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = serial.Port.ReadLine();

                if (!IsHandleCreated)
                    return;

                if (line.StartsWith("STATUS L:") && !logBoxLeft.IsDisposed)
                {
                    int speed = ParseSpeed(line);
                    Invoke(() =>
                    {
                        logBoxLeft.AppendText(line + Environment.NewLine);
                        leftChartManager.AddPoint(speed);
                    });
                }
                else if (line.StartsWith("STATUS R:") && !logBoxRight.IsDisposed)
                {
                    int speed = ParseSpeed(line);
                    Invoke(() =>
                    {
                        logBoxRight.AppendText(line + Environment.NewLine);
                        rightChartManager.AddPoint(speed);
                    });
                }
            }
            catch (Exception ex)
            {
                if (!IsHandleCreated)
                    return;

                Invoke(() =>
                {
                    logBoxLeft.AppendText("[ERROR] " + ex.Message + Environment.NewLine);
                    logBoxRight.AppendText("[ERROR] " + ex.Message + Environment.NewLine);
                });
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Odhlaš posluchač dat
            if (serial != null)
                serial.Port.DataReceived -= SerialDataReceived;

            // Zastav oba motory
            serial?.Send("LEFT_OFF");
            serial?.Send("RIGHT_OFF");
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


    }

}