using System;
using System.Collections.Generic;
using System.Text;

namespace WowDropSimulation
{
    class Player
    { 

         public string name;
           public Spec spec;
       
        public Dictionary<Slot, Loot> equipment;
        public int setNum;
        public Player(Spec spec,List<Slot> slots, string name)
        {
            setNum = 0;
            this.spec = spec;
            this.name = name;
            
            equipment = new Dictionary<Slot, Loot>() ;
            foreach (Slot slot in slots)
            {
                Loot loot = new Loot(slot,false);
                equipment.Add(loot.slot, loot);
            }
        }
        public bool GiveLoot(Loot loot)
        {
        
            if (loot.tier == true && equipment[loot.slot].tier == true)
            {

                if (equipment[loot.slot].iLevel < loot.iLevel)
                {
                    
                    equipment[loot.slot] = loot;
                    return true;

                }
                return false;
            }
            
            if (equipment[loot.slot].iLevel>=loot.iLevel && loot.tier == false)
            {
                return false;

            }
            equipment[loot.slot] = loot;
            if(loot.tier)
            {
                setNum++;
            }
            return true;
        }
        public bool CanTrade(Loot loot)
        {
            if (equipment[loot.slot].iLevel >= loot.iLevel && loot.tier == false)
            {
                return true;
            }
            if (equipment[loot.slot].iLevel >= loot.iLevel && loot.tier == true && equipment[loot.slot].tier == true)
            {
                return true;
            }
            if (equipment[loot.slot].iLevel >= loot.iLevel )
            {
                return true;
            }
            return false;
        }
      }
}
