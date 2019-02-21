///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Exercise1Driver.cs
//	Description:       The driver class is where the main method is stored.
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Feb 19 2019
//  Modified:          Thursday, Feb 21 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Windows.Forms;

namespace Project1
{
    /// <summary>
    ///  This class is the main part of the program. It interacts with the Pig Latin
    //   class and user input to display a translated word or sentence.
    //
    /// </summary>
    internal class Program
    {
        #region Main

        /// <summary>
        /// Main - The method that drives the program.
        /// </summary>
        /// <param name="string[] args"></param>
        [STAThread]
        private static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Project 1: NameList";

            string names = "";
            NameList nameList;
            char save;

            Menu menu = new Menu("Project 1: NameList");
            menu = menu + "Open a file." + "Add a Name" + "Remove a Name" + "View the list" + "Quit";

            Choices choice = (Choices)menu.GetChoice();
            while (choice != Choices.END)
            {
                switch (choice)
                {
                    case Choices.OPEN:
                        names = OpenFileHandler();
                        nameList = new NameList(names);
                        Tools.PressAnyKey();
                        Tools.Skip();
                        break;

                    case Choices.ADD:

                        break;

                    case Choices.REMOVE:

                        break;

                    case Choices.VIEW:
                        break;

                    case Choices.QUIT:
                        Console.WriteLine("Would you like to save the name list? Y/N");
                        save = Char.Parse(Console.ReadLine().ToLower());

                            if (save == 'y')
                            {
                                SaveFileHandler();
                                Tools.PressAnyKey();
                                System.Environment.Exit(1);
                        }
                        
                        else
                        {
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
            else
            {
            }

            return names;
        }

        private static void SaveFileHandler()
        {

        }


        #endregion FileHandlers
    }
}