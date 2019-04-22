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
    public partial class frmFind : Form
    {
        int searchFind { get; set; }
        public frmFind()
        {
            InitializeComponent();
        }

        private void txtBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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
            this.Close();
        }
        public int getNum()
        {
            return searchFind;
        }
    }
}
