///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmMain.Designer.cs
//	Description:       this is the designer file for the main window. 
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Friday, Mar 29 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project_3
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
            this.decLabel = new System.Windows.Forms.Label();
            this.baseLabel1 = new System.Windows.Forms.Label();
            this.txtBoxDecimal = new System.Windows.Forms.TextBox();
            this.selectedBaseLabel = new System.Windows.Forms.Label();
            this.fromDecBtn = new System.Windows.Forms.Button();
            this.toDecBtn = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.digitLabel = new System.Windows.Forms.Label();
            this.baseCounter = new System.Windows.Forms.NumericUpDown();
            this.placesInResult = new System.Windows.Forms.NumericUpDown();
            this.txtBoxBase = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.baseCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesInResult)).BeginInit();
            this.SuspendLayout();
            // 
            // decLabel
            // 
            this.decLabel.AutoSize = true;
            this.decLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decLabel.ForeColor = System.Drawing.Color.White;
            this.decLabel.Location = new System.Drawing.Point(50, 25);
            this.decLabel.Name = "decLabel";
            this.decLabel.Size = new System.Drawing.Size(122, 19);
            this.decLabel.TabIndex = 0;
            this.decLabel.Text = "Decimal Value:";
            // 
            // baseLabel1
            // 
            this.baseLabel1.AutoSize = true;
            this.baseLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel1.ForeColor = System.Drawing.Color.White;
            this.baseLabel1.Location = new System.Drawing.Point(243, 25);
            this.baseLabel1.Name = "baseLabel1";
            this.baseLabel1.Size = new System.Drawing.Size(188, 19);
            this.baseLabel1.TabIndex = 1;
            this.baseLabel1.Text = "Integer Value in Base: 2";
            // 
            // txtBoxDecimal
            // 
            this.txtBoxDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDecimal.Location = new System.Drawing.Point(52, 48);
            this.txtBoxDecimal.Name = "txtBoxDecimal";
            this.txtBoxDecimal.Size = new System.Drawing.Size(189, 29);
            this.txtBoxDecimal.TabIndex = 2;
            this.txtBoxDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDecimal_KeyPress);
            // 
            // selectedBaseLabel
            // 
            this.selectedBaseLabel.AutoSize = true;
            this.selectedBaseLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedBaseLabel.ForeColor = System.Drawing.Color.White;
            this.selectedBaseLabel.Location = new System.Drawing.Point(337, 87);
            this.selectedBaseLabel.Name = "selectedBaseLabel";
            this.selectedBaseLabel.Size = new System.Drawing.Size(43, 16);
            this.selectedBaseLabel.TabIndex = 4;
            this.selectedBaseLabel.Text = "Base:";
            // 
            // fromDecBtn
            // 
            this.fromDecBtn.BackColor = System.Drawing.Color.White;
            this.fromDecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDecBtn.Location = new System.Drawing.Point(52, 147);
            this.fromDecBtn.Name = "fromDecBtn";
            this.fromDecBtn.Size = new System.Drawing.Size(189, 23);
            this.fromDecBtn.TabIndex = 5;
            this.fromDecBtn.Text = "Convert From Decimal";
            this.fromDecBtn.UseVisualStyleBackColor = false;
            this.fromDecBtn.Click += new System.EventHandler(this.fromDecBtn_Click);
            // 
            // toDecBtn
            // 
            this.toDecBtn.BackColor = System.Drawing.Color.White;
            this.toDecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDecBtn.Location = new System.Drawing.Point(247, 147);
            this.toDecBtn.Name = "toDecBtn";
            this.toDecBtn.Size = new System.Drawing.Size(189, 23);
            this.toDecBtn.TabIndex = 6;
            this.toDecBtn.Text = "Convert To Decimal";
            this.toDecBtn.UseVisualStyleBackColor = false;
            this.toDecBtn.Click += new System.EventHandler(this.toDecBtn_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Location = new System.Drawing.Point(432, 176);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(58, 23);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // digitLabel
            // 
            this.digitLabel.AutoSize = true;
            this.digitLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitLabel.ForeColor = System.Drawing.Color.White;
            this.digitLabel.Location = new System.Drawing.Point(267, 122);
            this.digitLabel.Name = "digitLabel";
            this.digitLabel.Size = new System.Drawing.Size(113, 16);
            this.digitLabel.TabIndex = 8;
            this.digitLabel.Text = "Places in Result:";
            // 
            // baseCounter
            // 
            this.baseCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.baseCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseCounter.Location = new System.Drawing.Point(386, 81);
            this.baseCounter.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.baseCounter.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.baseCounter.Name = "baseCounter";
            this.baseCounter.Size = new System.Drawing.Size(50, 22);
            this.baseCounter.TabIndex = 10;
            this.baseCounter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.baseCounter.ValueChanged += new System.EventHandler(this.baseCounter_ValueChanged);
            this.baseCounter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.baseCounter_KeyPress);
            // 
            // placesInResult
            // 
            this.placesInResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.placesInResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placesInResult.Location = new System.Drawing.Point(386, 116);
            this.placesInResult.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.placesInResult.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.placesInResult.Name = "placesInResult";
            this.placesInResult.Size = new System.Drawing.Size(50, 22);
            this.placesInResult.TabIndex = 11;
            this.placesInResult.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtBoxBase
            // 
            this.txtBoxBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBase.Location = new System.Drawing.Point(248, 47);
            this.txtBoxBase.Name = "txtBoxBase";
            this.txtBoxBase.Size = new System.Drawing.Size(188, 29);
            this.txtBoxBase.TabIndex = 12;
            this.txtBoxBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBase_KeyPress_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(502, 211);
            this.Controls.Add(this.txtBoxBase);
            this.Controls.Add(this.placesInResult);
            this.Controls.Add(this.baseCounter);
            this.Controls.Add(this.digitLabel);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.toDecBtn);
            this.Controls.Add(this.fromDecBtn);
            this.Controls.Add(this.selectedBaseLabel);
            this.Controls.Add(this.txtBoxDecimal);
            this.Controls.Add(this.baseLabel1);
            this.Controls.Add(this.decLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.baseCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesInResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label decLabel;
        private System.Windows.Forms.Label baseLabel1;
        private System.Windows.Forms.TextBox txtBoxDecimal;
        private System.Windows.Forms.Label selectedBaseLabel;
        private System.Windows.Forms.Button fromDecBtn;
        private System.Windows.Forms.Button toDecBtn;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label digitLabel;
        private System.Windows.Forms.NumericUpDown baseCounter;
        private System.Windows.Forms.NumericUpDown placesInResult;
        private System.Windows.Forms.TextBox txtBoxBase;
    }
}

