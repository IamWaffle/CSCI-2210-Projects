using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace museum
{
    class Program
    {
        private const int NumPatrons = 100;
        private static Random r = new Random();
        private static PriorityQueue<Event> PQ;
        private static DateTime timeWeOpen;
        private static int maxPresent = 0;
        private static TimeSpan shortest, longest, totalTime;

        static void Main(string[] args)
        {
            PQ = new PriorityQueue<Event>();
            
            timeWeOpen = new DateTime(DateTime.Today.Year,
                DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);

            GeneratePatronEvents();
            DoSimulation();
            ShowStatistics();
        }

        private static void GeneratePatronEvents()
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
            Console.WriteLine("The average time customers spent in the museum was {0}", avgTime);
            Project4.Tools.PressAnyKey();
        }
    



        private static void DoSimulation()
        {
            int lineCount = 0;
            maxPresent = 0;
            int current = 0;

            while(PQ.Count > 0)
            {
                Console.Write(" {0}. ", (++lineCount).ToString().PadLeft(3));
                Console.Write( " {0}", PQ.Peek());

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

        private static void ShowStatistics() {
            Console.WriteLine("The maximun number in the museum at any time was {0}", maxPresent);
            Console.WriteLine("The shortest stay by any customer was {0}", shortest);
            Console.WriteLine("The lognest stay by any customer was {0}", longest);

            Project4.Tools.PressAnyKey();
        }

        private static double NegExp (double ExpectedValue)
        {
            return -ExpectedValue * Math.Log(r.NextDouble(), Math.E);
        } 
    }
}
