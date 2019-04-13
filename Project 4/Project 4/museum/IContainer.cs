using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    public interface IContainer<T>
    {

        void Clear();
        bool IsEmpty();
        int Count { get; set; }
    }
}
