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
            this.lablEvents = new System.Windows.Forms.Label();
            this.lablCharacters = new System.Windows.Forms.Label();
            this.listCharacters = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listEvents
            // 
            this.listEvents.Location = new System.Drawing.Point(12, 408);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(421, 314);
            this.listEvents.TabIndex = 111;
            this.listEvents.UseCompatibleStateImageBehavior = false;
            // 
            // lablEvents
            // 
            this.lablEvents.AutoSize = true;
            this.lablEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablEvents.Location = new System.Drawing.Point(9, 387);
            this.lablEvents.Name = "lablEvents";
            this.lablEvents.Size = new System.Drawing.Size(53, 18);
            this.lablEvents.TabIndex = 122;
            this.lablEvents.Text = "Events";
            // 
            // lablCharacters
            // 
            this.lablCharacters.AutoSize = true;
            this.lablCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablCharacters.Location = new System.Drawing.Point(521, 387);
            this.lablCharacters.Name = "lablCharacters";
            this.lablCharacters.Size = new System.Drawing.Size(81, 18);
            this.lablCharacters.TabIndex = 124;
            this.lablCharacters.Text = "Characters";
            // 
            // listCharacters
            // 
            this.listCharacters.Location = new System.Drawing.Point(524, 408);
            this.listCharacters.Name = "listCharacters";
            this.listCharacters.Size = new System.Drawing.Size(421, 314);
            this.listCharacters.TabIndex = 123;
            this.listCharacters.UseCompatibleStateImageBehavior = false;
            // 
            // MdlEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1564, 734);
            this.Controls.Add(this.lablCharacters);
            this.Controls.Add(this.listCharacters);
            this.Controls.Add(this.lablEvents);
            this.Controls.Add(this.listEvents);
            this.Name = "MdlEdit";
            this.Controls.SetChildIndex(this.listNotes, 0);
            this.Controls.SetChildIndex(this.NotesLabel, 0);
            this.Controls.SetChildIndex(this.textName, 0);
            this.Controls.SetChildIndex(this.textDescription, 0);
            this.Controls.SetChildIndex(this.listEvents, 0);
            this.Controls.SetChildIndex(this.lablEvents, 0);
            this.Controls.SetChildIndex(this.listCharacters, 0);
            this.Controls.SetChildIndex(this.lablCharacters, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listEvents;
        public System.Windows.Forms.Label lablEvents;
        public System.Windows.Forms.Label lablCharacters;
        private System.Windows.Forms.ListView listCharacters;
    }
}
