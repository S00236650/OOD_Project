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
                    2000, new List<string>() { "1 Humanity", "Big Pilgrim's Key", "Demon's Great Hammer" });
                Boss BellGargoylse = new Boss("Bell Gargoyles", "Undead Parish", 1480,
                    new List<string>() { "Fire", "Lightning" },
                    10000, new List<string>() { "1 Twin Humanities", "Gargoyle's Halberd", "Gargoyle Shield", "Gargoyle Helm", "Gargoyle Tail Axe" });

                // Add to DB and save

            }
        }
    }
}
