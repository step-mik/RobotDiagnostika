using RobotDiagnostika.Serial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RobotDiagnostika.screen
{
    public partial class SensorControlForm : Form
    {
        private readonly SerialDataRouter router;
        private int sampleIndex = 0;

        public SensorControlForm(SerialDataRouter router)
        {
            InitializeComponent();
            this.router = router;

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
            // Příklad: "Vzdalenost: 63.4 cm"
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

            var series = distanceChart.Series["DistanceSeries"];
            series.Points.AddXY(++sampleIndex, distance);

            // Udržuj maximálně 10 bodů v grafu
            if (series.Points.Count > 10)
                series.Points.RemoveAt(0);
        }

        private void SensorControlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
