///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Node.cs
//	Description:       This class creates and manages a Node
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Wednesday Apr 17, 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace Project_5_BTree
{
    /// <summary>
    /// Class node.
    /// </summary>
    internal class Node
    {
        public int NodeSize { get; set; }
        public List<int> Value { get; set; }

        #region Constructors

        /// <summary>
        /// basic no arg constructor
        /// </summary>
        public Node()
        {
            Value = new List<int>(3);

            NodeSize = 3;
        }

        /// <summary>
        /// Constructor that takes in a size and sets the node size to that size.
        /// </summary>
        /// <param name="size"></param>
        public Node(int size)
        {
            if (size < 3)
            {
                throw new Exception("Node size not greater than 3.");
            }
            else
            {
                NodeSize = size;
                Value = new List<int>(NodeSize);
            }
        }

        #endregion Constructors

        #region ToString

        /// <summary>
        /// ToString returns a formatted string for console viewing.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = "";
            string values = "";
            string tempString = "";

            try
            {
                if (this is Leaf)
                {
                    tempString = "Leaf";
                }
                else
                {
                    throw new Exception("Index");
                }
            }
            catch (Exception)
            {
                tempString = "Index";
            }

            output = "\nType: " + tempString;
            output = output + "\nValues: " + Value.Count;
            output += "  (" + Math.Round((decimal)Value.Count * 100m / (decimal)NodeSize) + "% full)" +
                "\n";

            for (int i = 0; i < Value.Count; i++)
            {
                try
                {
                    if (i != 0 || this is Leaf)
                    {
                        values += Value[i] + "  ";
                    }
                    else
                    {
                        throw new Exception("is index or == to 0");
                    }
                }
                catch (Exception)
                {
                    values += " ** ";
                }
            }

            output += values;
            return output;
        }

        #endregion ToString
    }
}