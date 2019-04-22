using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
namespace Project_5_BTree
{
    public partial class frmMain : Form
    {
        BTree tree = new BTree(3);
        int numNodes = 500;
        int nodeSize = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            frmCreate create = new frmCreate();
            
            create.ShowDialog();
            

            nodeSize = create.getNodeSize();
            try
            {
                

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

            }
            catch (Exception)
            {

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int addNum;
            frmAdd add = new frmAdd();
            add.ShowDialog();

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

        private void btnFind_Click(object sender, EventArgs e)
        {

            frmFind find = new frmFind();
            find.ShowDialog();
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
    }
}
