using System;
using System.Collections.Generic;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Supermarket.cs
//	Description:       This is where the entire supermarket is ran from.
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Apr 09 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project4
{
    public class Supermarket
    {
        public static int NumPatrons { get; set; }
        public int hours { get; set; }
        public int numRegisters { get; set; }
        public int numShoppers { get; set; }
        private int current;
        private int longestLine;
        private int largestLineCount = 0;

        private static Random r = new Random();
        private static PriorityQueue<Event> PQ;
        private static PriorityQueue<Customer> atRegister;

        private static DateTime timeWeOpen;
        private static DateTime timeWeClose;
        private static int maxPresent = 0;
        private static int numberCheckedOut = 0;

        private TimeSpan start;
        private TimeSpan interval;
        private TimeSpan avgTimeShopping;
        private TimeSpan avgCheckoutTime;
        private TimeSpan avgRegisterTime;
        private TimeSpan totalTimeInCheckout;
        private TimeSpan totalTimeAtRegister;
        private static TimeSpan shortest, longest, totalTime;

        private List<Queue<Customer>> registers;

        public Supermarket()
        {
            registers = new List<Queue<Customer>>();
            PQ = new PriorityQueue<Event>();

            timeWeOpen = new DateTime(DateTime.Today.Year,
                DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);
            timeWeClose = new DateTime(DateTime.Today.Year,
                 DateTime.Today.Month, DateTime.Today.Day, 23, 0, 0);
            totalTimeInCheckout = new TimeSpan(0, 0, 0);
            totalTimeAtRegister = new TimeSpan(0, 0, 0);
        }

        public Supermarket(int inCustomers, int inHours, int inRegisters)
        {
            numRegisters = inRegisters;
            registers = new List<Queue<Customer>>(inRegisters);
            atRegister = new PriorityQueue<Customer>();
            int[] maxNumInLine = new int[numRegisters];
            hours = inHours;

            for (int i = 0; i < inRegisters; i++)
            {
                registers.Add(new Queue<Customer>());
                maxNumInLine[i] = 0;
            }

            PQ = new PriorityQueue<Event>();
            totalTimeInCheckout = new TimeSpan(0, 0, 0);
            totalTimeAtRegister = new TimeSpan(0, 0, 0);

            timeWeOpen = new DateTime(DateTime.Today.Year,
                DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);

            if (hours != 0)
            {
                TimeSpan temp = new TimeSpan(hours, 0, 0);
                timeWeClose = new DateTime(DateTime.Today.Year,
                    DateTime.Today.Month, DateTime.Today.Day, (8 + hours), 0, 0);
            }
            else
            {
                timeWeClose = new DateTime(DateTime.Today.Year,
                    DateTime.Today.Month, DateTime.Today.Day, (23), 0, 0);
            }

            NumPatrons = inCustomers;
            GeneratePatronEvents();
        }

        public void GeneratePatronEvents()
        {
            shortest = new TimeSpan(0, 100000, 0);
            longest = new TimeSpan(0, 0, 0);
            totalTime = new TimeSpan(0, 0, 0);

            for (int patron = 1; patron <= NumPatrons; patron++)
            {
                start = new TimeSpan(0, r.Next(hours * 60), 0);

                interval = new TimeSpan(0, (int)(NegExp(hours * 5)), 0);
                totalTime += interval;

                if (shortest > interval)
                    shortest = interval;

                if (longest < interval)
                    longest = interval;

                PQ.Enqueue(new Event(EVENTTYPE.ENTER, timeWeOpen.Add(start), patron));

                PQ.Enqueue(new Event(EVENTTYPE.LEAVE, timeWeOpen.Add(start + interval), patron));
            }

            int seconds = (int)(totalTime.TotalSeconds / NumPatrons);
            avgTimeShopping = new TimeSpan(0, 0, seconds);
        }

        public void DoSimulation()
        {
            maxPresent = 0;
            current = 0;
            longestLine = 0;
            numberCheckedOut = 0;

            while (PQ.Count > 0)
            {
                if (PQ.Peek().Type == EVENTTYPE.ENTER)
                {
                    current++;
                    if (current > maxPresent)
                        maxPresent = current;
                }
                else
                {
                    current--;
                    Customer temp = new Customer(PQ.Peek().Patron, PQ.Peek().Time);
                    int pos = getSmallestLine();
                    temp.register = pos;
                    DateTime temptimestamp = DateTime.MinValue;

                    if (atRegister.Count > 0)
                    {
                        while ((atRegister.Count > 0) && (atRegister.Peek().exitTime < temp.checkoutArrive))
                        {
                            int x = atRegister.Peek().register;
                            if (registers[x].Count > 0)
                            {
                                temptimestamp = atRegister.Peek().exitTime;
                                registers[x].Dequeue();
                                if (registers[x].Count > 0)
                                {
                                    registers[x].Peek().registerArrive = temptimestamp;
                                    atRegister.Enqueue(new Customer(registers[x].Peek()));
                                }
                            }
                            totalTimeInCheckout += (atRegister.Peek().checkoutArrive - atRegister.Peek().exitTime);
                            totalTimeAtRegister += (atRegister.Peek().registerArrive - atRegister.Peek().exitTime);
                            atRegister.Dequeue();
                            numberCheckedOut += 1;
                        }
                    }

                    registers[pos].Enqueue(temp);

                    if (registers[pos].Count == 1)
                    {
                        if (temptimestamp == DateTime.MinValue)
                        {
                            registers[pos].Peek().registerArrive = registers[pos].Peek().checkoutArrive;
                        }
                        else
                        {
                            if (temptimestamp > registers[pos].Peek().checkoutArrive)
                            {
                                registers[pos].Peek().registerArrive = temptimestamp;
                            }
                            else
                            {
                                registers[pos].Peek().registerArrive = registers[pos].Peek().checkoutArrive;
                            }
                        }
                        atRegister.Enqueue(new Customer(registers[pos].Peek()));
                    }
                }
                PQ.Dequeue();
                WriteScreen();
            }

            while (atRegister.Count > 0)
            {
                int x = atRegister.Peek().register;

                if (registers[x].Count > 0)
                {
                    DateTime temptimestamp = atRegister.Peek().exitTime;
                    registers[x].Dequeue();
                    if (registers[x].Count > 0)
                    {
                        registers[x].Peek().registerArrive = temptimestamp;
                        atRegister.Enqueue(new Customer(registers[x].Peek()));
                    }
                }

                totalTimeInCheckout += (atRegister.Peek().checkoutArrive - atRegister.Peek().exitTime);
                totalTimeAtRegister += (atRegister.Peek().registerArrive - atRegister.Peek().exitTime);

                atRegister.Dequeue();
                numberCheckedOut += 1;
                WriteScreen();
            }

            int seconds = ((int)(totalTimeInCheckout.TotalSeconds / numberCheckedOut)) * -1;
            avgCheckoutTime = new TimeSpan(0, 0, seconds);

            int secondsReg = ((int)(totalTimeAtRegister.TotalSeconds / numberCheckedOut)) * -1;
            avgRegisterTime = new TimeSpan(0, 0, secondsReg);

            Tools.PressAnyKey();
        }

        public void WriteScreen()
        {
            Console.Clear();

            Console.WriteLine(ToString());

            Console.Write("Customers Shopping: ");
            numShoppers = current;
            Console.WriteLine(numShoppers.ToString().PadLeft(2));
            longestLine = getLargestLine();
            Console.Write("Longest Line encounterd: ");
            Console.WriteLine(longestLine.ToString().PadLeft(2));
            Console.Write("Customers Checked Out: ");
            Console.WriteLine(numberCheckedOut.ToString().PadLeft(2));
            System.Threading.Thread.Sleep(250);   // pause the screen for monitoring for 1/4 second
        }

        public int getLargestLine()
        {
            for (int i = 0; i < registers.Count; i++)
            {
                if (registers[i].Count >= largestLineCount)
                {
                    largestLineCount = registers[i].Count;
                }
            }

            return largestLineCount;
        }

        public int getSmallestLine()
        {
            int firstSmallestLineCount = registers[0].Count;
            int firstSmallestLine = 0;

            for (int i = 0; i < registers.Count; i++)
            {
                if (registers[i].Count < firstSmallestLineCount)
                {
                    firstSmallestLine = i;
                    firstSmallestLineCount = registers[i].Count;
                }
            }

            return firstSmallestLine;
        }

        public void ShowStatistics()
        {
            Console.WriteLine("The maximum number of customers shopping at any time was {0}", maxPresent);
            Console.WriteLine("The longest shopping time by any customer was {0}", longest);
            Console.WriteLine("The average time customers spent shopping was {0}", avgTimeShopping);

            Console.WriteLine("\n\nThe average time customers spent in the checkout queue was {0}", avgCheckoutTime);
            Console.WriteLine("The average time customers spent at the register was {0}", avgRegisterTime);

            Console.WriteLine("\n\nOpen Time: " + timeWeOpen + "\nClosingTime: " + timeWeClose);

            Project4.Tools.PressAnyKey();
        }

        private static double NegExp(double ExpectedValue)
        {
            return -ExpectedValue * Math.Log(r.NextDouble(), Math.E);
        }

        public override string ToString()
        {
            string output = "";

            if (registers.Count == 0)
            {
                for (int i = 0; i < numRegisters; i++)
                {
                    output += "[R" + i + "] " + "\n";
                }
            }
            else
            {
                for (int i = 0; i < registers.Count; i++)
                {
                    if (registers[i].Count == 0)
                    {
                        output += "[R" + (i + 1) + "] " + "\n";
                    }
                    else
                    {
                        output += "[R" + (i + 1) + "] ";

                        for (int n = 0; n < registers[i].Count; n++)
                        {
                            Customer[] temp = new Customer[registers[i].Count];
                            temp = registers[i].ToArray();

                            if (n == 0)
                            {
                                output += " *" + temp[n].ToString() + "* ";
                            }
                            else
                            {
                                output += " " + temp[n].ToString() + " ";
                            }
                        }

                        output += "\n";
                    }
                }
            }

            return output;
        }
    }
}