using RobotDiagnostika.Serial;
using RobotDiagnostika.Logic;
using System.IO.Ports;
using RobotDiagnostika.screen;

namespace RobotDiagnostika

{
    public partial class Form1 : Form
    {
        private SerialManager? serial;
        private SerialDataRouter? serialRouter;
        private BatteryInfoForm? batteryInfoForm;


        public Form1()
        {
            InitializeComponent();

            comboPorts.Items.AddRange(SerialPort.GetPortNames());
            btnLedOn.Click += btnLedOn_Click;
            btnLedOff.Click += btnLedOff_Click;
            btnConnect.Click += btnConnect_Click;
            this.Controls.Add(this.btnMotor);
            this.Controls.Add(this.btnBatteryInfo);
            this.Controls.Add(this.btnSensor);


        }


        // pripojení k COM portu
        private void btnConnect_Click(object? sender, EventArgs e)
        {
            if (comboPorts.SelectedItem is null)
            {
                MessageBox.Show("Vyber COM port.");
                return;
            }

            if (serial != null && serial.IsOpen)
            {
                MessageBox.Show("Už jsi připojený!");
                return;
            }

            try
            {
                serial = new SerialManager(comboPorts.SelectedItem.ToString()!);
                serial.Open();

                // Vytvoříme router po otevření portu
                serialRouter = new SerialDataRouter(serial.Port);
                serialRouter.OnBatteryStatus += HandleBatteryLine;


                MessageBox.Show("Připojeno!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při připojení: " + ex.Message);
            }
        }


        private void btnLedOn_Click(object? sender, EventArgs e)
        {
            serial?.Send(LedCommand.On);
        }

        private void btnLedOff_Click(object? sender, EventArgs e)
        {
            serial?.Send(LedCommand.Off);
        }



        private void btnMotor_Click(object? sender, EventArgs e)
        {
            if (serial == null || serialRouter == null)
            {
                MessageBox.Show("Nejprve se připoj k sériovému portu.");
                return;
            }

            var motorForm = new MotorControlForm(serial, serialRouter);
            motorForm.Show();
        }


        private void btnSensor_Click(object sender, EventArgs e)
        {
           var sensorForm = new SensorControlForm();
            sensorForm.Show();
        }

        private void HandleBatteryLine(string line)
        {
            if (!IsHandleCreated || IsDisposed) return;

            Invoke(() =>
            {
                double voltage = BatteryIndicator.CalculateVoltageFromLine(line);
                int percent = BatteryIndicator.CalculatePercentFromLine(line);

                lblPercent.Text = $"{percent}%";
                progressBattery.Value = Math.Clamp(percent, 0, 100);
                batteryLogBox.AppendText(line + Environment.NewLine);

                // 🔁 aktualizuj BatteryInfoForm (pokud je otevřený)
                batteryInfoForm?.UpdateBatteryInfo(voltage, percent, line);
            });
        }




        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            serialRouter?.Detach();

            if (serial?.Port?.IsOpen == true)
                serial.Port.Close();
        }

        private void btnBatteryInfo_Click(object sender, EventArgs e)
        {
            if (batteryInfoForm == null || batteryInfoForm.IsDisposed)
            {
                batteryInfoForm = new BatteryInfoForm();
                batteryInfoForm.Show();
            }
            else
            {
                batteryInfoForm.BringToFront();
            }
        }






    }
}
 