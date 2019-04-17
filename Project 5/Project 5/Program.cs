using System;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Driver.cs
//	Description:       The driver class is where the main method is stored. It is 
//                     where the entire program is ran from
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Apr 09 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project_5
{
    /// <summary>
    /// This is where the entire program is executed from.  
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
            Console.Title = "Project 5: B-Tree";

            Menu menu = new Menu("B-Tree Menu");
            menu = menu + "Set Size of Node and Create a new B-Tree" +
                "Display the B-Tree" +
                "Add a value in the B-Tree" +
                "Find a value in the B-Tree" + "End the program";

            Choices choice = (Choices)menu.GetChoice();
            while (choice != Choices.END)
            {
                switch (choice)
                {
                    case Choices.CREATE:

                      
                        break;

                    case Choices.DISPLAY:
                       
                        break;

                    case Choices.ADD:
                     
                        break;

                    case Choices.FIND:
                       
                        break;

                    case Choices.END:
                        System.Environment.Exit(1);
                        break;
                }  // end of switch
                choice = (Choices)menu.GetChoice();
            }  // end of while
        }

        #endregion main
    }
}