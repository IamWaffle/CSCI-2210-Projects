using System.Collections.Generic;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:        Register.cs
//	Description:       The register class is where we have a register object that can add customers
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Tuesday, Apr 09 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project4
{
    internal class Register
    {
        private Queue<Customer> line;

        public Register()
        {
            line = new Queue<Customer>();
        }

        public void addCustomer(Customer c)
        {
            line.Enqueue(c);
        }

        public void removeCustomer()
        {
            line.Dequeue();
        }

        public int Size()
        {
            return line.Count;
        }

        public override string ToString()
        {
            string output = " [R] ";
            Customer[] temp;
            temp = line.ToArray();

            for (int i = 0; i < Size(); i++)
            {
                output += temp[i].ToString() + " ";
            }

            output += "\n";
            return output;
        }
    }
}