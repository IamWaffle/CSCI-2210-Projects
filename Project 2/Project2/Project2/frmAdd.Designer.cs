namespace Project2
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    //	File Name:         frmAdd.Designer.cs
    //	Description:        this is the designer class for the add form
    //	Course:            CSCI 2210 - Data Structures
    //	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
    //	Created:           Friday, Mar 01 2019
    //  Modified:          Monday, Mar 04 2019
    //
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    partial class frmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            this.addLabel = new System.Windows.Forms.Label();
            this.nameContentPanel = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleLabel = new System.Windows.Forms.Label();
            this.fstNameLabel = new System.Windows.Forms.Label();
            this.txtboxEnd = new System.Windows.Forms.TextBox();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.txtboxMiddleName = new System.Windows.Forms.TextBox();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.nameContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.ForeColor = System.Drawing.Color.White;
            this.addLabel.Location = new System.Drawing.Point(15, 0);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(181, 13);
            this.addLabel.TabIndex = 2;
            this.addLabel.Text = "Type the name you would like to add";
            // 
            // nameContentPanel
            // 
            this.nameContentPanel.Controls.Add(this.btnAdd);
            this.nameContentPanel.Controls.Add(this.addLabel);
            this.nameContentPanel.Controls.Add(this.endLabel);
            this.nameContentPanel.Controls.Add(this.lastNameLabel);
            this.nameContentPanel.Controls.Add(this.middleLabel);
            this.nameContentPanel.Controls.Add(this.fstNameLabel);
            this.nameContentPanel.Controls.Add(this.txtboxEnd);
            this.nameContentPanel.Controls.Add(this.txtboxLastName);
            this.nameContentPanel.Controls.Add(this.fullNameLabel);
            this.nameContentPanel.Controls.Add(this.txtboxMiddleName);
            this.nameContentPanel.Controls.Add(this.txtboxFirstName);
            this.nameContentPanel.Location = new System.Drawing.Point(7, 12);
            this.nameContentPanel.Name = "nameContentPanel";
            this.nameContentPanel.Size = new System.Drawing.Size(227, 226);
            this.nameContentPanel.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(18, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Name";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.ForeColor = System.Drawing.Color.White;
            this.endLabel.Location = new System.Drawing.Point(15, 142);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(36, 13);
            this.endLabel.TabIndex = 12;
            this.endLabel.Text = "Suffix:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(15, 103);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // middleLabel
            // 
            this.middleLabel.AutoSize = true;
            this.middleLabel.ForeColor = System.Drawing.Color.White;
            this.middleLabel.Location = new System.Drawing.Point(15, 64);
            this.middleLabel.Name = "middleLabel";
            this.middleLabel.Size = new System.Drawing.Size(41, 13);
            this.middleLabel.TabIndex = 9;
            this.middleLabel.Text = "Middle:";
            // 
            // fstNameLabel
            // 
            this.fstNameLabel.AutoSize = true;
            this.fstNameLabel.ForeColor = System.Drawing.Color.White;
            this.fstNameLabel.Location = new System.Drawing.Point(15, 25);
            this.fstNameLabel.Name = "fstNameLabel";
            this.fstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.fstNameLabel.TabIndex = 8;
            this.fstNameLabel.Text = "First Name:";
            // 
            // txtboxEnd
            // 
            this.txtboxEnd.Location = new System.Drawing.Point(18, 158);
            this.txtboxEnd.Name = "txtboxEnd";
            this.txtboxEnd.Size = new System.Drawing.Size(151, 20);
            this.txtboxEnd.TabIndex = 3;
            this.txtboxEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxEnd_KeyPress);
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(18, 119);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(151, 20);
            this.txtboxLastName.TabIndex = 2;
            this.txtboxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxLastName_KeyPress);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.ForeColor = System.Drawing.Color.White;
            this.fullNameLabel.Location = new System.Drawing.Point(15, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(0, 13);
            this.fullNameLabel.TabIndex = 7;
            // 
            // txtboxMiddleName
            // 
            this.txtboxMiddleName.Location = new System.Drawing.Point(18, 80);
            this.txtboxMiddleName.Name = "txtboxMiddleName";
            this.txtboxMiddleName.Size = new System.Drawing.Size(151, 20);
            this.txtboxMiddleName.TabIndex = 1;
            this.txtboxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxMiddleName_KeyPress);
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(18, 41);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(151, 20);
            this.txtboxFirstName.TabIndex = 0;
            this.txtboxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxFirstName_KeyPress);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(234, 238);
            this.Controls.Add(this.nameContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a Name";
            this.nameContentPanel.ResumeLayout(false);
            this.nameContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Panel nameContentPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label middleLabel;
        private System.Windows.Forms.Label fstNameLabel;
        private System.Windows.Forms.TextBox txtboxEnd;
        public System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox txtboxMiddleName;
        private System.Windows.Forms.TextBox txtboxFirstName;
    }
}