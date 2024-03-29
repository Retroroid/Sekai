﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sekai {
    public partial class GhlEdit : Sekai.Editor {
        // ---------------- Variables ---------------- ---------------- //
        new public Ghl ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public GhlEdit() {
            ViewItem = new Ghl();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeGhl();
        }
        public GhlEdit(Ghl ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeGhl();
        }
        private void InitializeGhl() {
            InitializeList(listStaff, ViewItem.Staff, new string[] { "Name", "Shift", "CurrentlyDoing" });
            InitializeList(listCommonRoom, ViewItem.CommonRoom, new string[] { "Name", "CurrentlyDoing" });
            InitializeStringList(listQuestboard, ViewItem.Questboard, ViewItem.HeadQuestboard);
            InitializeStringList(listServices, ViewItem.Services, ViewItem.HeadServices);
            RegControlUpdateView();
        }
        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
#pragma warning disable IDE0067 // Dispose objects before losing scope
            GhlEdit newEditor = new GhlEdit(Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem));
#pragma warning restore IDE0067 // Dispose objects before losing scope
            newEditor.Show();
        }
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace