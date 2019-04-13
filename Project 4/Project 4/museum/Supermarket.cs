using System;
using System.Collections.Generic;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Supermarker.cs
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
        public int chkoutDuration { get; set; }

        private static Random r = new Random();
        private static PriorityQueue<Event> PQ;
        private static DateTime timeWeOpen;
        private static int maxPresent = 0;
        private static TimeSpan shortest, longest, totalTime;

        private Queue<Customer> customerQueue;
        private List<Register> registers;

        public Supermarket()
        {
            customerQueue = new Queue<Customer>();
            registers = new List<Register>();
            PQ = new PriorityQueue<Event>();

            timeWeOpen = new DateTime(DateTime.Today.Year,
                DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);
        }

        public Supermarket(int inCustomers, int inHours, int inRegisters, int inChkout)
        {
            customerQueue = new Queue<Customer>();
            registers = new List<Register>();
            PQ = new PriorityQueue<Event>();

            timeWeOpen = new DateTime(DateTime.Today.Year,
                DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);

            NumPatrons = inCustomers;
            GeneratePatronEvents();

            hours = inHours;
            numRegisters = inRegisters;
            chkoutDuration = inChkout;

            addRegister(numRegisters);
        }

        public void fillList()
        {
            for(int i = 0; i < NumPatrons; i++)
            {
                customerQueue.Enqueue(new Customer(i + 1));
            }
        }

        public void addRegister()
        {
            registers.Add(new Register());
        }

        public void addRegister(int num)
        {
            for (int i = 0; i < num; i++)
            {
                registers.Add(new Register());
            }
        }

        public int findRegister()
        {
            int lowestRegister = 0;

            return lowestRegister;
        }

        public void GeneratePatronEvents()
        {
            TimeSpan start;
            TimeSpan interval;
            shortest = new TimeSpan(0, 100000, 0);
            longest = new TimeSpan(0, 0, 0);
            totalTime = new TimeSpan(0, 0, 0);

            for (int patron = 1; patron <= NumPatrons; patron++)
            {
                start = new TimeSpan(0, r.Next(10 * 60), 0);

                interval = new TimeSpan(0, (int)(10.0 + NegExp(50)), 0);
                totalTime += interval;

                if (shortest > interval)
                    shortest = interval;

                if (longest < interval)
                    longest = interval;

                PQ.Enqueue(new Event(EVENTTYPE.ENTER, timeWeOpen.Add(start), patron));

                PQ.Enqueue(new Event(EVENTTYPE.LEAVE, timeWeOpen.Add(start + interval), patron));

            }



            int seconds = (int)(totalTime.TotalSeconds / NumPatrons);
            TimeSpan avgTime = new TimeSpan(0, 0, seconds);
            Console.WriteLine("The average time customers spent shopping was {0}", avgTime);
            Project4.Tools.PressAnyKey();
        }

        public void DoSimulation()
        {
            int lineCount = 0;
            maxPresent = 0;
            int current = 0;

            while (PQ.Count > 0)
            {
                Console.Write(" {0}. ", (++lineCount).ToString().PadLeft(3));
                Console.Write(" {0}", PQ.Peek());

                if (PQ.Peek().Type == EVENTTYPE.ENTER)
                {
                    current++;

                    if (current > maxPresent)
                        maxPresent = current;

                }
                else
                {
                    current--;

                }

                Console.Write(" Customers Present: ");
                Console.WriteLine(current.ToString().PadLeft(2));

                PQ.Dequeue();


            }

            Project4.Tools.PressAnyKey();
        }

        public void ShowStatistics()
        {
            Console.WriteLine("The maximun number in the museum at any time was {0}", maxPresent);
            Console.WriteLine("The shortest stay by any customer was {0}", shortest);
            Console.WriteLine("The lognest stay by any customer was {0}", longest);

            Project4.Tools.PressAnyKey();
        }

        private static double NegExp(double ExpectedValue)
        {
            return -ExpectedValue * Math.Log(r.NextDouble(), Math.E);
        }

        public override string ToString()
        {
            string output = "";

            for(int i = 0; i < registers.Count; i++)
            {
                output += registers[i].ToString();
            }

            output += "\n\n Customers waiting: " + customerQueue.Count;

            return output;
        }

        

    }
}