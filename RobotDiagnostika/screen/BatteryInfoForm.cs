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
    public partial class BatteryInfoForm : Form
    {
        public BatteryInfoForm()
        {
            InitializeComponent();
        }
        public void UpdateBatteryInfo(double voltage, int percent, string fullLine)
        {
            lblPercentInfo.Text = percent.ToString();
            progressBatteryInfo.Value = Math.Clamp(percent, 0, 100);
            batteryLogBoxInfo.Text = fullLine;
        }


    }
}
