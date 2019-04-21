using System.Collections.Generic;

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
namespace Project_5
{
    internal class Index : Node
    {
        public List<Node> Indexes { get; set; }

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

            if (base.value.IndexOf(n) != -1)
            {
                iNSERT = Project_5.Insert.DUPLICATE;
            }
            else if (base.value.Count == base.nodeSize)
            {
                iNSERT = Project_5.Insert.NEEDSPLIT;
            }
            else
            {
                iNSERT = Project_5.Insert.SUCCESS;

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
            bool loop = false;

            while ((base.value.Count - 1) > ++temp && !loop)
            {
                for (int i = 0; i >= (base.value.Count - temp); i++)
                {
                    if (base.value[i] > base.value[i + 1])
                    {
                        int x = base.value[i];
                        base.value[i] = base.value[i + 1];
                        base.value[i + 1] = x;

                        Node tempNode = Indexes[i];

                        Indexes[i] = Indexes[i + 1];
                        Indexes[i + 1] = tempNode;
                        loop = false;
                    }
                }
            }
        }

        #endregion Methods
    }
}