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
        public static string[] AbilityScoreID = {
            "STR", "DEX", "CON", "INT", "WIS", "CHA"
        };
        public static string[] SkillID = {
            "Acrobatics", "Animal Handling", "Arcana",
            "Athletics", "Deception", "History",
            "Insight", "Intimidation", "Investigation",
            "Medicine", "Nature", "Perception",
            "Performance", "Persuasion", "Religion",
            "Sleight of Hand", "Stealth", "Survival"
        };
        public static Dictionary<string, int> AbilityScoreIndex = new Dictionary<string, int> {
            { "STR", 0 }, { "DEX", 1 }, {"CON", 2},
            { "INT", 3}, {"WIS", 4}, {"CHA", 5}
        };
        public static Dictionary<string, int> SkillIndex = new Dictionary<string, int> {
                {"Acrobatics", 0 }, {"Animal Handling", 1 }, {"Arcana", 2 },
                { "Athletics", 3 }, {"Deception", 4 }, {"History", 5},
                { "Insight", 6 }, { "Intimidation", 7 }, { "Investigation", 8 },
                { "Medicine", 9 }, { "Nature", 10 }, { "Perception", 11 },
                { "Performance", 12 }, {"Persuasion",13 }, {"Religion",14 },
                { "Sleight of Hand", 15 }, {"Stealth",16 }, { "Survival",17 }
            };
        public static Dictionary<string, string> SkillBase = new Dictionary<string, string> {
                {"Acrobatics", "DEX" }, {"Animal Handling", "WIS" }, {"Arcana", "INT" },
                { "Athletics", "STR" }, {"Deception", "CHA" }, {"History", "INT"},
                { "Insight", "WIS" }, { "Intimidation", "CHA" }, { "Investigation", "INT" },
                { "Medicine", "WIS" }, { "Nature", "INT" }, { "Perception", "WIS" },
                { "Performance", "CHA" }, {"Persuasion","CHA" }, {"Religion","INT" },
                { "Sleight of Hand", "DEX" }, {"Stealth","DEX" }, { "Survival","WIS" }
            };
        #endregion

        #region Stat Block
        public int[] AbilityScore { get; set; }
        public int[] AbilityScoreBonus { get; set; }

        public bool[] SaveProficient { get; set; }
        public int[] SaveBonus { get; set; }

        public bool[] SkillProficient { get; set; }
        public int[] SkillBonus { get; set; }

        public int[] HP { get; set; } // Current, Max
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
            AbilityScore = new int[6]; AbilityScore.Populate(10);
            AbilityScoreBonus = new int[6]; AbilityScoreBonus.Populate(0);

            SaveProficient = new bool[6]; SaveProficient.Populate(false);
            SaveBonus = new int[6]; SaveBonus.Populate(0);

            SkillProficient = new bool[18];  SkillProficient.Populate(false);
            SkillBonus = new int[18]; SkillBonus.Populate(0);

            HP = new int[2] { 10, 10 };
            PB = 2; AC = 10; Speed = 10;

            CurrentlyDoing = "Currently, where and what is this character doing?";

            Relationships = new List<Cha>();
            Inventory = new List<Itm>();

            Accolades = new List<string[]>();
            Abilities = new List<string[]>();
            Attacks = new List<string[]>();
        }
        
        // ---------------- Methods ---------------- ---------------- //
        #region Mod-Set
        public void ModAbilityScore(int AbilityScore_1_To_6, int ModValue) {
            AbilityScore[AbilityScore_1_To_6 - 1] += ModValue;
        }
        public void SetAbilityScore(int AbilityScore_1_To_6, int SetValue) {
            AbilityScore[AbilityScore_1_To_6 - 1] = SetValue;
        }
        public void SetSaveProficiency(int AbilityScore_1_To_6, bool SetValue) {
            SaveProficient[AbilityScore_1_To_6 - 1] = SetValue;
        }
        public void SetSkillProficiency(int SkillIndex_1_To_18, bool SetValue) {
            SaveProficient[SkillIndex_1_To_18] = SetValue;
        }
        #endregion

        #region Rolls
        public int[] RollAbilityCheck(string Identifier, int count) {
            if (!AbilityScoreIndex.ContainsKey(Identifier))
                throw new Exception($"AbilityScoreIndex does not contain specified key: {Identifier}");

            int index = AbilityScoreIndex[Identifier];
            int[] ReturnRolls = new int[count];

            for (int i = 0; i < count; i++) {
                ReturnRolls[i] = Database.RNG.Next(1, 20) + AbilityScoreBonus[index];
            }
            return ReturnRolls;
        }
        public int[] RollAbilitySave(string Identifier, int count) {
            if (!AbilityScoreIndex.ContainsKey(Identifier))
                throw new Exception($"AbilityScoreIndex does not contain specified key: {Identifier}");

            int index = AbilityScoreIndex[Identifier];
            int[] ReturnRolls = new int[count];

            for (int i = 0; i < count; i++) {
                ReturnRolls[i] = Database.RNG.Next(1, 20) + SaveBonus[index];
            }
            return ReturnRolls;
        }
        public int[] RollSkillCheck(string Identifier, int count) {
            if (!SkillIndex.ContainsKey(Identifier))
                throw new Exception($"SkillIndex does not contain specified key: {Identifier}");

            int index = SkillIndex[Identifier];
            int[] ReturnRolls = new int[count];

            for (int i = 0; i < count; i++) {
                ReturnRolls[i] = Database.RNG.Next(1, 20) + SkillBonus[index];
            }
            return ReturnRolls;
        }
        #endregion

        #region Check-Save-Skill Update
        public void UpdateCheckBonus() {
            for(int i = 0; i < 6; i++) {
                AbilityScoreBonus[i] = ((AbilityScore[i] - 10) / 2);
            }
        }
        public void UpdateSaveBonus() {
            UpdateCheckBonus();
            for (int i = 0; i < 6; i++) {
                SaveBonus[i] = AbilityScoreBonus[i];
                if (SaveProficient[i]) SaveBonus[i] += PB;
            }
        }
        public void UpdateSkillBonus() {
            foreach(string st in SkillID) {
                SkillBonus[SkillIndex[st]] = AbilityScoreBonus[AbilityScoreIndex[SkillBase[st]]];
                if (SkillProficient[SkillIndex[st]]) SkillBonus[SkillIndex[st]] += PB;
            }
        }
        #endregion

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
