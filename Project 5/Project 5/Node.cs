using System;
using System.Collections.Generic;

namespace Project_5
{

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
    ///
    internal class Node
    {
        public int nodeSize { get; set; }
        public List<int> value { get; set; }

        #region Constructors
        /// <summary>
        /// basic no arg constructor
        /// </summary>
        public Node()
        {
            value = new List<int>(3);

            nodeSize = 3;
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
                nodeSize = size;
                value = new List<int>(nodeSize);
            }
        }

        #endregion Constructors

        #region ToString
        /// <summary>
        /// ToString returns a formattted string for console viewing.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result5 = "\nNode Type: " + ((this is Leaf) ? "Leaf" : "Index");
            result5 = result5 + "\nNumber of values: " + value.Count;
            result5 += $" (Node is {(decimal)value.Count * 100m / (decimal)nodeSize:#}% full)\nValues:\n";
            string result2 = "";
            for (int i = 0; i < value.Count; i++)
            {
                result2 = ((!(this is Index) || i != 0) ? (result2 + value[i] + "  ") : (result2 + "   **     "));
            }
            return result5 + result2;
        }
        #endregion ToString
    }
}