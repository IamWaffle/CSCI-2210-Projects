using System;
using System.Collections.Generic;

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         BTree.cs
//	Description:       This class creates and manages a BTree
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Wednesday Apr 17, 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project_5
{
    internal class BTree
    {
        public int count { get; set; }
        public int indexCount { get; set; }
        public int leafCount { get; set; }
        public int nodeSize { get; set; }
        public Node root { get; set; }
        public bool searchLeaf { get; set; }
        public Stack<Node> nodeStack { get; set; }

        #region Constructors

        /// <summary>
        /// Basic no argument constructor
        /// </summary>
        public BTree()
        {
            count = 0;
            indexCount = 0;
            nodeSize = 0;
        }

        /// <summary>
        /// Constructor that takes in an integer
        /// </summary>
        /// <param name="arity">the node side to be set </param>
        public BTree(int arity)
        {
            indexCount = 0;
            count = 0;
            nodeSize = arity;

            nodeStack = new Stack<Node>();
            root = new Index(nodeSize);
            Leaf leaf = new Leaf(nodeSize);

            ((Index)root).Insert(0, leaf);
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// This method adds a value to the BTree, throws an exception if it fails.
        /// </summary>
        /// <param name="inValue">The value that will be added to the tree.</param>
        public void AddValue(int inValue)
        {
            Index index = new Index();
            Leaf leaf = findLeaf(inValue);
            Insert insert = leaf.Insert(inValue);
            int temp;
            bool completed = false;

            try
            {
                if (insert == Insert.DUPLICATE)
                {
                    throw new Exception("Cannot add value");
                }
                else
                {
                    count++;
                    if (insert == Insert.SUCCESS)
                    {
                        nodeStack.Pop();
                        index = (Index)nodeStack.Peek();
                        temp = 0;
                        completed = false;

                        while (completed == false)
                        {
                            if (temp >= index.Indexes.Count)
                            {
                                completed = true;
                            }
                            else if (index.Indexes[temp] == leaf)
                            {
                                index.value[temp] = leaf.value[0];
                            }
                            else
                            {
                                completed = false;
                            }

                            temp++;
                        }
                    }
                    else
                    {
                        splitLeaf(leaf, inValue);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("AddValue failed.");
            }
        }

        /// <summary>
        /// This method displays the entire tree.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Root node:");
            Display(root, 0);
            Console.WriteLine("\n\n" + Stats());
        }

        /// <summary>
        /// This method displays a node
        /// </summary>
        /// <param name="node">node to be displayed</param>
        /// <param name="inNum"></param>
        public void Display(Node node, int inNum)
        {
            int tempIndex;
            Node nodeTemp = new Node();

            try
            {
                Console.WriteLine(node);
                tempIndex = ((Index)node).Indexes.Count;
                inNum++;
                indexCount++;

                Console.WriteLine("Level in the BTree: " + inNum);

                for (int i = 0; i < tempIndex; i++)
                {
                    nodeTemp = ((Index)node).Indexes[i];
                    Display(nodeTemp, inNum);
                }
            }
            catch (Exception)
            {
                leafCount++;
            }
        }

        /// <summary>
        /// returns an integer of the depth
        /// </summary>
        /// <returns>the depth</returns>

        public int findDepth()
        {
            int output = 0;
            Node nodeRoot = root;
            bool loop = true;

            while (loop == true)
            {
                try
                {
                    nodeRoot = ((Index)nodeRoot).Indexes[0];
                    output++;
                }
                catch (Exception)
                {
                    loop = false;
                }
            }

            return output;
        }

        /// <summary>
        /// This method finds an appropriate leaf and returns the leaf object.
        /// </summary>
        /// <param name="inNumLeaf">leaf to look for</param>
        /// <returns>the returning leaf node.</returns>
        public Leaf findLeaf(int inNumLeaf)
        {
            bool loop = true;
            Node searchNode = root;
            Index indexNode = new Index();
            Leaf output = new Leaf();
            int i;

            nodeStack.Clear();
            try
            {
                while (loop == true)
                {
                    if (searchNode is Index)
                    {
                        nodeStack.Push(searchNode);
                        indexNode = (Index)searchNode;

                        i = 1;
                        while (i < indexNode.value.Count && inNumLeaf >= indexNode.value[i])
                        {
                            i++;
                        }
                        searchNode = indexNode.Indexes[(i - 1)];
                        if (searchLeaf == true)
                        {
                            Console.WriteLine(searchNode);
                        }
                        else
                        {
                            searchLeaf = false;
                        }
                    }
                    else
                    {
                        loop = false;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred.");
            }

            nodeStack.Push(searchNode);
            output = (Leaf)searchNode;

            return output;
        }

        /// <summary>
        /// This method checks to see if a value is in the tree
        /// </summary>
        /// <param name="inValue">value to find</param>
        /// <returns>returning result if it is found or not.</returns>
        public bool findValue(int inValue)
        {
            int result = -1;
            bool found;

            searchLeaf = true;
            result = findLeaf(inValue).value.IndexOf(inValue);
            searchLeaf = false;

            try
            {
                if (result > -1 || result < -1)
                {
                    found = true;
                }
                else
                {
                    throw new Exception("not found");
                }
            }
            catch (Exception)
            {
                found = false;
            }

            return found;
        }

        /// <summary>
        /// This method takes in the node to and split and adds the other node passed in and the
        /// new value.
        /// </summary>
        /// <param name="nodeSplit">the node to be split</param>
        /// <param name="nodeAdd">node to be added</param>
        /// <param name="newValue">the new value to be added</param>
        public void splitIndex(Index nodeSplit, Node nodeAdd, int newValue)
        {
            List<Node> listNode = new List<Node>();
            List<int> listInt = new List<int>();
            Index index = new Index(nodeSize);
            Index tempIndex = new Index();
            Insert insert = new Insert();
            int nodeSizeinc = nodeSize + 1;

            listNode.Add(nodeAdd);
            listInt.Add(newValue);

            for (int i = 0; i < nodeSize; i++)
            {
                listNode.Add(nodeSplit.Indexes[i]);
                listInt.Add(nodeSplit.value[i]);
            }

            nodeSplit.Indexes.Clear();
            nodeSplit.value.Clear();
            Sort(listInt, listNode);


            for (int i = 0; i < nodeSizeinc / 2; i++)
            {
                nodeSplit.value.Add(listInt[i]);
                nodeSplit.Indexes.Add(listNode[i]);
            }

            for (int i = nodeSizeinc / 2; i < nodeSizeinc; i++)
            {
                index.value.Add(listInt[i]);
                index.Indexes.Add(listNode[i]);
            }
            try
            {
                if (root == nodeSplit)
                {
                    root = new Index(nodeSize);
                    ((Index)root).Insert(nodeSplit.value[0], nodeSplit);
                    ((Index)root).Insert(index.value[0], index);
                }
                else
                {
                    throw new Exception("root not equal to node split");
                }
            }
            catch (Exception)
            {
                nodeStack.Pop();

                tempIndex = (Index)nodeStack.Peek();
                insert = tempIndex.Insert(index.value[0], index);

                if (insert == Insert.NEEDSPLIT)
                {
                    splitIndex(tempIndex, index, index.value[0]);
                }
            }

        }

        /// <summary>
        /// split at leaf
        /// </summary>
        /// <param name="inLeaf">the leaf passed in</param>
        /// <param name="inNum">the number passed in</param>
        public void splitLeaf(Leaf inLeaf, int inNum)
        {
            Index tempIndex = new Index();
            Insert insert = new Insert();
            Leaf tempLeaf = new Leaf(nodeSize);
            List<int> tempList = new List<int>(inLeaf.value);
            int nodeSize2 = nodeSize / 2;
            int pos = 0;
            inLeaf.value.Clear();
            tempList.Add(inNum);
            tempList.Sort();

            for (int i = 0; i < nodeSize2 + 1; i++)
            {
                inLeaf.value.Add(tempList[i]);
            }
            for (int i = nodeSize2; i < nodeSize + 1; i++)
            {
                tempLeaf.value.Add(tempList[i]);
            }

            nodeStack.Pop();
            tempIndex = (Index)nodeStack.Peek();
            insert = tempIndex.Insert(tempLeaf.value[pos], tempLeaf);

            try
            {
                if (insert == Insert.SUCCESS)
                {
                }
                else if (insert == Insert.DUPLICATE)
                {
                }
                else
                {
                    throw new Exception("insert needs splitting");
                }
            }
            catch (Exception)
            {
                splitIndex(tempIndex, tempLeaf, tempLeaf.value[pos]);
            }
        }

        /// <summary>
        /// returns a string that contains stats about the BTree.
        /// </summary>
        /// <returns>output string</returns>
        public string Stats()
        {
            string output = "The number of Index nodes is : " + indexCount
                + "\nThe number of leaf nodes is: " + leafCount
                + " with an average of " + (leafCount / nodeSize)
                + "% full." + "\nThe depth of the tree is: " + findDepth()
                + "\n" + count + " total number of values in the tree.";

            return output;
        }

        /// <summary>
        /// Appropriately sorts.
        /// </summary>
        /// <param name="inListInt"></param>
        /// <param name="inNodeList"></param>
        private void Sort(List<int> inListInt, List<Node> inListNode)
        {
            Node tempNode = new Node();

            int y = 0;
            int x = 0;

            while (inListInt.Count > y++)
            {
                for (int i = 0; i < inListInt.Count - y; i++)
                {
                    if (inListInt[i] > inListInt[i + 1])
                    {
                        tempNode = inListNode[i];
                        x = inListInt[i];

                        inListInt[i] = inListInt[i + 1];
                        inListInt[i + 1] = x;
                        inListNode[i] = inListNode[i + 1];
                        inListNode[i + 1] = tempNode;
                    }
                }
            }
        }

        #endregion Methods
    }
}