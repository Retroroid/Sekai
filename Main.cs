using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekai {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }
#pragma warning disable IDE0067 // Dispose objects before losing scope
        private void ButtonCha_Click(object sender, EventArgs e) {
            new ChaEdit().Show();
        }

        private void ButtonItm_Click(object sender, EventArgs e) {
            new ItmEdit().Show();
        }

        private void ButtonAso_Click(object sender, EventArgs e) {
            new AsoEdit().Show();
        }

        private void ButtonFac_Click(object sender, EventArgs e) {
            new FacEdit().Show();
        }

        private void ButtonGhl_Click(object sender, EventArgs e) {
            new GhlEdit().Show();
        }

        private void ButtonMdl_Click(object sender, EventArgs e) {
            new MdlEdit().Show();
        }

        private void ButtonLoc_Click(object sender, EventArgs e) {
            new LocEdit().Show();
        }

        private void ButtonDoh_Click(object sender, EventArgs e) {
            new DohEdit().Show();
        }

        private void ButtonEvt_Click(object sender, EventArgs e) {
            new EvtEdit().Show();
        }

        private void ButtonDot_Click(object sender, EventArgs e) {

        }
#pragma warning restore IDE0067 // Dispose objects before losing scope
        // ---------------- ---------------- ---------------- ---------------- //
        // ---------------- Class Meta-Methods ---------------- ---------------- //

    } // End of class
} // End of namespace
