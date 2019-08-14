namespace Sekai {
    partial class MdlEdit {
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
            this.textType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lablEvents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listEvents
            // 
            this.listEvents.Location = new System.Drawing.Point(951, 264);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(601, 458);
            this.listEvents.TabIndex = 111;
            this.listEvents.UseCompatibleStateImageBehavior = false;
            // 
            // textType
            // 
            this.textType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textType.Location = new System.Drawing.Point(1104, 115);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(194, 26);
            this.textType.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(976, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 113;
            this.label1.Text = "Module Type";
            // 
            // lablEvents
            // 
            this.lablEvents.AutoSize = true;
            this.lablEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablEvents.Location = new System.Drawing.Point(948, 264);
            this.lablEvents.Name = "lablEvents";
            this.lablEvents.Size = new System.Drawing.Size(53, 18);
            this.lablEvents.TabIndex = 122;
            this.lablEvents.Text = "Events";
            // 
            // MdlEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1564, 734);
            this.Controls.Add(this.lablEvents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.listEvents);
            this.Name = "MdlEdit";
            this.Controls.SetChildIndex(this.listNotes, 0);
            this.Controls.SetChildIndex(this.NotesLabel, 0);
            this.Controls.SetChildIndex(this.textName, 0);
            this.Controls.SetChildIndex(this.textDescription, 0);
            this.Controls.SetChildIndex(this.listEvents, 0);
            this.Controls.SetChildIndex(this.textType, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lablEvents, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listEvents;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lablEvents;
    }
}
