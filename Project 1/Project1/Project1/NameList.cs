///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         NameList.cs
//	Description:
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Monday, Feb 04 2019
//  Modified:          Sunday, Feb 24 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Project1
{
    internal class NameList
    {
        private List<Name> nameList = new List<Name>();
        private Name owner = new Name();

        #region Constructors

        public NameList()
        {
            setOwnerName("Default Owner Name");
        }

        public NameList(string inNames)
        {
            nameList = populateList(Tools.Tokenize(inNames, "#,"));
        }

        public NameList(NameList original)
        {
            setOwnerName(original.getOwnerName());

            for (int i = 0; i < nameList.Count; i++)
            {
                nameList.Add(original.getName(i));
            }
        }

        #endregion Constructors

        #region NameList Methods
        public List<Name> populateList(List<String> inNames)
        {
            List<Name> outNames = new List<Name>();
            Name temp;

            for (int i = 0; i < inNames.Count; i ++)
            {
                temp = new Name(inNames[i]);
                outNames.Add(temp);
            }

            for (int y = 0;
            y < outNames.Count; y++)
            {
                Console.WriteLine(outNames[y]);
            }
            
            return outNames;
        }
        public void clear()
        {
            nameList.Clear();
        }
        public void remove(int i)
        {
            nameList.Remove(nameList[i]);
        }

        public Name getName(int i)
        {
            return nameList[i];

        }

        public void removeName()
        {
            Console.WriteLine("Enter the name of the contact you wish to remove:");
            String name = Console.ReadLine().ToLower();

            for (int i = 0; i < nameList.Count; i++)
            {
                if (nameList[i].personNameFull.ToLower() == name)
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

        public int Count()
        {
            return nameList.Count;
        }
        #endregion NameList Methods

        #region OwnerMethods
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
            owner.phoneNumber = input;
        }

        public string getOwnerPhone()
        {
            return owner.phoneNumber;
        }

        public void setOwnerEmail(string input)
        {
            owner.email = input;
        }

        public string getOwnerEmail()
        {
            return owner.email;
        }

        public String ToString()
        {
            String output = "";
            for (int i = 0; i < nameList.Count; i++)
            {
                output += (nameList[i].personNameFull + "\n");
            }
            return output;
        }

        #endregion OwnerMethods

        #region Plus and Minus Operators

        /// <summary>
        /// Operator + adds a choice to the menu
        /// </summary>
        /// <param name="m">the menu to which the choice is added</param>
        /// <param name="name">the choice to be added</param>
        /// <returns></returns>
        public static NameList operator +(NameList m, Name name)
        {
            m.nameList.Add(name);
            return m;
        }

        /// <summary>
        /// Operator + adds a choice to the menu
        /// </summary>
        /// <param name="m">the menu to which the choice is added</param>
        /// <param name="name">the choice to be added</param>
        /// <returns></returns>
        public static NameList operator +(NameList m, NameList n)
        {
            for (int i = 0; i < n.Count(); i++)
            {
                m.nameList.Add(n.getName(i));
            }    
            return m;
        }

        /// <summary>
        /// Operator  - removes a choice from the menu
        /// </summary>
        /// <param name="m">the menu from which the choice is removed</param>
        /// <param name="item">the number of the choice to be removed</param>
        /// <returns></returns>
        public static NameList operator -(NameList m, Name n)
        {
            for (int i = 0; i < m.Count(); i++)
            {
                if (m.getName(i).ToString().ToLower() == n.personNameFull.ToLower())
                {
                    m.remove(i);
                    return m;
                }
                else
                {
                    Console.WriteLine("Unable to find name in the list!/n");
                }
            }
            return m;
        }

        #endregion Plus and Minus Operators
    }
}
