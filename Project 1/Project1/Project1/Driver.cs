﻿///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Driver.cs
//	Description:       The driver class is where the main method is stored.
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Feb 19 2019
//  Modified:          Monday, Feb 25 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Project1
{
    /// <summary>
    ///  This class is the main part of the program. It interacts with multiple classes to make an editable list of names
    /// </summary>
    internal class Program
    {
        #region Main

        /// <summary>
        /// Main - The method that drives the program.
        /// </summary>
        /// <param name="string[] args"></param>
        [STAThread]
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Project 1: NameList";

            string names = "";
            NameList nameList = new NameList();
            NameList fileList;
            Name temp;
            char save;

            Menu menu = new Menu("Project 1: NameList");
            menu = menu + "Open a file." + "Add a Name" + "Remove a Name" + "Clear the list" + "View the list" + "Quit";

            Tools.displayWelcome(out string name, out string phone, out string email);
            nameList.setOwnerEmail(email);
            nameList.setOwnerPhone(phone);
            nameList.setOwnerName(name);

            Choices choice = (Choices)menu.GetChoice();
            while (choice != Choices.END)
            {
                switch (choice)
                {
                    case Choices.OPEN:
                        names = OpenFileHandler();
                        fileList = new NameList(names);
                        nameList += fileList;
                        Console.WriteLine("Names added to the list!");
                        Tools.PressAnyKey();
                        Tools.Skip();
                        break;

                    case Choices.ADD:
                        Console.WriteLine("What is the name you would like to add?:");
                        nameList += (temp = new Name(Console.ReadLine()));
                        Console.WriteLine("Name added!");
                        Tools.PressAnyKey();
                        Tools.Skip();
                        break;

                    case Choices.REMOVE:
                        nameList.removeName();
                        Tools.PressAnyKey();
                        Tools.Skip();
                        break;

                    case Choices.CLEAR:
                        nameList.clear();
                        Console.WriteLine("List Cleared!");
                        Tools.PressAnyKey();
                        Tools.Skip();
                        break;

                    case Choices.VIEW:
                        bool bchoice = true;
                        while (bchoice == true)
                        {
                            int vchoice;
                            Console.WriteLine(
                                "How would you like to view the list?\n1. First Name First\n2. Last Name First\n3. Order added\n\n\n4. Go Back");
                            int.TryParse(Console.ReadLine(), out vchoice);
                            if (vchoice == 1)
                            {
                                Tools.Skip();
                                List<String> tempSortedList = new List<String>();
                                tempSortedList = nameList.SortFNF();
                                for (int i = 0; i < tempSortedList.Count; i++)
                                {
                                    Console.WriteLine(tempSortedList[i].ToString());
                                }
                                Tools.PressAnyKey();
                                bchoice = false;
                                Tools.Skip();
                            }
                            else if (vchoice == 2)
                            {
                                Tools.Skip();
                                List<String> tempSortedList = new List<String>();
                                tempSortedList = nameList.SortLNF();
                                for (int i = 0; i < tempSortedList.Count; i++)
                                {
                                    Console.WriteLine(tempSortedList[i].ToString());
                                }
                                Tools.PressAnyKey();
                                bchoice = false;
                                Tools.Skip();
                            }
                            else if (vchoice == 3)
                            {
                                Tools.Skip();
                                Tools.Skip();
                                Console.WriteLine(nameList.ToString());
                                Tools.PressAnyKey();
                                bchoice = false;
                                Tools.Skip();
                            }
                            else if (vchoice == 4)
                            {
                                bchoice = false;
                                Tools.Skip();
                            }
                            else
                            {
                                Console.WriteLine("An error happened, please try again..");
                                Tools.PressAnyKey();
                                bchoice = true;
                                Tools.Skip();
                            }
                        }
                        break;

                    case Choices.QUIT:
                        Console.WriteLine("Would you like to save the name list? Y/N");
                        save = Char.Parse(Console.ReadLine().ToLower());

                        if (save == 'y')
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

                            Tools.displayExit(nameList.getOwnerName(), nameList.getOwnerPhone(), nameList.getOwnerEmail());
                            Tools.PressAnyKey();
                            System.Environment.Exit(1);
                        }
                        else
                        {
                            Tools.displayExit(nameList.getOwnerName(), nameList.getOwnerPhone(), nameList.getOwnerEmail());
                            Tools.PressAnyKey();
                            System.Environment.Exit(1);
                        }
                        break;
                }  // end of switch
                choice = (Choices)menu.GetChoice();
            }  // end of while
        }

        #endregion Main

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

        #endregion FileHandlers
    }
}