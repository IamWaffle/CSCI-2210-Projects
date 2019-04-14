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
    /// <summary>
    /// This is the customer class, contains attributes like a name and the required calculation times.
    /// </summary>
    internal class Customer : IComparable
    {
        public String name { get; set; }
        public int register { get; set; }
        private Random r = new Random();
        public DateTime registerArrive { get; set; }
        public DateTime checkoutArrive { get; set; }
        public DateTime exitTime { get; set; }

        #region Constructors
        /// <summary>
        /// Basic no arg constructor
        /// </summary>
        public Customer()
        {
            name = r.Next(500).ToString();
        }
        /// <summary>
        /// creates a customer with a name and the checkout arrive time
        /// </summary>
        /// <param name="n">the name/number of the customer</param>
        /// <param name="inTime">the time the customer leaves the previous queue is set to the checkout arrive time.</param>
        public Customer(int n, DateTime inTime)
        {
            name = n.ToString();
            checkoutArrive = inTime;
        }

        /// <summary>
        /// 90% Copy Constructor
        /// </summary>
        /// <param name="original">takes the customer passed in and creates a copy with a generated exit time.</param>
        public Customer(Customer original)
        {
            name = original.name;
            register = original.register;
            checkoutArrive = original.checkoutArrive;
            registerArrive = original.registerArrive;
            generateExitTime();
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Generate Exit time generates a randomo exit time between 2 and 7 minutes 
        /// </summary>
        public void generateExitTime()
        {
            exitTime = registerArrive + new TimeSpan(0, r.Next(2, 7), 0); ;
        }
        #endregion Methods

        #region Override Methods
        /// <summary>
        /// ToString returns the name of the customer.
        /// </summary>
        /// <returns>name</returns>
        public override string ToString()
        {
            return name;
        }
         
        /// <summary>
        /// CompareTo compares the exit time of the customer and returns if it is greater, less than or equal to
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int IComparable.CompareTo(object obj)
        {
            if (!(obj is Customer))
            {
                throw new ArgumentException("The argument is not an Customer object.");
            }

            Customer r = (Customer)obj;

            return (r.exitTime.CompareTo(exitTime));
        }
        #endregion Override Methods
    }
}