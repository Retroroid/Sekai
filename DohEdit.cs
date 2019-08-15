using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sekai {
    public partial class DohEdit : Sekai.Editor {
        // ---------------- Variables ---------------- ---------------- //
        new public Doh ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public DohEdit() {
            ViewItem = new Doh();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitialzieDoh();
        }
        public DohEdit(Doh ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitialzieDoh();
        }
        private void InitialzieDoh() {
            // TODO
        }
        // ---------------- Methods ---------------- ---------------- //
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
            
        // ---------------- Meta-Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
            using (DohEdit newEditor = new DohEdit()) {
                ViewItem = Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem);
                //newEditor.UpdateEditor();
                newEditor.Show();
            }
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
