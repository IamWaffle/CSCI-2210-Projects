///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:         Leaf.cs
//	Description:       This class creates and manages a leaf
//
//	Course:            CSCI 2210 - Data Structures
//	Author:            Ryan Shupe, shuper@etsu.edu, East Tennessee State University
//	Created:           Wednesday Apr 17, 2019
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace Project_5_BTree
{
    /// <summary>
    /// This is the type leaf that extends off of a node.
    /// </summary>
    internal class Leaf : Node
    {
        private Insert tempInsert;

        #region Constructors

        /// <summary>
        /// No arg constructor
        /// </summary>
        public Leaf()
        {
            tempInsert = new Insert();
        }

        /// <summary>
        /// constructor that takes in a node size, extends from its base class using polymorphism
        /// </summary>
        /// <param name="nodeSize">The size of the node passed in</param>
        public Leaf(int nodeSize) : base(nodeSize)
        {
            tempInsert = new Insert();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// returns an insert value
        /// </summary>
        /// <param name="inValue"></param>
        /// <returns>the returning insert value.</returns>
        public Insert Insert(int inValue)
        {
            try
            {
                if (base.value.Count == base.nodeSize)
                {
                    tempInsert = Project_5_BTree.Insert.NEEDSPLIT;
                }
                else if (base.value.Contains(inValue))
                {
                    tempInsert = Project_5_BTree.Insert.DUPLICATE;
                }
                else
                {
                    throw new Exception("Success");
                }
            }
            catch (Exception)
            {
                tempInsert = Project_5_BTree.Insert.SUCCESS;
                base.value.Add(inValue);
                base.value.Sort();
            }
            return tempInsert;
        }

        #endregion Methods
    }
}