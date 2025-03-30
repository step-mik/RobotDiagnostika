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
            btnLeftMotor.Location = new Point(650, 420);
            btnLeftMotor.Name = "btnLeftMotor";
            btnLeftMotor.Size = new Size(100, 30);
            btnLeftMotor.TabIndex = 6;
            btnLeftMotor.Text = "Levý motor";
            btnLeftMotor.Click += btnLeftMotor_Click;
            // 
            // btnRightMotor
            // 
            btnRightMotor.Location = new Point(650, 456);
            btnRightMotor.Name = "btnRightMotor";
            btnRightMotor.Size = new Size(100, 30);
            btnRightMotor.TabIndex = 7;
            btnRightMotor.Text = "Pravý motor";
            btnRightMotor.Click += btnRightMotor_Click;
            // 
            // btnServo
            // 
            btnServo.Location = new Point(415, 420);
            btnServo.Name = "btnServo";
            btnServo.Size = new Size(80, 30);
            btnServo.TabIndex = 8;
            btnServo.Text = "Servo";
            btnServo.Click += btnServo_Click;
            // 
            // btnSensor
            // 
            btnSensor.Location = new Point(501, 420);
            btnSensor.Name = "btnSensor";
            btnSensor.Size = new Size(129, 30);
            btnSensor.TabIndex = 9;
            btnSensor.Text = "Ultrazvuk Senzor";
            btnSensor.Click += btnSensor_Click;
            // 
            // labelSelected
            // 
            labelSelected.Location = new Point(337, 453);
            labelSelected.Name = "labelSelected";
            labelSelected.Size = new Size(250, 30);
            labelSelected.TabIndex = 10;
            labelSelected.Text = "Aktivní část: žádná";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 535);
            Controls.Add(pictureBox1);
            Controls.Add(btnLedOff);
            Controls.Add(label1);
            Controls.Add(btnLedOn);
            Controls.Add(btnConnect);
            Controls.Add(comboPorts);
            Controls.Add(btnLeftMotor);
            Controls.Add(btnRightMotor);
            Controls.Add(btnServo);
            Controls.Add(btnSensor);
            Controls.Add(labelSelected);
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
        private Button btnLeftMotor;
        private Button btnRightMotor;
        private Button btnServo;
        private Button btnSensor;
        private Label labelSelected;

    }
}
