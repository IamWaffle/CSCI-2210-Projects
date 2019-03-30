using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class frmMain : Form
    {

        public string convertIntString;
        public int convertInt;
        public int convertBase;
        public int result;
        public string resultNumber;
        public string places;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAboutbox about = new frmAboutbox();
            about.Show();
        }



        private void toDecBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxBase.Text))
            {

            }
            else
            {
                try
                {
                    
                    convertIntString = txtBoxBase.Text;
                    convertBase = Convert.ToInt16(baseCounter.Value);
                    result = BaseConverter.toDecimal(convertIntString, convertBase);

                    txtBoxDecimal.Text = result.ToString();
                }
                catch (Exception)
                {

                }
            }
            
            
        }

        private void fromDecBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxDecimal.Text))
            {

            }
            else
            {
                try
                {
                    places = "";
                    for (int i = 0; i < placesInResult.Value; i++)
                    {
                        places += 0;
                    }
                    txtBoxBase.Mask = places;

                    convertIntString = txtBoxDecimal.Text;
                    convertInt = int.Parse(convertIntString);
                    convertBase = Convert.ToInt16(baseCounter.Value);
                    resultNumber = BaseConverter.fromDecimal(convertInt, convertBase);

                    txtBoxBase.Text = resultNumber;
                }
                catch (Exception) { }
            }
            


        }

        private void txtBoxDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void baseCounter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) &&
                 !char.IsSymbol(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void txtBoxBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
