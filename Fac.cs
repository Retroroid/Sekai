using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekai {
    public class Fac : Aso {
        // ---------------- Variables ---------------- ---------------- //
        public Loc Location { get; set; }
        public Aso Association { get; set; }

        #region Dot Lists
        public List<Cha> Staff { get; set; }
        public List<Cha> Clients { get; set; }
        #endregion

        #region string[] Lists
        public List<string[]> Services { get; set; }

        public string[] HeadServices { get; set; } = { "Service", "Description", "Cost" };
        #endregion

        // ---------------- Constructors ---------------- ---------------- //
        public Fac() : base() {
            Staff = new List<Cha>();
            Clients = new List<Cha>();
            Services = new List<string[]>();
        }

        // ---------------- Methods ---------------- ---------------- //



        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
