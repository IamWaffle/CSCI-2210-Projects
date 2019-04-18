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
                        int i = 0;
                        int x = 0;

                        Console.WriteLine("What is the arity of the tree to be created?:\n");
                        int.TryParse(Console.ReadLine(), out nodeSize);
                        if (nodeSize == 0)
                        {
                            nodeSize = 3;
                        }
                        if (nodeSize < 3 || nodeSize > 25)
                        {
                            nodeSize = 3;
                            Console.WriteLine("Invalid input. Setting the node size to 3.");
                        }

                        tree = new BTree(nodeSize);

                        bool loop = true;

                        while (loop == true)
                        {
                            if (i >= numNodes)
                            {
                                Console.WriteLine("The tree has been created. " + i + " values were added in " + x + " loops.");
                                Tools.PressAnyKey();
                                loop = false; ;
                            }
                            Random rand = new Random();
                            if (tree.addValue(rand.Next(10000)))
                            {
                                i++;
                            }
                            x++;
                        }

                        break;

                    case Choices.DISPLAY:
                        tree.Display();
                        Tools.PressAnyKey();
                        break;

                    case Choices.ADD:
                        int inNum = 0;
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