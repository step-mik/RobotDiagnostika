using RobotDiagnostika.Logic;
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
        private LeftMotorController? leftMotor;
        private RightMotorController? rightMotor;

        public MotorControlForm(SerialManager serial)
        {
            InitializeComponent();

            leftMotor = new LeftMotorController(btnLeftMotor, serial);
            rightMotor = new RightMotorController(btnRightMotor, serial);
        }
    }
}