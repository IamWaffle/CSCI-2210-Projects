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
        public Stack<Node> stack { get; set; }
        public bool Trace { get; set; }

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

            stack = new Stack<Node>();
            root = new Index(nodeSize);
            Leaf leaf = new Leaf(nodeSize);

            ((Index)root).Insert(0, leaf);
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// This method adds a value to the BTree
        /// </summary>
        /// <param name="inValue">The value that will be added to the tree.</param>
        /// <returns>bool that says if the operation is successful</returns>
        public bool AddValue(int inValue)
        {
            Index index = new Index();
            Leaf leaf = findLeaf(inValue);
            Insert insert = leaf.Insert(inValue);
            int temp;
            bool completed = false; ;

            if (insert == Insert.DUPLICATE)
            {
                completed = false;
            }
            else
            {
                count++;
                if (insert != Insert.SUCCESS)
                {
                    splitLeaf(leaf, inValue);
                    completed = true;
                }
                else
                {
                    stack.Pop();
                    index = (Index)stack.Peek();

                    temp = 0;

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

                        temp++;
                    }
                }
            }
            return completed;
        }

        /// <summary>
        /// This method displays the entire tree.
        /// </summary>
        public void Display()
        {
            leafCount = 0;
            indexCount = 0;

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
            int tempIndex = ((Index)node).Indexes.Count;
            Node nodeTemp = new Node();
            Console.WriteLine(node);

            if (node is Index)
            {
                inNum++;
                indexCount++;

                Console.WriteLine("Level in the BTree: " + inNum);

                for (int i = 0; i < tempIndex; i++)
                {
                    nodeTemp = ((Index)node).Indexes[i];
                    Display(nodeTemp, inNum);
                }
            }
            else
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
            int temp = 0;
            Node nodeRoot = root;
            bool loop = true;

            while (loop == true)
            {
                if (nodeRoot is Index)
                {
                    nodeRoot = ((Index)nodeRoot).Indexes[0];
                    temp++;
                }
                else
                {
                    loop = false;
                }
            }

            return temp;
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

            stack.Clear();

            while (loop == true)
            {
                if (searchNode is Index)
                {
                    stack.Push(searchNode);
                    indexNode = (Index)searchNode;

                    for (i = 1; i < indexNode.value.Count && inNumLeaf >= indexNode.value[i]; i++) ;
                    searchNode = indexNode.Indexes[i - 1];

                    if (Trace == true)
                    {
                        Console.WriteLine(searchNode);
                    }
                }
                else
                {
                    loop = false;
                }
            }

            stack.Push(searchNode);
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

            Trace = true;
            result = findLeaf(inValue).value.IndexOf(inValue);
            Trace = false;

            if (result != -1)
            {
                found = true;
            }
            else
            {
                found = false;
            }

            return found;
        }

        /// <summary>
        /// This method takes in the node to nb split and adds the other node passed in and the
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

            Sort(listInt, listNode);
            nodeSplit.Indexes.Clear();
            nodeSplit.value.Clear();

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

            if (root == nodeSplit)
            {
                root = new Index(nodeSize);
                ((Index)root).Insert(nodeSplit.value[0], nodeSplit);
                ((Index)root).Insert(index.value[0], index);
            }
            else
            {
                stack.Pop();

                tempIndex = (Index)stack.Peek();
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

            tempList.Add(inNum);
            tempList.Sort();

            inLeaf.value.Clear();

            for (int i = 0; i < (nodeSize + 1) / 2; i++)
            {
                inLeaf.value.Add(tempList[i]);
            }
            for (int i = nodeSize / 2; i < nodeSize + 1; i++)
            {
                tempLeaf.value.Add(tempList[i]);
            }
            stack.Pop();
            tempIndex = (Index)stack.Peek();
            insert = tempIndex.Insert(tempLeaf.value[0], tempLeaf);
            if (insert == Insert.NEEDSPLIT)
            {
                splitIndex(tempIndex, tempLeaf, tempLeaf.value[0]);
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
                + "\nThe total number of values in the tree is: " + count;

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
            bool sorted = false;
            int y = 0;
            int x;

            while (inListInt.Count > y++ && !sorted)
            {
                for (int i = 0; i < inListInt.Count - y; i++)
                {
                    if (inListInt[i] > inListInt[i + 1])
                    {
                        x = inListInt[i];
                        inListInt[i] = inListInt[i + 1];
                        inListInt[i + 1] = x;

                        tempNode = inListNode[i];

                        inListNode[i] = inListNode[i + 1];
                        inListNode[i + 1] = tempNode;

                        sorted = false;
                    }
                }

                sorted = true;
            }
        }

        #endregion Methods
    }
}