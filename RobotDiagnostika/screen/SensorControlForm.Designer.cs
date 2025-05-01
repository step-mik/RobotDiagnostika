namespace RobotDiagnostika.screen
{
    partial class SensorControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            distanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            distanceLogBoxInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)distanceChart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 100);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Distance";
            // 
            // distanceChart
            // 
            distanceChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            distanceChart.ChartAreas.Add(chartArea1);
            distanceChart.Location = new Point(40, 158);
            distanceChart.Name = "distanceChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "DistanceSeries";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            distanceChart.Series.Add(series1);
            distanceChart.Size = new Size(446, 226);
            distanceChart.TabIndex = 8;
            // 
            // distanceLogBoxInfo
            // 
            distanceLogBoxInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            distanceLogBoxInfo.Location = new Point(225, 86);
            distanceLogBoxInfo.Multiline = true;
            distanceLogBoxInfo.Name = "distanceLogBoxInfo";
            distanceLogBoxInfo.ReadOnly = true;
            distanceLogBoxInfo.ScrollBars = ScrollBars.Vertical;
            distanceLogBoxInfo.Size = new Size(252, 50);
            distanceLogBoxInfo.TabIndex = 7;
            // 
            // SensorControlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 450);
            Controls.Add(distanceChart);
            Controls.Add(distanceLogBoxInfo);
            Controls.Add(label1);
            Name = "SensorControlForm";
            Text = "SensorControlForm";
            Load += SensorControlForm_Load;
            ((System.ComponentModel.ISupportInitialize)distanceChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart distanceChart;
        private TextBox distanceLogBoxInfo;
    }
}