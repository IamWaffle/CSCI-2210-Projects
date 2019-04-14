using System;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Customer.cs
//	Description:       The customer class houses a customer object with different attributes.
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Apr 09 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project_4
{
    internal class Customer : IComparable
    {
        public String name { get; set; }
        public int register { get; set; }
        private Random r = new Random();
        public DateTime registerArrive { get; set; }
        public DateTime checkoutArrive { get; set; }
        public DateTime exitTime { get; set; }

        public Customer()
        {
            name = r.Next(500).ToString();
        }

        public Customer(int n, DateTime inTime)
        {
            name = n.ToString();
            checkoutArrive = inTime;
        }

        public Customer(int n, DateTime inTime, int reg)
        {
            name = n.ToString();
            checkoutArrive = inTime;
            register = reg;
            generateExitTime();
        }

        public Customer(Customer original)
        {
            name = original.name;
            register = original.register;
            checkoutArrive = original.checkoutArrive;
            registerArrive = original.registerArrive;
            generateExitTime();
        }

        public void generateExitTime()
        {
            exitTime = registerArrive + new TimeSpan(0, r.Next(2, 7), 0); ;
        }

        public override string ToString()
        {
            return name;
        }

        int IComparable.CompareTo(object obj)
        {
            if (!(obj is Customer))
            {
                throw new ArgumentException("The argument is not an Customer object.");
            }

            Customer r = (Customer)obj;

            return (r.exitTime.CompareTo(exitTime));
        }
    }
}