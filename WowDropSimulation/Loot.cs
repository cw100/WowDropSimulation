using System;
using System.Collections.Generic;
using System.Text;

namespace WowDropSimulation
{
    class Loot
    {
        public Slot slot;
        public List<Spec> specs;
        public int iLevel;
        public bool tier;
       
        public Loot(Slot slot, bool tier)
        {
            this.slot = slot;
            iLevel = 0;
            this.tier = tier;
        }
        public Loot(Slot slot, List<Spec> specs, bool tier)
        {
            this.slot = slot;
            this.specs = specs;
            iLevel = 252;
            this.tier = tier;
        }
        
       

    }
}
