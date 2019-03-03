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
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.btnFNF = new System.Windows.Forms.Button();
            this.btnLNF = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tmrDateListItems = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeANameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.numNames = new System.Windows.Forms.Label();
            this.nameContentPanel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleLabel = new System.Windows.Forms.Label();
            this.fstNameLabel = new System.Windows.Forms.Label();
            this.txtboxEnd = new System.Windows.Forms.TextBox();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.txtboxMiddleName = new System.Windows.Forms.TextBox();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
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
            this.nameListBox.Location = new System.Drawing.Point(12, 38);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(251, 262);
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
            this.btnFNF.Text = "First Name First";
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
            this.btnLNF.Text = "Last Name First";
            this.btnLNF.UseVisualStyleBackColor = false;
            this.btnLNF.Click += new System.EventHandler(this.btnLNF_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(382, 329);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(28, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "date";
            // 
            // tmrDateListItems
            // 
            this.tmrDateListItems.Enabled = true;
            this.tmrDateListItems.Interval = 200;
            this.tmrDateListItems.Tick += new System.EventHandler(this.dateTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(417, 350);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(26, 13);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.fileToolStripMenuItem1,
            this.nameToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.editToolStripMenuItem.Text = "Name List";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.openToolStripMenuItem1.Text = "Open a file";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.saveToolStripMenuItem1.Text = "Save the list";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANameToolStripMenuItem,
            this.removeANameToolStripMenuItem});
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // addANameToolStripMenuItem
            // 
            this.addANameToolStripMenuItem.Name = "addANameToolStripMenuItem";
            this.addANameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addANameToolStripMenuItem.Text = "Add a Name";
            this.addANameToolStripMenuItem.Click += new System.EventHandler(this.addANameToolStripMenuItem_Click);
            // 
            // removeANameToolStripMenuItem
            // 
            this.removeANameToolStripMenuItem.Name = "removeANameToolStripMenuItem";
            this.removeANameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.removeANameToolStripMenuItem.Text = "Remove a Name";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
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
            this.nameContentPanel.Location = new System.Drawing.Point(317, 38);
            this.nameContentPanel.Name = "nameContentPanel";
            this.nameContentPanel.Size = new System.Drawing.Size(227, 226);
            this.nameContentPanel.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(18, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.ForeColor = System.Drawing.Color.White;
            this.endLabel.Location = new System.Drawing.Point(15, 142);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(29, 13);
            this.endLabel.TabIndex = 12;
            this.endLabel.Text = "End:";
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
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(18, 119);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(151, 20);
            this.txtboxLastName.TabIndex = 2;
            // 
            // txtboxMiddleName
            // 
            this.txtboxMiddleName.Location = new System.Drawing.Point(18, 80);
            this.txtboxMiddleName.Name = "txtboxMiddleName";
            this.txtboxMiddleName.Size = new System.Drawing.Size(151, 20);
            this.txtboxMiddleName.TabIndex = 1;
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(18, 41);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(151, 20);
            this.txtboxFirstName.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(553, 382);
            this.Controls.Add(this.nameContentPanel);
            this.Controls.Add(this.numNames);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
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
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer tmrDateListItems;
        private System.Windows.Forms.Label timeLabel;
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
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeANameToolStripMenuItem;
    }
}