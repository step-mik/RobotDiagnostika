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
            btnLeftMotor = new Button();
            btnRightMotor = new Button();
            label1 = new Label();

            // 
            // btnLeftMotor
            // 
            btnLeftMotor.Location = new Point(100, 100);
            btnLeftMotor.Name = "btnLeftMotor";
            btnLeftMotor.Size = new Size(120, 40);
            btnLeftMotor.Text = "Levý motor";
            btnLeftMotor.UseVisualStyleBackColor = true;

            // 
            // btnRightMotor
            // 
            btnRightMotor.Location = new Point(250, 100);
            btnRightMotor.Name = "btnRightMotor";
            btnRightMotor.Size = new Size(120, 40);
            btnRightMotor.Text = "Pravý motor";
            btnRightMotor.UseVisualStyleBackColor = true;

            // 
            // MotorControlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLeftMotor);
            Controls.Add(btnRightMotor);
            Controls.Add(label1);
            Name = "MotorControlForm";
            Text = "MotorControlForm";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Button btnLeftMotor;
        private Button btnRightMotor;
    }
}