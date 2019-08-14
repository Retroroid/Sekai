using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sekai {
    public partial class ChaEdit : Sekai.Editor {
        // ---------------- Variables ---------------- ---------------- //
        public Cha ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public ChaEdit() {
            ViewItem = new Cha();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            UpdateEditor();
        }
        public ChaEdit(Cha ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            UpdateEditor();
        }

        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
            using (ChaEdit newEditor = new ChaEdit()) {
                ViewItem = Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem);
                newEditor.UpdateEditor();
                newEditor.Show();
            }
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace