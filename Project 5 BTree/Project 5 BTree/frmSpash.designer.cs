namespace Project_5_BTree
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    //	File Name:         frmSplash.Designer.cs
    //	Description:        this is the designer class for the splash screen
    //	Course:            CSCI 2210 - Data Structures
    //	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
    //	Created:           Friday, Mar 01 2019
    //  Modified:          Friday, Mar 01 2019
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
            this.projectName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.projectNum = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.showTime = new System.Windows.Forms.Timer(this.components);
            this.progTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.ForeColor = System.Drawing.Color.White;
            this.projectName.Location = new System.Drawing.Point(68, 24);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(112, 42);
            this.projectName.TabIndex = 0;
            this.projectName.Text = "B-Tree";
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
            // projectNum
            // 
            this.projectNum.AutoSize = true;
            this.projectNum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNum.ForeColor = System.Drawing.Color.White;
            this.projectNum.Location = new System.Drawing.Point(172, 51);
            this.projectNum.Name = "projectNum";
            this.projectNum.Size = new System.Drawing.Size(56, 15);
            this.projectNum.TabIndex = 2;
            this.projectNum.Text = "Project 5";
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
            this.Controls.Add(this.projectNum);
            this.Controls.Add(this.name);
            this.Controls.Add(this.projectName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSpash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NameList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label projectNum;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer showTime;
        private System.Windows.Forms.Timer progTimer;
    }
}

