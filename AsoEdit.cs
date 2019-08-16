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
        new public Aso ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public AsoEdit() {
            ViewItem = new Aso();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeAsoEdit();
        }
        public AsoEdit(Aso ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeAsoEdit();
        }

        public void InitializeAsoEdit() {
            InitializeList(listLocations, ViewItem.Locations, new string[] { "Name" });
            InitializeList(listMembers, ViewItem.Members, new string[] { "Name", "Location", "CurrentlyDoing" });
            InitializeList(listGroups, ViewItem.Groups, new string[] { "Name", "Location" });
            InitializeStringList(listRanks, ViewItem.Ranks, ViewItem.HeadRanks);
            RegControlUpdateView();
        }
        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
#pragma warning disable IDE0067 // Dispose objects before losing scope
            AsoEdit newEditor = new AsoEdit(Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem));
#pragma warning restore IDE0067 // Dispose objects before losing scope
            newEditor.Show();
        }
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace