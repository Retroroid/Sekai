using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sekai {
    public partial class AsoEdit : Sekai.Editor {
        // ---------------- Variables ---------------- ---------------- //
        public Aso ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public AsoEdit() {
            ViewItem = new Aso();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            UpdateEditor();
        }
        public AsoEdit(Aso ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            UpdateEditor();
        }

        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
            using (AsoEdit newEditor = new AsoEdit()) {
                ViewItem = Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem);
                newEditor.UpdateEditor();
                newEditor.Show();
            }
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace