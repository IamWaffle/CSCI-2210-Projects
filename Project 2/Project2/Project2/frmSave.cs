using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmSave.cs
//	Description:        this form shows asking the user if they would like to save there work.
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Friday, Mar 01 2019
//  Modified:          Monday, Mar 04 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project2
{
    public partial class frmSave : Form
    {

        public bool save = false;

        #region Constructors
        public frmSave()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods
        private void btnYes_Click(object sender, EventArgs e)
        {
            save = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        #endregion Methods
    }
}
