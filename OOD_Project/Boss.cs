using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Game
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public virtual List<Boss> Bosses { get; set; }

        public Game(string name)
        {
            GameName = name;
            Bosses = new List<Boss>();
        }
    }

    public class Boss
    {
        public int BossID { get; set; }
        public string BossName { get; set; }
        public string Location { get; set; }
        public int Health { get; set; }
        public List<string> Weaknesses { get; set; }
        public string Weakness1 { get; set; }
        public string Weakness2 { get; set; }
        public string Weakness3 { get; set; }
        public string Weakness4 { get; set; }
        public string Weakness5 { get; set; }
        public string Weakness6 { get; set; }
        public int Souls { get; set; }
        public List<string> Drops { get; set; }
        public string Drop1 { get; set; }
        public string Drop2 { get; set; }
        public string Drop3 { get; set; }
        public string Drop4 { get; set; }
        public string Drop5 { get; set; }
        public string ImageSource { get; set; }

        public Boss(string bossName, string location, int health, List<string> weaknesses, int souls, List<string> drops, string imageSource)
        {
            BossName = bossName;
            Location = location;
            Health = health;
            Weaknesses = weaknesses;
            Souls = souls;
            Drops = drops;
            ImageSource = imageSource;

            Weakness1 = Weaknesses[0];
            if (Weaknesses.Count > 1)
                Weakness2 = Weaknesses[1];
            if (Weaknesses.Count > 2)
                Weakness3 = Weaknesses[2];
            if (Weaknesses.Count > 3)
                Weakness4 = Weaknesses[3];
            if (Weaknesses.Count > 4)
                Weakness5 = Weaknesses[4];
            if (Weaknesses.Count > 5)
                Weakness6 = Weaknesses[5];

            Drop1 = Drops[0];
            if (Drops.Count > 1)
                Drop2 = Drops[1];
            if (Drops.Count > 2)
                Drop3 = Drops[2];
            if (Drops.Count > 3)
                Drop4 = Drops[3];
            if (Drops.Count > 4)
                Drop5 = Drops[4];
        }

        public Boss() { }
    }

    public class GameData : DbContext
    {
        public GameData(string gameName) : base(gameName) { }

        public DbSet<Game> Games { get; set; }
        public DbSet<Boss> Bosses { get; set; }
        
    }
}
