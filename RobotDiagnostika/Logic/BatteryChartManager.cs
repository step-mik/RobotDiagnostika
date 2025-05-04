using System;
using System.Windows.Forms;
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
            this.chart = chart ?? throw new ArgumentNullException(nameof(chart));
            this.seriesName = seriesName;

            // Vyčistíme existující oblasti a série
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            // Přidáme novou ChartArea a sérii
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
            area.AxisX.Title = "Time (s)";

            area.AxisY.Minimum = 10;
            area.AxisY.Maximum = 13;
            area.AxisY.Title = "Voltage (U)";
        }

        public void AddPoint(double voltage)
        {
            // Ověření, že graf a potřebná série existují
            if (chart == null || chart.ChartAreas.Count == 0 || chart.Series.Count == 0)
                return;

            var area = chart.ChartAreas[0];
            var series = chart.Series[seriesName];

            // Ověření existence Series
            if (series == null || area == null || area.AxisX == null)
                return;

            // Přidání bodu
            series.Points.AddXY(pointIndex++, voltage);

            // Pokud počet bodů přesáhne limit, smažeme první body a posuneme osu X
            if (pointIndex >= maxPoints)
            {
                for (int i = 0; i < 10 && series.Points.Count > 0; i++)
                {
                    series.Points.RemoveAt(0);
                }

                try
                {
                    area.AxisX.Minimum = pointIndex - maxPoints + 10;
                    area.AxisX.Maximum = pointIndex + 10;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při nastavování osy X: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Clear()
        {
            // Pokud graf existuje, vyčistí ho
            if (chart != null && chart.Series.Count > 0)
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
