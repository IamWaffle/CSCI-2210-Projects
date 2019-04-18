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
        public Node root { get; set; }
        public Stack<Node> stack { get; set; }
        public bool Trace { get; set; }

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

        public bool AddValue(int n)
        {
            bool flag;
            Leaf leaf = findLeaf(n);
            INSERT insert = leaf.Insert(n);
            if (insert == INSERT.DUPLICATE)
            {
                flag = false;
            }
            else
            {
                count++;
                if (insert != INSERT.SUCCESS)
                {
                    splitLeaf(leaf, n);
                    flag = true;
                }
                else
                {
                    this.stack.Pop();
                    Index index = (Index)this.stack.Peek();
                    int num = 0;
                    while (true)
                    {
                        if (num >= index.Indexes.Count)
                        {
                            flag = true;
                            break;
                        }
                        if (index.Indexes[num] == leaf)
                        {
                            index.value[num] = leaf.value[0];
                        }
                        num++;
                    }
                }
            }
            return flag;
        }


        public void Display()
        {
            leafCount = 0;
            indexCount = 0;

            Console.WriteLine("Root node:");
            Display(root, 0);
            Console.WriteLine("\n\n" + Stats());
        }

        public void Display(Node node, int inNum)
        {
            Console.WriteLine(node);

            if (node is Index)
            {
                inNum++;
                Console.WriteLine("Level in the BTree: " + inNum);
                indexCount++;

                for (int i = 0; i < ((Index)node).Indexes.Count; i++)
                {
                    Display(((Index)node).Indexes[i], inNum);
                }
            }
            else
            {
                leafCount++;
            }
        }

        public int findDepth()
        {
            int n = 0;
            Node nodeRoot = root;
            while (nodeRoot is Index)
            {
                nodeRoot = ((Index)nodeRoot).Indexes[0];
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

        /// <summary>
        ///
        /// </summary>
        /// <param name="inList"></param>
        /// <param name="inNodeList"></param>
        public void sort(List<int> inList, List<Node> inNodeList)
        {
            int i = 0;
            bool loop = false;
            while ((++i < inList.Count) && !loop)
            {
                loop = true;
                int x = 0;
                while (loop == true)
                {
                    if (inList[x] > inList[x + 1])
                    {
                        int num = inList[x];

                        inList[x] = inList[x + 1];
                        inList[x + 1] = num;

                        Node node = inNodeList[x];

                        inNodeList[x] = inNodeList[x + 1];
                        inNodeList[x + 1] = node;

                        loop = false;
                    }

                    if (x >= (inList.Count - i))
                    {
                        loop = false;
                    }
                    x++;
                }
            }
        }

        public void splitIndex(Index nodeSplit, Node nodeAdd, int numAdd)
        {
            Index node = new Index(nodeSize);
            List<int> tempList = new List<int>();
            List<Node> tempNode = new List<Node>();
            tempList.Add(numAdd);
            tempNode.Add(nodeAdd);

            int i = 0;
            bool loop2 = true;

            while (loop2)
            {
                bool loop = i < nodeSize;
                loop = i < nodeSize;

                if (loop == false)
                {
                    sort(tempList, tempNode);
                    nodeSplit.value.Clear();
                    nodeSplit.Indexes.Clear();
                    i = 0;

                    while (loop2)
                    {
                        loop = i < ((nodeSize + 1) / 2);
                        if (loop == false)
                        {
                            i = (nodeSize + 1) / 2;
                            while (loop2)
                            {
                                loop = i < (nodeSize + 1);
                                if (loop == false)
                                {
                                    if (root == nodeSplit)
                                    {
                                        root = new Index(nodeSize);
                                        ((Index)root).Insert(nodeSplit.value[0], nodeSplit);
                                        ((Index)root).Insert(node.value[0], node);
                                    }
                                    else
                                    {
                                        stack.Pop();

                                        Index tempIndex = ((Index)stack.Peek());
                                        if (tempIndex.Insert(node.value[0], node) == INSERT.NEEDSPLIT)
                                        {
                                            splitIndex(tempIndex, node, node.value[0]);
                                        }
                                    }
                                    loop2 = false;
                                }
                                node.value.Add(tempList[i]);
                                node.Indexes.Add(tempNode[i]);
                                i++;
                            }
                        }
                        nodeSplit.value.Add(tempList[i]);
                        nodeSplit.Indexes.Add(tempNode[i]);
                        i++;
                    }
                }
                tempList.Add(nodeSplit.value[i]);
                tempNode.Add(nodeSplit.Indexes[i]);
                i++;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inLeaf"></param>
        /// <param name="inNum"></param>
        public void splitLeaf(Leaf inLeaf, int inNum)
        {
            Leaf node = new Leaf(nodeSize);
            List<int> listInt = new List<int>(inLeaf.value) {inNum};
            listInt.Sort();
            inLeaf.value.Clear();

            int i = 0;
            while (true)
            {
                bool loop = i < ((nodeSize + 1) / 2);
                if (!loop)
                {
                    i = (nodeSize + 1) / 2;
                    while (true)
                    {
                        loop = i < (nodeSize + 1);
                        if (!loop)
                        {
                            stack.Pop();
                            Index nodeToBeSplit = (Index)stack.Peek();
                            if (nodeToBeSplit.Insert(node.value[0], node) == INSERT.NEEDSPLIT)
                            {
                                splitIndex(nodeToBeSplit, node, node.value[0]);
                            }
                            return;
                        }
                        node.value.Add(listInt[i]);
                        i++;
                    }
                }
                inLeaf.value.Add(listInt[i]);
                i++;
            }
        }

        public string Stats()
        {
            string output = "The number of Index nodes is : " + indexCount + "\nThe number of leaf nodes is: " + leafCount + " with an average of "
                + (leafCount * nodeSize) + "% full." + "\nThe depth of the tree is: " + findDepth() + "\n the total number of values in the tree is: " + count;

            return output;
        }
    }
}