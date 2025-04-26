using System.Windows.Forms.DataVisualization.Charting;

namespace RobotDiagnostika.Logic
{
    public class BatteryChartManager
    {
        private readonly Chart chart;
        private readonly string seriesName;
        private int pointIndex = 0;
        private readonly int maxPoints = 20;

        public BatteryChartManager(Chart chart, string seriesName = "Voltage")
        {
            this.chart = chart;
            this.seriesName = seriesName;

            chart.Series.Clear();
            chart.ChartAreas.Clear();

            var area = new ChartArea();
            chart.ChartAreas.Add(area);

            var series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };
            chart.Series.Add(series);

            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = maxPoints;
            area.AxisX.Interval = 2;
            area.AxisY.Minimum = 10;
            area.AxisY.Maximum = 13;
        }

        public void AddPoint(double voltage)
        {
            if (chart.ChartAreas.Count == 0)
            {
                chart.ChartAreas.Add(new ChartArea());
            }

            var area = chart.ChartAreas[0];
            var series = chart.Series[seriesName];

            series.Points.AddXY(pointIndex++, voltage);

            if (pointIndex >= maxPoints && pointIndex % 10 == 0)
            {
                for (int i = 0; i < 10; i++)
                    if (series.Points.Count > 0) series.Points.RemoveAt(0);

                area.AxisX.Minimum = pointIndex - maxPoints + 10;
                area.AxisX.Maximum = pointIndex + 10;
            }
        }


        public void Clear()
        {
            chart.Series[seriesName].Points.Clear();
            pointIndex = 0;

            var area = chart.ChartAreas[0];
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = maxPoints;
        }
    }
}
