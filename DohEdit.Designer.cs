namespace Sekai {
    partial class DohEdit {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listElements = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listElements
            // 
            this.listElements.Location = new System.Drawing.Point(951, 98);
            this.listElements.Name = "listElements";
            this.listElements.Size = new System.Drawing.Size(601, 624);
            this.listElements.TabIndex = 111;
            this.listElements.UseCompatibleStateImageBehavior = false;
            this.listElements.View = System.Windows.Forms.View.Details;
            // 
            // DohEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1564, 734);
            this.Controls.Add(this.listElements);
            this.Name = "DohEdit";
            this.Controls.SetChildIndex(this.listElements, 0);
            this.Controls.SetChildIndex(this.NotesLabel, 0);
            this.Controls.SetChildIndex(this.listNotes, 0);
            this.Controls.SetChildIndex(this.textName, 0);
            this.Controls.SetChildIndex(this.textDescription, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listElements;
    }
}
