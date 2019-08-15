using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekai {
    public class Ghl : Fac {
        // ---------------- Variables ---------------- ---------------- //
        #region Dot Lists
        public List<Cha> CommonRoom { get; set; }
        #endregion

        #region string[] Lists
        public List<string[]> Questboard { get; set; }
        public string[] HeadQuestboard { get; set; } = { "Rank", "Tags", "Details", "Timeframe", "Reward" };
        #endregion

        // ---------------- Constructors ---------------- ---------------- //
        public Ghl() : base() {
            CommonRoom = new List<Cha>();
            Questboard = new List<string[]>();
        }

        // ---------------- Methods ---------------- ---------------- //
        public void PopulateCommonRoom() {
            //TODO
            // f(Fac.Clients, Fac.Staff)
        }

        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
