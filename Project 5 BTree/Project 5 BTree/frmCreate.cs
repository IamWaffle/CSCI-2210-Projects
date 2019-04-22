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
    public partial class frmCreate : Form
    {
        int nodeSize { get; set; }
        public frmCreate()
        {
            InitializeComponent();
        }

        public int getNodeSize()
        {
            return nodeSize;
        }

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

            this.Close();
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

    }
}
