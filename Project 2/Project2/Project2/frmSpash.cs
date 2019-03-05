using System;
using System.Windows.Forms;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmSplash.cs
//	Description:
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Friday, Mar 01 2019
//  Modified:          Monday, Mar 04 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project2
{
    public partial class frmSpash : Form
    {
        /// <summary>
        /// frmSpash - basic no arg constructor
        /// </summary>
        public frmSpash()
        {
            InitializeComponent();
            progressBar.MarqueeAnimationSpeed = 30;
        }

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
    }
}