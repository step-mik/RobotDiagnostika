using RobotDiagnostika.Serial;
using RobotDiagnostika.Logic;
using System.IO.Ports;
using RobotDiagnostika.screen;

namespace RobotDiagnostika

{
    public partial class Form1 : Form
    {
        private SerialManager? serial;

        public Form1()
        {
            InitializeComponent();

            comboPorts.Items.AddRange(SerialPort.GetPortNames());
            btnLedOn.Click += btnLedOn_Click;
            btnLedOff.Click += btnLedOff_Click;
            btnConnect.Click += btnConnect_Click;
            this.Controls.Add(this.btnMotor);
            this.Controls.Add(this.btnServo);
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
                MessageBox.Show("Už jsi pripojený!");
                return;
            }

            try
            {
                serial = new SerialManager(comboPorts.SelectedItem.ToString()!);
                serial.Open();
                MessageBox.Show("Pripojeno!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při pripojení: " + ex.Message);
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

        private void btnServo_Click(object sender, EventArgs e)
        {
            var servoForm = new ServoControlForm(); // Vytvoření nové instance formuláře pro servo
            servoForm.Show();
        }

        private void btnMotor_Click(object sender, EventArgs e)
        {
            if (serial == null || !serial.IsOpen)
            {
                MessageBox.Show("Nejprve se připoj k sériovému portu.");
                return;
            }

            var motorForm = new MotorControlForm(serial); // předáváme SerialManager
            motorForm.Show();
        }


        private void btnSensor_Click(object sender, EventArgs e)
        {
           var sensorForm = new SensorControlForm();
            sensorForm.Show();
        }




    }
}
 