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

            // Pokud není graf inicializován, nic nedělej
            if (chart == null || chart.ChartAreas.Count == 0) return;

            // Vyčistíme existující data, pokud jsou
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            // Vytvoříme novou ChartArea a Series
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
            area.AxisX.Title = "Time (s)";  // Titulek osy X

            area.AxisY.Minimum = 10;
            area.AxisY.Maximum = 13;
            area.AxisY.Title = "Voltage (U)";  // Titulek osy Y
        }

        public void AddPoint(double voltage)
        {
            // Kontrola, zda graf a série existují
            if (chart == null || chart.ChartAreas.Count == 0 || chart.Series.Count == 0) return;

            var area = chart.ChartAreas[0];
            var series = chart.Series[seriesName];

            // Přidání bodu s časem a napětím
            series.Points.AddXY(pointIndex++, voltage);

            // Pokud počet bodů dosáhne maximálního počtu, posune graf
            if (pointIndex >= maxPoints)
            {
                // Odstraní staré body, aby se graf posunul
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
