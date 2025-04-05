using System.Windows.Forms.DataVisualization.Charting;

namespace RobotDiagnostika.screen
{
    partial class MotorControlForm
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
            ChartArea chartArea1 = new ChartArea();
            Series series1 = new Series();
            ChartArea chartArea2 = new ChartArea();
            Series series2 = new Series();
            btnLeftMotor = new Button();
            btnRightMotor = new Button();
            btnLeftReverse = new Button();
            btnRightReverse = new Button();
            trackLeftSpeed = new TrackBar();
            trackRightSpeed = new TrackBar();
            logBoxLeft = new TextBox();
            logBoxRight = new TextBox();
            label1 = new Label();
            chartLeft = new Chart();
            chartRight = new Chart();
            ((System.ComponentModel.ISupportInitialize)trackLeftSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackRightSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRight).BeginInit();
            SuspendLayout();
            // 
            // btnLeftMotor
            // 
            btnLeftMotor.Location = new Point(100, 100);
            btnLeftMotor.Name = "btnLeftMotor";
            btnLeftMotor.Size = new Size(120, 40);
            btnLeftMotor.TabIndex = 6;
            btnLeftMotor.Text = "Levý motor";
            btnLeftMotor.UseVisualStyleBackColor = true;
            // 
            // btnRightMotor
            // 
            btnRightMotor.Location = new Point(250, 100);
            btnRightMotor.Name = "btnRightMotor";
            btnRightMotor.Size = new Size(120, 40);
            btnRightMotor.TabIndex = 7;
            btnRightMotor.Text = "Pravý motor";
            btnRightMotor.UseVisualStyleBackColor = true;
            // 
            // btnLeftReverse
            // 
            btnLeftReverse.Location = new Point(100, 160);
            btnLeftReverse.Name = "btnLeftReverse";
            btnLeftReverse.Size = new Size(120, 30);
            btnLeftReverse.TabIndex = 0;
            btnLeftReverse.Text = "Reverz L";
            // 
            // btnRightReverse
            // 
            btnRightReverse.Location = new Point(250, 160);
            btnRightReverse.Name = "btnRightReverse";
            btnRightReverse.Size = new Size(120, 30);
            btnRightReverse.TabIndex = 1;
            btnRightReverse.Text = "Reverz P";
            // 
            // trackLeftSpeed
            // 
            trackLeftSpeed.Location = new Point(100, 200);
            trackLeftSpeed.Maximum = 255;
            trackLeftSpeed.Name = "trackLeftSpeed";
            trackLeftSpeed.Size = new Size(120, 56);
            trackLeftSpeed.TabIndex = 2;
            trackLeftSpeed.TickFrequency = 50;
            trackLeftSpeed.Value = 200;
            // 
            // trackRightSpeed
            // 
            trackRightSpeed.Location = new Point(250, 200);
            trackRightSpeed.Maximum = 255;
            trackRightSpeed.Name = "trackRightSpeed";
            trackRightSpeed.Size = new Size(120, 56);
            trackRightSpeed.TabIndex = 3;
            trackRightSpeed.TickFrequency = 50;
            trackRightSpeed.Value = 200;
            // 
            // logBoxLeft
            // 
            logBoxLeft.Font = new Font("Consolas", 10F);
            logBoxLeft.Location = new Point(50, 255);
            logBoxLeft.Multiline = true;
            logBoxLeft.Name = "logBoxLeft";
            logBoxLeft.ReadOnly = true;
            logBoxLeft.ScrollBars = ScrollBars.Vertical;
            logBoxLeft.Size = new Size(300, 53);
            logBoxLeft.TabIndex = 4;
            // 
            // logBoxRight
            // 
            logBoxRight.Font = new Font("Consolas", 10F);
            logBoxRight.Location = new Point(50, 325);
            logBoxRight.Multiline = true;
            logBoxRight.Name = "logBoxRight";
            logBoxRight.ReadOnly = true;
            logBoxRight.ScrollBars = ScrollBars.Vertical;
            logBoxRight.Size = new Size(300, 51);
            logBoxRight.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 8;
            label1.Text = "Engines";
            // 
            // chartLeft
            // 
            chartArea1.Name = "ChartArea1";
            chartLeft.ChartAreas.Add(chartArea1);
            chartLeft.Location = new Point(503, 275);
            chartLeft.Name = "chartLeft";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.Name = "Speed";
            chartLeft.Series.Add(series1);
            chartLeft.Size = new Size(300, 200);
            chartLeft.TabIndex = 0;
            // 
            // chartRight
            // 
            chartArea2.Name = "ChartArea1";
            chartRight.ChartAreas.Add(chartArea2);
            chartRight.Location = new Point(503, 39);
            chartRight.Name = "chartRight";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Line;
            series2.Name = "Speed";
            chartRight.Series.Add(series2);
            chartRight.Size = new Size(300, 200);
            chartRight.TabIndex = 1;
            // 
            // MotorControlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 680);
            Controls.Add(chartLeft);
            Controls.Add(chartRight);
            Controls.Add(label1);
            Controls.Add(btnLeftReverse);
            Controls.Add(btnRightReverse);
            Controls.Add(trackLeftSpeed);
            Controls.Add(trackRightSpeed);
            Controls.Add(logBoxLeft);
            Controls.Add(logBoxRight);
            Controls.Add(btnLeftMotor);
            Controls.Add(btnRightMotor);
            Name = "MotorControlForm";
            Text = "MotorControlForm";
            ((System.ComponentModel.ISupportInitialize)trackLeftSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackRightSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLeftMotor;
        private Button btnRightMotor;

        //reverse buttons
        private Button btnLeftReverse;
        private Button btnRightReverse;

        //real speed control
        private TrackBar trackLeftSpeed;
        private TrackBar trackRightSpeed;

        private TextBox logBoxLeft;
        private TextBox logBoxRight;
        private Label label1;

        // charts
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLeft;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRight;

    }
}