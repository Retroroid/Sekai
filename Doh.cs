using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sekai.Extensions;

namespace Sekai {
    public class Element : IComparable {
        public static int SortBy { get; set; } // 0 for Weight, 1 for Value
        public int Weight { get; set; }
        public string Value { get; set; }
        public string LinkID { get; set; }
        public Element(int Weight, string Value) {
            this.Weight = Weight;
            this.Value = Value;
            LinkID = string.Empty;
        }
        [JsonConstructor]
        public Element(int Weight, string Value, string LinkID) {
            this.Weight = Weight;
            this.Value = Value;
            this.LinkID = LinkID;
            SortBy = 0;
        }
        public int CompareTo(object Ele) {
            Element Elem = Ele as Element;
            switch (SortBy) {
                case 0:
                return this.Weight - Elem.Weight;

                case 1:
                return this.Value.CompareTo(Elem.Value);

                default:
                throw new Exception("CompareTo Error in Element.CompareTo(Object)");
            }
        }
    }

    public class Doh : Dot {
        
        // ---------------- Variables ---------------- ---------------- //
        public List<Element> Elements { get; set; }
        public Doh Parent { get; set; }
        public Doh Child { get; set; }
        
        // ---------------- Constructors ---------------- ---------------- //
        public Doh() {
            Elements = new List<Element>();
        }

        // ---------------- Methods ---------------- ---------------- //
        #region Rolls
        public Element RollOnTable() {
            if (Elements.Count == 0) return null;
            int MaxRoll = Elements.Sum(c => c.Weight);
            int Target = Database.RNG.Next(MaxRoll);
            int CurrentlyAt = 0;
            for (int i = 0; i < Elements.Count; i++) {
                CurrentlyAt += Elements[i].Weight;
                if (Target < CurrentlyAt) return Elements[i];
            }
            return Elements.First();
        }
        public int RollOnTableForIndex() {
            if (Elements.Count == 0) return 0;
            int MaxRoll = Elements.Sum(c => c.Weight);
            int Target = Database.RNG.Next(MaxRoll);
            int CurrentlyAt = 0;
            for (int i = 0; i < Elements.Count; i++) {
                CurrentlyAt += Elements[i].Weight;
                if (Target < CurrentlyAt) return i;
            }
            return 0;
        }
        public int[] GetRollRanges() {
            int[] ReturnArray = new int[Elements.Count];
            for (int i = 1; i < Elements.Count; i++) {
                if (i == 0) ReturnArray[0] = Elements[0].Weight;
                else ReturnArray[i] = ReturnArray[i - 1] + Elements[i].Weight;
            }
            return ReturnArray;
        }
        #endregion

        #region Node Ordering
        public void CreateChildNode() {
            if (!Child.Equals(null)) throw new Exception("Doh already has a child Doh. (Sekai.Doh.CreateChildNode)");
            Child = new Doh();
        }
        public void InsertNode(bool GoesBeforeThis, Doh ToInsert) {
            if (GoesBeforeThis) {
                ToInsert.Parent = Parent;
                ToInsert.Child = this;
                ToInsert.Parent.Child = ToInsert;
                Parent = ToInsert;
            }
            else {
                ToInsert.Child = Child;
                ToInsert.Parent = this;
                ToInsert.Child.Parent = ToInsert;
                Child = ToInsert;
            }
        }
        #endregion
        public void SortList(int SortByWeightOrValue_0_1) {
            Element.SortBy = SortByWeightOrValue_0_1;
            Elements.Sort();
        }
        
        // ---------------- Meta-Methods ---------------- ---------------- //
        public void ImportListFromFile(string FilePath) {
            string[] ToParse = System.IO.File.ReadAllText(FilePath).PrepareToParse();
            Elements.Clear();
            foreach(string st in ToParse) {
                Elements.Add(new Element(1, st));
            }
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
