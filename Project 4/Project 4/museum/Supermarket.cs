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

        
        private static Random r = new Random();
        private static PriorityQueue<Event> PQ;
        private static PriorityQueue<Event> PQChkout;

        private static DateTime timeWeOpen;
        private static int maxPresent = 0;

        private static TimeSpan shortest, longest, totalTime;

        
        private List<Queue<Customer>> registers;

        public Supermarket()
        {
            
            registers = new List<Queue<Customer>>();
            PQ = new PriorityQueue<Event>();

            timeWeOpen = new DateTime(DateTime.Today.Year,
                DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);
        }

        public Supermarket(int inCustomers, int inHours, int inRegisters, int inChkout)
        {
            numRegisters = inRegisters;
            registers = new List<Queue<Customer>>(inRegisters);
            for(int i = 0; i < inRegisters; i++)
            {
                registers.Add(new Queue<Customer>());
            }
            


            PQ = new PriorityQueue<Event>();

            timeWeOpen = new DateTime(DateTime.Today.Year,
                DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);

            NumPatrons = inCustomers;
            GeneratePatronEvents();

            hours = inHours;

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
            Tools.PressAnyKey();
        }

        public void DoSimulation()
        {
            maxPresent = 0;
            int current = 0;
            int longestLine = 0;

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

                    Customer temp = new Customer(PQ.Peek().Patron);
                    registers[getSmallestLine()].Enqueue(temp);
                    
                    

                }
                Console.Clear();
                Tools.Skip();



                Console.WriteLine(ToString());

                Console.Write("Time: ");
                Console.WriteLine(PQ.Peek().Time.ToString().PadLeft(2));
                PQ.Dequeue();
                Console.Write("Customers Shopping: ");
                Console.WriteLine(current.ToString().PadLeft(2));
                longestLine = getLargestLine();
                Console.Write("Longest Line so far: ");
                Console.WriteLine(longestLine.ToString().PadLeft(2));


            }

            Tools.PressAnyKey();
        }

        public int getLargestLine()
        {
            int firstLargestLineCount = registers[0].Count;
            int firstLargestLine = 0;

            for (int i = 0; i < registers.Count; i++)
            {
                if (registers[i].Count >= firstLargestLineCount)
                {
                    
                    firstLargestLineCount = registers[i].Count;
                    firstLargestLine = firstLargestLineCount;
                }
            }

            return firstLargestLine;
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
            Console.WriteLine("The maximum number of customers shopping any time was {0}", maxPresent);
            Console.WriteLine("The shortest stay by any customer was {0}", shortest);
            Console.WriteLine("The longest stay by any customer was {0}", longest);

            Project4.Tools.PressAnyKey();
        }

        private static double NegExp(double ExpectedValue)
        {
            return -ExpectedValue * Math.Log(r.NextDouble(), Math.E);
        }

        public override string ToString()
        {
            string output = "";

            if(registers.Count == 0)
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
                    if(registers[i].Count == 0)
                    {
                        output += "[R" + i + "] " + "\n";
                    }
                    else
                    {
                        output += "[R" + i + "] " ;

                        for (int n = 0; n < registers[i].Count; n++)
                        {
                            Customer[] temp = new Customer[registers[i].Count];
                            temp = registers[i].ToArray();

                            output += " " + temp[n].ToString() + " ";
                        }

                        output += "\n";
                    }
                    
                }
            }


            return output;
        }

        

    }
}