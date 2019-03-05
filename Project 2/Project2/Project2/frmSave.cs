using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmSave : Form
    {

        public frmSave()
        {
            InitializeComponent();
        }

        public bool save = false;

        private void btnYes_Click(object sender, EventArgs e)
        {
            save = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
