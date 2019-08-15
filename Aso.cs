using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekai {
    public class Aso : Dot {
        // ---------------- Variables ---------------- ---------------- //
        public Loc Location { get; set; }
        public string Focus { get; set; }

        #region Dot Lists
        public List<Loc> Locations { get; set; }
        public List<Cha> Members { get; set; }
        public List<Aso> Groups { get; set; }
        #endregion

        #region string[] Lists
        public List<string[]> Ranks { get; set; }
        public string[] HeadRanks { get; set; } = { "Rank", "Title", "Levels", "Benefits", "Notes" };
        #endregion

        // ---------------- Constructors ---------------- ---------------- //
        public Aso() : base(){
            Locations = new List<Loc>();
            Members = new List<Cha>();
            Groups = new List<Aso>();

            Ranks = new List<string[]>();
            Ranks = new List<string[]> { HeadRanks };

            Focus = "Focus";
        }

         // ---------------- Methods ---------------- ---------------- //



        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
