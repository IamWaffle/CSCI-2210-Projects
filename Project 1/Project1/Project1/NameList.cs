///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         NameList.cs
//	Description:
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//  Modified:          Thursday, Feb 21 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Project1
{
    internal class NameList
    {
        private List<string> nameList = new List<string>();
        private Name owner = new Name();

        public string delimiters = "., -_   ";

        public NameList()
        {
            setOwnerName("Default Owner Name");
        }

        public NameList(string inNames)
        {
            nameList = Tools.Tokenize(inNames,delimiters);
        }

        public NameList(NameList original)
        {
            setOwnerName(original.getOwnerName());

            for (int i = 0; i < nameList.Count; i++)
            {
                nameList.Add(original.getName(i));
            }
        }

        public void add(Name n)
        {
            nameList.Add(n.ToString());
        }

        public void remove(int i)
        {
            nameList.Remove(nameList[i]);
        }

        public String get(int i)
        {
            string s = nameList[i].ToString();
            return s;
        }

        public string getName(int i)
        {
            string output;
            output = nameList[i].ToString();
            return output;
        }

        public void addName(string n)
        {
            nameList.Add(n);
        }

        public void removeName()
        {
            Console.WriteLine("Enter the name of the contact you wish to remove:");
            String name = Console.ReadLine().ToLower();

            for (int i = 0; i < nameList.Count; i++)
            {
                if (nameList[i].ToLower() == name)
                {
                    nameList.Remove(nameList[i]);
                    Console.WriteLine("Name Removed!");
                }
                else
                {
                    Console.WriteLine("Unable to find name in the list!/n");
                }
            }

        }

        public void setOwnerName(string input)
        {
            owner.personNameFull = input;
        }

        public string getOwnerName()
        {
            return owner.personNameFull;
        }

        public void setOwnerPhone(string input)
        {
            try
            {
                if (string.IsNullOrEmpty(input))
                {
                    owner.phoneNumber = "(XXX)-XXX-XXXX";
                }
                else
                {
                    var r = new Regex(@"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$");
                    if (r.IsMatch(input) == true)
                    {
                        owner.phoneNumber = input;
                    }
                    else
                    {
                        owner.phoneNumber = "(XXX)-XXX-XXXX";
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public string getOwnerPhone()
        {
            return owner.phoneNumber;
        }

        public void setOwnerEmail(string input)
        {
            try
            {
                if (string.IsNullOrEmpty(input))
                {
                    owner.email = "default@email.com";
                }
                else
                {
                    var r = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
                    if (r.IsMatch(input) == true)
                    {
                        owner.email = input;
                    }
                    else
                    {
                        owner.email = "default@email.com";
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public string getOwnerEmail()
        {
            return owner.email;
        }

        public void populateList(String inNames)
        {
            nameList = Tools.Tokenize(inNames, delimiters);
        }

        public String ToString()
        {
            String output = Tools.Format(nameList);
            return output;
        }

        #region Plus and Minus Operators

        /// <summary>
        /// Operator + adds a choice to the menu
        /// </summary>
        /// <param name="m">the menu to which the choice is added</param>
        /// <param name="name">the choice to be added</param>
        /// <returns></returns>
        public static NameList operator +(NameList m, string name)
        {
            m.nameList.Add(name);
            return m;
        }

        /// <summary>
        /// Operator  - removes a choice from the menu
        /// </summary>
        /// <param name="m">the menu from which the choice is removed</param>
        /// <param name="item">the number of the choice to be removed</param>
        /// <returns></returns>
        public static NameList operator -(NameList m, int n)
        {
            if (n > 0 && n <= m.nameList.Count)
                m.nameList.RemoveAt(n - 1);
            return m;
        }

        #endregion Plus and Minus Operators
    }
}