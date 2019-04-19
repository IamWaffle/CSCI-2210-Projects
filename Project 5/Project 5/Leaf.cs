namespace Project_5
{
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
    internal class Leaf : Node
    {
        #region Constructors

        /// <summary>
        /// No arg constructor
        /// </summary>
        public Leaf()
        {
        }

        /// <summary>
        /// constructor that takes in a node size, extends from its base class using polymorphism
        /// </summary>
        /// <param name="nodeSize">The size of the node passed in</param>
        public Leaf(int nodeSize) : base(nodeSize)
        {
        }

        #endregion Constructors

        #region Methods

        public INSERT Insert(int inValue)
        {
            INSERT iNSERT;
            if (base.value.Contains(inValue))
            {
                iNSERT = INSERT.DUPLICATE;
            }
            else if (base.value.Count == base.nodeSize)
            {
                iNSERT = INSERT.NEEDSPLIT;
            }
            else
            {
                base.value.Add(inValue);
                base.value.Sort();
                iNSERT = INSERT.SUCCESS;
            }
            return iNSERT;
        }

        #endregion Methods
    }
}