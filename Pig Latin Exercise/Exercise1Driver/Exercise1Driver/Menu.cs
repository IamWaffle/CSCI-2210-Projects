using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Driver
{
    class Menu
    {
        private List<string> Items = new List<string>();
        public string Title { get; set; }

        public Menu(string title)
        {
            Title = title;
        }

        public static Menu operator +(Menu m, string item)
        {
            m.Items.Add(item);
            return m;
        }

        public static Menu operator -(Menu m, int n)
        {
            if (n > 0 && n <= m.Items.Count)
                m.Items.RemoveAt(n - 1);
            return m;
        }

        public void Display()
        {
            string str = "";
            Console.Clear();
            str = DateTime.Today.ToLongDateString();
            Console.SetCursorPosition(Console.WindowWidth - str.Length, 0);
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\n\t   " + Title);
            Console.Write("\t   ");
            for (int n = 0; n < Title.Length; n++)
                Console.Write("-");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int n = 0; n < Items.Count; n++)
                Console.WriteLine("\t{0}. {1}", (n + 1), Items[n]);
        }
        public int GetChoice()
        {
            int choice = -1;
            string line;
            if (Items.Count < 1)
                throw new Exception("The menu is empty");

            while (true)
            {
                Display();
                Console.Write("\n\t   Type the number of your choice from the menu: ");
                Console.ForegroundColor = ConsoleColor.White;
                line = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (!Int32.TryParse(line, out choice))
                {
                    Console.WriteLine("\n\t   Your choice is not a number between 1 and {0}.  Please try again.",
                        Items.Count);
                    Console.ReadKey();
                }
                else
                {
                    if (choice < 1 || choice > Items.Count)
                    {
                        Console.WriteLine("\n\t   Your choice is not a number between 1 and {0}.  Please try again.",
                            Items.Count);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        return choice;
                    }
                }
            }
        }
    }
}
