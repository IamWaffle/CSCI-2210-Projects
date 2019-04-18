using System;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Driver.cs
//	Description:       The driver class is where the main method is stored. It is
//                     where the entire program is ran from
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Wednesday Apr 17, 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project_5
{
    /// <summary>
    /// This is where the entire program is executed from.
    /// </summary>
    internal class Driver
    {
        #region Main

        /// <summary>
        /// Main - The method that drives the program.
        /// </summary>
        /// <param name="string[] args"></param>
        [STAThread]
        public static void Main(string[] args)
        {
            BTree tree = new BTree(3);
            int numNodes = 0;
            int nodeSize = 0;

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

                            Console.WriteLine("What is the arity of the tree to be created?\n");
                            if (!int.TryParse(Console.ReadLine(), out nodeSize))
                            {
                                nodeSize = 3;
                            }
                            if ((nodeSize < 3) || (nodeSize > 0x19))
                            {
                                nodeSize = 3;
                                Console.WriteLine("The arity you gave is invalid - it has been reset to 3");
                            }
                            tree = new BTree(nodeSize);
                            int num2 = 0;
                            int num = 0;
                        Random rand = new Random();
                            while (true)
                            {
                                if (num >= numNodes)
                                {
                                    Console.WriteLine("\nThe tree has been built; {0} values were added in {1} loops.", num, num2);
                                    Tools.PressAnyKey();
                                    return;
                                }
                                if (tree.AddValue(rand.Next(0x2710)))
                                {
                                    num++;
                                }
                                num2++;
                            }

                        break;

                    case Choices.DISPLAY:
                        tree.Display();
                        Tools.PressAnyKey();
                        break;

                    case Choices.ADD:
                        int inNum;
                        Console.WriteLine("Type a value you would like to add to the tree: ");
                        int.TryParse(Console.ReadLine(), out inNum);

                        if (inNum <= 0 && inNum >= 9999)
                        {
                            Console.WriteLine("Invalid input. Must be between 0 and 9999...");
                        }
                        else
                        {
                            if (tree.addValue(inNum))
                            {
                                Console.WriteLine(inNum + " was added to the tree.");
                            }
                            else
                            {
                                Console.WriteLine("The tree already contains the value " + inNum);
                            }
                        }

                        Tools.PressAnyKey();
                        break;

                    case Choices.FIND:
                        int found = 0;
                        Console.WriteLine("Enter a value you want to search for: ");
                        int.TryParse(Console.ReadLine(), out found);

                        if (found >= 0 && found <= 9999)
                        {
                            Console.WriteLine("Starting from the root, the nodes visited are: ");

                            if (tree.findValue(found))
                            {
                                Console.WriteLine(found + " was found in the tree.");
                            }
                            else
                            {
                                Console.WriteLine(found + "was not found.");
                            }
                        }

                        Tools.PressAnyKey();
                        break;

                    case Choices.END:
                        System.Environment.Exit(1);
                        break;
                }  // end of switch
                choice = (Choices)menu.GetChoice();
            }  // end of while
        }

        #endregion Main
    }
}