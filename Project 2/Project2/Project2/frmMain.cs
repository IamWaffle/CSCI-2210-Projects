using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmMain : Form
    {
        private string names = "";
        private NameList nameList = new NameList();
        private NameList fileList;
        private Name tempName;
        private bool edited = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dateTimeBar.Text = DateTime.Now.ToLongDateString();
            dateTimeBar.Text += " " + DateTime.Now.ToLongTimeString();
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            dateTimeBar.Text = DateTime.Now.ToLongDateString();
            dateTimeBar.Text += " " + DateTime.Now.ToLongTimeString();
            numNames.Text = "Number of names in List: " + nameListBox.Items.Count.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutbox about = new frmAboutbox();
            about.Show();
        }

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

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameList.clear();
            nameListBox.Items.Clear();

            fullNameLabel.Text = null;
        }

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


        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtboxFirstName.Text = nameList.getName(nameListBox.SelectedItem.ToString()).firstName;
            txtboxMiddleName.Text = nameList.getName(nameListBox.SelectedItem.ToString()).middle;
            txtboxLastName.Text = nameList.getName(nameListBox.SelectedItem.ToString()).lastName;
            txtboxEnd.Text = nameList.getName(nameListBox.SelectedItem.ToString()).end;

            fullNameLabel.Text = nameList.getName(nameListBox.SelectedItem.ToString()).personNameFull;
        }

        private void addANameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
            tempName = new Name(add.name);
            if (string.IsNullOrWhiteSpace(tempName.personNameFull))
            {
            }
            else
            {
                nameList.add(tempName);
                nameListBox.Items.Add(tempName.personNameFull);

                nameListBox.Items.Clear();

                for (int i = 0; i < nameList.Count(); i++)
                {
                    nameListBox.Items.Add(nameList.getName(i).firstNameFirst());
                }
            }
        }

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

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileHandler();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tempName = new Name();
                if (string.IsNullOrWhiteSpace(txtboxFirstName.Text))
                {
                    tempName.firstName = null;
                    tempName.middle = txtboxMiddleName.Text;
                    tempName.lastName = txtboxLastName.Text;
                    tempName.end = txtboxEnd.Text;
                }
                else if (string.IsNullOrWhiteSpace(txtboxMiddleName.Text))
                {
                    tempName.firstName = txtboxFirstName.Text;
                    tempName.middle = null;
                    tempName.lastName = txtboxLastName.Text;
                    tempName.end = txtboxEnd.Text;
                }
                else if (string.IsNullOrWhiteSpace(txtboxLastName.Text))
                {
                    tempName.firstName = txtboxFirstName.Text;
                    tempName.middle = txtboxMiddleName.Text;
                    tempName.lastName = null;
                    tempName.end = txtboxEnd.Text;
                }
                else if (string.IsNullOrWhiteSpace(txtboxEnd.Text))
                {
                    tempName.firstName = txtboxFirstName.Text;
                    tempName.middle = txtboxMiddleName.Text;
                    tempName.lastName = txtboxLastName.Text;
                    tempName.end = null;
                }
                else
                {
                    tempName.firstName = txtboxFirstName.Text;
                    tempName.middle = txtboxMiddleName.Text;
                    tempName.lastName = txtboxLastName.Text;
                    tempName.end = txtboxEnd.Text;

                }

                tempName.personNameFull =
                    txtboxFirstName.Text + " " + txtboxMiddleName.Text + " " + txtboxLastName.Text + " " +
                    txtboxEnd.Text;

                nameList.replace(nameList.getName(nameListBox.SelectedItem.ToString()), tempName);
                nameList.remove(nameList.getName(nameListBox.SelectedItem.ToString()).personNameFull);

                nameListBox.Items.Clear();

                for (int i = 0; i < nameList.Count(); i++)
                {
                    nameListBox.Items.Add(nameList.getName(i).firstNameFirst());
                }

            }
            catch (Exception NullReferenceException)
            {
                Console.WriteLine("Something went wrong.. Is the list empty?");
            }

        }
    }
}

