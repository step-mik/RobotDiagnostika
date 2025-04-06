using System.Windows.Forms.DataVisualization.Charting;

namespace RobotDiagnostika.Logic
{
    public class MotorChartManager
    {
        private readonly Chart chart;
        private readonly string seriesName;
        private int pointIndex = 0;
        private readonly int maxPoints = 100;

        public MotorChartManager(Chart chart, string seriesName = "Speed")
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
            area.AxisX.Interval = 10;
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 255;
        }

        public void AddPoint(int speed)
        {
            var series = chart.Series[seriesName];
            series.Points.AddXY(pointIndex++, speed);

            if (pointIndex >= maxPoints && pointIndex % 50 == 0)
            {
                for (int i = 0; i < 50; i++)
                    if (series.Points.Count > 0) series.Points.RemoveAt(0);

                var area = chart.ChartAreas[0];
                area.AxisX.Minimum = pointIndex - maxPoints + 50;
                area.AxisX.Maximum = pointIndex + 50;
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
