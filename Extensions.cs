using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekai {
    public static class Extensions {
        // ---------------- Interfaces ---------------- ---------------- //
        public interface IWeighable {
            int Weight { get; set; }
        }

        // ---------------- Methods ---------------- ---------------- //
        #region ListView sort by column
        public static void SortListByColumn(this List<string[]> SL, int Col) {
            List<string[]> TL = new List<string[]> { SL[0] };
            bool Placed;
            for (int s = 1; s < SL.Count; s++) {
                Placed = false;
                for (int t = 0; t < TL.Count; t++) {
                    int S_T = SL[s].LeftBeforeRight(TL[t], Col);
                    if (S_T < 0) {
                        TL.Insert(t, SL[s]);
                        Placed = true;
                        break;
                    }
                }
                if (!Placed) TL.Add(SL[s]);
            }
            foreach (string[] str in TL) {
                SL.RemoveAt(0);
                SL.Add(str);
            }
        }

        // Recursive stuff is cool
        public static int LeftBeforeRight(this string[] Left, string[] Right, int Col) {
            if (Left[Col].CompareTo(Right[Col]) != 0) return Left[Col].CompareTo(Right[Col]);
            return Left.LeftBeforeRight(Right, 0, Col);
        }
        public static int LeftBeforeRight(this string[] Left, string[] Right, int Col, int InitialCol) {
            if (Col == Left.Length) return 0;
            else if (Left[Col].CompareTo(Right[Col]) != 0) return Left[Col].CompareTo(Right[Col]);
            else {
                if (Col == InitialCol - 1) Col++;
                return Left.LeftBeforeRight(Right, Col + 1, InitialCol);
            }
        }
        #endregion

        #region Array Extensions
        public static void AddEmptyItem(this List<string[]> SL, int Col) {
            string[] newStr = new string[Col];
            newStr.Populate("-");
            SL.Add(newStr);
        } 
        public static void Populate<T>(this T[] arr, T value) {
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = value;
            }
        }
        #endregion

        #region Info From Path
        public static Type GetTypeFromPath(this string filePath) {
            return Database.Dots[filePath.GetIDFromPath().Substring(0, 3)];
        }
        public static string GetIDFromPath(this string filePath) {
            string[] splitlist = filePath.Split('\\');
            return splitlist[splitlist.Length - 1].Split('.')[0];
        } 
        #endregion

        public static T WeightedRandom<T>(List<T> list) where T : IWeighable {
            if (list.Count == 0) return default(T);
            int TotalWeight = list.Sum(c => c.Weight);
            int Target = Database.RNG.Next(TotalWeight);
            int SumSoFar = 0;
            for (int i = 0; i < list.Count; i++) {
                SumSoFar += list[i].Weight;
                if (Target <= SumSoFar) return list[i];
            }
            return list.First();
        }
        public static string[] PrepareToParse(this string sb) {
            string[] Splitter = new string[] { "\n" };
            string[] ReturnString = sb.Split(Splitter, StringSplitOptions.RemoveEmptyEntries);

            return ReturnString.ToArray();
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
