using RobotDiagnostika.Serial;
using RobotDiagnostika.Logic;
using System.IO.Ports;

namespace RobotDiagnostika

{
    public partial class LeftMotor : Form
    {
        private SerialManager? serial;

        public LeftMotor()
        {
            InitializeComponent();
            comboPorts.Items.AddRange(SerialPort.GetPortNames());

            btnLedOn.Click += btnLedOn_Click;
            btnLedOff.Click += btnLedOff_Click;
            btnConnect.Click += btnConnect_Click;
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

        
    }
}