namespace Project2
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    //	File Name:         frmRemove.Designer.cs
    //	Description:
    //	Course:            CSCI 2210 - Data Structures
    //	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
    //	Created:           Friday, Mar 01 2019
    //  Modified:          Monday, Mar 04 2019
    //
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    partial class frmRemove
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
            this.nameListBox2 = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameListBox2
            // 
            this.nameListBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.nameListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameListBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nameListBox2.ForeColor = System.Drawing.Color.White;
            this.nameListBox2.FormattingEnabled = true;
            this.nameListBox2.Location = new System.Drawing.Point(48, 36);
            this.nameListBox2.Name = "nameListBox2";
            this.nameListBox2.Size = new System.Drawing.Size(251, 275);
            this.nameListBox2.TabIndex = 9;
            this.nameListBox2.SelectedIndexChanged += new System.EventHandler(this.nameListBox2_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(84, 317);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(170, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.ForeColor = System.Drawing.Color.White;
            this.selectLabel.Location = new System.Drawing.Point(70, 20);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(207, 13);
            this.selectLabel.TabIndex = 0;
            this.selectLabel.Text = "Select the name you would like to remove:";
            // 
            // frmRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(351, 365);
            this.Controls.Add(this.nameListBox2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.selectLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRemove";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove a Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox nameListBox2;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Label selectLabel;
    }
}