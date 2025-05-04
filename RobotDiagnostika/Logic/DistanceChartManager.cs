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
            this.chart = chart ?? throw new ArgumentNullException(nameof(chart));
            this.seriesName = seriesName;

            // Vymažeme existující oblasti a série, abychom nezačínali na špatných datech
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            // Přidání nové oblasti a série
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
            area.AxisX.Title = "Čas (s)";

            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 200;
            area.AxisY.Title = "Vzdálenost (cm)";
        }


        public void AddPoint(double distance)
        {
            if (chart == null || chart.ChartAreas.Count == 0 || chart.Series.Count == 0)
                return;

            var area = chart.ChartAreas[0];
            var series = chart.Series.FindByName(seriesName);

            // Kontrola existence a inicializace
            if (area == null || series == null || area.AxisX == null)
                return;

            series.Points.AddXY(pointIndex++, distance);

            if (pointIndex >= maxPoints && pointIndex % 10 == 0)
            {
                for (int i = 0; i < 10 && series.Points.Count > 0; i++)
                {
                    series.Points.RemoveAt(0);
                }

                // Dodatečná ochrana přes try-catch (pro případ nečekané chyby)
                try
                {
                    area.AxisX.Minimum = pointIndex - maxPoints + 10;
                    area.AxisX.Maximum = pointIndex + 10;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Neočekávaná chyba při nastavování os: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
