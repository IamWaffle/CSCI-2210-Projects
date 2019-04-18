using System.Collections.Generic;

namespace Project_5
{
    internal class Index : Node
    {
        public List<Node> Indexes { get; set; }

        public Index()
        {
            Indexes = new List<Node>(base.nodeSize);
        }

        public Index(int n) : base(n)
        {
            Indexes = new List<Node>(base.nodeSize);
        }

        public INSERT Insert(int n, Node inNode)
        {
            INSERT iNSERT;

            if (base.value.IndexOf(n) != -1)
            {
                iNSERT = INSERT.DUPLICATE;
            }
            else if (base.value.Count == base.nodeSize)
            {
                iNSERT = INSERT.NEEDSPLIT;
            }
            else
            {
                iNSERT = INSERT.SUCCESS;

                base.value.Add(n);
                Indexes.Add(inNode);
                Sort();
            }

            return iNSERT;
        }

        public void Sort()
        {
        }
    }
}