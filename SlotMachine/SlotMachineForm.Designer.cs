﻿namespace SlotMachine
{
    partial class SlotMachineForm
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
            this.SpinPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.ResetButton = new System.Windows.Forms.PictureBox();
            this.BetButton1 = new System.Windows.Forms.PictureBox();
            this.BetButton5 = new System.Windows.Forms.PictureBox();
            this.BetButton25 = new System.Windows.Forms.PictureBox();
            this.SpinBox1 = new System.Windows.Forms.PictureBox();
            this.SpinBox2 = new System.Windows.Forms.PictureBox();
            this.SpinBox3 = new System.Windows.Forms.PictureBox();
            this.BetLabel = new System.Windows.Forms.Label();
            this.TotalCreditsLabel = new System.Windows.Forms.Label();
            this.WinLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.BetButton50 = new System.Windows.Forms.PictureBox();
            this.BetButton10 = new System.Windows.Forms.PictureBox();
            this.BetButton2 = new System.Windows.Forms.PictureBox();
            this.BetButton100 = new System.Windows.Forms.PictureBox();
            this.BetButton500 = new System.Windows.Forms.PictureBox();
            this.BetLine = new System.Windows.Forms.PictureBox();
            this.CreditButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinPictureBox
            // 
            this.SpinPictureBox.BackColor = System.Drawing.Color.Black;
            this.SpinPictureBox.Image = global::SlotMachine.Properties.Resources.spin;
            this.SpinPictureBox.Location = new System.Drawing.Point(324, 430);
            this.SpinPictureBox.Name = "SpinPictureBox";
            this.SpinPictureBox.Size = new System.Drawing.Size(60, 56);
            this.SpinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinPictureBox.TabIndex = 6;
            this.SpinPictureBox.TabStop = false;
            this.SpinPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SlotMachine.Properties.Resources.slotmachine;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Image = global::SlotMachine.Properties.Resources.powerbutton;
            this.ExitButton.Location = new System.Drawing.Point(102, 107);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(49, 50);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButton.TabIndex = 8;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Image = global::SlotMachine.Properties.Resources.reset;
            this.ResetButton.Location = new System.Drawing.Point(404, 108);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(49, 50);
            this.ResetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResetButton.TabIndex = 9;
            this.ResetButton.TabStop = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BetButton1
            // 
            this.BetButton1.Image = global::SlotMachine.Properties.Resources.bet1;
            this.BetButton1.Location = new System.Drawing.Point(112, 429);
            this.BetButton1.Name = "BetButton1";
            this.BetButton1.Size = new System.Drawing.Size(32, 28);
            this.BetButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetButton1.TabIndex = 10;
            this.BetButton1.TabStop = false;
            this.BetButton1.Click += new System.EventHandler(this.setPlayerBet);
            // 
            // BetButton5
            // 
            this.BetButton5.Image = global::SlotMachine.Properties.Resources.bet5;
            this.BetButton5.Location = new System.Drawing.Point(164, 429);
            this.BetButton5.Name = "BetButton5";
            this.BetButton5.Size = new System.Drawing.Size(32, 28);
            this.BetButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetButton5.TabIndex = 11;
            this.BetButton5.TabStop = false;
            this.BetButton5.Click += new System.EventHandler(this.setPlayerBet);
            // 
            // BetButton25
            // 
            this.BetButton25.Image = global::SlotMachine.Properties.Resources.bet25;
            this.BetButton25.Location = new System.Drawing.Point(216, 430);
            this.BetButton25.Name = "BetButton25";
            this.BetButton25.Size = new System.Drawing.Size(32, 28);
            this.BetButton25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetButton25.TabIndex = 12;
            this.BetButton25.TabStop = false;
            this.BetButton25.Click += new System.EventHandler(this.setPlayerBet);
            // 
            // SpinBox1
            // 
            this.SpinBox1.Image = global::SlotMachine.Properties.Resources.banana;
            this.SpinBox1.Location = new System.Drawing.Point(138, 264);
            this.SpinBox1.Name = "SpinBox1";
            this.SpinBox1.Size = new System.Drawing.Size(64, 61);
            this.SpinBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinBox1.TabIndex = 13;
            this.SpinBox1.TabStop = false;
            // 
            // SpinBox2
            // 
            this.SpinBox2.Image = global::SlotMachine.Properties.Resources.banana;
            this.SpinBox2.Location = new System.Drawing.Point(245, 264);
            this.SpinBox2.Name = "SpinBox2";
            this.SpinBox2.Size = new System.Drawing.Size(64, 61);
            this.SpinBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinBox2.TabIndex = 14;
            this.SpinBox2.TabStop = false;
            // 
            // SpinBox3
            // 
            this.SpinBox3.Image = global::SlotMachine.Properties.Resources.bell;
            this.SpinBox3.Location = new System.Drawing.Point(355, 264);
            this.SpinBox3.Name = "SpinBox3";
            this.SpinBox3.Size = new System.Drawing.Size(64, 61);
            this.SpinBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinBox3.TabIndex = 15;
            this.SpinBox3.TabStop = false;
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.BackColor = System.Drawing.Color.Black;
            this.BetLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.BetLabel.Location = new System.Drawing.Point(250, 376);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(28, 15);
            this.BetLabel.TabIndex = 16;
            this.BetLabel.Text = "Bet";
            // 
            // TotalCreditsLabel
            // 
            this.TotalCreditsLabel.AutoSize = true;
            this.TotalCreditsLabel.BackColor = System.Drawing.Color.Black;
            this.TotalCreditsLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCreditsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalCreditsLabel.Location = new System.Drawing.Point(148, 376);
            this.TotalCreditsLabel.Name = "TotalCreditsLabel";
            this.TotalCreditsLabel.Size = new System.Drawing.Size(40, 15);
            this.TotalCreditsLabel.TabIndex = 17;
            this.TotalCreditsLabel.Text = "Total";
            // 
            // WinLabel
            // 
            this.WinLabel.AutoSize = true;
            this.WinLabel.BackColor = System.Drawing.Color.Black;
            this.WinLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.WinLabel.Location = new System.Drawing.Point(356, 376);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(34, 15);
            this.WinLabel.TabIndex = 18;
            this.WinLabel.Text = "Win";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.Black;
            this.InfoLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoLabel.Location = new System.Drawing.Point(244, 172);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(39, 15);
            this.InfoLabel.TabIndex = 19;
            this.InfoLabel.Text = "Info ";
            // 
            // BetButton50
            // 
            this.BetButton50.Image = global::SlotMachine.Properties.Resources.bet50;
            this.BetButton50.Location = new System.Drawing.Point(239, 457);
            this.BetButton50.Name = "BetButton50";
            this.BetButton50.Size = new System.Drawing.Size(32, 28);
            this.BetButton50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetButton50.TabIndex = 22;
            this.BetButton50.TabStop = false;
            this.BetButton50.Click += new System.EventHandler(this.setPlayerBet);
            // 
            // BetButton10
            // 
            this.BetButton10.Image = global::SlotMachine.Properties.Resources.bet10;
            this.BetButton10.Location = new System.Drawing.Point(190, 458);
            this.BetButton10.Name = "BetButton10";
            this.BetButton10.Size = new System.Drawing.Size(32, 28);
            this.BetButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetButton10.TabIndex = 21;
            this.BetButton10.TabStop = false;
            this.BetButton10.Click += new System.EventHandler(this.setPlayerBet);
            // 
            // BetButton2
            // 
            this.BetButton2.Image = global::SlotMachine.Properties.Resources.bet2;
            this.BetButton2.Location = new System.Drawing.Point(137, 457);
            this.BetButton2.Name = "BetButton2";
            this.BetButton2.Size = new System.Drawing.Size(32, 28);
            this.BetButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetButton2.TabIndex = 20;
            this.BetButton2.TabStop = false;
            this.BetButton2.Click += new System.EventHandler(this.setPlayerBet);
            // 
            // BetButton100
            // 
            this.BetButton100.Image = global::SlotMachine.Properties.Resources.bet100;
            this.BetButton100.Location = new System.Drawing.Point(262, 429);
            this.BetButton100.Name = "BetButton100";
            this.BetButton100.Size = new System.Drawing.Size(32, 28);
            this.BetButton100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetButton100.TabIndex = 23;
            this.BetButton100.TabStop = false;
            this.BetButton100.Click += new System.EventHandler(this.setPlayerBet);
            // 
            // BetButton500
            // 
            this.BetButton500.Image = global::SlotMachine.Properties.Resources.bet500;
            this.BetButton500.Location = new System.Drawing.Point(286, 456);
            this.BetButton500.Name = "BetButton500";
            this.BetButton500.Size = new System.Drawing.Size(32, 28);
            this.BetButton500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetButton500.TabIndex = 24;
            this.BetButton500.TabStop = false;
            this.BetButton500.Click += new System.EventHandler(this.setPlayerBet);
            // 
            // BetLine
            // 
            this.BetLine.Image = global::SlotMachine.Properties.Resources.bet_line;
            this.BetLine.Location = new System.Drawing.Point(124, 292);
            this.BetLine.Name = "BetLine";
            this.BetLine.Size = new System.Drawing.Size(306, 10);
            this.BetLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BetLine.TabIndex = 25;
            this.BetLine.TabStop = false;
            this.BetLine.Click += new System.EventHandler(this.setPlayerBet);
            // 
            // CreditButton
            // 
            this.CreditButton.Image = global::SlotMachine.Properties.Resources.spin_disabled;
            this.CreditButton.Location = new System.Drawing.Point(384, 430);
            this.CreditButton.Name = "CreditButton";
            this.CreditButton.Size = new System.Drawing.Size(59, 54);
            this.CreditButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreditButton.TabIndex = 26;
            this.CreditButton.TabStop = false;
            this.CreditButton.Click += new System.EventHandler(this.CreditButton_Click);
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(555, 543);
            this.ControlBox = false;
            this.Controls.Add(this.CreditButton);
            this.Controls.Add(this.BetLine);
            this.Controls.Add(this.BetButton500);
            this.Controls.Add(this.BetButton100);
            this.Controls.Add(this.BetButton50);
            this.Controls.Add(this.BetButton10);
            this.Controls.Add(this.BetButton2);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.WinLabel);
            this.Controls.Add(this.TotalCreditsLabel);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.SpinBox3);
            this.Controls.Add(this.SpinBox2);
            this.Controls.Add(this.SpinBox1);
            this.Controls.Add(this.BetButton25);
            this.Controls.Add(this.BetButton5);
            this.Controls.Add(this.BetButton1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SpinPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.SlotMachineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetButton500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.PictureBox ResetButton;
        private System.Windows.Forms.PictureBox BetButton1;
        private System.Windows.Forms.PictureBox BetButton5;
        private System.Windows.Forms.PictureBox BetButton25;
        private System.Windows.Forms.PictureBox SpinBox1;
        private System.Windows.Forms.PictureBox SpinBox2;
        private System.Windows.Forms.PictureBox SpinBox3;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Label TotalCreditsLabel;
        private System.Windows.Forms.Label WinLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.PictureBox BetButton50;
        private System.Windows.Forms.PictureBox BetButton10;
        private System.Windows.Forms.PictureBox BetButton2;
        private System.Windows.Forms.PictureBox BetButton100;
        private System.Windows.Forms.PictureBox BetButton500;
        private System.Windows.Forms.PictureBox BetLine;
        private System.Windows.Forms.PictureBox CreditButton;
    }
}