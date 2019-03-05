using System;
using System.Windows.Forms;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmRemove.cs
//	Description:       form that removes a name from the name list if it is found
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

        public frmRemove(string lol)
        {
            if (nameListBox2 == null)
            {
                nameListBox2.Items.Add(lol);
            }
            


        }

    }
}