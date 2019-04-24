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
        public int Count { get; set; }
        public int IndexCount { get; set; }
        public int LeafCount { get; set; }
        public int NodeSize { get; set; }
        public Node Root { get; set; }
        public bool SearchLeaf { get; set; }
        public Stack<Node> NodeStack { get; set; }

        #region Constructors

        /// <summary>
        /// Basic no argument constructor
        /// </summary>
        public BTree()
        {
            Count = 0;
            IndexCount = 0;
            NodeSize = 0;
        }

        /// <summary>
        /// Constructor that takes in an integer
        /// </summary>
        /// <param name="arity">the node side to be set </param>
        public BTree(int arity)
        {
            NodeSize = arity;
            IndexCount = 0;
            Count = 0;

            NodeStack = new Stack<Node>();
            Root = new Index(NodeSize);
            Leaf leaf = new Leaf(NodeSize);

            ((Index)Root).Insert(0, leaf);
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
            FindLeaf(inValue, out Leaf leaf, out string throwAway);
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
                    Count++;
                    if (insert == Insert.SUCCESS)
                    {
                        NodeStack.Pop();
                        index = (Index)NodeStack.Peek();
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
                                index.Value[temp] = leaf.Value[0];
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
                        SplitLeaf(leaf, inValue);
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
            output += "Root node:";
            string tempString = "";

            tempString = Display(Root, 0);
            output += "\n" + tempString;

            return output;
        }

        /// <summary>
        /// This method displays a node (index or leaf) and the values that are in them.
        /// </summary>
        /// <param name="node">node to be displayed</param>
        /// <param name="inNum"></param>
        public string Display(Node node, int inNum)
        {
            string output = " ";

            Node nodeTemp = new Node();

            try
            {
                output = node.ToString();
                inNum++;
                if (node is Index)
                {
                    IndexCount++;
                    output += "\nLevel in the BTree: " + inNum;

                    for (int i = 0; i < ((Index)node).Indexes.Count; i++)
                    {
                        if (((Index)node).Indexes[i] != null)
                        {
                            nodeTemp = ((Index)node).Indexes[i];
                            string tempString = Display(nodeTemp, inNum);

                            output += "\n" + tempString;
                        }
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                LeafCount++;
            }

            return output;
        }

        /// <summary>
        /// This method finds a leaf and outputs a leaf and the string
        /// </summary>
        /// <param name="inNumLeaf">in number leaf</param>
        /// <param name="outLeaf">output leaf</param>
        /// <param name="outString">the leaf's string</param>
        public void FindLeaf(int inNumLeaf, out Leaf outLeaf, out string outString)
        {
            bool loop = true;
            Node searchNode = Root;
            Index index = new Index();
            int i;
            outString = "";

            try
            {
                NodeStack.Clear();
                while (loop == true)
                {
                    if (searchNode is Index)
                    {
                        NodeStack.Push(searchNode);
                        index = (Index)searchNode;

                        i = 1;
                        while (i < index.Value.Count && inNumLeaf >= index.Value[i])
                        {
                            i++;
                        }

                        searchNode = index.Indexes[(i - 1)];
                        if (SearchLeaf == true)
                        {
                            outString += (searchNode.ToString() + "\n");
                        }
                        else
                        {
                            SearchLeaf = false;
                        }
                    }
                    else
                    {
                        loop = false;
                    }
                }
                outLeaf = new Leaf();
                NodeStack.Push(searchNode);
            }
            catch (Exception)
            {
                outString += ("An error has occurred.");
            }

            outLeaf = (Leaf)searchNode;
        }

        /// <summary>
        /// this method takes in a value and searches the entire tree using it.
        /// </summary>
        /// <param name="inValue">the value to look for</param>
        /// <param name="outputString"> outputs the nodes visited</param>
        /// <param name="found">outputs a bool is the number is not found</param>

        public void FindValue(int inValue, out string outputString, out bool found)
        {
            int result = -1;
            outputString = "";
            Leaf leaf = new Leaf();

            SearchLeaf = true;
            FindLeaf(inValue, out leaf, out string leafString);
            SearchLeaf = false;

            result = leaf.Value.IndexOf(inValue);

            outputString += leafString;

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
        }

        /// <summary>
        /// This method takes in the node to and split and adds the other node passed in and the
        /// new value.
        /// </summary>
        /// <param name="nodeSplit">the node to be split</param>
        /// <param name="nodeAdd">node to be added</param>
        /// <param name="newValue">the new value to be added</param>
        public void SplitIndex(Index nodeSplit, Node nodeAdd, int newValue)
        {
            List<Node> listNode = new List<Node>();
            List<int> listInt = new List<int>();
            Index index = new Index(NodeSize);
            Index tempIndex = new Index();
            Insert insert = new Insert();
            int pos = 0;
            int nodeSizeinc = NodeSize + 1;

            if (nodeAdd != null)
            {
                listNode.Add(nodeAdd);
                if (nodeAdd != null)
                {
                    if (newValue != 0)
                    {
                        listInt.Add(newValue);

                        for (int i = 0; i < NodeSize; i++)
                        {
                            listNode.Add(nodeSplit.Indexes[i]);
                            listInt.Add(nodeSplit.Value[i]);
                        }

                        if (nodeSplit != null)
                        {
                            nodeSplit.Indexes.Clear();
                            nodeSplit.Value.Clear();
                        }
                    }
                }

                Sort(listInt, listNode);

                for (int i = nodeSizeinc / 2; i < nodeSizeinc; i++)
                {
                    index.Value.Add(listInt[i]);
                    index.Indexes.Add(listNode[i]);
                }
                for (int i = 0; i < nodeSizeinc / 2; i++)
                {
                    nodeSplit.Value.Add(listInt[i]);
                    nodeSplit.Indexes.Add(listNode[i]);
                }
            }
            try
            {
                if (Root == nodeSplit)
                {
                    Root = new Index(NodeSize);
                    ((Index)Root).Insert(index.Value[pos], index);
                    ((Index)Root).Insert(nodeSplit.Value[pos], nodeSplit);
                }
                else
                {
                    throw new Exception("root not equal to node split");
                }
            }
            catch (Exception)
            {
                NodeStack.Pop();

                tempIndex = (Index)NodeStack.Peek();
                insert = tempIndex.Insert(index.Value[pos], index);

                if (insert == Insert.NEEDSPLIT)
                {
                    SplitIndex(tempIndex, index, index.Value[pos]);
                }
            }
        }

        /// <summary>
        /// split at leaf
        /// </summary>
        /// <param name="inLeaf">the leaf passed in</param>
        /// <param name="inNum">the number passed in</param>
        public void SplitLeaf(Leaf inLeaf, int inNum)
        {
            Index tempIndex = new Index();
            Insert insert = new Insert();
            Leaf tempLeaf = new Leaf(NodeSize);
            List<int> tempList = new List<int>(inLeaf.Value);
            int nodeSize2 = NodeSize / 2;
            int pos = 0;
            inLeaf.Value.Clear();
            tempList.Add(inNum);
            tempList.Sort();

            for (int i = 0; i < nodeSize2 + 1; i++)
            {
                inLeaf.Value.Add(tempList[i]);
            }
            for (int i = nodeSize2; i < NodeSize + 1; i++)
            {
                tempLeaf.Value.Add(tempList[i]);
            }

            NodeStack.Pop();
            tempIndex = (Index)NodeStack.Peek();
            insert = tempIndex.Insert(tempLeaf.Value[pos], tempLeaf);

            try
            {
                if (insert == Insert.NEEDSPLIT)
                {
                    throw new Exception("insert needs splitting");
                }
            }
            catch (Exception)
            {
                SplitIndex(tempIndex, tempLeaf, tempLeaf.Value[pos]);
            }
        }

        /// <summary>
        /// returns a string that contains stats about the BTree.
        /// </summary>
        /// <returns>output string</returns>
        public string Stats()
        {
            string output = "The number of Index nodes is : " + IndexCount
                + "\nThe number of leaf nodes is: " + LeafCount
                + " with an average of " + (LeafCount / NodeSize)
                + "% full."
                + "\n" + Count + " total number of values in the tree.";

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