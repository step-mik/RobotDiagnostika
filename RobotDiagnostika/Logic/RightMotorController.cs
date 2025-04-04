using System;
using System.Drawing;
using System.Windows.Forms;
using RobotDiagnostika.Serial;

namespace RobotDiagnostika.Logic
{
    public class RightMotorController
    {
        private readonly Button button;
        private readonly SerialManager serial;
        private bool isRunning = false;

        public RightMotorController(Button button, SerialManager serial)
        {
            this.button = button;
            this.serial = serial;

            button.Click += Button_Click;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                button.BackColor = Color.LightGreen;
                serial.Send("RIGHT_ON");
            }
            else
            {
                button.BackColor = SystemColors.Control;
                serial.Send("RIGHT_OFF");
            }
        }

        public void Stop()
        {
            isRunning = false;
            button.BackColor = SystemColors.Control;
            serial.Send("RIGHT_OFF");
        }
    }
}
