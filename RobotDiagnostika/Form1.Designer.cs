namespace RobotDiagnostika
{
    partial class LeftMotor
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
            btnLeftMotor = new Button();
            btnRightMotor = new Button();
            btnServo = new Button();
            btnSensor = new Button();
            labelSelected = new Label();
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
            pictureBox1.Image = Properties.Resources.Clipped_image_20250328_211429;
            pictureBox1.Location = new Point(337, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnLeftMotor
            // 
            btnLeftMotor.Location = new Point(617, 420);
            btnLeftMotor.Name = "btnLeftMotor";
            btnLeftMotor.Size = new Size(94, 29);
            btnLeftMotor.TabIndex = 6;
            btnLeftMotor.Text = "Left Motor";
            btnLeftMotor.UseVisualStyleBackColor = true;
            // 
            // btnRightMotor
            // 
            btnRightMotor.Location = new Point(617, 455);
            btnRightMotor.Name = "btnRightMotor";
            btnRightMotor.Size = new Size(94, 29);
            btnRightMotor.TabIndex = 7;
            btnRightMotor.Text = "RightMotor";
            btnRightMotor.UseVisualStyleBackColor = true;
            // 
            // btnServo
            // 
            btnServo.Location = new Point(487, 420);
            btnServo.Name = "btnServo";
            btnServo.Size = new Size(94, 29);
            btnServo.TabIndex = 8;
            btnServo.Text = "Servo";
            btnServo.UseVisualStyleBackColor = true;
            // 
            // btnSensor
            // 
            btnSensor.Location = new Point(338, 420);
            btnSensor.Name = "btnSensor";
            btnSensor.Size = new Size(130, 29);
            btnSensor.TabIndex = 9;
            btnSensor.Text = "ultrasonic sensor";
            btnSensor.UseVisualStyleBackColor = true;
            // 
            // labelSelected
            // 
            labelSelected.AutoSize = true;
            labelSelected.Location = new Point(243, 426);
            labelSelected.Name = "labelSelected";
            labelSelected.Size = new Size(50, 20);
            labelSelected.TabIndex = 10;
            labelSelected.Text = "label2";
            // 
            // LeftMotor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 535);
            Controls.Add(labelSelected);
            Controls.Add(btnSensor);
            Controls.Add(btnServo);
            Controls.Add(btnRightMotor);
            Controls.Add(btnLeftMotor);
            Controls.Add(pictureBox1);
            Controls.Add(btnLedOff);
            Controls.Add(label1);
            Controls.Add(btnLedOn);
            Controls.Add(btnConnect);
            Controls.Add(comboPorts);
            Name = "LeftMotor";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            // 
            btnLeftMotor.Click += btnLeftMotor_Click;
            btnRightMotor.Click += btnRightMotor_Click;
            btnServo.Click += btnServo_Click;
            btnSensor.Click += btnSensor_Click;

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
        private Button btnLeftMotor;
        private Button btnRightMotor;
        private Button btnServo;
        private Button btnSensor;
        private Label labelSelected;
    }
}
