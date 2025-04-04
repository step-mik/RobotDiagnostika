using RobotDiagnostika.Serial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotDiagnostika.screen
{
    public partial class MotorControlForm : Form
    {
        private SerialManager serial;
        private bool leftMotorRunning = false;
        private bool rightMotorRunning = false;

        public MotorControlForm(SerialManager serial)
        {
            InitializeComponent();
            this.serial = serial;

            btnLeftMotor.Click += btnLeftMotor_Click;
            btnRightMotor.Click += btnRightMotor_Click;
        }

        private void btnLeftMotor_Click(object? sender, EventArgs e)
        {
            leftMotorRunning = !leftMotorRunning;
            if (leftMotorRunning)
            {
                btnLeftMotor.BackColor = Color.LightGreen;
                serial.Send("LEFT_ON");
            }
            else
            {
                btnLeftMotor.BackColor = SystemColors.Control;
                serial.Send("LEFT_OFF");
            }
        }

        private void btnRightMotor_Click(object? sender, EventArgs e)
        {
            rightMotorRunning = !rightMotorRunning;
            if (rightMotorRunning)
            {
                btnRightMotor.BackColor = Color.LightGreen;
                serial.Send("RIGHT_ON");
            }
            else
            {
                btnRightMotor.BackColor = SystemColors.Control;
                serial.Send("RIGHT_OFF");
            }
        }
    }
}