﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sekai {
    public partial class MdlEdit : Sekai.Editor {
        // ---------------- Variables ---------------- ---------------- //
        new public Mdl ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public MdlEdit() {
            ViewItem = new Mdl();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            //UpdateEditor();
        }
        public MdlEdit(Mdl ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            //UpdateEditor();
        }

        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
            using (MdlEdit newEditor = new MdlEdit()) {
                ViewItem = Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem);
                newEditor.Show();
            }
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace