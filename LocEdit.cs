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
            RegControlUpdateView();
        }
        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
#pragma warning disable IDE0067 // Dispose objects before losing scope
            LocEdit newEditor = new LocEdit(Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem));
#pragma warning restore IDE0067 // Dispose objects before losing scope
            newEditor.Show();
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace