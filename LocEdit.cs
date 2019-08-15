using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sekai {
    public partial class LocEdit : Sekai.Editor {
        // ---------------- Variables ---------------- ---------------- //
        new public Loc ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public LocEdit() {
            ViewItem = new Loc();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeLoc();
        }
        public LocEdit(Loc ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeLoc();
        }
        private void InitializeLoc() {
            InitializeStringList(listExports, ViewItem.Exports, ViewItem.HeadExports);
            InitializeStringList(listImports, ViewItem.Imports, ViewItem.HeadImports);
            InitializeList(listFacilities, ViewItem.Facilities, new string[] { "Name", "Focus" });
            InitializeList(listCharacters, ViewItem.Characters, new string[] { "Name", "Shift" });
            InitializeTextBox(textLocationPath);
        }
        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
            using (LocEdit newEditor = new LocEdit()) {
                ViewItem = Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem);
                //newEditor.UpdateEditor();
                newEditor.Show();
            }
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace