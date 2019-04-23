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
            int numNodes = 500;
            int nodeSize = 0;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Project 5: B-Tree";

            Menu menu = new Menu("B-Tree Menu");
            menu = menu + "Create a new B-Tree" +
                "Display the B-Tree" +
                "Add a value in the B-Tree" +
                "Find a value in the B-Tree" + "End the program";

            Choices choice = (Choices)menu.GetChoice();
            while (choice != Choices.END)
            {
                switch (choice)
                {
                    case Choices.CREATE:
                        Random rand = new Random();
                        try
                        {
                            Console.WriteLine("What is the arity of the tree to be created? (3 - 25): ");
                            string str = Console.ReadLine();

                            int.TryParse(str, out nodeSize);

                            if (nodeSize >= 3 && nodeSize <= 25)
                            {
                                nodeSize = 3;
                            }
                            else
                            {
                                throw new Exception("Not valid");
                            }
                        }
                        catch
                        {
                            nodeSize = 3;
                            Console.WriteLine("The input is invalid, default set to 3");
                        }

                        tree = new BTree(nodeSize);
                        Console.WriteLine("Building tree. Please wait...");

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

                        Console.WriteLine("The tree has been created.  " + values
                            + " values were added in " + loops + " loops.");
                        Tools.PressAnyKey();

                        break;

                    case Choices.DISPLAY:
                        tree.Display();
                        Tools.PressAnyKey();
                        break;

                    case Choices.ADD:
                        int inNum;
                        Console.WriteLine("Type a value you would like to add to the tree: ");
                        int.TryParse(Console.ReadLine(), out inNum);

                        try
                        {
                            if (inNum > 0 && inNum < 9999)
                            {
                                try
                                {
                                    tree.AddValue(inNum);
                                    Console.WriteLine(inNum + " was added to the tree.");
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("The tree already contains the value " + inNum);
                                }
                            }
                            else
                            {
                                throw new Exception("Invalid Input");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input. Must be between 0 and 9999...");
                        }

                        Tools.PressAnyKey();
                        break;

                    case Choices.FIND:
                        int searchInt = 0;
                        Console.WriteLine("Enter a value you want to search for: ");
                        int.TryParse(Console.ReadLine(), out searchInt);

                        try
                        {
                            if (searchInt >= 0 && searchInt <= 9999)
                            {
                                Console.WriteLine("Starting from the root, the nodes visited are: ");

                                if (tree.FindValue(searchInt))
                                {
                                    Console.WriteLine(searchInt + " was found in the tree.");
                                }
                                else
                                {
                                    Console.WriteLine(searchInt + " was not found.");
                                }
                            }
                            else
                            {
                                throw new Exception("Invalid Input");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input. Must be between 0 and 9999...");
                        }

                        Tools.PressAnyKey();
                        break;

                    case Choices.END:

                        break;
                }  // end of switch
                choice = (Choices)menu.GetChoice();
            }  // end of while

            Console.WriteLine("Thank you for a challenging semester!");
            Tools.PressAnyKey();
            System.Environment.Exit(1);
        }

        #endregion Main
    }
}