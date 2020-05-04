namespace TicTacToe
{
    partial class Form1
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
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(12, 12);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(92, 87);
            this.B1.TabIndex = 0;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.buttonClick);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(12, 105);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(92, 87);
            this.B2.TabIndex = 1;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.buttonClick);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(12, 198);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(92, 87);
            this.B3.TabIndex = 2;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.buttonClick);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(110, 198);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(92, 87);
            this.B4.TabIndex = 3;
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.buttonClick);
            // 
            // B5
            // 
            this.B5.Location = new System.Drawing.Point(110, 105);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(92, 87);
            this.B5.TabIndex = 4;
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.buttonClick);
            // 
            // B6
            // 
            this.B6.Location = new System.Drawing.Point(110, 12);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(92, 87);
            this.B6.TabIndex = 5;
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.buttonClick);
            // 
            // B7
            // 
            this.B7.Location = new System.Drawing.Point(208, 198);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(92, 87);
            this.B7.TabIndex = 6;
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.buttonClick);
            // 
            // B8
            // 
            this.B8.Location = new System.Drawing.Point(208, 105);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(92, 87);
            this.B8.TabIndex = 7;
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.buttonClick);
            // 
            // B9
            // 
            this.B9.Location = new System.Drawing.Point(208, 12);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(92, 87);
            this.B9.TabIndex = 8;
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.buttonClick);
            // 
            // NGButton
            // 
            this.NGButton.Location = new System.Drawing.Point(12, 314);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(92, 25);
            this.NGButton.TabIndex = 9;
            this.NGButton.Text = "New Game";
            this.NGButton.UseVisualStyleBackColor = true;
            this.NGButton.Click += new System.EventHandler(this.NGButton_Click);
            // 
            // EButton
            // 
            this.EButton.Location = new System.Drawing.Point(110, 365);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(92, 25);
            this.EButton.TabIndex = 10;
            this.EButton.Text = "Exit";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.EButton_Click);
            // 
            // RButton
            // 
            this.RButton.Location = new System.Drawing.Point(208, 314);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(92, 25);
            this.RButton.TabIndex = 11;
            this.RButton.Text = "Reset";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.RButton_Click);
            // 
            // XWin
            // 
            this.XWin.Location = new System.Drawing.Point(317, 47);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(100, 23);
            this.XWin.TabIndex = 12;
            this.XWin.Text = "label1";
            // 
            // OWin
            // 
            this.OWin.Location = new System.Drawing.Point(317, 140);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(100, 23);
            this.OWin.TabIndex = 13;
            this.OWin.Text = "label2";
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(317, 233);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(100, 23);
            this.Draw.TabIndex = 14;
            this.Draw.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 442);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.NGButton);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draw;
    }
}

