using System;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         PriorityQueue.cs
//	Description:       This class uses the other classes to create a priority queue
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
    /// This is the IPriorityQueue class, a required class for a priority queue
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class PriorityQueue<T> : IPriorityQueue<T> where T : IComparable
    {
        private Node<T> top;
        public int Count { get; set; }

        #region Methods
        /// <summary>
        /// Clears the priority queue
        /// </summary>
        public void Clear()
        {
            top = null;
            Count = 0;
        }

        /// <summary>
        /// Dequeue takes the object on top of the queue and removed it
        /// </summary>

        public void Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot remove from empty queue");
            }
            else
            {
                Node<T> oldNode = top;
                top = top.Next;
                Count--;
                oldNode = null;
            }
        }
        /// <summary>
        /// Enqueue takes in an object and places it into the queue
        /// </summary>
        /// <param name="item">Object T to be inserted in queue</param>
        public void Enqueue(T item)
        {
            if (Count == 0)
            {
                top = new Node<T>(item, null);
            }
            else
            {
                Node<T> current = top;
                Node<T> previous = null;

                while (current != null && current.Item.CompareTo(item) >= 0)
                {
                    previous = current;
                    current = current.Next;
                }

                Node<T> newNode = new Node<T>(item, current);

                if (previous != null)
                {
                    previous.Next = newNode;
                }
                else
                {
                    top = newNode;
                }
            }

            Count++;
        }
        /// <summary>
        /// checks to see if the queue is empty
        /// </summary>
        /// <returns>returns true or false depending on if the queue is empty</returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }

        /// <summary>
        /// Peek takes a look at the top object inside the queue
        /// </summary>
        /// <returns>Object type T</returns>

        public T Peek()
        {
            if (!IsEmpty())
            {
                return top.Item;
            }
            else
            {
                throw new InvalidOperationException("Cannot obtain top of empty priority queue");
            }
        }
        #endregion Methods
    }
}