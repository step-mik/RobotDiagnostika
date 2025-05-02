using RobotDiagnostika.Logic;
using RobotDiagnostika.Serial;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace RobotDiagnostika.screen
{
    public partial class SensorControlForm : Form
    {
        private readonly SerialDataRouter router;
        private readonly DistanceChartManager distanceChartManager;

        public SensorControlForm(SerialDataRouter router)
        {
            InitializeComponent();
            this.router = router;

            distanceChartManager = new DistanceChartManager(distanceChart);
            router.OnSensorData += Router_OnSensorData;
        }

        private void Router_OnSensorData(string line)
        {
            string? valueStr = ExtractDistanceValue(line);

            if (float.TryParse(valueStr, NumberStyles.Float, CultureInfo.InvariantCulture, out float distance))
            {
                UpdateDistanceDisplay(distance);
            }
        }

        private string ExtractDistanceValue(string line)
        {
            // Např. "DISTANCE:63.4cm"
            int start = line.IndexOf("DISTANCE:") + "DISTANCE:".Length;
            string value = line.Substring(start).Replace("cm", "").Trim();
            return value;
        }

        private void UpdateDistanceDisplay(float distance)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateDistanceDisplay(distance)));
                return;
            }

            distanceLogBoxInfo.Text = $"{distance:F1} cm";
            distanceChartManager.AddPoint(distance);
        }

        private void SensorControlForm_Load(object sender, EventArgs e)
        {
            // Nepovinné – můžeš něco inicializovat při načtení
        }
    }
}
