using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Project;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create DB model
            GameData db = new GameData("DarkSoulsGames");

            using(db)
            {
                // Create Games
                Game ds1 = new Game("Dark Souls");
                Game ds3 = new Game("Dark Souls III");

                // Create Bosses
                Boss AsylumDemon = new Boss("Asylum Demon", "Undead Asylum", 825,
                    new List<string>() { "Fire", "Bleed" },
                    2000, new List<string>() { "Big Pilgrim's Key", "1 Humanity", "Demon's Great Hammer" }, "Images/ds1/AsylumDemon");
                Boss BellGargoyles = new Boss("Bell Gargoyles", "Undead Parish", 1480,
                    new List<string>() { "Fire", "Lightning" },
                    10000, new List<string>() { "1 Twin Humanities", "Gargoyle's Halberd", "Gargoyle Shield", "Gargoyle Helm", "Gargoyle Tail Axe" }, "Images/ds1/BellGargoyle");
                Boss CapraDemon = new Boss("Capra Demon", "Undead Burg", 1176,
                    new List<string>() { "Fire", "Toxic" },
                    6000, new List<string>() { "Key to Depths", "1 Humanity", "1 Homeward Bone", "Demon Great Machete" }, "Images/ds1/CapraDemon");
                Boss CeaselessDischarge = new Boss("Ceaseless Discharge", "Demon Ruins", 4200,
                    new List<string>() { "None" },
                    20000, new List<string>() { "1 Humanity", "1 Homeward Bone" }, "Images/ds1/CeaselessDischarge");
                Boss CentipedeDemon = new Boss("Centipede Demon", "Demon Ruins", 3432,
                    new List<string>() { "Lightning" },
                    40000, new List<string>() { "Orange Charred Ring", "1 Humanity", "1 Homeward Bone" }, "Images/ds1/CentipedeDemon");
                Boss Quelaag = new Boss("Chaos Witch Quelaag", "Blighttown", 3139,
                    new List<string>() { "Lightning" },
                    20000, new List<string>() { "Soul of Quelaag", "1 Twin Humanities" }, "Images/ds1/ChaosWitchQuelaag");
                Boss Priscilla = new Boss("Crosspreed Priscilla", "Painted World of Ariamis", 2300,
                    new List<string>() { "Fire" },
                    30000, new List<string>() { "Soul of Priscilla", "1 Twin Humanities", "Priscilla's Dagger" }, "Images/ds1/CrossbreedPriscilla");
                Boss Gwyndolin = new Boss("Dark Sun Gwyndolin", "Anor Londo", 2000,
                    new List<string>() { "None" },
                    40000, new List<string>() { "Soul of Gwyndolin" }, "Images/ds1/DarkSunGwyndolin");
                Boss DemonFiresage = new Boss("Demon Firesage", "Demon Ruins", 5950,
                    new List<string>() { "Fire, Bleed" },
                    20000, new List<string> () { "1 Humanity", "Demon's Catalyst" }, "Images/ds1/DemonFiresage");
                Boss FourKings = new Boss("Four Kings", "Abyss", 9604,
                   new List<string>() { "Fire", "Lightning" },
                   60000, new List<string>() { "Bequeathed Lord Soul Shard", "4 Humanity" }, "Images/ds1/FourKings");
                Boss GapingDragon = new Boss("Gaping Dragon", "Depths", 4401,
                    new List<string>() { "Lightning" },
                    25000, new List<string>() { "Blighttown Key", "1 Twin Humanities", "1 Homeward Bone", "Demon King Greataxe" }, "Images/ds1/GapingDragon");
                Boss Sif = new Boss("Great Greywolf Sif", "Darkroot Garden", 3432,
                    new List<string>() { "Fire" },
                    40000, new List<string>() { "Soul of Sif", "Covenant of Artorias", "1 Humanity", "1 Homeward Bone" }, "Images/ds1/GreatGreywolfSif");
                Boss Gwyn = new Boss("Gwyn, Lord of Cynder", "Kiln of the First Flame", 4250,
                    new List<string>() { "Fire" },
                    70000, new List<string>() { "Soul of Gwyn, Lord of Cinder" }, "Images/ds1/GwynLordofCynder");
                Boss IronGolem = new Boss("Iron Golem", "Sen's Fortress", 2880,
                    new List<string>() { "None" },
                    40000, new List<string>() { "Core of an Iron Golem", "1 Humanity" }, "Images/ds1/IronGolem");
                Boss MoonlightButterfly = new Boss("Moonlight Butterfly", "Darkroot Garden", 1255,
                    new List<string>() { "None" },
                    10000, new List<string>() { "Soul of the Moonlight Butterfly", "1 Humanity" }, "Images/ds1/MoonlightButterfly");
                Boss Nito = new Boss("Gravelord Nito", "Tomb of Giants", 4317,
                    new List<string>() { "Fire" },
                    60000, new List<string>() { "Lord Soul", "1 Humanity" }, "Images/ds1/GravelordNito");
                Boss Ornstein = new Boss("Dragon Slayer Ornstein", "Anor Londo", 2981,
                    new List<string>() { "Fire" },
                    50000, new List<string>() { "Soul of Ornstein", "Leo Ring" }, "Images/ds1/DragonSlayerOrnstein");
                Boss Smough = new Boss("Executioner Smough", "Anor Londo", 4094,
                    new List<string>() { "Fire", "Bleed", "Lightning" },
                    50000, new List<string>() { "Soul of Smough" }, "Images/ds1/ExecutionerSmough");


                // Add to DB and save

            }
        }
    }
}
