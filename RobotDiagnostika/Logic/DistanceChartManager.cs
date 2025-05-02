using System.Windows.Forms.DataVisualization.Charting;

namespace RobotDiagnostika.Logic
{
    public class DistanceChartManager
    {
        private readonly Chart chart;
        private readonly string seriesName;
        private int pointIndex = 0;
        private readonly int maxPoints = 20;

        public DistanceChartManager(Chart chart, string seriesName = "DistanceSeries")
        {
            this.chart = chart;
            this.seriesName = seriesName;

            // Ensure the chart and areas are initialized
            if (chart == null || chart.ChartAreas.Count == 0)
            {
                chart.ChartAreas.Add(new ChartArea());
            }

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

            // Nastavení os
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = maxPoints;
            area.AxisX.Interval = 2;
            area.AxisX.Title = "Čas (s)"; // ⬅️ Popisek X osy

            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 200;
            area.AxisY.Title = "Vzdálenost (cm)"; // ⬅️ Popisek Y osy
        }

        public void AddPoint(double distance)
        {
            // Ensure chart and series are initialized before attempting to add points
            if (chart == null || chart.ChartAreas.Count == 0 || chart.Series.Count == 0)
            {
                return; // Exit if chart is not initialized correctly
            }

            var area = chart.ChartAreas[0];
            var series = chart.Series[seriesName];

            // Přidání bodu
            series.Points.AddXY(pointIndex++, distance);

            // Pokud počet bodů dosáhne maximálního počtu, posune graf
            if (pointIndex >= maxPoints && pointIndex % 10 == 0)
            {
                // Odstraní staré body
                for (int i = 0; i < 10; i++)
                {
                    if (series.Points.Count > 0)
                    {
                        series.Points.RemoveAt(0);
                    }
                }

                // Posune osy
                area.AxisX.Minimum = pointIndex - maxPoints + 10;
                area.AxisX.Maximum = pointIndex + 10;
            }
        }

        public void Clear()
        {
            // Pokud graf existuje, vyčistí ho
            if (chart != null)
            {
                chart.Series[seriesName].Points.Clear();
                pointIndex = 0;

                var area = chart.ChartAreas[0];
                area.AxisX.Minimum = 0;
                area.AxisX.Maximum = maxPoints;
            }
        }
    }

}
