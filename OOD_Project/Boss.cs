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
        public int Souls { get; set; }
        public List<string> Drops { get; set; }
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
        }
    }

    public class GameData : DbContext
    {
        public GameData(string gameName) : base(gameName) { }

        public DbSet<Game> Games { get; set; }
        public DbSet<Boss> Bosses { get; set; }
        
    }
}
