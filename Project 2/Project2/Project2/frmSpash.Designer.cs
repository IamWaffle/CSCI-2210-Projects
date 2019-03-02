namespace Project2
{
    partial class frmSpash
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
            this.nameList = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.project = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.showTime = new System.Windows.Forms.Timer(this.components);
            this.progTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // nameList
            // 
            this.nameList.AutoSize = true;
            this.nameList.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameList.ForeColor = System.Drawing.Color.White;
            this.nameList.Location = new System.Drawing.Point(45, 24);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(154, 42);
            this.nameList.TabIndex = 0;
            this.nameList.Text = "NameList";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(80, 66);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(129, 14);
            this.name.TabIndex = 1;
            this.name.Text = "Ryan Shupe - CSCI 2210";
            // 
            // project
            // 
            this.project.AutoSize = true;
            this.project.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project.ForeColor = System.Drawing.Color.White;
            this.project.Location = new System.Drawing.Point(186, 44);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(56, 15);
            this.project.TabIndex = 2;
            this.project.Text = "Project 2";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.progressBar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(95)))), ((int)(((byte)(85)))));
            this.progressBar.Location = new System.Drawing.Point(0, 92);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(294, 30);
            this.progressBar.Step = 25;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            // 
            // showTime
            // 
            this.showTime.Enabled = true;
            this.showTime.Interval = 1850;
            this.showTime.Tick += new System.EventHandler(this.showTime_Tick);
            // 
            // progTimer
            // 
            this.progTimer.Enabled = true;
            this.progTimer.Interval = 15;
            this.progTimer.Tick += new System.EventHandler(this.progTimer_Tick);
            // 
            // frmSpash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(294, 123);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.project);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameList);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSpash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NameList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameList;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label project;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer showTime;
        private System.Windows.Forms.Timer progTimer;
    }
}

