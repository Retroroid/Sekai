using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekai {
    public class Loc : Dot {
        // ---------------- Variables ---------------- ---------------- //
        public string LocationPath { get; set; }
        public int Scale { get; set; }
        public int Population { get; set; }
        public int[] Coordinates { get; set; }

        #region Dot Lists
        public List<Cha> Characters { get; set; }
        public List<Loc> Locations { get; set; }
        public List<Fac> Facilities { get; set; }
        public List<Evt> Events { get; set; }

        #endregion

        #region string[] Lists
        public List<string[]> Exports { get; set; }
        public List<string[]> Imports { get; set; }

        public string[] HeadExports { get; set; } =
            new string[] { "Export", "Scale", "To" };
        public string[] HeadImports { get; set; } =
            new string[] { "Import", "Scale", "From" };
        #endregion


        // ---------------- Constructors ---------------- ---------------- //
        public Loc() : base() {
            LocationPath = "Setting/Continent/Country/City/Facility";
            Scale = 0; Population = 0; Coordinates = new int[] { 0, 0, 0 };

            Characters = new List<Cha>();
            Locations = new List<Loc>();
            Facilities = new List<Fac>();
            Exports = new List<string[]>();
            Imports = new List<string[]>();
        }

        
        // ---------------- Methods ---------------- ---------------- //


        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
