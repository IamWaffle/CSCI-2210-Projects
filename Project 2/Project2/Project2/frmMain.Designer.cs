namespace Project2
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    //	File Name:         frmMain.Designer.cs
    //	Description:        this is the designer class for the main form
    //	Course:            CSCI 2210 - Data Structures
    //	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
    //	Created:           Friday, Mar 01 2019
    //  Modified:          Monday, Mar 04 2019
    //
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.btnFNF = new System.Windows.Forms.Button();
            this.btnLNF = new System.Windows.Forms.Button();
            this.tmrDateListItems = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addANameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.numNames = new System.Windows.Forms.Label();
            this.nameContentPanel = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleLabel = new System.Windows.Forms.Label();
            this.fstNameLabel = new System.Windows.Forms.Label();
            this.txtboxEnd = new System.Windows.Forms.TextBox();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.txtboxMiddleName = new System.Windows.Forms.TextBox();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.dateTimeBar = new System.Windows.Forms.StatusBar();
            this.nameListLabel = new System.Windows.Forms.Label();
            this.project2 = new System.Windows.Forms.Label();
            this.selectedNameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.ownerPhoneLabel = new System.Windows.Forms.Label();
            this.ownerEmailLabel = new System.Windows.Forms.Label();
            this.addNameButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.nameContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameListBox
            // 
            this.nameListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.nameListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nameListBox.ForeColor = System.Drawing.Color.White;
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(12, 51);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(251, 249);
            this.nameListBox.TabIndex = 0;
            this.nameListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.nameListBox_DrawItem);
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            // 
            // btnFNF
            // 
            this.btnFNF.BackColor = System.Drawing.Color.White;
            this.btnFNF.ForeColor = System.Drawing.Color.Black;
            this.btnFNF.Location = new System.Drawing.Point(12, 321);
            this.btnFNF.Name = "btnFNF";
            this.btnFNF.Size = new System.Drawing.Size(251, 21);
            this.btnFNF.TabIndex = 1;
            this.btnFNF.Text = "&First Name First";
            this.btnFNF.UseVisualStyleBackColor = false;
            this.btnFNF.Click += new System.EventHandler(this.btnFNF_Click);
            // 
            // btnLNF
            // 
            this.btnLNF.BackColor = System.Drawing.Color.White;
            this.btnLNF.Location = new System.Drawing.Point(12, 350);
            this.btnLNF.Name = "btnLNF";
            this.btnLNF.Size = new System.Drawing.Size(251, 21);
            this.btnLNF.TabIndex = 2;
            this.btnLNF.Text = "&Last Name First";
            this.btnLNF.UseVisualStyleBackColor = false;
            this.btnLNF.Click += new System.EventHandler(this.btnLNF_Click);
            // 
            // tmrDateListItems
            // 
            this.tmrDateListItems.Enabled = true;
            this.tmrDateListItems.Interval = 200;
            this.tmrDateListItems.Tick += new System.EventHandler(this.dateTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.addANameToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.editToolStripMenuItem.Text = "&Name List";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.openToolStripMenuItem1.Text = "&Import a list";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.saveToolStripMenuItem1.Text = "&Export the list";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // addANameToolStripMenuItem
            // 
            this.addANameToolStripMenuItem.Name = "addANameToolStripMenuItem";
            this.addANameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addANameToolStripMenuItem.Text = "Add a name";
            this.addANameToolStripMenuItem.Click += new System.EventHandler(this.addANameToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "&Clear the list";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            // numNames
            // 
            this.numNames.AutoSize = true;
            this.numNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numNames.Location = new System.Drawing.Point(12, 305);
            this.numNames.Name = "numNames";
            this.numNames.Size = new System.Drawing.Size(135, 13);
            this.numNames.TabIndex = 8;
            this.numNames.Text = "Number of names in List:  0";
            // 
            // nameContentPanel
            // 
            this.nameContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.nameContentPanel.Controls.Add(this.btnRemove);
            this.nameContentPanel.Controls.Add(this.btnSave);
            this.nameContentPanel.Controls.Add(this.endLabel);
            this.nameContentPanel.Controls.Add(this.lastNameLabel);
            this.nameContentPanel.Controls.Add(this.middleLabel);
            this.nameContentPanel.Controls.Add(this.fstNameLabel);
            this.nameContentPanel.Controls.Add(this.txtboxEnd);
            this.nameContentPanel.Controls.Add(this.txtboxLastName);
            this.nameContentPanel.Controls.Add(this.fullNameLabel);
            this.nameContentPanel.Controls.Add(this.txtboxMiddleName);
            this.nameContentPanel.Controls.Add(this.txtboxFirstName);
            this.nameContentPanel.Location = new System.Drawing.Point(298, 50);
            this.nameContentPanel.Name = "nameContentPanel";
            this.nameContentPanel.Size = new System.Drawing.Size(214, 226);
            this.nameContentPanel.TabIndex = 9;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(104, 194);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(65, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(18, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // dateTimeBar
            // 
            this.dateTimeBar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBar.Location = new System.Drawing.Point(0, 383);
            this.dateTimeBar.Name = "dateTimeBar";
            this.dateTimeBar.Size = new System.Drawing.Size(550, 22);
            this.dateTimeBar.TabIndex = 10;
            // 
            // nameListLabel
            // 
            this.nameListLabel.AutoSize = true;
            this.nameListLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameListLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameListLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nameListLabel.Location = new System.Drawing.Point(310, 270);
            this.nameListLabel.Name = "nameListLabel";
            this.nameListLabel.Size = new System.Drawing.Size(154, 42);
            this.nameListLabel.TabIndex = 16;
            this.nameListLabel.Text = "NameList";
            // 
            // project2
            // 
            this.project2.AutoSize = true;
            this.project2.ForeColor = System.Drawing.Color.White;
            this.project2.Location = new System.Drawing.Point(452, 292);
            this.project2.Name = "project2";
            this.project2.Size = new System.Drawing.Size(49, 13);
            this.project2.TabIndex = 17;
            this.project2.Text = "Project 2";
            // 
            // selectedNameLabel
            // 
            this.selectedNameLabel.AutoSize = true;
            this.selectedNameLabel.ForeColor = System.Drawing.Color.White;
            this.selectedNameLabel.Location = new System.Drawing.Point(306, 34);
            this.selectedNameLabel.Name = "selectedNameLabel";
            this.selectedNameLabel.Size = new System.Drawing.Size(81, 13);
            this.selectedNameLabel.TabIndex = 18;
            this.selectedNameLabel.Text = "Selected name:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(338, 305);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(126, 13);
            this.name.TabIndex = 19;
            this.name.Text = "Ryan Shupe - CSCI 2210";
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.AutoSize = true;
            this.ownerNameLabel.ForeColor = System.Drawing.Color.White;
            this.ownerNameLabel.Location = new System.Drawing.Point(314, 329);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(13, 13);
            this.ownerNameLabel.TabIndex = 21;
            this.ownerNameLabel.Text = "1";
            // 
            // ownerPhoneLabel
            // 
            this.ownerPhoneLabel.AutoSize = true;
            this.ownerPhoneLabel.ForeColor = System.Drawing.Color.White;
            this.ownerPhoneLabel.Location = new System.Drawing.Point(314, 342);
            this.ownerPhoneLabel.Name = "ownerPhoneLabel";
            this.ownerPhoneLabel.Size = new System.Drawing.Size(13, 13);
            this.ownerPhoneLabel.TabIndex = 22;
            this.ownerPhoneLabel.Text = "2";
            // 
            // ownerEmailLabel
            // 
            this.ownerEmailLabel.AutoSize = true;
            this.ownerEmailLabel.ForeColor = System.Drawing.Color.White;
            this.ownerEmailLabel.Location = new System.Drawing.Point(314, 355);
            this.ownerEmailLabel.Name = "ownerEmailLabel";
            this.ownerEmailLabel.Size = new System.Drawing.Size(13, 13);
            this.ownerEmailLabel.TabIndex = 23;
            this.ownerEmailLabel.Text = "3";
            // 
            // addNameButton
            // 
            this.addNameButton.BackColor = System.Drawing.Color.White;
            this.addNameButton.Location = new System.Drawing.Point(12, 27);
            this.addNameButton.Name = "addNameButton";
            this.addNameButton.Size = new System.Drawing.Size(91, 22);
            this.addNameButton.TabIndex = 15;
            this.addNameButton.Text = "Add a name";
            this.addNameButton.UseVisualStyleBackColor = false;
            this.addNameButton.Click += new System.EventHandler(this.addNameButton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(550, 405);
            this.Controls.Add(this.addNameButton);
            this.Controls.Add(this.ownerEmailLabel);
            this.Controls.Add(this.ownerPhoneLabel);
            this.Controls.Add(this.ownerNameLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.selectedNameLabel);
            this.Controls.Add(this.project2);
            this.Controls.Add(this.nameListLabel);
            this.Controls.Add(this.dateTimeBar);
            this.Controls.Add(this.nameContentPanel);
            this.Controls.Add(this.numNames);
            this.Controls.Add(this.btnLNF);
            this.Controls.Add(this.btnFNF);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project 2 - NameList Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.nameContentPanel.ResumeLayout(false);
            this.nameContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Button btnFNF;
        private System.Windows.Forms.Button btnLNF;
        private System.Windows.Forms.Timer tmrDateListItems;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label numNames;
        private System.Windows.Forms.Panel nameContentPanel;
        private System.Windows.Forms.TextBox txtboxEnd;
        private System.Windows.Forms.TextBox txtboxMiddleName;
        private System.Windows.Forms.TextBox txtboxFirstName;
        public System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label middleLabel;
        private System.Windows.Forms.Label fstNameLabel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusBar dateTimeBar;
        private System.Windows.Forms.Label nameListLabel;
        private System.Windows.Forms.Label project2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label selectedNameLabel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label ownerNameLabel;
        private System.Windows.Forms.Label ownerPhoneLabel;
        private System.Windows.Forms.Label ownerEmailLabel;
        private System.Windows.Forms.Button addNameButton;
        private System.Windows.Forms.ToolStripMenuItem addANameToolStripMenuItem;
    }
}