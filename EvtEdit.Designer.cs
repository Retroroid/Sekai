namespace Sekai {
    partial class EvtEdit {
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
            this.listEvents = new System.Windows.Forms.ListView();
            this.lablEvents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listEvents
            // 
            this.listEvents.Location = new System.Drawing.Point(12, 381);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(933, 341);
            this.listEvents.TabIndex = 111;
            this.listEvents.UseCompatibleStateImageBehavior = false;
            // 
            // lablEvents
            // 
            this.lablEvents.AutoSize = true;
            this.lablEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablEvents.Location = new System.Drawing.Point(9, 378);
            this.lablEvents.Name = "lablEvents";
            this.lablEvents.Size = new System.Drawing.Size(53, 18);
            this.lablEvents.TabIndex = 122;
            this.lablEvents.Text = "Events";
            // 
            // EvtEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1564, 734);
            this.Controls.Add(this.lablEvents);
            this.Controls.Add(this.listEvents);
            this.Name = "EvtEdit";
            this.Controls.SetChildIndex(this.listNotes, 0);
            this.Controls.SetChildIndex(this.NotesLabel, 0);
            this.Controls.SetChildIndex(this.textName, 0);
            this.Controls.SetChildIndex(this.textDescription, 0);
            this.Controls.SetChildIndex(this.listEvents, 0);
            this.Controls.SetChildIndex(this.lablEvents, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listEvents;
        public System.Windows.Forms.Label lablEvents;
    }
}
