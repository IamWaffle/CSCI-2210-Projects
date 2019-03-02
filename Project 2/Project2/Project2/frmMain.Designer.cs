namespace Project2
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFNF = new System.Windows.Forms.Button();
            this.btnLNF = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 303);
            this.listBox1.TabIndex = 0;
            // 
            // btnFNF
            // 
            this.btnFNF.BackColor = System.Drawing.Color.White;
            this.btnFNF.ForeColor = System.Drawing.Color.Black;
            this.btnFNF.Location = new System.Drawing.Point(12, 321);
            this.btnFNF.Name = "btnFNF";
            this.btnFNF.Size = new System.Drawing.Size(251, 21);
            this.btnFNF.TabIndex = 1;
            this.btnFNF.Text = "First Name First";
            this.btnFNF.UseVisualStyleBackColor = false;
            // 
            // btnLNF
            // 
            this.btnLNF.BackColor = System.Drawing.Color.White;
            this.btnLNF.Location = new System.Drawing.Point(12, 350);
            this.btnLNF.Name = "btnLNF";
            this.btnLNF.Size = new System.Drawing.Size(251, 21);
            this.btnLNF.TabIndex = 2;
            this.btnLNF.Text = "Last Name First";
            this.btnLNF.UseVisualStyleBackColor = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(426, 340);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "temp";
            // 
            // dateTimer
            // 
            this.dateTimer.Enabled = true;
            this.dateTimer.Interval = 1000;
            this.dateTimer.Tick += new System.EventHandler(this.dateTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(456, 361);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(30, 13);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "temp";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(304, 350);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(72, 21);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(556, 383);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.btnLNF);
            this.Controls.Add(this.btnFNF);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project 2 - NameList Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFNF;
        private System.Windows.Forms.Button btnLNF;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer dateTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button btnAbout;
    }
}