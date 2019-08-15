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
        new public Itm ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public ItmEdit() {
            ViewItem = new Itm();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeItm();
        }
        public ItmEdit(Itm ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeItm();
        }
        private void InitializeItm() {
            InitializeStringList(listItemTags, ViewItem.ItemTags, ViewItem.HeadItemTags);
            InitializeStringList(listRolls, ViewItem.Rolls, ViewItem.HeadRolls);
            InitializeTextBox(textItemType);
            InitializeTextBox(textItemSubType);
            InitializeTextBoxNumerical(textMass);
            InitializeTextBoxNumerical(textValue);
            InitializeTextBoxNumerical(textMagicLevel);
            InitializeTextBoxNumerical(textRarity);
        }
        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
            using (ItmEdit newEditor = new ItmEdit()) {
                ViewItem = Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem);
                //newEditor.UpdateEditor();
                newEditor.Show();
            }
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace