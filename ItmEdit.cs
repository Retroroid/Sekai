using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sekai {
    public partial class ItmEdit : Sekai.Editor {
        // ---------------- Variables ---------------- ---------------- //
        public Itm ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public ItmEdit() {
            ViewItem = new Itm();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            UpdateEditor();
        }
        public ItmEdit(Itm ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            UpdateEditor();
        }

        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
            using (ItmEdit newEditor = new ItmEdit()) {
                ViewItem = Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem);
                newEditor.UpdateEditor();
                newEditor.Show();
            }
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace