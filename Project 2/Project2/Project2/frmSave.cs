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

        /// <summary>
        ///  frmSave - Basic constructor that does not take any parameters
        /// </summary>
        public frmSave()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods
        /// <summary>
        /// btnYes_Click - this method checks to see if the user wants to save their work/ This will set save bool = true then close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            save = true;
            this.Close();
        }

        /// <summary>
        /// btnNo_Click - this method checks to see if the user wants to save their work/ This will close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        #endregion Methods
    }
}
