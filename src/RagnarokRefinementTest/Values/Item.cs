using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RagnarokRefinementTest.Values
{
    public class Item
    {
        public RefinementChances RefinementChances { get; }
        public int ItemLevel { get; }
        public bool IsBroke { get; }

        public Item(RefinementChances refinementChances)
        {
            RefinementChances = refinementChances;
        }
    }
}
