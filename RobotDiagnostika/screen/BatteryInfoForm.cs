using RobotDiagnostika.Logic;

namespace RobotDiagnostika.screen
{
    public partial class BatteryInfoForm : Form
    {
        private readonly BatteryChartManager batteryChartManager;

        public BatteryInfoForm()
        {
            InitializeComponent();
            batteryChartManager = new BatteryChartManager(batteryChart); // jen TADY to má být!
        }

        public void UpdateBatteryInfo(double voltage, int percent, string fullLine)
        {
            lblPercentInfo.Text = percent.ToString();
            progressBatteryInfo.Value = Math.Clamp(percent, 0, 100);
            batteryLogBoxInfo.Text = fullLine;
            batteryChartManager.AddPoint(voltage);
        }

    }
}
