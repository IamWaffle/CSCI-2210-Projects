using System;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmAdd : Form
    {
        private Name addName = new Name();

        public frmAdd()
        {
            InitializeComponent();
        }

        public string name
        {
            get
            {
                return addName.personNameFull;
            }
        }


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