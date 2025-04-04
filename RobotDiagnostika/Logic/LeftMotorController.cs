using System;
using System.Drawing;
using System.Windows.Forms;
using RobotDiagnostika.Serial;

namespace RobotDiagnostika.Logic
{
    public class LeftMotorController
    {
        private readonly Button button;
        private readonly SerialManager serial;
        private bool isRunning = false;
        private bool isReversed = false;
        private int currentSpeed = 200; // výchozí rychlost

        public LeftMotorController(Button button, SerialManager serial)
        {
            this.button = button;
            this.serial = serial;

            button.Click += Button_Click;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Toggle();
        }

        public void Toggle()
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                button.BackColor = Color.LightGreen;
                serial.Send("LEFT_ON");
                serial.Send($"LEFT_SPEED:{currentSpeed}");
            }
            else
            {
                button.BackColor = SystemColors.Control;
                serial.Send("LEFT_OFF");
            }
        }

        public void Stop()
        {
            isRunning = false;
            button.BackColor = SystemColors.Control;
            serial.Send("LEFT_OFF");
        }

        public void Reverse()
        {
            isReversed = !isReversed;
            serial.Send("LEFT_REV");
        }

        public void SetSpeed(int pwm)
        {
            currentSpeed = pwm;
            if (isRunning)
                serial.Send($"LEFT_SPEED:{currentSpeed}");
        }
    }
}
