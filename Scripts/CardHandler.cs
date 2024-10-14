﻿using System;
using System.Collections.Generic;

namespace API_For_TCG_Card_Shop_Simulator.Scripts
{
    internal class CardHandler
    {
        // Instance field for the dictionary
        public List<string> CardsTotal = new List<string>
            {
            "None",
"PiggyA",
"PiggyB",
"PiggyC",
"PiggyD",
"FoxA",
"FoxB",
"FoxC",
"FoxD",
"GolemA",
"GolemB",
"GolemC",
"GolemD",
"TreeA",
"TreeB",
"TreeC",
"TreeD",
"StarfishA",
"StarfishB",
"StarfishC",
"StarfishD",
"ShellyA",
"ShellyB",
"ShellyC",
"ShellyD",
"BugA",
"BugB",
"BugC",
"BugD",
"BatA",
"BatB",
"BatC",
"BatD",
"Skull",
"Beetle",
"Bear",
"Jellyfish",
"Wisp",
"MummyMan",
"FlowerA",
"FlowerB",
"FlowerC",
"FlowerD",
"WeirdBirdA",
"FireSpirit",
"Angez",
"Mosquito",
"HydraA",
"HydraB",
"HydraC",
"HydraD",
"DragonFire",
"DragonEarth",
"DragonWater",
"DragonThunder",
"Turtle",
"FireWolfA",
"FireWolfB",
"FireWolfC",
"FireWolfD",
"FishA",
"FishB",
"FishC",
"FishD",
"HalloweenA",
"HalloweenB",
"HalloweenC",
"HalloweenD",
"TronA",
"TronB",
"TronC",
"TronD",
"LobsterA",
"LobsterB",
"LobsterC",
"LobsterD",
"FireBirdA",
"FireBirdB",
"FireBirdC",
"SerpentA",
"SerpentB",
"SerpentC",
"CloudA",
"CloudB",
"CloudC",
"EmeraldA",
"EmeraldB",
"EmeraldC",
"Crystalmon",
"ElecDragon",
"CrabA",
"CrabB",
"FireUmbrellaDragon",
"Lanternmon",
"SeedBugA",
"SeedBugB",
"SeedBugC",
"NinjaBirdA",
"NinjaBirdB",
"NinjaBirdC",
"NinjaBirdD",
"NinjaCrowC",
"NinjaCrowD",
"MuffinTreeA",
"MuffinTreeB",
"MuffinTreeC",
"SharkFishA",
"SharkFishB",
"SharkFishC",
"FireGeckoA",
"FireGeckoB",
"EarthDino",
"SlimeA",
"SlimeB",
"SlimeC",
"SlimeD",
"SeahorseA",
"SeahorseB",
"SeahorseC",
"SeahorseD",
"FireChickenA",
"FireChickenB",
"MAX",
"START_MEGABOT",
"Alpha",
"Beta",
"Gamma",
"Ronin",
"Bumblebee",
"Orca",
"Garuda",
"Viper",
"Blitz",
"Cylops",
"Kabuto",
"Minotaur",
"Spectre",
"Wolf",
"Bolt",
"Hawk",
"Cyber",
"Space",
"Hangar",
"Arena",
"UndergroundDark",
"UndergroundLight",
"RoninBoss",
"OrcaBoss",
"GarudaBoss",
"ViperBoss",
"Max",
"Shockwave",
"Tremor",
"Rhino",
"RoninArt",
"GarudaArt",
"MaxArt",
"MinotaurArt",
"WolfArt",
"SkullArt",
"OrcaAlt",
"GarudaAlt",
"ViperAlt",
"KabutoAlt",
"Neon",
"Pulse",
"Raptor",
"AncientHammer",
"ArcMissile",
"Axe",
"BarrageMissle",
"BarrelHammer",
"BattleChip",
"BoxingGlove",
"ChainGun",
"ChillMissile",
"ColdShoulder",
"CrescentClaw",
"CrescentMachete",
"CrimsonWheel",
"CryoBlaster",
"Drill",
"DualMissile",
"ElecBroadsword",
"ElectricChainsaw",
"ElectricSpike",
"EnergyShield",
"FanBlade",
"FeatherBlade",
"FireAxe",
"FireBroadsword",
"FireKatana",
"FireRocket",
"FireShield",
"FireTwinAxe",
"Flamethrower",
"FreezeBomb",
"GigaBlade",
"GigaCannon",
"GreatCleaver",
"HeatKnife",
"HeatMissile",
"IceBroadsword",
"IceMortar",
"IcePike",
"IceSpinner",
"IceTwinSpear",
"InfernoBoost",
"IronBall",
"JetBurner",
"Katana",
"KnightShield",
"KnightSword",
"LightSaber",
"LionShield",
"MagneticCoil",
"MaulerMace",
"MegavoltBeam",
"MiniMissile",
"MissileCannon",
"MoonlightBlade",
"MorningStar",
"Mortar",
"PulseCannon",
"RailCannon",
"Ravager",
"RocketMissile",
"RollerSpike",
"ShurikenBlade",
"SonicBlaster",
"SpikeBall",
"SpikedWarhammer",
"Sword",
"ThorHammer",
"Thunderblade",
"ThunderTwinBlade",
"WingBooster",
"MAX_MEGABOT",
"START_FANTASYRPG",
"Archer",
"ArmoredSlime",
"AxeWarrior",
"Basilisk",
"Blacksmith",
"CatMage",
"CatPirate1",
"CatThief",
"Cook",
"DarkKnight",
"Dragon",
"DragonKnight",
"EldritchCreature",
"Farmer",
"Fencer",
"Florist",
"GoblinMage",
"GoblinThief",
"GoblinWarrior",
"Golem",
"Grandma",
"Harpy1",
"Harpy2",
"InkKnight",
"Jester1",
"Jester2",
"King",
"Knight",
"Lamia",
"Mage",
"Mimic1",
"Mimic2",
"MushroomMonster",
"Noble1",
"Noble2",
"Peasant1",
"Peasant2",
"Phoenix",
"Queen",
"Reaper",
"Schoolboy1",
"SchoolBoy2",
"Slime",
"Snake",
"Traveller",
"TreeMonster",
"Vampire",
"Witch",
"Wizard",
"WolfFantasy",
"MAX_FANTASYRPG",
"START_CATJOB",
"EX0Teacher",
"EX0Detective",
"EX0Woodworker",
"EX0Plumber",
"EX0Electrician",
"EX0Soldier",
"EX0General",
"EX0Police",
"EX0Fireman",
"EX0Farmer",
"EX0Architect",
"EX0Construction",
"EX0Bodybuilder",
"EX0Archer",
"EX0Explorer",
"EX0Hiker",
"EX0Programmer",
"EX0Librarian",
"EX0Laundry",
"EX0Racer",
"EX0Florist",
"EX0Geologist",
"EX0Gamer",
"EX0Maid",
"EX0Barber",
"EX0Bartender",
"EX0Bouncer",
"EX0Composer",
"EX0Director",
"EX0Investor",
"EX0Singer",
"EX0Musician",
"EX0Artist",
"EX0Photographer",
"EX0Lawyer",
"EX0Janitor",
"EX0Psychic",
"EX0Astronaut",
"EX0Scout",
"EX0Pirate",
"MAX_CATJOB"
            };

