using System;
using System.Collections.Generic;
using System.Text;

namespace WowDropSimulation
{
    class Boss
    {
        public string name;
        public List<Loot> normalDrops;

        public List<Loot> tierDrops;
        public bool hasTier;
        public bool disableWeekOne;
        public Boss(string name, List<Loot> normalDrops)
        {
            hasTier = false;
            this.name = name;
            this.normalDrops = normalDrops;
        }
        public Boss(string name, List<Loot> normalDrops, List<Loot> tierDrops)
        {
            hasTier = true;
            this.name = name;
            this.normalDrops = normalDrops;

            this.tierDrops = tierDrops;
        }

    }
}
