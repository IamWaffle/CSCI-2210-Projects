using System;
using System.Collections.Generic;

namespace Project_5
{
    internal class Node
    {
        public int nodeSize { get; set; }
        public List<int> value { get; set; }

        public Node()
        {
            value = new List<int>(3);

            nodeSize = 3;
        }

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

        public override string ToString()
        {
            string output = "";

            return output;
        }
    }
}