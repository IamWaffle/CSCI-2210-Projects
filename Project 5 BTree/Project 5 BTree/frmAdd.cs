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

    public partial class frmAdd : Form
    {
        int addNum { get; set; }
        public frmAdd()
        {
            InitializeComponent();
        }

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
    }
}
