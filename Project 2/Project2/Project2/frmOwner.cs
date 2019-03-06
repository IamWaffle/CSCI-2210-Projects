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
//	File Name:         frmOwner.cs
//	Description:       This is where we get and validate the owners information
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Wednesday, Mar 06 2019
//  Modified:          Wednesday, Mar 06 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project2
{
    public partial class frmOwner : Form
    {
        private string outName, outPhone, outEmail, tempName, tempPhone, tempEmail;

        public string name
        {
            get { return outName; }
        }

        public string phone
        {
            get { return outPhone; }
        }


        public string email
        {
            get { return outEmail; }
        }

        #region Constructors
        /// <summary>
        /// frmOwner - basic no arg constructor
        /// </summary>
        public frmOwner()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// btnContinue_Click - this method executes when the continue button is pressed.
        /// It validates the information before going on with the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinue_Click(object sender, EventArgs e)
        {
            tempName = txtboxName.Text;
            tempPhone = txtboxPhone.Text + "";
            tempEmail = txtboxEmail.Text;
            try
            {
                Tools.displayWelcome( out outName, out outPhone, out outEmail, tempName, tempPhone, tempEmail);
                this.Close();
            }
            catch(Exception)
            {
                 if (email == null && phone == null && name == null)
                {
                    txtboxName.Text = null;
                    txtboxPhone.Text = null;
                    txtboxEmail.Text = null;
                    invalidInfoLabel.Text = "Please enter in your information.";
                }
                else if(name == null)
                {
                    txtboxName.Text = null;
                    invalidInfoLabel.Text = "Please enter a valid name.";
                }
                else if (email == null && phone == null)
                {
                    txtboxPhone.Text = null;
                    txtboxEmail.Text = null;
                    invalidInfoLabel.Text = "Please enter a valid phone and email.";
                }
                else if (phone == null)
                {
                    txtboxPhone.Text = null;
                    invalidInfoLabel.Text = "Please enter a valid phone number";
                }
                else if (email == null)
                {
                    txtboxEmail.Text = null;
                    invalidInfoLabel.Text = "Please enter a valid email.";
                }
  
            }
 
        }


        /// <summary>
        /// btnExit_Click_1 - this method executes when the exit button is clicked and it terminates the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion Methods

        #region KeyPress
        /// <summary>
        /// txtboxName_KeyPress - this method checks to see if the user is typing the right key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtboxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// txtboxPhone_KeyPress - this method checks to see if the user is typing the right key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtboxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
        #endregion KeyPress
    }
}
