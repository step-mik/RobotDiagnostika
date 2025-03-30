using RobotDiagnostika.Serial;
using RobotDiagnostika.Logic;
using System.IO.Ports;

namespace RobotDiagnostika

{
    public partial class Form1 : Form
    {
        private SerialManager? serial;
        private MotorController? motorController;



        public Form1()
        {
            InitializeComponent();
            comboPorts.Items.AddRange(SerialPort.GetPortNames());

            btnLedOn.Click += btnLedOn_Click;
            btnLedOff.Click += btnLedOff_Click;
            btnConnect.Click += btnConnect_Click;
            btnLeftMotor.Enabled = false;

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
            motorController = new MotorController(serial);
            btnLeftMotor.Enabled = true;


        }


        private void btnLedOn_Click(object? sender, EventArgs e)
        {
            serial?.Send(LedCommand.On);
        }

        private void btnLedOff_Click(object? sender, EventArgs e)
        {
            serial?.Send(LedCommand.Off);
        }

        private void btnLeftMotor_Click(object sender, EventArgs e)
        {
            labelSelected.Text = "Aktivní část: Levý motor";

            if (motorController == null)
            {
                MessageBox.Show("Nejprve se připoj k Arduinu.");
                return;
            }

            bool isRunning = motorController.ToggleLeftMotor();

            labelSelected.Text = isRunning ? "Levý motor: Zapnutý" : "Levý motor: Vypnutý";
            btnLeftMotor.BackColor = isRunning ? Color.LightGreen : SystemColors.Control;

        }

        private void btnRightMotor_Click(object sender, EventArgs e)
        {
            labelSelected.Text = "Aktivní část: Pravý motor";
        }

        private void btnServo_Click(object sender, EventArgs e)
        {
            labelSelected.Text = "Aktivní část: Servo";
        }

        private void btnSensor_Click(object sender, EventArgs e)
        {
            labelSelected.Text = "Aktivní část: Ultrazvukový senzor";
        }

    }
}
 