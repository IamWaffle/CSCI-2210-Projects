///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         frmMain.cs
//	Description:       The main form where the program an ran and managed from.
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Wednesday Apr 17, 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;


namespace Project_5_BTree
{
    /// <summary>
    /// This is the main window form.
    /// </summary>
    public partial class frmMain : Form
    {
        private BTree tree = new BTree(3);
        private int numNodes = 500;
        private int nodeSize = 0;

        #region Constructor

        /// <summary>
        /// Basic no arg constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// this method executes when the user presses the create button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            frmCreate create = new frmCreate();

            create.ShowDialog();

            nodeSize = create.getNodeSize();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                tree = new BTree(nodeSize);

                txtboxTree.Text = "Tree is building. Please Wait...";
                txtBoxInfo.Text = "";
                int values = 0;
                int loops = 0;

                while (values < numNodes)
                {
                    try
                    {
                        tree.AddValue(rand.Next(9999));

                        values++;
                    }
                    catch (Exception)
                    {
                    }

                    loops++;
                }

                
                txtboxTree.Text = tree.Display();
                txtBoxInfo.Text = tree.Stats();
                txtBoxInfo.Text += ("\n\nThe tree has been created.  " + values
                    + " values were added in " + loops + " loops.");
                Cursor.Current = Cursors.Default;
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// this method executes wehn the user clicks the add number button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int addNum;
            frmAdd add = new frmAdd();
            add.ShowDialog();
            try
            {
                addNum = add.getNum();

                if (addNum > 0 && addNum < 9999)
                {
                    try
                    {
                        tree.AddValue(addNum);
                        MessageBox.Show(addNum + " was added to the tree.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("The tree already contains the value " + addNum);
                    }

                   
                    txtboxTree.Text = tree.Display();
                    txtBoxInfo.Text = tree.Stats();
                }
                else
                {
                    throw new Exception("Invalid Input");
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// this method executes when the user clicks the find value button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFind find = new frmFind();
            find.ShowDialog();

            try
            {
                int findNum = find.getNum();

                if (findNum >= 0 && findNum <= 9999)
                {
                    txtBoxInfo.Text = ("Starting from the root, the nodes visited are: \n");

                    if (tree.findValue(findNum))
                    {
                        txtBoxInfo.Text += (findNum + " was found in the tree.");
                    }
                    else
                    {
                        txtBoxInfo.Text += (findNum + " was not found.");
                    }
                }
                else
                {
                    throw new Exception("Invalid Input");
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// this method executes when the user clicks the about button, brings up the about box form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutbox about = new frmAboutbox();
            about.ShowDialog();
        }

        #endregion Methods
    }
}