        // This method should not be static to access the instance variable
        public void AddCardsToPool(string ModPrefix, string CardName, string ImagePath, string CardSet)
        {

            // Combine ModPrefix and CardName to form the key
            string CardEnum = ModPrefix + "_" + CardName;
            string Set = CardSet;

            // Setup Base Game Cards as An Array

            // Check if ModdedCards has any entries
            if (CardsTotal != null && CardsTotal.Count > 0)
            {
                // Find the index of MAX
                int TetraMonInsert = CardsTotal.IndexOf("MAX");
                int MegabotInsert = CardsTotal.IndexOf("MAX_MEGABOT");
                int FantasyRPGInsert = CardsTotal.IndexOf("MAX_FANTASYRPG");
                int CatJobInsert = CardsTotal.IndexOf("MAX_CATJOB");
                // Insert the modded cards before MAX if the Set is "MAX"
                foreach (var card in CardsTotal)
                {

                    if (CardSet == "Tetramon") // Check if the Set is "Tetramon"
                    {
                        // Insert each CardEnum at the found index
                        CardsTotal.Insert(TetraMonInsert, CardEnum); // Using card.Value to get the CardEnum
                        TetraMonInsert++; // Increment the index to insert subsequent cards
                    }
                    if (CardSet == "Megabot") // Check if the Set is "MegaBot"
                    {
                        // Insert each CardEnum at the found index
                        CardsTotal.Insert(MegabotInsert, CardEnum); // Using card.Value to get the CardEnum
                        MegabotInsert++; // Increment the index to insert subsequent cards
                    }
                    if (CardSet == "FantasyRPG") // Check if the Set is "FantasyRPG"
                    {
                        // Insert each CardEnum at the found index
                        CardsTotal.Insert(FantasyRPGInsert, CardEnum); // Using card.Value to get the CardEnum
                        FantasyRPGInsert++; // Increment the index to insert subsequent cards
                    }
                    if (CardSet == "CatJob") // Check if the Set is "CatJob"
                    {
                        // Insert each CardEnum at the found index
                        CardsTotal.Insert(CatJobInsert, CardEnum); // Using card.Value to get the CardEnum
                        CatJobInsert++; // Increment the index to insert subsequent cards
                    }
                }
            }

            // Optional: Display the combined list (for debugging purposes)
            foreach (var item in CardsTotal)
            {
                Console.WriteLine(item);
            }
        }
    }
}