using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekai {
    public class Ghl : Fac {
        // ---------------- Variables ---------------- ---------------- //
        #region string[] Lists
        public List<string[]> Questboard { get; set; }

        public string[] HeadQuestboard { get; set; } = { "Rank", "Tags", "Details", "Timeframe", "Reward" };
        #endregion

        // ---------------- Constructors ---------------- ---------------- //
        public Ghl() : base() {
            Questboard = new List<string[]> { HeadQuestboard };
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
