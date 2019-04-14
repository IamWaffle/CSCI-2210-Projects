using System;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Node.cs
//	Description:       This is a required class for a priority queue. Creates a node.
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
    /// This class creates a node to be placed in a Priority Queue
    /// </summary>
    /// <typeparam name="T">Type T</typeparam>
    public class Node<T> where T : IComparable
    {
        public T Item { get; set; }
        public Node<T> Next { get; set; }

        #region Constructor
        /// <summary>
        /// Simple constructor
        /// </summary>
        /// <param name="value">the value of T</param>
        /// <param name="link">the link Node</param>
        public Node(T value, Node<T> link)
        {
            Item = value;
            Next = link;
        }
        #endregion Constructor
    }
}