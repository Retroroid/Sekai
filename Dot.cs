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
        // ---------------- Variables and Structures ---------------- ---------------- //
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

        #region Get-And-Set By name definition
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
        #endregion

        public List<object> CopyList { get; set; }

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

        #region List Manipulation
        public void CreateListItems<T>(List<T> Liste, int[] Indices) {
            int index = 0;
            do {
                var x = (T)Activator.CreateInstance(typeof(T));
                Liste.Add(x);
                index++;
            } while (index < Indices.Length);
        }
        public void CopyListItems<T>(List<T> Liste, int[] Indices) {
            CopyList = new List<object>();
            foreach (int i in Indices) {
                CopyList.Add(Liste[i]);
            }
        }
        public void PasteListItems<T>(List<T> Liste, int[] Indices) {
            for (int i = 0; i < CopyList.Count && i < Indices.Length; i++) {
                Liste[Indices[i]] = (T)Convert.ChangeType(CopyList[i], typeof(T));
            }
        }
        public void DeleteListItems<T>(List<T> Liste, int[] Indices) {
            List<int> Index = Indices.ToList<int>();
            Index.Sort();
            for (int i = 0; i < Indices.Length && Index.Count != 0; i++) {
                Liste.RemoveAt(Index[Index.Count - 1]);
                Index.RemoveAt(Index.Count - 1);
            }
        }
        #endregion

        public ListViewItem DotAsLVI(string[] IncludeTheseFields) {
            if (IncludeTheseFields.Length == 0) throw new Exception("Included fields cannot be empty.");
            ListViewItem lvi = new ListViewItem(GetPropertyByName(IncludeTheseFields[0]));
            for(int i = 1; i < IncludeTheseFields.Length; i++){
                lvi.SubItems.Add((string)GetPropertyByName(IncludeTheseFields[i]));
            }
            return lvi;
        }
        public void OpenEditor() {
            this.OpenEditore();
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
