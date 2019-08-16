using System;
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
            InitializeMdl();
        }
        public MdlEdit(Mdl ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeMdl();
        }
        private void InitializeMdl() {
            InitializeList(listEvents, ViewItem.Events, new string[] { "Name", "Location" });
            InitializeList(listCharacters, ViewItem.Characters, new string[] { "Name" });
            RegControlUpdateView();
        }
        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
#pragma warning disable IDE0067 // Dispose objects before losing scope
            MdlEdit newEditor = new MdlEdit(Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem));
#pragma warning restore IDE0067 // Dispose objects before losing scope
            newEditor.Show();
        }
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace