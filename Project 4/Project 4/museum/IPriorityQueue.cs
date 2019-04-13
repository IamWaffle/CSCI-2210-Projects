using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    public interface IPriorityQueue<T> : IContainer<T> where T : IComparable
    {
        void Enqueue(T item);
        void Dequeue();
        T Peek();
    }
    
}
