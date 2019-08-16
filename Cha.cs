using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekai {
    public partial class Cha : Dot {
        // ---------------- Class Variables ---------------- ---------------- //
        #region Dictionaries
        public static string[] AbilityScoreList = {
            "STR", "DEX", "CON", "INT", "WIS", "CHA"
        };
        public static string[] SkillList = {
            "Acrobatics", "Animal Handling", "Arcana",
            "Athletics", "Deception", "History",
            "Insight", "Intimidation", "Investigation",
            "Medicine", "Nature", "Perception",
            "Performance", "Persuasion", "Religion",
            "Sleight of Hand", "Stealth", "Survival"
        };

        public static Dictionary<int, string> AbilityScoreByIndex = new Dictionary<int, string> {
            { 0, "STR" }, { 1, "DEX" }, {2, "CON"},
            { 3, "INT"}, {4, "WIS"}, {5, "CHA"}
        };
        public static Dictionary<string, int> SkillNameIndex = new Dictionary<string, int> {
                {"Acrobatics", 0 }, {"Animal Handling", 1 }, {"Arcana", 2 },
                { "Athletics", 3 }, {"Deception", 4 }, {"History", 5},
                { "Insight", 6 }, { "Intimidation", 7 }, { "Investigation", 8 },
                { "Medicine", 9 }, { "Nature", 10 }, { "Perception", 11 },
                { "Performance", 12 }, {"Persuasion",13 }, {"Religion",14 },
                { "Sleight of Hand", 15 }, {"Stealth",16 }, { "Survival",17 }
            };
        public static Dictionary<int, string> SkillIndexName = new Dictionary<int, String> {
                {0,"Acrobatics"}, {1,"Animal Handling" }, {2,"Arcana" },
                { 3,"Athletics" }, {4,"Deception" }, {5,"History"},
                {6, "Insight" }, {7, "Intimidation"}, { 8,"Investigation" },
                { 9,"Medicine" }, {10, "Nature" }, { 11,"Perception" },
                { 12,"Performance" }, {13,"Persuasion"}, {14,"Religion" },
                { 15,"Sleight of Hand"}, {16,"Stealth" }, {17, "Survival" }
            };
        public static Dictionary<string, string> SkillBaseByName = new Dictionary<string, string> {
                {"Acrobatics", "DEX" }, {"Animal Handling", "WIS" }, {"Arcana", "INT" },
                { "Athletics", "STR" }, {"Deception", "CHA" }, {"History", "INT"},
                { "Insight", "WIS" }, { "Intimidation", "CHA" }, { "Investigation", "INT" },
                { "Medicine", "WIS" }, { "Nature", "INT" }, { "Perception", "WIS" },
                { "Performance", "CHA" }, {"Persuasion","CHA" }, {"Religion","INT" },
                { "Sleight of Hand", "DEX" }, {"Stealth","DEX" }, { "Survival","WIS" }
            };
        #endregion




        #region Stat Block

        #region Ability Scores
        public int STR { get; set; }
        public int DEX { get; set; }
        public int CON { get; set; }
        public int INT { get; set; }
        public int WIS { get; set; }
        public int CHA { get; set; }
        #endregion

        #region Ability Score Save Proficiency
        public bool STRProf { get; set; }
        public bool DEXProf { get; set; }
        public bool CONProf { get; set; }
        public bool INTProf { get; set; }
        public bool WISProf { get; set; }
        public bool CHAProf { get; set; }
        #endregion

        #region Ability Score Check Bonuses
        public int STRCheckBonus { get; set; }
        public int DEXCheckBonus { get; set; }
        public int CONCheckBonus { get; set; }
        public int INTCheckBonus { get; set; }
        public int WISCheckBonus { get; set; }
        public int CHACheckBonus { get; set; }
        #endregion

        #region Ability Score Save Bonuses
        public int STRSaveBonus { get; set; }
        public int DEXSaveBonus { get; set; }
        public int CONSaveBonus { get; set; }
        public int INTSaveBonus { get; set; }
        public int WISSaveBonus { get; set; }
        public int CHASaveBonus { get; set; }
        #endregion

        public bool[] SkillProficient { get; set; }
        public int[] SkillBonus { get; set; }

        public int HPCurrent { get; set; }
        public int HPMax { get; set; }
        public int PB { get; set; }
        public int AC { get; set; }
        public int Speed { get; set; }
        #endregion

        #region RP Block
        public Loc Location { get; set; }
        public string CurrentlyDoing { get; set; }
        public string Shift { get; set; }
        #endregion

        #region Dot Lists
        public List<Cha> Relationships { get; set; }
        public List<Itm> Inventory { get; set; }
        #endregion

        #region List<string[]> Lists
        public List<string[]> Attacks { get; set; }
        public List<string[]> Abilities { get; set; }
        public List<string[]> Accolades { get; set; }

        public string[] HeadAccolades { get; set; } = { "Accolade", "Rank", "Affiliate" };
        public string[] HeadAbilities { get; set; } = { "Ability", "Description", "Type", "Charges", "Recharge" };
        public string[] HeadAttacks { get; set; } = { "Attack", "Thac0", "Damage", "Bonus", "Range", "Ammo" };
        #endregion

        // ---------------- Constructors ---------------- ---------------- //
        public Cha() : base() {
            for(int i = 0; i < 6; i++) {
                SetPropertyByName(AbilityScoreByIndex[i], 10);
                SetPropertyByName(AbilityScoreByIndex[i] + "Prof", false);
                SetPropertyByName(AbilityScoreByIndex[i] + "CheckBonus", 0);
                SetPropertyByName(AbilityScoreByIndex[i] + "SaveBonus", 0);
            }
            SkillProficient = new bool[18]; SkillProficient.Populate(false);
            SkillBonus = new int[18]; SkillBonus.Populate(0);

            HPCurrent = 10;
            HPMax = 10;
            PB = 2; AC = 10; Speed = 10;

            CurrentlyDoing = "Currently, where and what is this character doing?";

            Relationships = new List<Cha>();
            Inventory = new List<Itm>();

            Accolades = new List<string[]>();
            Abilities = new List<string[]>();
            Attacks = new List<string[]>();
        }

        // ---------------- Methods ---------------- ---------------- //


        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
