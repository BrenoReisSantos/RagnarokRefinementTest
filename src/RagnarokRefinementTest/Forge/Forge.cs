using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RagnarokRefinementTest.Values;

namespace RagnarokRefinementTest.Forge
{
    public class Forge
    {
        public Item RefiningItem { get; }

        public Forge(Item item)
        {
            RefiningItem = item;
        }
    }
}
