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
using System;
using System.Collections.Generic;


namespace Project_5_BTree
{
    /// <summary>
    /// This is the main class that handles the B-Tree.
    /// </summary>
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
            string throwAway = "";
            Leaf leaf;
            findLeaf(inValue, out leaf, out throwAway);
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
        /// This method displays the entire tree. Calling another display method to get the index and leaves.
        /// </summary>
        /// <Returns>string output</Returns>
        public string Display()
        {
            string output = "";
            output +="Root node:";
            output += "\n" + Display(root, 0);
            
            return output;
        }

        /// <summary>
        /// This method displays a node (index or leaf) and the values that are in them.
        /// </summary>
        /// <param name="node">node to be displayed</param>
        /// <param name="inNum"></param>
        public string Display(Node node, int inNum)
        {
            int tempIndex;
            Node nodeTemp = new Node();
            string output = " ";

            try
            {
                output += node;
                tempIndex = ((Index)node).Indexes.Count;
                inNum++;
                indexCount++;

                output += "\nLevel in the BTree: " + inNum;

                for (int i = 0; i < tempIndex; i++)
                {
                    nodeTemp = ((Index)node).Indexes[i];
                    output += "\n" + Display(nodeTemp, inNum);
                }
            }
            catch (Exception)
            {
                leafCount++;
            }

            return output;
        }

        /// <summary>
        /// This method finds an appropriate leaf and returns the leaf object.
        /// </summary>
        /// <param name="inNumLeaf">leaf to look for</param>
        /// <returns>the returning leaf node.</returns>
        public void findLeaf(int inNumLeaf, out Leaf outLeaf, out string outString)
        {
            bool loop = true;
            Node searchNode = root;
            Index index = new Index();
            int i;
            outString = "";

            
            try
            {
                nodeStack.Clear();
                while (loop == true)
                {
                    if (searchNode is Index)
                    {
                        nodeStack.Push(searchNode);
                        index = (Index)searchNode;

                        i = 1;
                        while (i < index.value.Count && inNumLeaf >= index.value[i])
                        {
                            i++;
                        }

                        searchNode = index.Indexes[(i - 1)];
                        if (searchLeaf == true)
                        {
                            outString = (searchNode.ToString());
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
                outString += ("An error has occurred.");
            }

            outLeaf = new Leaf();
            nodeStack.Push(searchNode);

            outLeaf = (Leaf)searchNode;


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
            Leaf leaf = new Leaf();
            string throwAway = "";

            findLeaf(inValue, out leaf, out throwAway);

            result = leaf.value.IndexOf(inValue);

            
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
            int pos = 0;
            int nodeSizeinc = nodeSize + 1;

            if (nodeAdd != null)
            {
                listNode.Add(nodeAdd);
                if (nodeAdd != null)
                {
                    if (newValue != 0)
                    {
                        listInt.Add(newValue);

                        for (int i = 0; i < nodeSize; i++)
                        {
                            listNode.Add(nodeSplit.Indexes[i]);
                            listInt.Add(nodeSplit.value[i]);
                        }

                        if (nodeSplit != null)
                        {
                            nodeSplit.Indexes.Clear();
                            nodeSplit.value.Clear();
                        }
                    }
                }

                Sort(listInt, listNode);

                for (int i = nodeSizeinc / 2; i < nodeSizeinc; i++)
                {
                    index.value.Add(listInt[i]);
                    index.Indexes.Add(listNode[i]);
                }
                for (int i = 0; i < nodeSizeinc / 2; i++)
                {
                    nodeSplit.value.Add(listInt[i]);
                    nodeSplit.Indexes.Add(listNode[i]);
                }
            }
            try
            {
                if (root == nodeSplit)
                {
                    root = new Index(nodeSize);
                    ((Index)root).Insert(index.value[pos], index);
                    ((Index)root).Insert(nodeSplit.value[pos], nodeSplit);
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
                insert = tempIndex.Insert(index.value[pos], index);

                if (insert == Insert.NEEDSPLIT)
                {
                    splitIndex(tempIndex, index, index.value[pos]);
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
                if (insert == Insert.NEEDSPLIT)
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
                + "% full."
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

            while (inListInt.Count > y + 1)
            {
                y++;
                for (int i = 0; i < inListInt.Count - y; i++)
                {
                    if (inListInt[i] > inListInt[i + 1])
                    {
                        tempNode = inListNode[i];
                        x = inListInt[i];

                        inListInt[i] = inListInt[i + 1];
                        inListInt[i + 1] = x;
                        inListNode[i + 1] = tempNode;
                        inListNode[i] = inListNode[i + 1];
                        
                    }
                }
            }
        }

        #endregion Methods
    }
}