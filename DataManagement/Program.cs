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

            using (db)
            {
                // Create Games
                Game ds1 = new Game("Dark Souls");
                Game ds3 = new Game("Dark Souls III");

                // Create Bosses
                // Dark Souls 1
                Boss AsylumDemon = new Boss("Asylum Demon", "Undead Asylum", 825,
                    new List<string>() { "Fire", "Bleed" },
                    2000, new List<string>() { "Big Pilgrim's Key", "1 Humanity", "Demon's Great Hammer" }, "Images/ds1/AsylumDemon.jpg");
                Boss BellGargoyles = new Boss("Bell Gargoyles", "Undead Parish", 1480,
                    new List<string>() { "Fire", "Lightning" },
                    10000, new List<string>() { "1 Twin Humanities", "Gargoyle's Halberd", "Gargoyle Shield", "Gargoyle Helm", "Gargoyle Tail Axe" }, "Images/ds1/BellGargoyle.jpg");
                Boss CapraDemon = new Boss("Capra Demon", "Undead Burg", 1176,
                    new List<string>() { "Fire", "Toxic" },
                    6000, new List<string>() { "Key to Depths", "1 Humanity", "1 Homeward Bone", "Demon Great Machete" }, "Images/ds1/CapraDemon.jpg");
                Boss CeaselessDischarge = new Boss("Ceaseless Discharge", "Demon Ruins", 4200,
                    new List<string>() { "None" },
                    20000, new List<string>() { "1 Humanity", "1 Homeward Bone" }, "Images/ds1/CeaselessDischarge.jpg");
                Boss CentipedeDemon = new Boss("Centipede Demon", "Demon Ruins", 3432,
                    new List<string>() { "Lightning" },
                    40000, new List<string>() { "Orange Charred Ring", "1 Humanity", "1 Homeward Bone" }, "Images/ds1/CentipedeDemon.jpg");
                Boss Quelaag = new Boss("Chaos Witch Quelaag", "Blighttown", 3139,
                    new List<string>() { "Lightning" },
                    20000, new List<string>() { "Soul of Quelaag", "1 Twin Humanities" }, "Images/ds1/ChaosWitchQuelaag.jpg");
                Boss Priscilla = new Boss("Crosspreed Priscilla", "Painted World of Ariamis", 2300,
                    new List<string>() { "Fire" },
                    30000, new List<string>() { "Soul of Priscilla", "1 Twin Humanities", "Priscilla's Dagger" }, "Images/ds1/CrossbreedPriscilla.jpg");
                Boss Gwyndolin = new Boss("Dark Sun Gwyndolin", "Anor Londo", 2000,
                    new List<string>() { "None" },
                    40000, new List<string>() { "Soul of Gwyndolin" }, "Images/ds1/DarkSunGwyndolin.jpg");
                Boss DemonFiresage = new Boss("Demon Firesage", "Demon Ruins", 5950,
                    new List<string>() { "Fire, Bleed" },
                    20000, new List<string>() { "1 Humanity", "Demon's Catalyst" }, "Images/ds1/DemonFiresage.jpg");
                Boss FourKings = new Boss("Four Kings", "Abyss", 9604,
                    new List<string>() { "Fire", "Lightning" },
                    60000, new List<string>() { "Bequeathed Lord Soul Shard", "4 Humanity" }, "Images/ds1/FourKings.jpg");
                Boss GapingDragon = new Boss("Gaping Dragon", "Depths", 4401,
                    new List<string>() { "Lightning" },
                    25000, new List<string>() { "Blighttown Key", "1 Twin Humanities", "1 Homeward Bone", "Demon King Greataxe" }, "Images/ds1/GapingDragon.jpg");
                Boss Sif = new Boss("Great Greywolf Sif", "Darkroot Garden", 3432,
                    new List<string>() { "Fire" },
                    40000, new List<string>() { "Soul of Sif", "Covenant of Artorias", "1 Humanity", "1 Homeward Bone" }, "Images/ds1/GreatGreywolfSif.jpg");
                Boss Gwyn = new Boss("Gwyn, Lord of Cynder", "Kiln of the First Flame", 4250,
                    new List<string>() { "Fire" },
                    70000, new List<string>() { "Soul of Gwyn, Lord of Cinder" }, "Images/ds1/GwynLordofCynder.jpg");
                Boss IronGolem = new Boss("Iron Golem", "Sen's Fortress", 2880,
                    new List<string>() { "None" },
                    40000, new List<string>() { "Core of an Iron Golem", "1 Humanity" }, "Images/ds1/IronGolem.jpg");
                Boss MoonlightButterfly = new Boss("Moonlight Butterfly", "Darkroot Garden", 1255,
                    new List<string>() { "None" },
                    10000, new List<string>() { "Soul of the Moonlight Butterfly", "1 Humanity" }, "Images/ds1/MoonlightButterfly.jpg");
                Boss Nito = new Boss("Gravelord Nito", "Tomb of Giants", 4317,
                    new List<string>() { "Fire" },
                    60000, new List<string>() { "Lord Soul", "1 Humanity" }, "Images/ds1/GravelordNito.jpg");
                Boss Ornstein = new Boss("Dragon Slayer Ornstein", "Anor Londo", 2981,
                    new List<string>() { "Fire" },
                    50000, new List<string>() { "Soul of Ornstein", "Leo Ring" }, "Images/ds1/DragonSlayerOrnstein.jpg");
                Boss Smough = new Boss("Executioner Smough", "Anor Londo", 4094,
                    new List<string>() { "Fire", "Bleed", "Lightning" },
                    50000, new List<string>() { "Soul of Smough" }, "Images/ds1/ExecutionerSmough.jpg");
                Boss Pinwheel = new Boss("Pinwheel", "The Catacombs", 1326,
                    new List<string>() { "Fire", "Lightning", "Magic" },
                    15000, new List<string>() { "Rite of Kindling", "1 Humanity", "Mask of the Father", "Mask of the Mother", "Mask of the Child" }, "Images/ds1/Pinwheel.jpg");
                Boss Seath = new Boss("Seath the Scaleless", "Crystal Cave", 5525,
                    new List<string>() { "Fire", "Lightning" },
                    60000, new List<string>() { "Bequeathed Lord Soul Shard", "1 Humanity", "Moonlight Greatsword" }, "Images/ds1/SeaththeScaleless.jpg");
                Boss StrayDemon = new Boss("Stray Demon", "Undead Asylum", 5250,
                    new List<string>() { "Bleed" },
                    20000, new List<string>() { "Titanite Slab", "1 Humanity", "1 Homeward Bone" }, "Images/ds1/Stray Demon.jpg");
                Boss TaurusDemon = new Boss("Taurus Demon", "Undead Burg", 1215,
                    new List<string>() { "Lightning" },
                    3000, new List<string>() { "1 Humanity", "1 Homeward Bone", "Demon's Greataxe" }, "Images/ds1/TaurusDemon.jpg");
                Boss BedOfChaos = new Boss("The Bed of Chaos", "Lost Izalith", 2,
                    new List<string>() { "None" },
                    60000, new List<string>() { "Lord's Soul", "1 Humanity" }, "Images/ds1/TheBedofChaos.jpg");
                Boss Artorias = new Boss("Knight Artorias the Abysswalker", "Royal Wood", 3750,
                    new List<string>() { "None" },
                    50000, new List<string>() { "Soul of Artorias" }, "Images/ds1/KnightArtoriastheAbysswalker.jpg");
                Boss Kalameet = new Boss("Black Dragon Kalameet", "Royal Woods", 5400,
                    new List<string>() { "Bleed" },
                    60000, new List<string> { "Calamity Ring", "Obsidian Greatsword" }, "Images/ds1/BlackDragonKalameet.jpg");
                Boss Manus = new Boss("Manus, Father of the Abyss", "Chasm of the Abyss", 6665,
                    new List<string>() { "None" },
                    60000, new List<string>() { "Soul of Manus", "10 Humanity" }, "Images/ds1/ManusFatheroftheAbyss.jpg");
                Boss SanctuaryGuardian = new Boss("Sanctuary Guardian", "Sanctuary Garden", 2560,
                    new List<string>() { "Bleed" },
                    30000, new List<string>() { "Guardian Soul", "1 Humanity", "Guardian Tail" }, "Images/ds1/SanctuaryGuardian.jpg");

                // Dark Souls 3
                Boss IudexGundyr = new Boss("Iudex Gundyr", "Cemetery of Ash", 1037,
                    new List<string>() { "Lightning", "Bleed", "Frostbite" },
                    3000, new List<string>() { "Coiled Sword" }, "Images/ds3/IudexGundyr.png");
                Boss Vordt = new Boss("Vordt of the Boreal Valley", "High Wall of Lothric", 1328,
                    new List<string>() { "Dark" },
                    3000, new List<string>() { "Soul of Boreal Valley Vordt" }, "Images/ds3/VordtoftheBorealValley.png");
                Boss Greatwood = new Boss("Curse-Rotted Greatwood", "Undead Settlement", 5405,
                    new List<string>() { "Fire" },
                    7000, new List<string>() { "Transposing Kiln", "Soul of the Rotted Greatwood" }, "Images/ds3/CurseRottedGreatwood.png");
                Boss CrystalSage = new Boss("Crystal Sage", "Road of Sacrifices", 2723,
                    new List<string>() { "Lightning", "Dark", "Fire", "Poison", "Toxic", "Frosy" },
                    8000, new List<string>() { "Soul of a Crystal Sage" }, "Images/ds3/CrystalSage.png");
                Boss AbyssWatchers = new Boss("Abyss Watchers", "Farron Keep", 1548,
                    new List<string>() { "Lightning" },
                    18000, new List<string>() { "Soul of the Blood of the Wolf", "Cinders of a Lord" }, "Images/ds3/AbyssWatchers.png");
                Boss Deacons = new Boss("Deacons of the Deep", "Cathederal of the Deep", 4099,
                    new List<string>() { "Frostbite" },
                    13000, new List<string>() { "Soul of the Deacons of the Deep", "Small Doll Archdeacon Set" }, "Images/ds3/DeaconsoftheDeep.png");
                Boss Wolnir = new Boss("High Lord Wolnir", "Catacombs of Carthus", 15041,
                    new List<string>() { "None" },
                    22000, new List<string>() { "Soul of High Lord Wolnyr" }, "Images/ds3/HighLordWolnir.png");
                Boss OldDemonKing = new Boss("Old Demon King", "Smouldering Lake", 5301,
                    new List<string>() { "Dark" },
                    25000, new List<string>() { "Soul of the Old Demon King" }, "Images/ds3/OldDemonKing.png");
                Boss Pontiff = new Boss("Pontiff Sulyvahn", "Irithyll of the Boreal Valley", 5106,
                    new List<string>() { "Fire", "Lightning", "Dark" },
                    28000, new List<string>() { "Soul of Pontiff Sulyvahn" }, "Images/ds3/PontiffSulyvahn.png");
                Boss Yhorm = new Boss("Yhorm the Giant", "Profaned Capital", 27822,
                    new List<string>() { "Lightning", "Dark" },
                    36000, new List<string>() { "Soul of Thorm the Giant", "Cinders of a Lord" }, "Images/ds3/YhormtheGiant.png");
                Boss Aldrich = new Boss("Aldrich, Devourer of Gods", "Anor Londo", 4727,
                    new List<string>() { "Lightning", "Fire" },
                    50000, new List<string>() { "Soul of Aldrich", "Cinders of a Lord" }, "Images/ds3/AldrichDevourerofGods.png");
                Boss Dancer = new Boss("Dancer of the Boreal Valley", "High Wall of Lothric", 5111,
                    new List<string>() { "Dark" },
                    60000, new List<string>() { "Soul of the Dancer" }, "Images/ds3/DanceroftheBorealValley.png");
                Boss DragonslayerArmour = new Boss("Dragonslayer Armour", "Lothric Castle", 4581,
                    new List<string>() { "Frost" },
                    48000, new List<string>() { "Soul of the Dragonslayer Armour" }, "Images/ds3/DragonslayerArmour.png");
                Boss Oceiros = new Boss("Oceiros, the Consumed King", "Consumed King's Garden", 8087,
                    new List<string>() { "Lightning", "Frost" },
                    58000, new List<string>() { "Soul of Consumed Oceiros" }, "Images/ds3/OceirostheConsumedKing.png");
                Boss ChampionGundyr = new Boss("Champion Gundyr", "Untended Graves", 4956,
                    new List<string>() { "Lightning", "Frost", "Bleed" },
                    60000, new List<string>() { "Soul of Champion Gundyr" }, "Images/ds3/ChampionGundyr.png");
                Boss Lothric = new Boss("Lothric, Younger Prince", "Grand Archives", 13529,
                    new List<string>() { "Lightning", "Frost", "Magic" },
                    85000, new List<string>() { "Soul of the Twin Princes", "Cinders of a Lord" }, "Images/ds3/LothricYoungerPrince.png");
                Boss AncientWyvern = new Boss("Ancient Wyvern", "Archdragon Peak", 7873,
                    new List<string>() { "Lightning", "Frostbite" },
                    70000, new List<string>() { "Dragon Head Stone" }, "Images/ds3/AncientWyvern.png");
                Boss NamelessKing = new Boss("Nameless King", "Archdragon Peak", 11677,
                    new List<string>() { "Lightning", "Frostbite", "Fire", "Dark" },
                    80000, new List<string>() { "Soul of the Nameless King" }, "Images/ds3/NamelessKing.png");
                Boss SoulOfCinder = new Boss("Soul of Cinder", "Kiln of the First Flame", 10766,
                    new List<string>() { "Lightning", "Dark" },
                    100000, new List<string>() { "Soul of the Lords" }, "Images/ds3/SoulofCinder.jpg");
                Boss Gravetender = new Boss("Champion's Gravetender & Gravetender Wolf", "Painted World of Ariandel", 6984,
                    new List<string>() { "Fire" },
                    60000, new List<string>() { "Valorheart", "Champion's Bones" }, "Images/ds3/Gravetender.jpg");
                Boss SisterFriede = new Boss("Sister Friede", "Painted World of Ariandel", 18877,
                    new List<string>() { "None" },
                    72000, new List<string>() { "Soul of Sister Friede", "Titanite Slab" }, "Images/ds3/SisterFriede.jpg");
                Boss DemonPrince = new Boss("Demon Prince", "Dreg Heap", 7045,
                    new List<string>() { "Bleed" },
                    100000, new List<string>() { "Soul of the Demon Prince" }, "Images/ds3/DemonPrince.jpg");
                Boss Halflight = new Boss("Halflight, Spear of the Church", "The Ringed City", 3350,
                    new List<string>() { "Frost", "Lightning" },
                    80000, new List<string>() { "Filianore's Spear Ornament", "Titanite Slab" }, "Images/ds3/HalflightSpearoftheChurch.jpg");
                Boss Midir = new Boss("Darkeater Midir", "The Ringed City", 15860,
                    new List<string>() { "None" },
                    150000, new List<string>() { "Soul of Darkeater Midir", "Spears of the Church" }, "Images/ds3/DarkeaterMidir.jpeg");
                Boss Gael = new Boss("Slave Knight Gael", "Filianore's Rest", 15037,
                    new List<string>() { "Frostbite", "Poison", "Toxic" },
                    120000, new List<string>() { "Soul of Slave Knight Gael", "Blood of the Dark Soul" }, "Images/ds3/SlaveKnightGael.jpeg");

                // Add to DB and save

            }
        }
    }
}
