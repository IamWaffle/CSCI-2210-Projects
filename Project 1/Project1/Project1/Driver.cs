///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Exercise1Driver.cs
//	Description:       The driver class is where the main method is stored.
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Feb 19 2019
//  Modified:          Tuesday, Feb 19 2019
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
            Console.Title = "Project 1";

            string names = "";

            Menu menu = new Menu("Project 1");
            menu = menu + "Open a file." + "Option 2" + "Quit";

            Choices choice = (Choices)menu.GetChoice();
            while (choice != Choices.QUIT)
            {
                switch (choice)
                {
                    case Choices.OPEN:
                        names = FileHandler();
                        break;

                    case Choices.EDIT:

                        break;

                    case Choices.CLOSE:
                        System.Environment.Exit(1);
                        break;
                }  // end of switch
                choice = (Choices)menu.GetChoice();
            }  // end of while
        }

        #endregion Main

        #region FileHandler

        /// <summary>
        /// File handler - Opens and reads a file.
        /// </summary>
        /// <param></param>
        /// <returns name="sentence"> returns the contents of the file</returns>
        private static string FileHandler()
        {
            StreamReader rdr = null;

            string sentence = "";
            OpenFileDialog OpenDlg = new OpenFileDialog();
            OpenDlg.Filter = "text files|*.txt;*.text";
            OpenDlg.InitialDirectory = Application.StartupPath;
            OpenDlg.Title = "Select a text file to translate the contents.";
            if (DialogResult.Cancel != OpenDlg.ShowDialog())
            {
                try
                {
                    rdr = new StreamReader(OpenDlg.FileName);

                    while (!rdr.EndOfStream)
                    {
                        sentence += rdr.ReadLine();
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

            return sentence;
        }

        #endregion FileHandler
    }
}