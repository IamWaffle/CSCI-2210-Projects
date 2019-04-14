using System;

namespace Project4
{
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
    public class Node<T> where T : IComparable
    {
        public T Item { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value, Node<T> link)
        {
            Item = value;
            Next = link;
        }
    }
}