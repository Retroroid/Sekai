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

        public Dictionary<ListView, List<Dot>> LinkDotList;

        public List<ListViewItem> CopyList;

        // ---------------- Constructors and Initialization---------------- ---------------- //
        public Editor() {
            InitializeComponent();
        }
        public void PostInitialization(dynamic ViewItem) {
            this.ViewItem = ViewItem;

            RegularListView = new List<ListView>();
            RegularTextBox = new List<TextBox>();
            RegularTextBoxNumerical = new List<TextBox>();
            LinkLV = new Dictionary<ListView, List<string[]>>();
            LinkTB = new Dictionary<TextBox, string>();
            LinkNM = new Dictionary<TextBox, string>();

            Type T = Database.Dots[ViewItem.ClassType];
            LinkDotList = new Dictionary<ListView, List<Dot>>();

            RegularListView.Add(listNotes);
            RegularTextBox.Add(textName);
            RegularTextBox.Add(textDescription);

            openFileDialog.InitialDirectory = ViewItem.DirectoryPath;
            saveFileDialog.InitialDirectory = ViewItem.DirectoryPath;

            textName.TextChanged += new System.EventHandler(TextBaseDohnged);
            textDescription.TextChanged += new System.EventHandler(TextBaseDohnged);

            editToolStripMenuItem.Click += new System.EventHandler(ListViewEditItem);
            createToolStripMenuItem.Click += new System.EventHandler(CreateTSMI);
            copyToolStripMenuItem.Click += new System.EventHandler(CopyTSMI);
            pasteToolStripMenuItem.Click += new System.EventHandler(PasteTSMI);
            deleteToolStripMenuItem.Click += new System.EventHandler(DeleteTSMI);

            saveToolStripMenuItem.Click += new System.EventHandler(SaveTSMI);
            saveAsToolStripMenuItem.Click += new System.EventHandler(SaveAsTSMI);
            saveFileDialog.FileOk += new CancelEventHandler(SaveFileOK);
            openToolStripMenuItem.Click += new System.EventHandler(OpenTSMI);
        }

        #region Control Initialization (Regular)
        public void InitializeStringList(ListView lv, List<string[]> DataList, string[] Headers) {
            if (LinkLV.ContainsKey(lv)) LinkLV.Remove(lv);
            LinkLV.Add(lv, DataList);

            lv.FullRowSelect = true;
            lv.View = View.Details;
            lv.GridLines = true;
            lv.ContextMenuStrip = ContextList;
            lv.ColumnClick += new ColumnClickEventHandler(ListViewColumnClick);

            lv.Columns.Clear();
            for (int i = 0; i < Headers.Length; i++) {
                lv.Columns.Add(Headers[i]);
            }
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        #endregion

        // ---------------- Methods ---------------- ---------------- //
        #region View Updates
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
            lv.EndUpdate();
        }
        public void RegTBUpdateView(TextBox tb) {
            tb.Text = ViewItem.GetPropertyByName(LinkTB[tb]);
        }
        public void RegNMUpdateView(TextBox nm) {
            nm.Text = ViewItem.GetPropertyByName(LinkNM[nm]).ToString();
        }
        #endregion

        #region View Updates (Particular)


        #endregion

        #endregion

        #region Model Updates

        #region Model Updates (Regular)
        public void RegLVUpdateModel(ListViewItem lvi) {
            //TODO
            // Implemented already in the ListItemEditor?
        }
        public void RegTBUpdateModel(TextBox tb) {
            ViewItem.SetPropertyByName(tb.Name.Substring(4), tb.Text);
        }
        public void RegNMUpdateModel(TextBox nm) {
            ViewItem.SetPropertyByName(nm.Name.Substring(4), int.Parse(nm.Text));
        }
        #endregion

        #region Model Updates (Particular)


        #endregion 

        #endregion

        #region ListView Context List Options
        public void ListViewEditItem(object sender, EventArgs e) {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsmi.Owner;
            using (ListViewItemEditor lvie = new ListViewItemEditor(
                    (ListView)cms.SourceControl, LinkLV)) {
                lvie.ShowDialog();
            }
        }
        public void CreateTSMI(object sender, EventArgs e) {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsmi.Owner;
            ListView lv = (ListView)cms.SourceControl;
            int i = 0;
            do {
                LinkLV[lv].AddEmptyItem(lv.Columns.Count);
                i++;
            } while (i < lv.SelectedIndices.Count);
        }
        public void CopyTSMI(object sender, EventArgs e) {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsmi.Owner;
            ListView lv = (ListView)cms.SourceControl;
            if (lv.SelectedIndices.Count < 1) return;
            CopyList = new List<ListViewItem>();
            foreach (int si in lv.SelectedIndices) {
                CopyList.Add(LinkLV[lv][si]);
            }
        }
        public void PasteTSMI(object sender, EventArgs e) {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsmi.Owner;
            ListView lv = (ListView)cms.SourceControl;
            int i = 0;
            while (i < lv.SelectedIndices.Count && CopyList.Count > 0) {
                LinkLV[lv][lv.SelectedIndices[i]] = CopyList[0];
                CopyList.RemoveAt(0);
            }
            while (CopyList.Count > 0) {
                LinkLV[lv].Add(CopyList[0]);
                CopyList.RemoveAt(0);
            }
        }
        public void DeleteTSMI(object sender, EventArgs e) {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsmi.Owner;
            ListView lv = (ListView)cms.SourceControl;
            int i = 0;
            while (i < lv.SelectedIndices.Count) {
                LinkLV[lv].RemoveAt(lv.SelectedIndices[0]);
                i++;
            }
        } 
        #endregion

        public void ListViewColumnClick(object sender, ColumnClickEventArgs e) {
            LinkLV[sender as ListView].SortListByColumn(e.Column);
        }

        // ---------------- Meta-Methods ---------------- ---------------- //
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

        public void UpdateList(ListView lv) {
            lv.Items.Clear();
            ListViewItem lvi;
            for (int Row = 0; Row < LinkLV[lv].Count; Row++) {
                lvi = new ListViewItem(LinkLV[lv][Row][0]);
                for (int Col = 1; Col < LinkLV[lv][0].Length; Col++) lvi.SubItems.Add(LinkLV[lv][Row][Col]);
                lv.Items.Add(lvi);
            }
            foreach (ColumnHeader c in lv.Columns) { c.Width = -2; }
        }
        public void TextBaseDohnged(object sender, EventArgs e) {
            ViewItem.SetPropertyByName((sender as TextBox).Name.Substring(4), (sender as TextBox).Text);
        }
        public void NumericBaseDohnged(object sender, EventArgs e) {

        }
        
        // ---------------- ---------------- ---------------- ---------------- ---------------- //
    } // End of class
} // End of namespace