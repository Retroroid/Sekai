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
        new public Cha ViewItem;

        // ---------------- Constructors ---------------- ---------------- //
        public ChaEdit() {
            ViewItem = new Cha();
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeCha();
        }
        public ChaEdit(Cha ViewItem) {
            this.ViewItem = ViewItem;
            InitializeComponent();
            PostInitialization(ViewItem);
            openFileDialog.FileOk += new CancelEventHandler(OpenFileOK);
            InitializeCha();
            RegControlUpdateView();
        }
        private void InitializeCha() {
            InitializeList(listInventory, ViewItem.Inventory, new string[] { "Name", "ItemType","Quantity" });
            InitializeStringList(listAttacks, ViewItem.Attacks, ViewItem.HeadAttacks);
            InitializeStringList(listAbilities, ViewItem.Abilities, ViewItem.HeadAbilities);
            InitializeStringList(listAccolades, ViewItem.Accolades, ViewItem.HeadAccolades);

            InitializeTextBoxNumerical(textSTR);
            InitializeTextBoxNumerical(textDEX);
            InitializeTextBoxNumerical(textCON);
            InitializeTextBoxNumerical(textINT);
            InitializeTextBoxNumerical(textWIS);
            InitializeTextBoxNumerical(textCHA);

            InitializeTextBoxNumerical(textPB);
            InitializeTextBoxNumerical(textAC);
            InitializeTextBoxNumerical(textSpeed);
            InitializeTextBoxNumerical(textHPCurrent);
            InitializeTextBoxNumerical(textHPMax);

            InitializeSkillList();
            RegControlUpdateView();
        }
        private void InitializeSkillList() {
            listSkills.FullRowSelect = true;
            listSkills.View = View.Details;
            listSkills.GridLines = true;
            listSkills.ColumnClick += new ColumnClickEventHandler(ListViewColumnClick);
            listSkills.Columns.Clear();
            listSkills.CheckBoxes = true;
            for(int i = 0; i < Cha.SkillIndexName.Count; i++) {
                ListViewItem lvi = new ListViewItem(Cha.SkillList[i]);
                lvi.SubItems.Add(ViewItem.SkillBonus[i].ToString());
                lvi.SubItems.Add(Cha.SkillBaseByName[Cha.SkillIndexName[i]]);
                lvi.Checked = ViewItem.SkillProficient[i];
            }
            listSkills.Columns.Add("Skill");
            listSkills.Columns.Add("+");
            listSkills.Columns.Add("Base");
        }
        // ---------------- Methods ---------------- ---------------- //
        override public void OpenFileOK(object sender, CancelEventArgs e) {
#pragma warning disable IDE0067 // Dispose objects before losing scope
            ChaEdit newEditor = new ChaEdit(Dot.LoadFileRaw((sender as OpenFileDialog).FileName, ViewItem));
#pragma warning restore IDE0067 // Dispose objects before losing scope
            newEditor.Show();
        }

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace