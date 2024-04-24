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
                Boss AssylumDemon = new Boss("Assylum Demon", "Undead Assylum", 825,
                    new List<string>() { "Fire", "Bleed" },
                    2000, new List<string>() { "Big Pilgrim's Key", "1 Humanity", "Demon's Great Hammer" });
                Boss BellGargoyles = new Boss("Bell Gargoyles", "Undead Parish", 1480,
                    new List<string>() { "Fire", "Lightning" },
                    10000, new List<string>() { "1 Twin Humanities", "Gargoyle's Halberd", "Gargoyle Shield", "Gargoyle Helm", "Gargoyle Tail Axe" });
                Boss CapraDemon = new Boss("Capra Demon", "Undead Burg", 1176,
                    new List<string>() { "Fire", "Toxic" },
                    6000, new List<string>() { "Key to Depths", "1 Humanity", "1 Homeward Bone", "Demon Great Machete" });
                Boss CeaselessDischarge = new Boss("Ceaseless Discharge", "Demon Ruins", 4200,
                    new List<string>() { "None" },
                    20000, new List<string>() { "1 Humanity", "1 Homeward Bone" });
                Boss CentipedeDemon = new Boss("Centipede Demon", "Demon Ruins", 3432,
                    new List<string>() { "Lightning" },
                    40000, new List<string>() { "Orange Charred Ring", "1 Humanity", "1 Homeward Bone" });
                Boss Quelaag = new Boss("Chaos Witch Quelaag", "Blighttown", 3139,
                    new List<string>() { "Lightning" },
                    20000, new List<string>() { "Soul of Quelaag", "1 Twin Humanities" });
                Boss Priscilla = new Boss("Crosspreed Priscilla", "Painted World of Ariamis", 2300,
                    new List<string>() { "Fire" },
                    30000, new List<string>() { "Soul of Priscilla", "1 Twin Humanities", "Priscilla's Dagger" });
                Boss Gwyndolin = new Boss("Dark Sun Gwyndolin", "Anor Londo", 2000,
                    new List<string>() { "None" },
                    40000, new List<string>() { "Soul of Gwyndolin" });
                Boss DemonFiresage = new Boss("Demon Firesage", "Demon Ruins", 5950,
                    new List<string>() { "Fire, Bleed" },
                    20000, new List<string> () { "1 Humanity", "Demon's Catalyst" });
                Boss FourKings = new Boss("Four Kings", "Abyss", 9604,
                   new List<string>() { "Fire", "Lightning" },
                   60000, new List<string>() { "Bequeathed Lord Soul Shard", "4 Humanity" });
                Boss GapingDragon = new Boss("Gaping Dragon", "Depths", 4401,
                    new List<string>() { "Lightning" },
                    25000, new List<string>() { "Blighttown Key", "1 Twin Humanities", "1 Homeward Bone", "Demon King Greataxe" });
                Boss Sif = new Boss("Great Grey Wolf Sif", "Darkroot Garden", 3432,
                    new List<string>() { "Fire" },
                    40000, new List<string>() { "Soul of Sif", "Covenant of Artorias", "1 Humanity", "1 Homeward Bone" });
                Boss Gwyn = new Boss("Gwyn, Lord of Cynder", "Kiln of the First Flame", 4250,
                    new List<string>() { "Fire" },
                    70000, new List<string>() { "Soul of Gwyn, Lord of Cinder" });
                Boss IronGolem = new Boss("Iron Golem", "Sen's Fortress", 2880,
                    new List<string>() { "None" },
                    40000, new List<string>() { "Core of an Iron Golem", "1 Humanity" });
                Boss MoonlightButterfly = new Boss("Moonlight Butterfly", "Darkroot Garden", 1255,
                    new List<string>() { "None" },
                    10000, new List<string>() { "Soul of the Moonlight Butterfly", "1 Humanity" });
                Boss Nito = new Boss("Gravelord Nito", "Tomb of Giants", 4317,
                    new List<string>() { "Fire" },
                    60000, new List<string>() { "Lord Soul", "1 Humanity" });
                Boss Ornstein = new Boss("Dragon Slayer Ornstein", "Anor Londo", 2981,
                    new List<string>() { "Fire" },
                    50000, new List<string>() { "Soul of Ornstein", "Leo Ring" });
                Boss Smough = new Boss("Executioner Smough", "Anor Londo", 4094,
                    new List<string>() { "Fire", "Bleed", "Lightning" },
                    50000, new List<string>() { "Soul of Smough" });

                // Add to DB and save

            }
        }
    }
}
