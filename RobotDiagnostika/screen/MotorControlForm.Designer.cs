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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnLeftMotor = new Button();
            btnRightMotor = new Button();
            btnLeftReverse = new Button();
            btnRightReverse = new Button();
            trackLeftSpeed = new TrackBar();
            trackRightSpeed = new TrackBar();
            logBoxLeft = new TextBox();
            logBoxRight = new TextBox();
            label1 = new Label();
            chartLeft = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartRight = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            legend1.Name = "Legend1";
            chartLeft.Legends.Add(legend1);
            chartLeft.Location = new Point(431, 22);
            chartLeft.Name = "chartLeft";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "left motor";
            chartLeft.Series.Add(series1);
            chartLeft.Size = new Size(488, 261);
            chartLeft.TabIndex = 9;
            chartLeft.Text = "chart1";
            // 
            // chartRight
            // 
            chartArea2.Name = "ChartArea1";
            chartRight.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartRight.Legends.Add(legend2);
            chartRight.Location = new Point(431, 289);
            chartRight.Name = "chartRight";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "right motor";
            chartRight.Series.Add(series2);
            chartRight.Size = new Size(488, 261);
            chartRight.TabIndex = 10;
            chartRight.Text = "chart2";
            // 
            // MotorControlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 594);
            Controls.Add(chartRight);
            Controls.Add(chartLeft);
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLeft;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRight;
    }
}