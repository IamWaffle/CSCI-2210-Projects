using System;

namespace Project4
{
    public interface IPriorityQueue<T> : IContainer<T> where T : IComparable
    {
        void Enqueue(T item);

        void Dequeue();

        T Peek();
    }
}