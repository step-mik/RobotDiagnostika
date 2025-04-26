namespace RobotDiagnostika.screen
{
    partial class BatteryInfoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            infoLabel = new Label();
            safeRangeLabel = new Label();
            rechargeLabel = new Label();
            lblPercentInfo = new Label();
            progressBatteryInfo = new ProgressBar();
            batteryLogBoxInfo = new TextBox();
            batteryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)batteryChart).BeginInit();
            SuspendLayout();
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(30, 30);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(340, 20);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "Battery Monitoring System is active and reporting.";
            // 
            // safeRangeLabel
            // 
            safeRangeLabel.AutoSize = true;
            safeRangeLabel.Location = new Point(30, 70);
            safeRangeLabel.Name = "safeRangeLabel";
            safeRangeLabel.Size = new Size(334, 20);
            safeRangeLabel.TabIndex = 1;
            safeRangeLabel.Text = "Safe Voltage Range: 11.4V (empty) to 12.6V (full).";
            // 
            // rechargeLabel
            // 
            rechargeLabel.AutoSize = true;
            rechargeLabel.Location = new Point(30, 110);
            rechargeLabel.Name = "rechargeLabel";
            rechargeLabel.Size = new Size(323, 20);
            rechargeLabel.TabIndex = 2;
            rechargeLabel.Text = "Recommendation: Recharge when below 11.4V.";
            // 
            // lblPercentInfo
            // 
            lblPercentInfo.Location = new Point(30, 162);
            lblPercentInfo.Name = "lblPercentInfo";
            lblPercentInfo.Size = new Size(40, 25);
            lblPercentInfo.TabIndex = 3;
            lblPercentInfo.Text = "0";
            // 
            // progressBatteryInfo
            // 
            progressBatteryInfo.Location = new Point(30, 192);
            progressBatteryInfo.Name = "progressBatteryInfo";
            progressBatteryInfo.Size = new Size(150, 23);
            progressBatteryInfo.TabIndex = 4;
            // 
            // batteryLogBoxInfo
            // 
            batteryLogBoxInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            batteryLogBoxInfo.Location = new Point(215, 188);
            batteryLogBoxInfo.Multiline = true;
            batteryLogBoxInfo.Name = "batteryLogBoxInfo";
            batteryLogBoxInfo.ReadOnly = true;
            batteryLogBoxInfo.ScrollBars = ScrollBars.Vertical;
            batteryLogBoxInfo.Size = new Size(301, 50);
            batteryLogBoxInfo.TabIndex = 5;
            // 
            // batteryChart
            // 
            batteryChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            batteryChart.ChartAreas.Add(chartArea1);
            batteryChart.Location = new Point(30, 260);
            batteryChart.Name = "batteryChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Voltage";
            batteryChart.Series.Add(series1);
            batteryChart.Size = new Size(346, 226);
            batteryChart.TabIndex = 6;
            // 
            // BatteryInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 513);
            Controls.Add(batteryChart);
            Controls.Add(rechargeLabel);
            Controls.Add(safeRangeLabel);
            Controls.Add(infoLabel);
            Controls.Add(lblPercentInfo);
            Controls.Add(progressBatteryInfo);
            Controls.Add(batteryLogBoxInfo);
            Name = "BatteryInfoForm";
            Text = "Battery Info";
            ((System.ComponentModel.ISupportInitialize)batteryChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoLabel;
        private Label safeRangeLabel;
        private Label rechargeLabel;
        private Label lblPercentInfo;
        private ProgressBar progressBatteryInfo;
        private TextBox batteryLogBoxInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart batteryChart;
    }
}
