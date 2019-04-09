///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Driver.cs
//	Description:       The driver class is where the main method is stored.
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Apr 09 2019
//  
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;


namespace Project4
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
            Console.Title = "Project 4: Supermarket Simulation";


            Menu menu = new Menu("Simulation Menu");
            menu = menu + "Set the number of customers" +
                "Set the number of hours of operation" + 
                "Set the number of registers" +
                "Set the expected checkout duration" +
                "Run the simulation" + "End the program";

            

            Choices choice = (Choices)menu.GetChoice();
            while (choice != Choices.END)
            {
                switch (choice)
                {
                    case Choices.OPEN:
                        
                        break;

                    case Choices.ADD:
                       
                        break;

                    case Choices.REMOVE:
                        
                        break;

                    case Choices.CLEAR:
                        
                        break;

                    case Choices.VIEW:
                       
                        break;

                    case Choices.QUIT:
                       
                        break;
                }  // end of switch
                choice = (Choices)menu.GetChoice();
            }  // end of while
        }

        #endregion Main

    }
}