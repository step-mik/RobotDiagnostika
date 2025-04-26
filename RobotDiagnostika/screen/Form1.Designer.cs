namespace RobotDiagnostika
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboPorts = new ComboBox();
            btnConnect = new Button();
            btnLedOn = new Button();
            label1 = new Label();
            btnLedOff = new Button();
            pictureBox1 = new PictureBox();
            btnMotor = new Button();
            btnSensor = new Button();
            lblPercent = new Label();
            progressBattery = new ProgressBar();
            batteryLogBox = new TextBox();
            btnBatteryInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboPorts
            // 
            comboPorts.FormattingEnabled = true;
            comboPorts.Location = new Point(36, 41);
            comboPorts.Name = "comboPorts";
            comboPorts.Size = new Size(151, 28);
            comboPorts.TabIndex = 0;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(193, 41);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnLedOn
            // 
            btnLedOn.Location = new Point(36, 86);
            btnLedOn.Name = "btnLedOn";
            btnLedOn.Size = new Size(94, 29);
            btnLedOn.TabIndex = 2;
            btnLedOn.Text = "Led On";
            btnLedOn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "Choose Port";
            // 
            // btnLedOff
            // 
            btnLedOff.Location = new Point(160, 86);
            btnLedOff.Name = "btnLedOff";
            btnLedOff.Size = new Size(94, 29);
            btnLedOff.TabIndex = 4;
            btnLedOff.Text = "Led Off";
            btnLedOff.UseVisualStyleBackColor = true;
            btnLedOff.Click += btnLedOff_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Clipped_image_20250328_211429;
            pictureBox1.Location = new Point(358, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnMotor
            // 
            btnMotor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMotor.Location = new Point(677, 405);
            btnMotor.Name = "btnMotor";
            btnMotor.Size = new Size(94, 30);
            btnMotor.TabIndex = 7;
            btnMotor.Text = "Motor";
            btnMotor.UseVisualStyleBackColor = true;
            btnMotor.Click += btnMotor_Click;
            // 
            // btnSensor
            // 
            btnSensor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSensor.Location = new Point(358, 405);
            btnSensor.Name = "btnSensor";
            btnSensor.Size = new Size(94, 29);
            btnSensor.TabIndex = 8;
            btnSensor.Text = "Senzor";
            btnSensor.UseVisualStyleBackColor = true;
            btnSensor.Click += btnSensor_Click;
            // 
            // lblPercent
            // 
            lblPercent.Location = new Point(340, 7);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(36, 25);
            lblPercent.TabIndex = 1;
            lblPercent.Text = "0%";
            // 
            // progressBattery
            // 
            progressBattery.Location = new Point(340, 32);
            progressBattery.Name = "progressBattery";
            progressBattery.Size = new Size(125, 23);
            progressBattery.TabIndex = 2;
            // 
            // batteryLogBox
            // 
            batteryLogBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            batteryLogBox.Location = new Point(471, 31);
            batteryLogBox.Multiline = true;
            batteryLogBox.Name = "batteryLogBox";
            batteryLogBox.ReadOnly = true;
            batteryLogBox.ScrollBars = ScrollBars.Vertical;
            batteryLogBox.Size = new Size(330, 50);
            batteryLogBox.TabIndex = 3;
            // 
            // btnBatteryInfo
            // 
            btnBatteryInfo.Anchor = AnchorStyles.Bottom;
            btnBatteryInfo.Location = new Point(526, 405);
            btnBatteryInfo.Name = "btnBatteryInfo";
            btnBatteryInfo.Size = new Size(94, 29);
            btnBatteryInfo.TabIndex = 6;
            btnBatteryInfo.Text = "Battery Info";
            btnBatteryInfo.UseVisualStyleBackColor = true;
            btnBatteryInfo.Click += btnBatteryInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 522);
            Controls.Add(btnBatteryInfo);
            Controls.Add(lblPercent);
            Controls.Add(progressBattery);
            Controls.Add(batteryLogBox);
            Controls.Add(pictureBox1);
            Controls.Add(btnLedOff);
            Controls.Add(label1);
            Controls.Add(btnLedOn);
            Controls.Add(btnConnect);
            Controls.Add(comboPorts);
            Controls.Add(btnMotor);
            Controls.Add(btnSensor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ComboBox comboPorts;
        private Button btnConnect;
        private Button btnLedOn;
        private Label label1;
        private Button btnLedOff;
        private PictureBox pictureBox1;
        private Button btnMotor;
        private Button btnSensor;
        private Label lblPercent;
        private ProgressBar progressBattery;
        private TextBox batteryLogBox;
        private Button btnBatteryInfo;




    }
}
