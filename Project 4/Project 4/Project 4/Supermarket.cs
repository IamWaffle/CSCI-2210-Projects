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
    internal class Supermarket
    {
        public int customers { get; set; }
        public int hours { get; set; }
        public int numRegisters { get; set; }
        public int chkoutDuration { get; set; }
        private Queue<Customer> customerQueue;
        private List<Register> registers;

        public Supermarket()
        {
            customerQueue = new Queue<Customer>();
            registers = new List<Register>();
        }

        public Supermarket(int inCustomers, int inHours, int inRegisters, int inChkout)
        {
            customerQueue = new Queue<Customer>();
            registers = new List<Register>();

            customers = inCustomers;          
            fillList();

            hours = inHours;
            numRegisters = inRegisters;
            chkoutDuration = inChkout;

            addRegister(numRegisters);
        }

        public void fillList()
        {
            for(int i = 0; i < customers; i++)
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

        public void RunSimulation()
        {
            while(customerQueue.Count != 0)
            {
                for (int i = 0; i < registers.Count; i++)
                {
                    registers[i].addCustomer(customerQueue.Dequeue());
                }
            }
            
            Console.WriteLine(ToString());
      
            Tools.PressAnyKey();
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

        public void ShowStatistics()
        {
            Console.WriteLine(customers.ToString() + hours.ToString() + numRegisters.ToString() + chkoutDuration.ToString());
            Tools.PressAnyKey();

        }

    }
}