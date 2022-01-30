using System;
using System.Collections.Generic;
using System.Text;
namespace WowDropSimulation
{
    class Program
    {
        static List<Player> players;
       
        static List<Boss> bosses;
        static void Main(string[] args)
        {

            Spec fireMage = new Spec("Mage", "Fire");
            Spec arcaneMage = new Spec("Mage", "Arcane");
            Spec frostMage = new Spec("Mage", "Frost");

            Spec bloodDK = new Spec("Death Knight", "Blood");
            Spec frostDK = new Spec("Death Knight", "Frost");
            Spec unholyDK = new Spec("Death Knight", "Unholy");

            Spec havocDH = new Spec("Demon Hunter", "Havoc");
            Spec vengeanceDH = new Spec("Demon Hunter", "Vengeance");

            Spec balanceDruid = new Spec("Druid", "Balance");
            Spec feralDruid = new Spec("Druid", "Feral");
            Spec guardianDruid = new Spec("Druid", "Guardian");
            Spec restorationDruid = new Spec("Druid", "Restoration");

            Spec bmHunter = new Spec("Hunter", "Beast Mastery");
            Spec marksmanshipHunter = new Spec("Hunter", "Marksmanship");
            Spec survivalHunter = new Spec("Hunter", "Survival");

            Spec brewmasterMonk = new Spec("Monk", "Brewmaster");
            Spec mistweaverMonk = new Spec("Monk", "Mistweaver");
            Spec windwalkerMonk = new Spec("Monk", "Windwalker");

            Spec holyPaladin = new Spec("Paladin", "Holy");
            Spec protectionPaladin = new Spec("Paladin", "Protection");
            Spec retributionPaladin = new Spec("Paladin", "Retribution");

            Spec disciplinePriest = new Spec("Priest", "Discipline");
            Spec holyPriest = new Spec("Priest", "Holy");
            Spec shadowPriest = new Spec("Priest", "Shadow");

            Spec assassinationRogue = new Spec("Rogue", "Assassination");
            Spec outlawRogue = new Spec("Rogue", "Outlaw");
            Spec subtletyRogue = new Spec("Rogue", "Subtlety");

            Spec elementalShaman = new Spec("Shaman", "Elemental");
            Spec enhancementShaman = new Spec("Shaman", "Enhancement");
            Spec restorationShaman = new Spec("Shaman", "Restoration");

            Spec afflictionWarlock = new Spec("Warlock", "Affliction");
            Spec demonologyWarlock = new Spec("Warlock", "Demonology");
            Spec destructionWarlock = new Spec("Warlock", "Destruction");

            Spec armsWarrior = new Spec("Warrior", "Arms");
            Spec furyWarrior = new Spec("Warrior", "Fury");
            Spec protectionWarrior = new Spec("Warrior", "Destruction");



            List<Spec> conqueror = new List<Spec> {
            afflictionWarlock, demonologyWarlock, destructionWarlock,
            disciplinePriest,holyPriest,shadowPriest,
            havocDH,vengeanceDH,
            holyPaladin,protectionPaladin,retributionPaladin};

            List<Spec> protector = new List<Spec> {
            brewmasterMonk,mistweaverMonk,windwalkerMonk,
            elementalShaman,enhancementShaman,restorationShaman,
            bmHunter,marksmanshipHunter,survivalHunter,
            armsWarrior,furyWarrior,protectionWarrior};


            List<Spec> vanquisher = new List<Spec> {
            fireMage, arcaneMage, frostMage,
            assassinationRogue, outlawRogue, subtletyRogue,
            balanceDruid,feralDruid,guardianDruid,restorationDruid,
            bloodDK,frostDK,unholyDK};

            List<Spec> everyone = new List<Spec> {
            fireMage, arcaneMage, frostMage,
            afflictionWarlock, demonologyWarlock, destructionWarlock,
            disciplinePriest,holyPriest,shadowPriest,
            assassinationRogue, outlawRogue, subtletyRogue,
            brewmasterMonk,mistweaverMonk,windwalkerMonk,
            havocDH,vengeanceDH,
            balanceDruid,feralDruid,guardianDruid,restorationDruid,
            elementalShaman,enhancementShaman,restorationShaman,
            bmHunter,marksmanshipHunter,survivalHunter,
            bloodDK,frostDK,unholyDK,
            armsWarrior,furyWarrior,protectionWarrior,
            holyPaladin,protectionPaladin,retributionPaladin};

            List<Spec> cloth = new List<Spec> { 
            fireMage, arcaneMage, frostMage,
            afflictionWarlock, demonologyWarlock, destructionWarlock,
            disciplinePriest,holyPriest,shadowPriest};

            List<Spec> leather = new List<Spec> {
            assassinationRogue, outlawRogue, subtletyRogue,
            brewmasterMonk,mistweaverMonk,windwalkerMonk,
            havocDH,vengeanceDH,
            balanceDruid,feralDruid,guardianDruid,restorationDruid};

            List<Spec> mail = new List<Spec> {
            elementalShaman,enhancementShaman,restorationShaman,
            bmHunter,marksmanshipHunter,survivalHunter};

            List<Spec> plate = new List<Spec> {
            bloodDK,frostDK,unholyDK,
            armsWarrior,furyWarrior,protectionWarrior,
            holyPaladin,protectionPaladin,retributionPaladin};

            List<Spec> intShield = new List<Spec>
            {holyPaladin,
            elementalShaman,restorationShaman};

            List<Spec> shield = new List<Spec>
            {holyPaladin,protectionPaladin,
            protectionWarrior,
            elementalShaman,restorationShaman};

            List<Spec> oneHandMaceAgility = new List<Spec>
            {outlawRogue,
            enhancementShaman,
            brewmasterMonk,windwalkerMonk};

            List<Spec> oneHandAxeAgility = new List<Spec>
            {outlawRogue,
            enhancementShaman,
            brewmasterMonk,windwalkerMonk,
            havocDH,vengeanceDH};

            List<Spec> healers = new List<Spec>
            {restorationDruid,
            restorationShaman,
            holyPriest,shadowPriest,
            holyPaladin,
            mistweaverMonk};

            List<Spec> tanks = new List<Spec>
            {protectionPaladin,
            vengeanceDH,
            guardianDruid,
            bloodDK,
            protectionWarrior,
            vengeanceDH};

            List<Spec> intDps = new List<Spec>
            {fireMage, arcaneMage, frostMage,
            afflictionWarlock, demonologyWarlock, destructionWarlock,
            shadowPriest,
            balanceDruid,
            elementalShaman};
          
            List<Spec> rangedDps = new List<Spec>
            {fireMage, arcaneMage, frostMage,
            afflictionWarlock, demonologyWarlock, destructionWarlock,
            shadowPriest,
            bmHunter,marksmanshipHunter};

            List<Spec> agistrTrinkets = new List<Spec>
            {assassinationRogue, outlawRogue, subtletyRogue,
            brewmasterMonk,windwalkerMonk,
            havocDH,vengeanceDH,
            feralDruid,guardianDruid,
            enhancementShaman,
            bmHunter,marksmanshipHunter,survivalHunter,
            bloodDK,frostDK,unholyDK,
            armsWarrior,furyWarrior,protectionWarrior,
            protectionPaladin,retributionPaladin};

            List<Spec> strTrinkets = new List<Spec>
            {
            bloodDK,frostDK,unholyDK,
            armsWarrior,furyWarrior,protectionWarrior,
            protectionPaladin,retributionPaladin};


            List<Spec> oneHandedIntSword = new List<Spec>
            {fireMage, arcaneMage, frostMage,
            afflictionWarlock, demonologyWarlock, destructionWarlock,
            holyPaladin,
            mistweaverMonk};

            List<Spec> intStaff = new List<Spec> {
            fireMage, arcaneMage, frostMage,
            afflictionWarlock, demonologyWarlock, destructionWarlock,
            disciplinePriest,holyPriest,shadowPriest,
            mistweaverMonk,          
            balanceDruid,restorationDruid,
            elementalShaman,restorationShaman};

            List<Spec> intDaggers = new List<Spec> {
            fireMage, arcaneMage, frostMage,
            afflictionWarlock, demonologyWarlock, destructionWarlock,
            disciplinePriest,holyPriest,shadowPriest,
            balanceDruid,restorationDruid,
            elementalShaman,restorationShaman};

            List<Spec> intOffhand = new List<Spec> {
            fireMage, arcaneMage, frostMage,
            afflictionWarlock, demonologyWarlock, destructionWarlock,
            disciplinePriest,holyPriest,shadowPriest,
            mistweaverMonk,
            balanceDruid,restorationDruid,
            elementalShaman,restorationShaman,
            holyPaladin};

            List<Spec> oneHandedStrSword = new List<Spec>
            {bloodDK,
            furyWarrior,protectionWarrior,
            retributionPaladin};

            List<Spec> oneHandedStrAxe = new List<Spec>
            {frostDK,
            furyWarrior,protectionWarrior,
            protectionPaladin};

            List<Spec> agiTrinkets = new List<Spec>
            {assassinationRogue, outlawRogue, subtletyRogue,
            brewmasterMonk,windwalkerMonk,
            havocDH,vengeanceDH,
            feralDruid,
            enhancementShaman,
            bmHunter,marksmanshipHunter,survivalHunter};


            List<Spec> agiStaff = new List<Spec>
            {
            brewmasterMonk,windwalkerMonk,
 
            feralDruid,guardianDruid,
            survivalHunter};

            List<Spec> twoHandedMace = new List<Spec>
            {bloodDK,frostDK,unholyDK,
            armsWarrior,furyWarrior,
            retributionPaladin};

            List<Spec> twoHandedSword = new List<Spec>
            {bloodDK,frostDK,unholyDK,
            armsWarrior,furyWarrior,
            retributionPaladin};

            List<Spec> agiDagger = new List<Spec>
            { assassinationRogue, subtletyRogue};

            List<Spec> fistWeapon = new List<Spec>
            {outlawRogue,
            enhancementShaman,
            brewmasterMonk,windwalkerMonk,
            havocDH,vengeanceDH};

            List<Spec> demonHunters = new List<Spec>
            {
            havocDH,vengeanceDH};

            List<Spec> rangedHunter = new List<Spec>
            {bmHunter,marksmanshipHunter};

            List<Spec> dk = new List<Spec>
            {bloodDK,frostDK,unholyDK};
            List<Spec> priest = new List<Spec>
            {disciplinePriest,holyPriest,shadowPriest};

            Slot head = new Slot("Head");

            Slot shoulders = new Slot("Shoulders");

            Slot chest = new Slot("Chest");

            Slot wrist = new Slot("Wrist");

            Slot hands = new Slot("Hands");

            Slot waist = new Slot("Waist");

            Slot legs = new Slot("Legs");

            Slot feet = new Slot("Feet");

            Slot neck = new Slot("Neck");

            Slot back = new Slot("Back");

            Slot finger = new Slot("Finger");

            Slot trinket = new Slot("Trinket");


            Slot mainHand = new Slot("MainHand");

            Slot offHand = new Slot("OffHand");

            List<Slot> slots = new List<Slot> { head, shoulders, chest, wrist, hands, waist, legs, feet , neck , back, finger, trinket, mainHand, offHand };

          

            List<Loot> vigilantGuardianLoot = new List<Loot> { new Loot(chest,leather,false),
            new Loot(feet,cloth,false),
            new Loot(finger,everyone,false),
            new Loot(hands,plate,false),
            new Loot(head,mail,false),
            new Loot(legs,cloth,false),
            new Loot(legs,plate,false),
            new Loot(mainHand,oneHandMaceAgility,false),
            new Loot(offHand,shield,false),
            new Loot(trinket,healers,false),
            new Loot(waist,mail,false)
            };

            Boss vigilantGuardian = new Boss("Vigilant Guardian", vigilantGuardianLoot);

            List<Loot> skolexLoot = new List<Loot> {
            new Loot(offHand, shield, false),
            new Loot(trinket, agistrTrinkets, false),
            new Loot(mainHand, agiDagger, false),
            new Loot(wrist, leather, false),
            new Loot(mainHand, fistWeapon, false),
            new Loot(shoulders,cloth,false),
            new Loot(shoulders,plate,false),
            new Loot(waist,leather,false),
            new Loot(back,everyone,false),
            new Loot(shoulders,mail,false),
            new Loot(mainHand,twoHandedMace,false),
            new Loot(wrist,cloth,false)
            };

            Boss skolex = new Boss("Skolex", skolexLoot);


            List<Loot> artificerLoot = new List<Loot> {
            new Loot(trinket, agiTrinkets, false),
            new Loot(neck, everyone, false),
            new Loot(wrist, plate, false),
            new Loot(mainHand, oneHandedStrSword, false),
            new Loot(waist, cloth, false),
            new Loot(shoulders, leather, false),

            new Loot(trinket, agistrTrinkets, false),
            new Loot(mainHand, oneHandedIntSword, false),
            new Loot(feet, cloth, false),

            new Loot(hands, mail, false),

            new Loot(wrist, plate, false),
            new Loot(wrist, rangedHunter, false)

            };

            Boss artificer = new Boss("Xy'mox", artificerLoot);


            List<Loot> dausegneLoot = new List<Loot> {
            new Loot(back, everyone, false),
           new Loot(chest, cloth, false),
           new Loot(chest, mail, false),

           new Loot(feet, plate, false),

           new Loot(head, plate, false),

           new Loot(mainHand, oneHandedStrSword, false),

           new Loot(mainHand, oneHandAxeAgility, false),

           new Loot(mainHand, rangedHunter, false),

           new Loot(shoulders,leather, false),

           new Loot(trinket,intDps, false),

           new Loot(waist,leather, false),

           new Loot(waist,cloth, false)
            };


            Boss dausegne = new Boss("Dausegne", dausegneLoot);

            List<Loot> prototypeLoot = new List<Loot> {
            new Loot(chest, plate, false),
             new Loot(feet, cloth, false),
               new Loot(feet, leather, false),
                 new Loot(feet, mail, false),

                 new Loot(head, leather, false),


                 new Loot(trinket, everyone, false),
                 new Loot(trinket, everyone, false),

                 new Loot(mainHand, agiStaff, false),

                 new Loot(mainHand, twoHandedSword, false),

                 new Loot(mainHand, intStaff, false),
                 new Loot(wrist, mail, false)
            };


            Boss prototype = new Boss("Prototype Pantheon", prototypeLoot);


            List<Loot> lihuvimLoot = new List<Loot> {
            new Loot(finger, everyone, false),
            new Loot(head, cloth, false),
            new Loot(legs, leather, false),
            new Loot(mainHand, healers, false),

            new Loot(mainHand, agiDagger, false),

            new Loot(trinket, intDps, false),
             new Loot(trinket, agistrTrinkets, false),

             new Loot(waist, mail, false),

             new Loot(wrist, plate, false)
            };
            List<Loot> lihuvimTierLoot = new List<Loot> {
                new Loot(hands,conqueror,true),
                new Loot(hands,vanquisher,true),
                new Loot(hands,protector,true)
            };

            Boss lihuvim = new Boss("Lihuvim", lihuvimLoot, lihuvimTierLoot);


            List<Loot> halondrusLoot = new List<Loot> {
            new Loot(feet, mail, false),
            new Loot(feet, plate, false),
            new Loot(finger, everyone, false),
            new Loot(offHand, intOffhand, false),
            new Loot(offHand, intOffhand, false),

            new Loot(mainHand, oneHandedStrAxe, false),

            new Loot(trinket, agistrTrinkets, false),

            new Loot(trinket, healers, false),

            new Loot(mainHand, intStaff, false)

            };
            List<Loot> halondrusTierLoot = new List<Loot> {
                new Loot(legs,conqueror,true),
                new Loot(legs,vanquisher,true),
                new Loot(legs,protector,true)
            };

            Boss halondrus = new Boss("Halondrus", halondrusLoot, halondrusTierLoot);

           


            List<Loot> anduinLoot = new List<Loot> { 
                new Loot(chest,cloth,false),
                new Loot(finger,dk,false),
                new Loot(finger,priest,false),
                new Loot(neck,everyone,false),
                new Loot(trinket,healers,false),
                new Loot(waist,mail,false),
                new Loot(waist,plate,false),
                new Loot(wrist,leather,false)
            };

            List<Loot> anduinTierLoot = new List<Loot> {

                new Loot(head,conqueror,true),
                new Loot(head,vanquisher,true),
                new Loot(head,protector,true)

            };
            Boss anduin = new Boss("Anduin", anduinLoot,anduinTierLoot);
           
            List<Loot> dreadlordsLoot = new List<Loot> {
            new Loot(wrist, cloth, false),
           new Loot(trinket, strTrinkets , false),
             new Loot(trinket, agistrTrinkets , false),
             new Loot(offHand, shield , false),
              new Loot(mainHand, shield , false),
              new Loot(mainHand, demonHunters , false),
              new Loot(hands, mail , false),
              new Loot(hands, leather , false),
              new Loot(back, everyone , false)
            };
            List<Loot> dreadlordsTierLoot = new List<Loot> {
                new Loot(shoulders,conqueror,true),
                new Loot(shoulders,vanquisher,true),
                new Loot(shoulders,protector,true)
            };

            Boss dreadlords = new Boss("Dreadlords", dreadlordsLoot, dreadlordsTierLoot);
            dreadlords.disableWeekOne = true;

            List<Loot> rygelonLoot = new List<Loot> {
            new Loot(feet, leather, false),
            new Loot(finger, everyone, false),
            new Loot(hands, plate, false),

            new Loot(mainHand, intDaggers, false),

            new Loot(mainHand, oneHandedStrSword, false),

            new Loot(mainHand, rangedHunter, false),

            new Loot(trinket, intDps, false),

            new Loot(wrist, mail, false)
            };
            List<Loot> rygelonTierLoot = new List<Loot> {
                new Loot(chest,conqueror,true),
                new Loot(chest,vanquisher,true),
                new Loot(chest,protector,true)
            };

            Boss rygelon = new Boss("Rygelon", rygelonLoot, rygelonTierLoot);
            rygelon.disableWeekOne = true;
            List<Loot> jailerLoot = new List<Loot> {
            new Loot(hands, cloth, false),
            new Loot(offHand, intOffhand, false),
            new Loot(legs, mail, false),
            new Loot(neck, everyone, false),
            new Loot(trinket, agistrTrinkets, false),
            new Loot(trinket, everyone, false),
            new Loot(mainHand, twoHandedMace, false),

            new Loot(mainHand, agiStaff, false),

            new Loot(waist, leather, false)
            };
           

            Boss jailer = new Boss("Jailer", jailerLoot);
            jailer.disableWeekOne = true;
            bosses = new List<Boss> { vigilantGuardian,skolex,artificer,halondrus,dausegne,prototype,lihuvim, anduin ,dreadlords,rygelon,jailer};

            Random rng = new Random();
            int normalDropNum = 4;
            int tierDropNum = 2;
            int numberOfWeeks = 1;
            for( int n = numberOfWeeks; numberOfWeeks < 8; numberOfWeeks++)
            { 
           
                double amountOfFourSets = 0;
                double amountOfTwoSets = 0;

                double amountOfZeroSets = 0;
                for (int i = 0; i < 10000; i++)
                {
                    Player cdw = new Player(frostMage, slots, "cdw");
                    Player bunnys = new Player(unholyDK, slots, "bunnys");
                    Player goldenglory = new Player(restorationShaman, slots, "goldenglory");
                    Player xantoos = new Player(holyPaladin, slots, "xantoos");
                    Player holykow = new Player(balanceDruid, slots, "holykow");
                    Player octopi = new Player(havocDH, slots, "octopi");
                    Player aryl = new Player(balanceDruid, slots, "aryl");
                    Player merenth = new Player(frostDK, slots, "merenth");

                    Player figtree = new Player(marksmanshipHunter, slots, "figtree");
                    Player casoly = new Player(balanceDruid, slots, "casoly");
                    Player ming = new Player(assassinationRogue, slots, "ming");
                    Player llandrelina = new Player(frostMage, slots, "llandrelina");
                    Player lixou = new Player(destructionWarlock, slots, "lixou");
                    Player gpriest = new Player(shadowPriest, slots, "gpriest");
                    Player based = new Player(brewmasterMonk, slots, "based");
                    Player sunnier = new Player(bmHunter, slots, "sunnier");

                    Player kirliana = new Player(protectionWarrior, slots, "kirliana");

                    Player anatís = new Player(holyPriest, slots, "anatís");

                    Player mituharu = new Player(restorationShaman, slots, "mituharu");

                    Player soul = new Player(armsWarrior, slots, "soul");
                    players = new List<Player> { cdw, bunnys, goldenglory, xantoos, holykow, octopi, aryl, merenth, figtree, casoly, ming, llandrelina, lixou, gpriest, based, sunnier, kirliana, anatís, mituharu, soul };


                    RunSim(0, true);
                    RunSim(13, true);
                    RunVault(0, true);
                    for (int j = 0; j < numberOfWeeks-1; j++)
                    {
                        RunSim(13, false);
                      
                          RunSim(0, false);
                        

                       
                        
                        RunVault(13, false);
                    }

                   

                    

                    foreach (Player player in players)
                    {
                        if (player.setNum >= 4)
                        {
                            amountOfFourSets++;
                        }
                        if (player.setNum < 4 && player.setNum >=2)
                        {
                            amountOfTwoSets++;
                        }
                        if (player.setNum < 2)
                        {
                            amountOfZeroSets++;
                        }
                    }

                }
                Console.WriteLine("After week " + numberOfWeeks);

                Console.WriteLine("Number of 4 set: " + amountOfFourSets / 10000);
                Console.WriteLine("Number of 2 set: "+ amountOfTwoSets / 10000);

                Console.WriteLine("Number of 0 set: " + amountOfZeroSets / 10000);

            }
            Console.ReadKey();
        }
        static void RunVault(int offset, bool weekOne)
        {
            List<Boss> tempBosses = new List<Boss>(bosses);
            foreach (Boss boss in tempBosses)
            {
                foreach (Loot loot in boss.normalDrops)
                {
                    loot.iLevel += offset;
                }
                if (boss.tierDrops != null)
                {
                    foreach (Loot loot in boss.tierDrops)
                    {
                        loot.iLevel += offset;
                    }
                }
            }
            
            List<Loot> lootList = new List<Loot>();
            foreach (Boss boss in tempBosses)
            {
                foreach (Loot loot in boss.normalDrops)
                {
                    lootList.Add(loot);
                }
                if (boss.tierDrops != null)
                {
                    foreach (Loot loot in boss.tierDrops)
                    {
                        lootList.Add(loot);
                    }
                }
            }
            Random rng = new Random();
            int vaultLootNum = 2;
            if(weekOne)
            {
                vaultLootNum = 1;
            }
            foreach (Player player in players)
            {
                List<Loot> tempLootList = new List<Loot>(lootList);
                
                List<Loot> lootListToChoose = new List<Loot>();
                for (int i = 0; i < vaultLootNum; i++)
                {
                    int lootRoll = rng.Next(0, lootList.Count);
                    lootListToChoose.Add(lootList[lootRoll]);
                    lootList.RemoveAt(lootRoll);
                }
                Loot bestLoot = lootListToChoose[0];
                foreach (Loot loot in lootListToChoose)
                {
                    if (loot.tier && player.equipment[loot.slot].tier ==false)
                    {
                        if(bestLoot.tier ==true)
                        {
                            if(bestLoot.iLevel>loot.iLevel)
                            {
                                bestLoot = loot;
                            }
                        }
                        else
                        {
                            bestLoot = loot;
                        }
                        
                    }
                    else
                    {
                        if(loot.iLevel>bestLoot.iLevel && bestLoot.tier ==false)
                        {
                            bestLoot = loot;
                        }
                    }
                }
                player.GiveLoot(bestLoot);
            }
        }
        static void RunSim(int offset, bool weekOne)
        {
            List<Boss> tempBosses = new List<Boss>(bosses);
            foreach (Boss boss in tempBosses)
            {
                foreach(Loot loot in boss.normalDrops)
                {
                    loot.iLevel += offset;
                }
                if (boss.tierDrops != null)
                {
                    foreach (Loot loot in boss.tierDrops)
                    {
                        loot.iLevel += offset;
                    }
                }
            }

                int normalDropNum = 4;
            int tierDropNum = 2;
            int playerChosen = 0;
            Random rng = new Random();
            foreach (Boss boss in tempBosses)
            {
                if(boss.disableWeekOne && weekOne )
                {
                    continue;
                }

                if (!boss.hasTier)
                {
                    List<Player> eligablePlayers = new List<Player>(players);
                    List<Player> tradeListPlayer = new List<Player>();

                    List<Loot> tradeListLoot = new List<Loot>();
                    for (int i = 0; i < normalDropNum; i++)
                    {
                        if (eligablePlayers.Count > 0)
                        {
                            List<Loot> possibleLoot = new List<Loot>();

                            playerChosen = rng.Next(0, eligablePlayers.Count);
                            foreach (Loot loot in boss.normalDrops)
                            {

                                if (loot.specs.Contains(eligablePlayers[playerChosen].spec))
                                {
                                   
                                    possibleLoot.Add(loot);
                                }
                            }
                            int lootChosen = rng.Next(0, possibleLoot.Count);
                            if (!eligablePlayers[playerChosen].GiveLoot(possibleLoot[lootChosen]))
                            {
                                if (eligablePlayers[playerChosen].CanTrade(possibleLoot[lootChosen]))
                                {
                                    tradeListPlayer.Add(eligablePlayers[playerChosen]);
                                    tradeListLoot.Add(possibleLoot[lootChosen]);
                                }
                            }
                            try
                            {
                                eligablePlayers.RemoveAt(playerChosen);
                            }
                            catch
                            {

                            }
                        }
                    }
                    for (int i = 0; i < tradeListPlayer.Count; i++)
                    {
                        TryTrade(tradeListLoot[i], tradeListPlayer[i]);
                    }
                }
                else
                {
                    List<Player> eligablePlayers = new List<Player>(players);
                    List<Player> tradeListPlayer = new List<Player>();

                    List<Loot> tradeListLoot = new List<Loot>();
                    for (int i = 0; i < tierDropNum; i++)
                    {
                        if (eligablePlayers.Count > 0)
                        {
                            List<Loot> possibleLoot = new List<Loot>();

                            playerChosen = rng.Next(0, eligablePlayers.Count);
                            foreach (Loot loot in boss.normalDrops)
                            {

                                if (loot.specs.Contains(eligablePlayers[playerChosen].spec))
                                {
                                    possibleLoot.Add(loot);
                                }
                            }
                            int lootChosen = rng.Next(0, possibleLoot.Count);
                            if (!eligablePlayers[playerChosen].GiveLoot(possibleLoot[lootChosen]))
                            {
                                if (eligablePlayers[playerChosen].CanTrade(possibleLoot[lootChosen]))
                                {
                                    tradeListPlayer.Add(eligablePlayers[playerChosen]);
                                    tradeListLoot.Add(possibleLoot[lootChosen]);
                                }
                            }
                            try
                            {
                                eligablePlayers.RemoveAt(playerChosen);
                            }
                            catch
                            {

                            }
                        }
                    }
                    for (int i = 0; i < tierDropNum; i++)
                    {
                        if (eligablePlayers.Count > 0)
                        {
                            List<Loot> possibleLoot = new List<Loot>();

                            playerChosen = rng.Next(0, eligablePlayers.Count);
                            foreach (Loot loot in boss.tierDrops)
                            {

                                if (loot.specs.Contains(eligablePlayers[playerChosen].spec))
                                {
                                    possibleLoot.Add(loot);
                                }
                            }
                            int lootChosen = rng.Next(0, possibleLoot.Count);
                            if (!eligablePlayers[playerChosen].GiveLoot(possibleLoot[lootChosen]))
                            {
                                if (eligablePlayers[playerChosen].CanTrade(possibleLoot[lootChosen]))
                                {
                                    tradeListPlayer.Add(eligablePlayers[playerChosen]);
                                    tradeListLoot.Add(possibleLoot[lootChosen]);
                                }
                            }
                            try
                            {
                                eligablePlayers.RemoveAt(playerChosen);
                            }
                            catch
                            {

                            }
                        }
                    }
                    for (int i = 0; i < tradeListPlayer.Count; i++)
                    {
                        TryTrade(tradeListLoot[i], tradeListPlayer[i]);
                    }
                }
            }
        }
        static void TryTrade(Loot loot, Player tradingPlayer)
        {
            Player currentPriority = tradingPlayer;
            foreach(Player player in players)
            {
                if(player != tradingPlayer && loot.specs.Contains( player.spec))
                {
                    if(loot.tier == true)
                    {
                        if (player.equipment[loot.slot].tier != true)
                        {
                            if (player.setNum <= currentPriority.setNum)
                            {

                                currentPriority = player;

                            }
                        }
                    }
                    else
                    {
                        if (player.equipment[loot.slot].iLevel < currentPriority.equipment[loot.slot].iLevel)
                        {
                            currentPriority = player;
                        }
                    }
                }
            }
            if (currentPriority == tradingPlayer)
            {

            }
            else
            {
                currentPriority.GiveLoot(loot);
            }
        }
        
    }
}
