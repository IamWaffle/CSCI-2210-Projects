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

        /// <summary>
        ///
        /// </summary>
        public void Sort()
        {
            int num = 0;
            bool flag = false;
            while ((++num < (base.value.Count - 1)) && !flag)
            {
                flag = true;
                int num2 = 0;
                while (true)
                {
                    if (num2 >= (base.value.Count - num))
                    {
                        break;
                    }
                    if (base.value[num2] > base.value[num2 + 1])
                    {
                        int num3 = base.value[num2];
                        base.value[num2] = base.value[num2 + 1];
                        base.value[num2 + 1] = num3;
                        Node node = Indexes[num2];
                        Indexes[num2] = Indexes[num2 + 1];
                        Indexes[num2 + 1] = node;
                        flag = false;
                    }
                    num2++;
                }
            }
        }
    }
}