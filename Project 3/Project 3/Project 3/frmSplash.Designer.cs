namespace Project_3
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    //	File Name:         frmSplash.Designer.cs
    //	Description:        this is the designer class for the splash screen
    //	Course:            CSCI 2210 - Data Structures
    //	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
    //	Created:           Friday, Mar 29 2019
    //  
    //
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpash));
            this.projName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.project = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.showTime = new System.Windows.Forms.Timer(this.components);
            this.progTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // projName
            // 
            this.projName.AutoSize = true;
            this.projName.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projName.ForeColor = System.Drawing.Color.White;
            this.projName.Location = new System.Drawing.Point(34, 24);
            this.projName.Name = "projName";
            this.projName.Size = new System.Drawing.Size(164, 42);
            this.projName.TabIndex = 0;
            this.projName.Text = "Converter";
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
            this.project.Text = "Project 3";
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
            this.Controls.Add(this.projName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSpash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NameList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label project;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer showTime;
        private System.Windows.Forms.Timer progTimer;
    }
}

