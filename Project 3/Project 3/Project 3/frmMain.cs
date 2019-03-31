using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmMain.cs
//	Description:       this is the class that holds the main window. 
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Friday, Mar 29 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project_3
{
   
    public partial class frmMain : Form
    {
        
        public string convertIntString;
        public int convertInt;
        public int convertBase;
        public int result;
        public string resultNumber;
        public int places;

        public object KeyCode { get; private set; }


        /// <summary>
        /// basic no arg constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            this.Text = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        }
        /// <summary>
        /// This method executes when the user clicks the about button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAboutbox about = new frmAboutbox();
            about.Show();
        }
        /// <summary>
        /// This method executes when the user clicks the to decimal button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toDecBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxBase.Text))
            {
                txtBoxDecimal.Text = "Invalid!";
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
        /// <summary>
        ///  This method executes when the user clicks the from decimal button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fromDecBtn_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(txtBoxDecimal.Text))
            {
                txtBoxBase.Text = "Invalid!";
            }
            else
            {
                try
                {

                    places = Convert.ToInt16(placesInResult.Value);

                    convertIntString = txtBoxDecimal.Text;
                    convertInt = int.Parse(convertIntString);
                    convertBase = Convert.ToInt16(baseCounter.Value);
                    resultNumber = BaseConverter.fromDecimal(convertInt, convertBase);

                    if (places > resultNumber.Count())
                    {
                        string temp = "";
                        for (int i = 0; i < (places - resultNumber.Count()); i++)
                        {
                            temp += "0";
                        }

                        resultNumber = temp + resultNumber;
                    }

                    if (resultNumber.Count() > places)
                    {
                        string temp = "";

                        for (int i = 0; i < places; i++)
                        {
                            temp += resultNumber[(resultNumber.Count() - 1) - i];
                        }
                        char[] charArray = temp.ToCharArray();
                        Array.Reverse(charArray);
                        resultNumber = new string(charArray);
                    }

                    txtBoxBase.Text = resultNumber;
                }
                catch (Exception) { }
            }
        }
        /// <summary>
        ///  This makes sure the user is typing the right key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        ///  This makes sure the user is typing the right key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void baseCounter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) &&
                 !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        ///  This makes sure the user is typing the right key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        ///  This makes sure the user is typing the right key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxBase_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }


        }
        /// <summary>
        ///  This method changes a label when the user changes the base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void baseCounter_ValueChanged(object sender, EventArgs e)
        {
            baseLabel1.Text = "Integer Value in Base: " + baseCounter.Value;
        }


    }
}