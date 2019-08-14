using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekai {
    class Database {
        // ---------------- Variables ---------------- ---------------- //
        public static string path;
        public static Dictionary<string, Type> Dots;
        public static Font ListFont;
        public static Random RNG;

        // ---------------- Constructors ---------------- ---------------- //
        public static void InitializeDatabase() {
            string tempPath = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            Database.path = System.IO.Path.GetDirectoryName(tempPath).Substring(6).Replace("/", "\\\\") + "\\Data";
            ListFont = new Font("Microsoft Sans Serif", 11);

            Dots = new Dictionary<string, Type> {
            { "Aso", typeof(Sekai.Aso) },
            { "Cha", typeof(Sekai.Cha) },
            { "Doh", typeof(Sekai.Doh) },
            { "Evt", typeof(Sekai.Evt) },
            { "Fac", typeof(Sekai.Fac) },
            { "Ghl", typeof(Sekai.Ghl) },
            { "Itm", typeof(Sekai.Itm) },
            { "Loc", typeof(Sekai.Loc) },
            { "Mdl", typeof(Sekai.Mdl) }
        };
            RNG = new Random(Guid.NewGuid().GetHashCode());
            
        }

        // ---------------- Databases ---------------- ---------------- //
        Dictionary<string, string> ItemTag = new Dictionary<string, string> {

        };


        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
