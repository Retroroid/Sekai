using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekai {
    public class Mdl : Dot {
        // ---------------- Variables ---------------- ---------------- //
        #region Dot Lists
        public List<Cha> Characters;
        public List<Evt> Events { get; set; } 
        #endregion

        // ---------------- Constructors ---------------- ---------------- //
        public Mdl() : base() {
            Characters = new List<Cha>();
            Events = new List<Evt>();
        }

        // ---------------- Methods ---------------- ---------------- //


        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
