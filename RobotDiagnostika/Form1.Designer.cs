﻿namespace RobotDiagnostika
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 535);
            Controls.Add(btnLedOff);
            Controls.Add(label1);
            Controls.Add(btnLedOn);
            Controls.Add(btnConnect);
            Controls.Add(comboPorts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboPorts;
        private Button btnConnect;
        private Button btnLedOn;
        private Label label1;
        private Button btnLedOff;
    }
}
