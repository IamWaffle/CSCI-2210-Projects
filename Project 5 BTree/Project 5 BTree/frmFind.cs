///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmFind.cs
//	Description:       This class is the window to verify the value to be found
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Wednesday Apr 17, 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;



namespace Project_5_BTree
{
    /// <summary>
    /// This is the form that shows up when the user is trying to find a variable
    /// </summary>
    public partial class frmFind : Form
    {
        private int searchFind { get; set; }

        #region Constructor

        /// <summary>
        /// basic no arg constructor
        /// </summary>
        public frmFind()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// this method checks to see if the user is typing the right stuff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// this method executes when the user clicks the ok button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnOk_Click(object sender, EventArgs e)
        {
            string str = txtBoxFind.Text;

            try
            {
                searchFind = int.Parse(str);
            }
            catch (Exception)
            {
                MessageBox.Show("The input is invalid");
                txtBoxFind.Clear();
            }
            Close();
        }

        /// <summary>
        /// this method returns the value in search find variable
        /// </summary>
        /// <returns></returns>
        public int getNum()
        {
            return searchFind;
        }

        #endregion Methods

    }
}