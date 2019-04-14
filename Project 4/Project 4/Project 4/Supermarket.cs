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
namespace Project_4
{
    /// <summary>
    /// Creates a super market that will be able to take in customers and sort them in registers
    /// </summary>
    public class Supermarket
    {
        public static int NumPatrons { get; set; }
        public int hours { get; set; }
        public int numRegisters { get; set; }
        public int numShoppers { get; set; }
        private int current;
        private int longestLine;
        private int largestLineCount = 0;
        private int customersRejected = 0;

        private static Random r = new Random();
        private static PriorityQueue<Event> PQ;
        private static PriorityQueue<Customer> atRegister;
        private List<Queue<Customer>> registers;

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
        private Customer endTemp;

        #region Constructors
        /// <summary>
        /// Basic no arg constructor that defines key variables
        /// </summary>
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

        /// <summary>
        /// Arg Constructor that defines variables with the arguments passed in 
        /// </summary>
        /// <param name="inCustomers">the number of customers to be served</param>
        /// <param name="inHours">the number of hours of operation</param>
        /// <param name="inRegisters">the number of registers to make</param>

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
                DateTime.Today.Month, DateTime.Today.Day, 7, 0, 0);

            if (hours != 0 && hours < 17)
            {

                int timeClose = timeWeOpen.Hour + hours;
             timeWeClose = new DateTime(DateTime.Today.Year,
                DateTime.Today.Month, DateTime.Today.Day, timeClose, 0, 0);
               
                
            }
            else
            {
                timeWeClose = new DateTime(DateTime.Today.Year,
                    DateTime.Today.Month, DateTime.Today.Day, (23), 0, 0);
            }

            NumPatrons = inCustomers;
            GeneratePatronEvents();
        }

        #endregion Constructors

        #region Methods
        /// <summary>
        /// GeneratePatronEvents creates enter times into the store and leave events for whenever
        /// they are entering the checkout queue
        /// </summary>
        public void GeneratePatronEvents()
        {
            shortest = new TimeSpan(0, 100000, 0);
            longest = new TimeSpan(0, 0, 0);
            totalTime = new TimeSpan(0, 0, 0);

            for (int patron = 1; patron <= NumPatrons; patron++)
            {
                start = new TimeSpan(0, r.Next(hours * 60), 0);

                interval = new TimeSpan(0, (int)(NegExp(hours)), 0);
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
        /// <summary>
        /// Do simulation simulates the supermarket. It checkout every customer until closing time. 
        /// </summary>
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
                    if (temp.checkoutArrive < timeWeClose)
                    {
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
                    else
                    {
                        customersRejected++;

                        temp.checkoutArrive -= interval;
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
                endTemp = new Customer(atRegister.Peek());
                atRegister.Dequeue();
                numberCheckedOut += 1;
                WriteScreen();
            }

            int seconds = ((int)(totalTimeInCheckout.TotalSeconds / numberCheckedOut)) * -1;
            avgCheckoutTime = new TimeSpan(0, 0, seconds);

            int secondsReg = ((int)(totalTimeAtRegister.TotalSeconds / numberCheckedOut)) * -1;
            avgRegisterTime = new TimeSpan(0, 0, secondsReg);

            Tools.PressAnyKey("look at the statistics...");
        }

        /// <summary>
        /// This method writes key information to the screen.
        /// </summary>
        public void WriteScreen()
        {
            Console.Clear();

            Console.WriteLine(ToString());

            Console.Write("Customers Shopping: ");
            numShoppers = current;
            Console.WriteLine(numShoppers.ToString().PadLeft(2));
            longestLine = getLargestLine();
            Console.Write("Longest Line encountered: ");
            Console.WriteLine(longestLine.ToString().PadLeft(2));
            Console.Write("Customers Checked Out: ");
            Console.WriteLine(numberCheckedOut.ToString().PadLeft(2) + "\n");

            //System.Threading.Thread.Sleep(175);   
        }

        /// <summary>
        /// This method looks at the size of the register line and keeps track of the largest
        /// known line.
        /// </summary>
        /// <returns> int largest line count</returns>
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

        /// <summary>
        /// get smallest line returns the position of the register that contains the smallest
        /// line.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// ShowStatistics shows key information about the simulation that just occurred.
        /// </summary>
        public void ShowStatistics()
        {
            Console.WriteLine("The maximum number of customers shopping at any time was {0}\n", maxPresent);
            Console.WriteLine("The longest shopping time by any customer was {0}", longest);
            Console.WriteLine("The average time customers spent shopping was {0}", avgTimeShopping);

            Console.WriteLine("\n\nThe average time customers spent in the checkout queue was {0}", avgCheckoutTime);
            Console.WriteLine("The average time customers spent at the register was {0}", avgRegisterTime);
            Console.WriteLine("\n\nThe number of registers: {0}", numRegisters);
            Console.WriteLine("The longest line encountered: {0}", longestLine.ToString()); 
            Console.WriteLine("\n\nThe last customer left at {0}", endTemp.registerArrive.AddHours(1).ToShortTimeString());
            Console.WriteLine("The number of customers that shopped too long and never checked out was {0}", customersRejected);

            Console.WriteLine("\n\nOpen Time: " + timeWeOpen.AddHours(1).ToShortTimeString() + "\nClosing Time: " + timeWeClose.AddHours(1).ToShortTimeString() + "\n\n");

            Tools.PressAnyKey();
        }

        /// <summary>
        /// NegExp gets and returns a number using negative distribution
        /// </summary>
        /// <param name="ExpectedValue">the expected value passed into the method</param>
        /// <returns>the returning result</returns>
        private static double NegExp(double ExpectedValue)
        {
            return -ExpectedValue * Math.Log(r.NextDouble(), Math.E);
        }
        #endregion Methods

        #region Override Methods
        /// <summary>
        /// To string returns what the supermarket looks like currently showing
        /// the registers with the names of the customers in the line.
        /// </summary>
        /// <returns>string the returning formatted output string.</returns>

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
                        output += "[R" + (i + 1) + "] " + "\n\n";
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

                        output += "\n\n";
                    }
                }
            }

            return output;
        }
        #endregion Override Methods
    }
}