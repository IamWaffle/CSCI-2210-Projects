using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmMain.cs
//	Description:        this is where the main window of the program is held. It is programmed to control different aspects and can interact with the entire program.
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Friday, Mar 01 2019
//  Modified:          Monday, Mar 04 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project2
{
    public partial class frmMain : Form
    {
        private string names = "";
        private NameList nameList = new NameList();
        private NameList fileList;
        private Name tempName;
        private Name tempNameEdit = new Name();

        private bool edited = false;

        #region Constructors
        /// <summary>
        ///  Basic constructor that does not take any parameters
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// frmMain_Load - this method executes when the form is initially loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            dateTimeBar.Text = DateTime.Now.ToLongDateString();
            dateTimeBar.Text += " " + DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// dateTimer_Tick - this method executes each time the timer ticks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimer_Tick(object sender, EventArgs e)
        {
            dateTimeBar.Text = DateTime.Now.ToLongDateString();
            dateTimeBar.Text += " " + DateTime.Now.ToLongTimeString();
            numNames.Text = "Number of names in List: " + nameListBox.Items.Count.ToString();
        }

        /// <summary>
        /// aboutToolStripMenuItem_Click - this method executes when the user clicks the about button and it displays an about box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutbox about = new frmAboutbox();
            about.Show();
        }

        /// <summary>
        /// nameListBox_DrawItem - this method is used to change the color of the highlighted object to fit the theme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                    e.Font,
                    e.Bounds,
                    e.Index,
                    e.State ^ DrawItemState.Selected,
                    e.ForeColor,
                    Color.FromArgb(254, 95, 85));
            e.DrawBackground();
            e.Graphics.DrawString(nameListBox.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds,
                StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }


        /// <summary>
        /// clearToolStripMenuItem_Click - this methods runs if the user clicks the clear button and it clears the list and the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameList.clear();
            nameListBox.Items.Clear();

            fullNameLabel.Text = null;
            txtboxFirstName.Text = null;
            txtboxMiddleName.Text = null;
            txtboxLastName.Text = null;
            txtboxEnd.Text = null;
        }

        /// <summary>
        /// btnFNF_Click - this methods runs if the first name first button is clicked and organizes the list into the format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFNF_Click(object sender, EventArgs e)
        {
            List<String> tempSortedList = new List<String>();
            tempSortedList = nameList.SortFNF();
            nameListBox.Items.Clear();
            for (int i = 0; i < tempSortedList.Count; i++)
            {
                nameListBox.Items.Add(tempSortedList[i].ToString());
            }
        }

        /// <summary>
        /// btnLNF_Click - this methods runs if the last name first button is clicked and organizes the list into the format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLNF_Click(object sender, EventArgs e)
        {
            List<String> tempSortedList = new List<String>();
            tempSortedList = nameList.SortLNF();
            nameListBox.Items.Clear();
            for (int i = 0; i < tempSortedList.Count; i++)
            {
                nameListBox.Items.Add(tempSortedList[i].ToString());
            }
        }

        /// <summary>
        /// nameListBox_SelectedIndexChanged - this methods runs if the selected object in the list box changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxFirstName.Text = nameList.getName(nameListBox.SelectedItem.ToString()).firstName;
            txtboxMiddleName.Text = nameList.getName(nameListBox.SelectedItem.ToString()).middle;
            txtboxLastName.Text = nameList.getName(nameListBox.SelectedItem.ToString()).lastName;
            txtboxEnd.Text = nameList.getName(nameListBox.SelectedItem.ToString()).end;

            fullNameLabel.Text = nameList.getName(nameListBox.SelectedItem.ToString()).personNameFull;
        }

        /// <summary>
        /// addANameToolStripMenuItem_Click - this methods runs if the add a name button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addANameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
            String personName = add.name;

            if (string.IsNullOrWhiteSpace(personName))
            {
            }
            else
            {
                fileList = new NameList();
                tempName = new Name(personName);
                fileList.add(tempName);
                nameList += fileList;

                refresh();

                edited = true;
            }
        }

        /// <summary>
        /// openToolStripMenuItem1_Click - when the user clicks the open button it opens a file and populates the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
            nameList.clear();
            names = OpenFileHandler();
            fileList = new NameList(names);
            nameList += fileList;

            for (int i = 0; i < nameList.Count(); i++)
            {
                nameListBox.Items.Add(nameList.getName(i).firstNameFirst());
            }
        }

        /// <summary>
        /// saveToolStripMenuItem1_Click - when the user clicks the save button it saves a file using the handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileHandler();
        }

        /// <summary>
        /// exitToolStripMenuItem1_Click - when the user clicks the exit button it checks to see if the data has been changed then quits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (edited)
            {
                frmSave saveDialog = new frmSave();
                saveDialog.ShowDialog();
                if (saveDialog.save)
                {
                    saveFileHandler();
                    Close();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                
                tempNameEdit = new Name();
                
                String editNameString;
                txtboxFirstName.Text = null;
                txtboxMiddleName.Text = null;
                txtboxLastName.Text = null;
                txtboxEnd.Text = null;
                tempNameEdit.firstName = txtboxFirstName.Text;
                tempNameEdit.middle = txtboxMiddleName.Text;
                tempNameEdit.lastName = txtboxLastName.Text;
                tempNameEdit.end = txtboxEnd.Text;
                

                
                    editNameString = null;
                
               

                tempName = new Name(editNameString);
                if (nameList.Count() < 1)
                {
                    index = 0;
                }
                else
                {
                    index = nameList.getIndex(nameList.getName(nameListBox.SelectedItem.ToString()));
                }

                if (index == 0)
                {
                    nameList.remove(0);
                }
                else if (index == nameList.Count() - 1)
                {
                    nameList.remove(nameList.Count() - 1);
                }

                if (string.IsNullOrWhiteSpace(tempName.personNameFull))
                {
                    nameList.remove(nameList.getName(nameListBox.SelectedItem.ToString()).firstNameFirst());

                    nameListBox.Items.Clear();

                    refresh();

                    fullNameLabel.Text = tempName.personNameFull;
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong. The textboxes are probably null.");
            }
        }


        /// <summary>
        /// btnSave_Click - this methods run if the save button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tempNameEdit = new Name();
                int index;
                String editNameString;
                tempNameEdit.firstName = txtboxFirstName.Text;
                tempNameEdit.middle = txtboxMiddleName.Text;
                tempNameEdit.lastName = txtboxLastName.Text;
                tempNameEdit.end = txtboxEnd.Text;

                if (tempNameEdit.firstName == null &&
                    tempNameEdit.middle == null &&
                    tempNameEdit.lastName == null && tempNameEdit.end == null)
                {
                    editNameString = null;
                }
                else
                {
                    editNameString = tempNameEdit.firstName + " " + tempNameEdit.middle + " " +
                                        tempNameEdit.lastName +
                                        " " + tempNameEdit.end;
                }

                tempName = new Name(editNameString);
                

                if (nameList.Count() < 1)
                {
                    index = 0;
                }
                else
                {
                    index = nameList.getIndex(nameList.getName(nameListBox.SelectedItem.ToString()));
                }

                if (index == 0)
                {
                    nameList.remove(0);
                }
                else if (index == nameList.Count() - 1)
                {
                    nameList.remove(nameList.Count() - 1);
                }

                if (string.IsNullOrWhiteSpace(tempName.personNameFull))
                {
                    nameList.remove(nameList.getName(nameListBox.SelectedItem.ToString()).firstNameFirst());

                    nameListBox.Items.Clear();

                    refresh();

                    fullNameLabel.Text = tempName.personNameFull;
                }
                else
                {
                    nameList.remove(nameList.getName(nameListBox.SelectedItem.ToString()).firstNameFirst());

                    nameListBox.Items.Clear();

                    refresh();

                    nameList.insert(tempName, index);

                    refresh();

                    fullNameLabel.Text = tempName.personNameFull;
                }
                edited = true;
            }
            catch (Exception NullReferenceException)
            {
                Console.WriteLine("Something went wrong.. Is the list empty?");
            }
        }

        /// <summary>
        /// refresh - refreshes the listbox
        /// </summary>

        private void refresh()
        {
            nameListBox.Items.Clear();

            for (int i = 0; i < nameList.Count(); i++)
            {
                nameListBox.Items.Add(nameList.getName(i).firstNameFirst());
            }
        }

        /// <summary>
        /// removeANameToolStripMenuItem_Click - this methods runs if the remove a name button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeANameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string lol = "fsdfsdf";

            frmRemove rmvDialog = new frmRemove(lol);

            rmvDialog.ShowDialog();
        }


        #endregion Methods

        #region FileHandlers

        /// <summary>
        /// File handler - Opens and reads a file.
        /// </summary>
        /// <param></param>
        /// <returns name="names"> returns the contents of the file</returns>
        private static string OpenFileHandler()
        {
            StreamReader rdr = null;

            string names = "";
            OpenFileDialog OpenDlg = new OpenFileDialog();
            OpenDlg.Filter = "text files|*.txt;*.text";
            OpenDlg.InitialDirectory = Application.StartupPath;
            OpenDlg.Title = "Select a text file to insert into the list";
            if (DialogResult.Cancel != OpenDlg.ShowDialog())
            {
                try
                {
                    rdr = new StreamReader(OpenDlg.FileName);

                    while (!rdr.EndOfStream)
                    {
                        names += rdr.ReadLine();
                    }
                }
                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }

                string fileName = OpenDlg.FileName;
            }

            return names;
        }

        /// <summary>
        /// saveFileHandler - this method uses the save file dialog to save a file then saves it in a format to be read by the program.
        /// </summary>

        public void saveFileHandler()
        {
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.InitialDirectory = Application.StartupPath;
            dlg.Title = "Save this name list";
            dlg.Filter = "text files|*.txt|all files|*.*";

            if (dlg.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write));

                for (int i = 0; i < nameList.Count(); i++)
                {
                    writer.WriteLine(nameList.getName(i) + "#");
                }
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        #endregion FileHandlers

        #region KeyPress
        private void txtboxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtboxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtboxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtboxEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        #endregion KeyPress


    }
}