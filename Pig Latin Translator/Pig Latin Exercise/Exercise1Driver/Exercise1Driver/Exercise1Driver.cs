///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  PigLatin_Exercise/PigLatin_Exercise
//	File Name:         Exercise1Driver.cs
//	Description:       The driver class is where the main method is stored. It interacts with the Pig Latin
//                     class and user input to display a translated word or sentence.
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Windows.Forms;

namespace Exercise1Driver
{
    /// <summary>  
    ///  This class is the main part of the program. It interacts with the Pig Latin
    //   class and user input to display a translated word or sentence.
    //
    /// </summary>
    class Program
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
            Console.Title = "Pig Latin Translator";

            string sentence = "";
            PigLatin translator;

            Menu menu = new Menu("Pig Latin Translator");
            menu = menu + "Open a text file" + "Type a sentence" + "Quit";

            Choices choice = (Choices)menu.GetChoice();
            while (choice != Choices.QUIT)
            {
                switch (choice)
                {
                    case Choices.OPEN:
                        sentence = FileHandler();
                        translator = new PigLatin(sentence);
                        Console.WriteLine("The files contents: \n\n" + sentence + "\n\ntranslates into: \n\n" + translator.ToString() + "\n\n");
                        Console.WriteLine("Press any key to go back to the menu...");
                        Console.ReadKey();
                        break;

                    case Choices.EDIT:
                        Console.WriteLine("Please type the sentence/word you would like to translate:");
                        sentence = Console.ReadLine() + " ";
                        Console.Clear();
                        translator = new PigLatin(sentence);
                        Console.WriteLine("The sentence/word: \n\n" + sentence + "\n\ntranslates into: \n\n" + translator.ToString() + "\n\n");
                        Console.WriteLine("Press any key to go back to the menu...");
                        Console.ReadKey();
                        break;

                    case Choices.CLOSE:
                        System.Environment.Exit(1);
                        break;
                }  // end of switch
                choice = (Choices)menu.GetChoice();
            }  // end of while
        }
        #endregion
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
        #endregion
    }
}