using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekai {
    public class Dot : IComparable<Dot> {
        // ---------------- Variables ---------------- ---------------- //
        #region Dot Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
        #endregion

        #region Meta-Properties
        public string ImagePath { get; set; }
        public string DirectoryPath { get; set; }
        public string SavePath { get; set; }
        public string ClassType { get; set; }
        #endregion

        #region string[] Lists
        public List<string[]> Notes { get; set; }
        public string[] HeadNotes { get; set; } = { "Title", "Time", "Tag", "Text" }; 
        #endregion

        public object this[string propertyName] {
            get {
                Type myType = this.GetType();
                PropertyInfo myPropInfo = myType.GetProperty(propertyName);
                return myPropInfo.GetValue(this, null);
            }
            set {
                Type myType = this.GetType();
                PropertyInfo myPropInfo = myType.GetProperty(propertyName);
                myPropInfo.SetValue(this, value, null);
            }
        }

        // ---------------- Constructors ---------------- ---------------- //
        public Dot() {
            // Get class type as string
            string[] classType = GetType().ToString().Split('.');
            ClassType = classType[classType.Length - 1];

            // Base directory of this type of object. Useful with the sub-classes
            DirectoryPath = Database.path + "\\" + ClassType;
            if (!System.IO.Directory.Exists(DirectoryPath)) System.IO.Directory.CreateDirectory(DirectoryPath);
            DirectoryInfo DI = new DirectoryInfo(DirectoryPath);

            // Create a new unique ID for this object.
            ID = ClassType + DI.GetFiles().Length;
            SavePath = DirectoryPath + "\\" + ID + ".txt";

            // Default information
            Name = ClassType + " Name";
            Description = "A short expose of what this is.";
            ImagePath = "";

            // Initialize list
            Notes = new List<string[]> { HeadNotes };
        }

        // ---------------- Methods ---------------- ---------------- //
        #region Get-Set-Property by Name
        public void SetPropertyByName<T>(string field, T value) {
            this[field] = value;
        }
        public dynamic GetPropertyByName(string field) {
            return this[field];
        } 
        #endregion
        public ListViewItem DotAsLVI(string[] IncludeTheseFields) {
            ListViewItem lvi = new ListViewItem(Name);
            foreach(string st in IncludeTheseFields) {
                lvi.SubItems.Add(GetPropertyByName(st));
            }
            lvi.SubItems.Add(ID);
            return lvi;
        }
        
        // ---------------- Meta-Methods ---------------- ---------------- //
        public int CompareTo(Dot obj) {
            // CompareTo for sorting implementation.
            if (obj == null) return 1;
            return string.Compare(ID, obj.ID);
        }
        override public string ToString() {
            return ID + ":" + Name;
        }

        #region Save-Load || I AM PRETTY SURE THIS WORKS DO NOT TOUCH IT IS VERY FRAGILE
        public void SaveFile() {
            // Serialize the Class object and save it to the appropriate location.
            SavePath = DirectoryPath + "\\" + ID + ".txt";
            System.IO.File.WriteAllText(SavePath, JsonConvert.SerializeObject(this));
        }
        public static dynamic LoadFromID(string fileID) {
            Type ClassType = Database.Dots[fileID.Substring(0, 3)];
            dynamic VarClassObj = Activator.CreateInstance(ClassType);
            return LoadFile(fileID, VarClassObj);
        }
#pragma warning disable IDE0060 // Remove unused parameter
        private static dynamic LoadFile<T>(string fileID, T Entity) {
            string SavePath = Database.path + "\\" + fileID.Substring(0, 3) + "\\" + fileID + ".txt";
            return JsonConvert.DeserializeObject<T>(System.IO.File.ReadAllText(SavePath));
        }
        public static dynamic LoadFileRaw<T>(string SavePath, T Entity) {
            dynamic d = JsonConvert.DeserializeObject<T>(System.IO.File.ReadAllText(SavePath));
            return d;
        }
#pragma warning restore IDE0060 // Remove unused parameter 
        #endregion

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // end of class
} // end of namespace
