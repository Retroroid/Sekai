using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sekai {
    public partial class DohEdit : Sekai.Editor {
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
        // ---------------- Class Variables ---------------- ---------------- //
        public Doh ViewItem;

        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- Class Constructors ---------------- ---------------- //
        public DohEdit() {
            ViewItem = new Doh();

            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeD100();

            UpdateD100();
            UpdateEditor();
        }
        public DohEdit(Doh ViewItem) {
            this.ViewItem = ViewItem;

            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeD100();

            UpdateD100();
            UpdateEditor();
        }
        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- Class Methods ---------------- ---------------- //
        public void InitializeD100() {
            listElements.Columns.Add("Weight");
            listElements.Columns.Add("Value");
        }
        public void UpdateD100() {
            listElements.Items.Clear();
            foreach (Element el in ViewItem.Elements) {
                ListViewItem lvi = new ListViewItem(el.Weight.ToString());
                lvi.SubItems.Add(el.Value);
                listElements.Items.Add(lvi);
            }
            listElements.Columns[0].Width = 50;
            listElements.Columns[1].Width = -2;
        }
        public void AddSomeData() {
            ViewItem.Elements.Add(new Sekai.Element(Database.RNG.Next(30), "Element 1"));
            ViewItem.Elements.Add(new Sekai.Element(Database.RNG.Next(30), "Element 2"));
            ViewItem.Elements.Add(new Sekai.Element(Database.RNG.Next(30), "Element 3"));
            ViewItem.Elements.Add(new Sekai.Element(Database.RNG.Next(100), "Element 4"));
            ViewItem.Elements.Add(new Sekai.Element(Database.RNG.Next(100), "Element 5"));
            ViewItem.Elements.Add(new Sekai.Element(Database.RNG.Next(100), "Element 6"));
            ViewItem.Elements.Add(new Sekai.Element(Database.RNG.Next(50), "Element 7"));
            ViewItem.Elements.Add(new Sekai.Element(Database.RNG.Next(50), "Element 8"));
            ViewItem.Elements.Add(new Sekai.Element(Database.RNG.Next(60), "Element 9"));
            ViewItem.Elements.Add(new Sekai.Element(Database.RNG.Next(60), "Element 10"));
            listElements.Update();
        }
        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- Control Methods ---------------- ---------------- //
        private void Button1_Click(object sender, EventArgs e) {
            if (listElements.Items.Count == 0) return;
            int ItemIndex = ViewItem.RollOnTableForIndex();
            foreach(ListViewItem lvi in listElements.Items) {
                lvi.Selected = false;
            }
            listElements.Items[ItemIndex].Focused = true;
            listElements.Items[ItemIndex].Selected = true;
            textValue.Text = listElements.SelectedItems[0].SubItems[1].Text;
        }

        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- Class Meta-Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
            DohEdit newEditor = new DohEdit(
                Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem));
            newEditor.UpdateEditor();
            newEditor.Show();
        }

        private void Button2_Click(object sender, EventArgs e) {
            AddSomeData();
            UpdateD100();
        }

        private void ListElements_SelectedIndexChanged(object sender, EventArgs e) {
            if (listElements.SelectedIndices.Count == 0) return;
            string temptext = ViewItem.Elements[listElements.SelectedIndices[0]].Value;
            int tempvalue = ViewItem.Elements[listElements.SelectedIndices[0]].Weight;
            textValue.Text = temptext;
            nyumWeight.Value = tempvalue;
        }

        private void TextValue_TextChanged(object sender, EventArgs e) {
            foreach (ListViewItem lvi in listElements.SelectedItems) {
                ViewItem.Elements[lvi.Index].Value = textValue.Text;
            }
        }

        private void NyumWeight_ValueChanged(object sender, EventArgs e) {
            foreach(ListViewItem lvi in listElements.SelectedItems) {
                ViewItem.Elements[lvi.Index].Weight = (int)nyumWeight.Value;
            }
        }

        private void Button3_Click(object sender, EventArgs e) {
            UpdateD100();
        }

        private void TextValue_MouseLeave(object sender, EventArgs e) {
            UpdateD100();
        }
        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
