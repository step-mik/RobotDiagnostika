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
        private bool isReversed = false;
        private int currentSpeed = 200; // defaultní rychlost

        public RightMotorController(Button button, SerialManager serial)
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
                serial.Send("RIGHT_ON");
                serial.Send($"RIGHT_SPEED:{currentSpeed}"); // nastavíme i aktuální rychlost
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

        public void Reverse()
        {
            isReversed = !isReversed;
            serial.Send("RIGHT_REV");
        }

        public void SetSpeed(int pwm)
        {
            currentSpeed = pwm;
            if (isRunning)
                serial.Send($"RIGHT_SPEED:{currentSpeed}");
        }
    }
}
