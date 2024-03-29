﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sekai {
    public partial class EvtEdit : Sekai.Editor {
        // ---------------- Variables ---------------- ---------------- //
        new public Evt ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public EvtEdit() {
            ViewItem = new Evt();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeEvt();
        }
        public EvtEdit(Evt ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeEvt();
        }
        private void InitializeEvt() {
            InitializeList(listSubEvents, ViewItem.SubEvents, new string[] { "Name", "Location" } );
            InitializeList(listCharacters, ViewItem.Characters, new string[] { "Name" });
            InitializeList(listRandomEvents, ViewItem.RandomEvents, new string[] { "Name" });
            RegControlUpdateView();
        }
        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
#pragma warning disable IDE0067 // Dispose objects before losing scope
            EvtEdit newEditor = new EvtEdit(Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem));
#pragma warning restore IDE0067 // Dispose objects before losing scope
            newEditor.Show();
        }
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace