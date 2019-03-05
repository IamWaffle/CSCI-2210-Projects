using System;
using System.Windows.Forms;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmAdd.cs
//	Description:
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Friday, Mar 01 2019
//  Modified:          Monday, Mar 04 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project2
{
    public partial class frmAdd : Form
    {
        private Name addName = new Name();
        public string name
        {
            get
            {
                return addName.personNameFull;
            }
        }

        /// <summary>
        /// frmAdd - basic no arg constructor.
        /// </summary>
        public frmAdd()
        {
            InitializeComponent();
        }



        /// <summary>
        /// btnAdd_Click - this methods runs if the user clicks the add button and it takes the text from the boxes and puts it into a variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addName.firstName = txtboxFirstName.Text;
            addName.middle = txtboxMiddleName.Text;
            addName.lastName = txtboxLastName.Text;
            addName.end = txtboxEnd.Text;

            addName.personNameFull = addName.firstName + " " + addName.middle + " " +
                                     addName.lastName +
                                     " " + addName.end;

            this.Close();
        }

    }
}