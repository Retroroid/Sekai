using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekai {
    public class Itm : Dot {
        // ---------------- Variables ---------------- ---------------- //
        #region Stat Block
        public string ItemType { get; set; }
        public string ItemSubType { get; set; }

        public int Mass { get; set; }
        public int Value { get; set; }
        public int Rarity { get; set; }
        public int MagicLevel { get; set; }

        public int AttackBonus { get; set; }
        #endregion

        #region Lists
        public List<string[]> Rolls { get; set; }
        public List<string[]> Abilities { get; set; }
        public List<string[]> ItemTags { get; set; }

        public string[] HeadRolls { get; set; } = { "Roll", "Die Count", "Die Size", "Type / Range", "Tag" };
        public string[] HeadAbilities { get; set; } = { "Name", "Description", "Roll", "Tag" };
        public string[] HeadItemTags { get; set; } = { "Tag", "Description" };
        #endregion

        // ---------------- Constructors ---------------- ---------------- //
        public Itm() : base() {
            ItemType = "Item Type";
            ItemSubType = "Item Sub-Type";

            Mass = 0; Value = 0; Rarity = 0;
            AttackBonus = 0;  MagicLevel = 0;

            Rolls = new List<string[]>();
            Abilities = new List<string[]>();
            ItemTags = new List<string[]>();
        }

        // ---------------- Methods ---------------- ---------------- //


        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace