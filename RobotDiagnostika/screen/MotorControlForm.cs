using RobotDiagnostika.Logic;
using RobotDiagnostika.Serial;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RobotDiagnostika.screen
{
    public partial class MotorControlForm : Form
    {
        private LeftMotorController leftMotor;
        private RightMotorController rightMotor;
        private SerialManager serial;

        private int pointIndexLeft = 0;
        private int pointIndexRight = 0;

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

            serial.Port.DataReceived += SerialDataReceived;

            // Inicializace os grafů
            chartLeft.ChartAreas[0].AxisX.Minimum = 0;
            chartLeft.ChartAreas[0].AxisX.Maximum = 100;
            chartLeft.ChartAreas[0].AxisX.Interval = 10;

            chartRight.ChartAreas[0].AxisX.Minimum = 0;
            chartRight.ChartAreas[0].AxisX.Maximum = 100;
            chartRight.ChartAreas[0].AxisX.Interval = 10;
        }

        private void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = serial.Port.ReadLine().Trim();

                if (!IsHandleCreated)
                    return;

                if (line.StartsWith("STATUS L:") && !logBoxLeft.IsDisposed)
                {
                    int speed = ParseSpeed(line);
                    Invoke(() =>
                    {
                        logBoxLeft.AppendText(line + Environment.NewLine);

                        var series = chartLeft.Series["Speed"];
                        series.Points.AddXY(pointIndexLeft++, speed);

                        if (series.Points.Count > 100 && pointIndexLeft % 50 == 0)
                        {
                            for (int i = 0; i < 50; i++)
                                series.Points.RemoveAt(0);

                            var area = chartLeft.ChartAreas[0];
                            area.AxisX.Minimum = pointIndexLeft - 100;
                            area.AxisX.Maximum = pointIndexLeft;
                        }
                    });
                }
                else if (line.StartsWith("STATUS R:") && !logBoxRight.IsDisposed)
                {
                    int speed = ParseSpeed(line);
                    Invoke(() =>
                    {
                        logBoxRight.AppendText(line + Environment.NewLine);

                        var series = chartRight.Series["Speed"];
                        series.Points.AddXY(pointIndexRight++, speed);

                        if (series.Points.Count > 100 && pointIndexRight % 50 == 0)
                        {
                            for (int i = 0; i < 50; i++)
                                series.Points.RemoveAt(0);

                            var area = chartRight.ChartAreas[0];
                            area.AxisX.Minimum = pointIndexRight - 100;
                            area.AxisX.Maximum = pointIndexRight;
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                if (!IsHandleCreated) return;

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

            if (serial != null)
                serial.Port.DataReceived -= SerialDataReceived;

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
