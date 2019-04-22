using System;
using System.Windows.Forms;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmSplash.cs
//	Description:        this is the form where the spash screen is displayed. It is programed to show until the progress bar reaches 100%
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Friday, Mar 01 2019
//  Modified:           Friday, Mar 01 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project_5_BTree
{
    public partial class frmSpash : Form
    {

        #region Constructors
        /// <summary>
        /// frmSpash - basic no arg constructor
        /// </summary>
        public frmSpash()
        {
            InitializeComponent();
            progressBar.MarqueeAnimationSpeed = 30;
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// showTime_Tick - this method executes when the showTime timer ticks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showTime_Tick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// progTime_Tick - this method executes when the progTime timer ticks to progress the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void progTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            if (progressBar.Value == 100)
            {
                progTimer.Stop();
            }
        }

        #endregion Methods


    }
}