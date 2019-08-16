using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekai {
    public partial class Editor : Form {
        // ---------------- Variables ---------------- ---------------- //
        public Dot ViewItem { get; set; }

        #region Regular Lists
        public List<ListView> RegularListView;
        public List<TextBox> RegularTextBox;
        public List<TextBox> RegularTextBoxNumerical;
        public Dictionary<ListView, List<string[]>> LinkLV;
        public Dictionary<TextBox, string> LinkTB;
        public Dictionary<TextBox, string> LinkNM;
        #endregion

        public Dictionary<ListView, string[]> ListHeaders;

        public Dictionary<ListView, dynamic> ListLink;
        public Dictionary<ListView, Type> ListType;

        // ---------------- Constructors and Initialization---------------- ---------------- //
        public Editor() {
            InitializeComponent();
        }
        public void PostInitialization(dynamic ViewItem) {
            this.ViewItem = ViewItem;

            #region Dictionary and List ini
            ListLink = new Dictionary<ListView, dynamic>();
            ListHeaders = new Dictionary<ListView, string[]>();
            ListType = new Dictionary<ListView, Type>();

            RegularListView = new List<ListView>();
            RegularTextBox = new List<TextBox>();
            RegularTextBoxNumerical = new List<TextBox>();
            LinkLV = new Dictionary<ListView, List<string[]>>();
            LinkTB = new Dictionary<TextBox, string>();
            LinkNM = new Dictionary<TextBox, string>();

            InitializeStringList(listNotes, ViewItem.Notes, ViewItem.HeadNotes);
            InitializeTextBox(textName);
            InitializeTextBox(textDescription);
            #endregion

            #region Directory path and event handling
            openFileDialog.InitialDirectory = ViewItem.DirectoryPath;
            saveFileDialog.InitialDirectory = ViewItem.DirectoryPath;

            editToolStripMenuItem.Click += new System.EventHandler(ListViewEditItem);
            createToolStripMenuItem.Click += new System.EventHandler(CreateTSMI);
            copyToolStripMenuItem.Click += new System.EventHandler(CopyTSMI);
            pasteToolStripMenuItem.Click += new System.EventHandler(PasteTSMI);
            deleteToolStripMenuItem.Click += new System.EventHandler(DeleteTSMI);

            saveToolStripMenuItem.Click += new System.EventHandler(SaveTSMI);
            saveAsToolStripMenuItem.Click += new System.EventHandler(SaveAsTSMI);
            saveFileDialog.FileOk += new CancelEventHandler(SaveFileOK);
            openToolStripMenuItem.Click += new System.EventHandler(OpenTSMI);
            #endregion
        }

        #region Control Initialization
        public void InitializeStringList(ListView lv, List<string[]> DataList, string[] Headers) {
            if (LinkLV.ContainsKey(lv)) LinkLV.Remove(lv);
            LinkLV.Add(lv, DataList);
            RegularListView.Add(lv);

            lv.FullRowSelect = true;
            lv.View = View.Details;
            lv.GridLines = true;
            lv.ContextMenuStrip = ContextList;
            lv.ColumnClick += new ColumnClickEventHandler(ListViewColumnClick);

            lv.Columns.Clear();
            for (int i = 0; i < Headers.Length; i++) {
                lv.Columns.Add(Headers[i]);
            }
            ListHeaders.Add(lv, Headers);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void InitializeTextBox(TextBox tb) {
            RegularTextBox.Add(tb);
            LinkTB.Add(tb, tb.Name.Substring(4));
            RegTBUpdateView(tb);
            tb.TextChanged += new EventHandler(TextBox_TextChanged);
        }
        public void InitializeTextBoxNumerical(TextBox tb) {
            RegularTextBoxNumerical.Add(tb);
            LinkNM.Add(tb, tb.Name.Substring(4));
            tb.TextChanged += new EventHandler(TextBoxNumerical_TextChanged);
            tb.KeyPress += new KeyPressEventHandler(TextBoxNumerical_KeyPressed);
            RegNMUpdateView(tb);
        }
        public void InitializeList<T>(ListView lv, List<T> Liste, string[] Headers) {
            lv.FullRowSelect = true;
            lv.View = View.Details;
            lv.GridLines = true;
            lv.ContextMenuStrip = ContextList;
            lv.ColumnClick += new ColumnClickEventHandler(ListViewColumnClick);
            lv.Columns.Clear();
            for (int i = 0; i < Headers.Length; i++) {
                lv.Columns.Add(Headers[i]);
            }
            ListLink.Add(lv, Liste);
            ListHeaders.Add(lv, Headers);
            ListType.Add(lv, typeof(T));
            for (int i = 0; i < ListLink[lv].Count; i++) {
                lv.Items.Add(ListLink[lv][i].DotAsLVI(ListHeaders[lv]));
            }
            if (lv.Items.Count == 0) lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            else lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        #endregion

        // ---------------- Methods ---------------- ---------------- //
        #region View Updates (Regular)
        public void RegControlUpdateView() {
            foreach (ListView lv in RegularListView) { RegLVUpdateView(lv); }
            foreach (TextBox tb in RegularTextBox) { RegTBUpdateView(tb); }
            foreach (TextBox tb in RegularTextBoxNumerical) { RegNMUpdateView(tb); }
        }
        public void RegLVUpdateView(ListView lv) {
            lv.BeginUpdate();
            lv.Items.Clear();
            for (int i = 0; i < LinkLV[lv].Count; i++) {
                lv.Items.Add(new ListViewItem(LinkLV[lv][i]));
            }
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.EndUpdate();
        }
        public void RegTBUpdateView(TextBox tb) {
            tb.Text = ViewItem.GetPropertyByName(LinkTB[tb]);
        }
        public void RegNMUpdateView(TextBox nm) {
            nm.Text = ViewItem.GetPropertyByName(LinkNM[nm]).ToString();
        }
        #endregion

        #region Model Updates (Regular)

        //public void RegLVUpdateModel(ListViewItem lvi) {
        //    //TODO
        //    // Implemented already in the ListItemEditor?
        //}
        public void RegTBUpdateModel(TextBox tb) {
            ViewItem.SetPropertyByName(tb.Name.Substring(4), tb.Text);
        }
        public void RegNMUpdateModel(TextBox nm) {
            ViewItem.SetPropertyByName(nm.Name.Substring(4), int.Parse(nm.Text));
        }
        #endregion

        #region ListView Context List Options (Including new editor from list)
        public void ListViewEditItem(object sender, EventArgs e) {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsmi.Owner;
            ListView lv = (ListView)cms.SourceControl;
            if (RegularListView.Contains(lv)) {
                using (ListViewItemEditor lvie = new ListViewItemEditor(
                    lv, LinkLV)) {
                    lvie.ShowDialog();
                }
                RegLVUpdateView(lv);
            }
            else {
                OpenByReference(lv);
                lv.Refresh();
            }
        }
        public void OpenByReference(ListView lv) {
            if (lv.SelectedIndices.Count == 0) return;
            ListLink[lv][lv.SelectedIndices[0]].OpenEditor();
        }

        public void CreateTSMI(object sender, EventArgs e) {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsmi.Owner;
            ListView lv = (ListView)cms.SourceControl;
            if (RegularListView.Contains(lv)) {
                ViewItem.CreateListItemsString(LinkLV[lv], ListHeaders[lv], lv.SelectedIndices.IndicesToArray());
                for (int i = lv.Items.Count; i < LinkLV[lv].Count; i++) {
                    lv.Items.Add(new ListViewItem(LinkLV[lv][i]));
                }
                lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lv.Update();
            }
            else {
                ViewItem.CreateListItems(ListLink[lv], lv.SelectedIndices.IndicesToArray());
                // ^ This line does the work. Everything else is just display for the results of the list change.
                for (int i = lv.Items.Count; i < ListLink[lv].Count; i++) {
                    lv.Items.Add(ListLink[lv][i].DotAsLVI(ListHeaders[lv]));
                }
                lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lv.Update();
            }
        }
        public void CopyTSMI(object sender, EventArgs e) {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsmi.Owner;
            ListView lv = (ListView)cms.SourceControl;
            if (RegularListView.Contains(lv)) {
                ViewItem.CopyListItemsString(LinkLV[lv], lv.SelectedIndices.IndicesToArray());
            }
            else {
                ViewItem.CopyListItems(ListLink[lv], lv.SelectedIndices.IndicesToArray());
            }
        }
        public void PasteTSMI(object sender, EventArgs e) {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsmi.Owner;
            ListView lv = (ListView)cms.SourceControl;
            if (RegularListView.Contains(lv)) {
                ViewItem.PasteListItemsString(LinkLV[lv], lv.SelectedIndices.IndicesToArray());
                RegLVUpdateView(lv);
            }
            else {
                ViewItem.PasteListItems(ListLink[lv], lv.SelectedIndices.IndicesToArray());
                foreach (int i in lv.SelectedIndices) {
                    lv.Items[i] = ListLink[lv][i].DotAsLVI(ListHeaders[lv]);
                }
                lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lv.Update();
            }
        }
        public void DeleteTSMI(object sender, EventArgs e) {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsmi.Owner;
            ListView lv = (ListView)cms.SourceControl;
            if (RegularListView.Contains(lv)) {
                ViewItem.DeleteListItems(LinkLV[lv], lv.SelectedIndices.IndicesToArray());
                lv.Items.Clear();
                for (int i = 0; i < LinkLV[lv].Count; i++) {
                    lv.Items.Add(new ListViewItem(LinkLV[lv][i]));
                }
            }
            else {
                ViewItem.DeleteListItems(ListLink[lv], lv.SelectedIndices.IndicesToArray());
                lv.Items.Clear();
                for (int i = 0; i < ListLink[lv].Count; i++) {
                    lv.Items.Add(ListLink[lv][i].DotAsLVI(ListHeaders[lv]));
                }
            }
        }
        #endregion

        public void ListViewColumnClick(object sender, ColumnClickEventArgs e) {
            LinkLV[sender as ListView].SortListByColumn(e.Column);
        }

        public void TextBox_TextChanged(object sender, EventArgs e) {
            ViewItem.SetPropertyByName((sender as TextBox).Name.Substring(4), (sender as TextBox).Text);
        }

        // ---------------- Meta-Methods ---------------- ---------------- //
        #region Numerical Text Box Masking
        public void TextBoxNumerical_TextChanged(object sender, EventArgs e) {
            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, "  ^ [0-9]")) {
                (sender as TextBox).Text = "";
            }
            else ViewItem.SetPropertyByName((sender as TextBox).Name.Substring(4), int.Parse((sender as TextBox).Text));
        }
        public void TextBoxNumerical_KeyPressed(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }
        #endregion

        #region Save-Load
        public void SaveTSMI(object sender, EventArgs e) { ViewItem.SaveFile(); }
        public void SaveAsTSMI(object sender, EventArgs e) { saveFileDialog.ShowDialog(); }
        public void SaveFileOK(object sender, CancelEventArgs e) {
            string path = (sender as SaveFileDialog).FileName;
            ViewItem.ID = path.GetIDFromPath();
            ViewItem.SaveFile();
        }
        public void OpenTSMI(object sender, EventArgs e) { openFileDialog.ShowDialog(); }
        public virtual void OpenFileOK(object sender, CancelEventArgs e) { }
        #endregion

        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace