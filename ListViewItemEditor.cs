using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sekai {
    public partial class ListViewItemEditor : Form {
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
        // ---------------- Class Variables ---------------- ---------------- //
        ListView Refer;
        Dictionary<ListView, List<string[]>> VM;
        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- Class Constructors ---------------- ---------------- //
        //TODO

        public ListViewItemEditor(ListView lv, Dictionary<ListView, List<string[]>> VMe) {
            if (lv.SelectedIndices.Count < 1) return;
            Refer = lv;
            VM = VMe;
            InitializeComponent();
            for (int i = 0; i < VM[lv][0].Length; i++) {
                listFields.Items.Add(lv.Columns[i].Text);
                listFields.Items[i].SubItems.Add(VM[lv][lv.SelectedIndices[0]][i]);
            }
        }

        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- Class Methods ---------------- ---------------- //
        private void ListFields_SelectedIndexChanged(object sender, EventArgs e) {
            try { textListItemEditor.Text = listFields.SelectedItems[0].SubItems[1].Text; }
            catch (Exception) { }
        }
        private void TextListItemEditor_TextChanged(object sender, EventArgs e) {
            if (Refer.SelectedIndices.Count < 1) return;
            VM[Refer][Refer.SelectedIndices[0]][listFields.SelectedIndices[0]] = textListItemEditor.Text;
            listFields.SelectedItems[0].SubItems[1].Text = textListItemEditor.Text;

        }
        private void ButtonLVIESave_Click(object sender, EventArgs e) {
            Close();
        }

        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- Class Meta-Methods ---------------- ---------------- //


        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace
