///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Exercise1Driver.cs
//	Description:       The driver class is where the main method is stored.
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Feb 19 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;

namespace Project1
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
            Console.Title = "Project 1";

            string sentence = "";

            Menu menu = new Menu("Project 1");
            menu = menu + "Option 1" + "Option 2" + "Quit";

            Choices choice = (Choices)menu.GetChoice();
            while (choice != Choices.QUIT)
            {
                switch (choice)
                {
                    case Choices.OPEN:

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
    }
}