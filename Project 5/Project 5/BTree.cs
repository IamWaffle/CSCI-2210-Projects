using System;
using System.Collections.Generic;

namespace Project_5
{
    internal class BTree
    {
        public int count { get; set; }
        public int indexCount { get; set; }
        public int leafCount { get; set; }
        public int nodeSize { get; set; }
        public bool Trace { get; set; }

        public Node root { get; set; }
        public Stack<Node> stack { get; set; }

        public BTree()
        {
            count = 0;
            indexCount = 0;
            nodeSize = 0;
        }

        public BTree(int arity)
        {
            count = 0;
            indexCount = 0;
            nodeSize = arity;

            Leaf node = new Leaf(nodeSize);
            root = new Index(nodeSize);
            stack = new Stack<Node>();

            ((Index)root).Insert(0, node);
        }

        public bool addValue(int inValue)
        {
            bool result = false;
            Leaf leaf = findLeaf(inValue);
            INSERT iNSERT = leaf.Insert(inValue);

            if (iNSERT == INSERT.DUPLICATE)
            {
                result = false;
            }
            else
            {
                count++;
                if (iNSERT == INSERT.NEEDSPLIT)
                {
                    result = true;
                    splitLeaf(leaf, inValue);
                }
                else
                {
                    stack.Pop();
                    Index index = (Index)stack.Peek();
                    int n = 0;

                    bool loop = true;

                    while (loop == true)
                    {
                        if (index.Indexes[n] == leaf)
                        {
                            index.value[n] = leaf.value[0];
                        }
                        if (n >= index.Indexes.Count)
                        {
                            result = true;
                            loop = false;
                        }
                        n++;
                    }
                }
            }
            return result;
        }

        public int findDepth()
        {
            int n = 0;
            Node root = this.root;
            while (root is Index)
            {
                root = ((Index)root).Indexes[0];
                n++;
            }

            return n;
        }

        public Leaf findLeaf(int nValueToFind)
        {
            Leaf output = new Leaf();
            return output;
        }

        public bool findValue(int n)
        {
            Trace = true;
            int result = findLeaf(n).value.IndexOf(n);
            Trace = false;

            bool equal = (indexCount != -1);

            return equal;
        }

        public void sort(List<int> inList, List<Node> inNodeList)
        {
        }

        public void splitIndex(Index nodeToBeSplit, Node nodeToBeAdded, int valueToBeAdded)
        {
        }

        public void splitLeaf(Leaf leaf, int nInsertedValue)
        {
        }

        public void Display()
        {
            leafCount = 0;
            indexCount = 0;

            Console.WriteLine("Root node:");
            Display(root, 0);
            Console.WriteLine("\n\n" + Stats());
        }

        public void Display(Node node, int n)
        {
        }

        public string Stats()
        {
            string output = "The number of Index nodes is : " + indexCount + "\nThe number of leaf nodes is: " + leafCount + " with an average of "
                + (leafCount * nodeSize) + "% full." + "\nThe depth of the tree is: " + findDepth() + "\n the total number of values in the tree is: " + count;

            return output;
        }
    }
}