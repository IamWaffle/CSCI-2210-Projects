using System;
using System.Windows.Forms;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmCreate.cs
//	Description:       This is the window to specify the arity and create a new tree
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Wednesday Apr 17, 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project_5_BTree
{
    public partial class frmCreate : Form
    {
        private int nodeSize { get; set; }

        #region Constructor

        /// <summary>
        /// basic no arg constructor
        /// </summary>
        public frmCreate()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// this method returns the node size value
        /// </summary>
        /// <returns>node size</returns>
        public int getNodeSize()
        {
            return nodeSize;
        }

        /// <summary>
        /// this method executes when the user clicks the ok button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            string str = txtBoxSize.Text;

            try
            {
                nodeSize = int.Parse(str);
            }
            catch (Exception)
            {
                MessageBox.Show("The input is invalid, default set to 3");
                txtBoxSize.Clear();
            }

            if (nodeSize >= 3 && nodeSize <= 25)
            {
            }
            else
            {
                nodeSize = 3;
                MessageBox.Show("The input is invalid, default set to 3");
            }

            Close();
        }

        /// <summary>
        /// txtboxSize_KeyPress - this method checks to see if the user is typing the right key
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

        #endregion Methods
    }
}