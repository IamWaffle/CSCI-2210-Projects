///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmMain.Designer.cs
//	Description:       This is the designer file for the main form.
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Wednesday Apr 17, 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project_5_BTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtboxTree = new System.Windows.Forms.RichTextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtBoxInfo = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBTree = new System.Windows.Forms.Label();
            this.labelStats = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxTree
            // 
            this.txtboxTree.Location = new System.Drawing.Point(12, 46);
            this.txtboxTree.Name = "txtboxTree";
            this.txtboxTree.ReadOnly = true;
            this.txtboxTree.Size = new System.Drawing.Size(317, 392);
            this.txtboxTree.TabIndex = 0;
            this.txtboxTree.Text = "";
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.White;
            this.BtnCreate.Location = new System.Drawing.Point(338, 30);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(241, 23);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "Create a new Tree";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(339, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add a value to the tree";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(339, 90);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(240, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find a value in the tree";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.Location = new System.Drawing.Point(338, 136);
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.ReadOnly = true;
            this.txtBoxInfo.Size = new System.Drawing.Size(241, 302);
            this.txtBoxInfo.TabIndex = 4;
            this.txtBoxInfo.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // labelBTree
            // 
            this.labelBTree.AutoSize = true;
            this.labelBTree.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelBTree.Location = new System.Drawing.Point(12, 30);
            this.labelBTree.Name = "labelBTree";
            this.labelBTree.Size = new System.Drawing.Size(76, 13);
            this.labelBTree.TabIndex = 6;
            this.labelBTree.Text = "Whole B-Tree:";
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStats.Location = new System.Drawing.Point(338, 117);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(113, 13);
            this.labelStats.TabIndex = 7;
            this.labelStats.Text = "B-Tree Stats and Find:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(591, 446);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.labelBTree);
            this.Controls.Add(this.txtBoxInfo);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.txtboxTree);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project 5 - BTree";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtboxTree;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RichTextBox txtBoxInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelBTree;
        private System.Windows.Forms.Label labelStats;
    }
}