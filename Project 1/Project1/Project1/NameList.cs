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

namespace Project1
{
    internal class NameList
    {
        List<string> nameList;
        public string delimiters = " .,;:!?-    ";

        public NameList()
        {
            nameList = new List<string>();
        }

        public NameList(string inNames)
        {

        }

        public NameList(NameList original)
        {

        }

        public void populateList(String inNames)
        {
            nameList = Tools.Tokenize(inNames, delimiters);
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