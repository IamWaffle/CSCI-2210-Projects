using System;

namespace Project4
{    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    //	File Name:         IPriorityQueue.cs
    //	Description:       This is a required class for a priority queue.
    //
    //	Course:            CSCI 2210 - Data Structures
    //	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
    //	Created:           Tuesday, Apr 09 2019
    //
    //
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public interface IPriorityQueue<T> : IContainer<T> where T : IComparable
    {
        void Enqueue(T item);

        void Dequeue();

        T Peek();
    }
}