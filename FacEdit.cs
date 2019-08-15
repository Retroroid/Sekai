using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sekai {
    public partial class FacEdit : Sekai.Editor {
        // ---------------- Variables ---------------- ---------------- //
        new public Fac ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public FacEdit() {
            ViewItem = new Fac();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitialzieFac();
        }
        public FacEdit(Fac ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitialzieFac();
        }
        private void InitialzieFac() {
            InitializeList(listStaff, ViewItem.Staff, new string[] { "Name", "Shift", "CurrentlyDoing" });
            InitializeList(listClients, ViewItem.Clients, new string[] { "Name", "Location", "CurrentlyDoing" });
            InitializeStringList(listServices, ViewItem.Services, ViewItem.HeadServices);
            InitializeTextBox(textLocation);
            InitializeTextBox(textFocus);
        }
        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
            using (FacEdit newEditor = new FacEdit()) {
                ViewItem = Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem);
                //newEditor.UpdateEditor();
                newEditor.Show();
            }
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace