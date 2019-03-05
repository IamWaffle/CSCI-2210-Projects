using System;
using System.Windows.Forms;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmRemove.cs
//	Description:
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Friday, Mar 01 2019
//  Modified:          Monday, Mar 04 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project2
{
    public partial class frmRemove : Form
    {
        private NameList nameList;
        private NameList tempList;

        public frmRemove()
        {
            InitializeComponent();
        }

        private void nameListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}