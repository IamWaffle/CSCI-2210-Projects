///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmAdd.cs
//	Description:       This is the window that adds a value to the tree
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Wednesday Apr 17, 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5_BTree
{
    /// <summary>
    /// This is the window that shows up when the user is trying to add a value to the tree.
    /// </summary>
    public partial class frmAdd : Form
    {
        int addNum { get; set; }

        #region Constructor
        /// <summary>
        /// basic no arg constructor
        /// </summary>
        public frmAdd()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Methods
        /// <summary>
        /// this method executes when the user clicks the ok button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            string str = txtBoxAdd.Text;
           

            try
            {
                addNum = int.Parse(str);
            }
            catch (Exception)
            {
                MessageBox.Show("The input is invalid");
                txtBoxAdd.Clear();
            }
            this.Close();
        }
        /// <summary>
        /// this method returns the value in addnum
        /// </summary>
        /// <returns>add num</returns>
        public int getNum()
        {
            return addNum;
        }

        /// <summary>
        /// txtboxAdd_KeyPress - this method checks to see if the user is typing the right key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
