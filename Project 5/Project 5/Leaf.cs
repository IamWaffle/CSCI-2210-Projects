namespace Project_5
{
    internal class Leaf : Node
    {
        public Leaf()
        {
        }

        public Leaf(int nodeSize) : base(nodeSize)
        {
        }

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
    }
}