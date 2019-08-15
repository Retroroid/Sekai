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
            this.listSubEvents = new System.Windows.Forms.ListView();
            this.lablEvents = new System.Windows.Forms.Label();
            this.listCharacters = new System.Windows.Forms.ListView();
            this.listRandomEvents = new System.Windows.Forms.ListView();
            this.lablCharacters = new System.Windows.Forms.Label();
            this.lablRandomEvents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listSubEvents
            // 
            this.listSubEvents.Location = new System.Drawing.Point(12, 399);
            this.listSubEvents.Name = "listSubEvents";
            this.listSubEvents.Size = new System.Drawing.Size(404, 323);
            this.listSubEvents.TabIndex = 111;
            this.listSubEvents.UseCompatibleStateImageBehavior = false;
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
            // listCharacters
            // 
            this.listCharacters.Location = new System.Drawing.Point(422, 399);
            this.listCharacters.Name = "listCharacters";
            this.listCharacters.Size = new System.Drawing.Size(402, 323);
            this.listCharacters.TabIndex = 123;
            this.listCharacters.UseCompatibleStateImageBehavior = false;
            // 
            // listRandomEvents
            // 
            this.listRandomEvents.Location = new System.Drawing.Point(830, 399);
            this.listRandomEvents.Name = "listRandomEvents";
            this.listRandomEvents.Size = new System.Drawing.Size(722, 323);
            this.listRandomEvents.TabIndex = 125;
            this.listRandomEvents.UseCompatibleStateImageBehavior = false;
            // 
            // lablCharacters
            // 
            this.lablCharacters.AutoSize = true;
            this.lablCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablCharacters.Location = new System.Drawing.Point(422, 378);
            this.lablCharacters.Name = "lablCharacters";
            this.lablCharacters.Size = new System.Drawing.Size(81, 18);
            this.lablCharacters.TabIndex = 126;
            this.lablCharacters.Text = "Characters";
            // 
            // lablRandomEvents
            // 
            this.lablRandomEvents.AutoSize = true;
            this.lablRandomEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablRandomEvents.Location = new System.Drawing.Point(827, 378);
            this.lablRandomEvents.Name = "lablRandomEvents";
            this.lablRandomEvents.Size = new System.Drawing.Size(114, 18);
            this.lablRandomEvents.TabIndex = 127;
            this.lablRandomEvents.Text = "Random Events";
            // 
            // EvtEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1564, 734);
            this.Controls.Add(this.lablRandomEvents);
            this.Controls.Add(this.lablCharacters);
            this.Controls.Add(this.listRandomEvents);
            this.Controls.Add(this.listCharacters);
            this.Controls.Add(this.lablEvents);
            this.Controls.Add(this.listSubEvents);
            this.Name = "EvtEdit";
            this.Controls.SetChildIndex(this.listNotes, 0);
            this.Controls.SetChildIndex(this.NotesLabel, 0);
            this.Controls.SetChildIndex(this.textName, 0);
            this.Controls.SetChildIndex(this.textDescription, 0);
            this.Controls.SetChildIndex(this.listSubEvents, 0);
            this.Controls.SetChildIndex(this.lablEvents, 0);
            this.Controls.SetChildIndex(this.listCharacters, 0);
            this.Controls.SetChildIndex(this.listRandomEvents, 0);
            this.Controls.SetChildIndex(this.lablCharacters, 0);
            this.Controls.SetChildIndex(this.lablRandomEvents, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listSubEvents;
        public System.Windows.Forms.Label lablEvents;
        private System.Windows.Forms.ListView listCharacters;
        private System.Windows.Forms.ListView listRandomEvents;
        public System.Windows.Forms.Label lablCharacters;
        public System.Windows.Forms.Label lablRandomEvents;
    }
}
