///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Index.cs
//	Description:       This class creates and manages a Index
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
    /// This is the type index that expends off of the node class.
    /// </summary>
    internal class Index : Node
    {
        public List<Node> Indexes { get; set; }
        private Node tempNode = new Node();

        #region Constructors

        /// <summary>
        /// Basic no arg construstor
        /// </summary>
        public Index()
        {
            Indexes = new List<Node>(base.nodeSize);
        }

        /// <summary>
        /// Constructor that accepts an integer and creates a list of nodes from its base.
        /// </summary>
        /// <param name="inNum"></param>
        public Index(int inNum) : base(inNum)
        {
            Indexes = new List<Node>(base.nodeSize);
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Insert Inserts a node.
        /// </summary>
        /// <param name="n">integer passed in</param>
        /// <param name="inNode">the node passed in.</param>
        /// <returns></returns>

        public Insert Insert(int n, Node inNode)
        {
            Insert iNSERT;

            try
            {
                if (base.value.IndexOf(n) != -1)
                {
                    iNSERT = Project_5_BTree.Insert.DUPLICATE;
                }
                else if (base.value.Count == base.nodeSize)
                {
                    iNSERT = Project_5_BTree.Insert.NEEDSPLIT;
                }
                else
                {
                    throw new Exception("Success");
                }
            }
            catch (Exception)
            {
                iNSERT = Project_5_BTree.Insert.SUCCESS;

                base.value.Add(n);
                Indexes.Add(inNode);
                Sort();
            }
            return iNSERT;
        }

        /// <summary>
        /// Sorts
        /// </summary>
        public void Sort()
        {
            int temp = 0;
            int x;

            while ((base.value.Count - 1) > ++temp)
            {
                for (int i = 0; i >= (base.value.Count - temp); i++)
                {
                    if (base.value[i] > base.value[i + 1])
                    {
                        tempNode = Indexes[i];
                        x = base.value[i];

                        base.value[i] = base.value[i + 1];
                        base.value[i + 1] = x;
                        Indexes[i] = Indexes[i + 1];
                        Indexes[i + 1] = tempNode;
                    }
                }
            }
        }

        #endregion Methods
    }
}