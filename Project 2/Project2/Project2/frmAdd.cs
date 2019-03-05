using System;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmAdd : Form
    {
        private String nameFull = "";

        public frmAdd()
        {
            InitializeComponent();
        }

        public string name
        {
            get
            {
                return nameFull;
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {

                nameFull = txtBoxAdd.Text;
                this.Close();
        }

        private void txtBoxAdd_TextChanged(object sender, EventArgs e)
        {
        }
    }
}