using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekai {
    public class Evt : Dot {
        // ---------------- Variables ---------------- ---------------- //
        #region Dot Lists
        public List<Evt> SubEvents { get; set; }
        public List<Cha> Characters { get; set; }
        public List<Doh> RandomEvents { get; set; }
        #endregion

        public Loc Location { get; set; }

        // ---------------- Constructors ---------------- ---------------- //
        public Evt() : base() {
            SubEvents = new List<Evt>();
            Characters = new List<Cha>();
            RandomEvents = new List<Doh>();
        }

        // ---------------- Methods ---------------- ---------------- //



        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
