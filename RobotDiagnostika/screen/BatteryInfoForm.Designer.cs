namespace RobotDiagnostika.screen
{
    partial class BatteryInfoForm
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
            infoLabel = new Label();
            safeRangeLabel = new Label();
            rechargeLabel = new Label();
            lblPercentInfo = new Label();
            progressBatteryInfo = new ProgressBar();
            batteryLogBoxInfo = new TextBox();
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
            batteryLogBoxInfo.Size = new Size(330, 50);
            batteryLogBoxInfo.TabIndex = 5;

            // 
            // BatteryInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 346);
            Controls.Add(rechargeLabel);
            Controls.Add(safeRangeLabel);
            Controls.Add(infoLabel);
            Controls.Add(lblPercentInfo);
            Controls.Add(progressBatteryInfo);
            Controls.Add(batteryLogBoxInfo);
            Name = "BatteryInfoForm";
            Text = "Battery Info";
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
    }
}
