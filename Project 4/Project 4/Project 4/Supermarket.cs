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

        private List<Register> registers = new List<Register>();

        public Supermarket()
        {
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

        public void RunSimulation()
        {
            Console.WriteLine("HAHAHAHH");
            Tools.PressAnyKey();
        }

        public void ShowStatistics()
        {
            Console.WriteLine(customers.ToString() + hours.ToString() + numRegisters.ToString() + chkoutDuration.ToString());
            Tools.PressAnyKey();

        }

    }
}