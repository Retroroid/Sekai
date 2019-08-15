namespace Sekai {
    partial class AsoEdit {
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
            this.listMembers = new System.Windows.Forms.ListView();
            this.listGroups = new System.Windows.Forms.ListView();
            this.listRanks = new System.Windows.Forms.ListView();
            this.listLocations = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lablRanks = new System.Windows.Forms.Label();
            this.lablMembers = new System.Windows.Forms.Label();
            this.lablGroups = new System.Windows.Forms.Label();
            this.lablLocations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listMembers
            // 
            this.listMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMembers.Location = new System.Drawing.Point(951, 492);
            this.listMembers.Name = "listMembers";
            this.listMembers.Size = new System.Drawing.Size(601, 263);
            this.listMembers.TabIndex = 118;
            this.listMembers.UseCompatibleStateImageBehavior = false;
            // 
            // listGroups
            // 
            this.listGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGroups.Location = new System.Drawing.Point(951, 218);
            this.listGroups.Name = "listGroups";
            this.listGroups.Size = new System.Drawing.Size(605, 250);
            this.listGroups.TabIndex = 117;
            this.listGroups.UseCompatibleStateImageBehavior = false;
            // 
            // listRanks
            // 
            this.listRanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRanks.Location = new System.Drawing.Point(12, 492);
            this.listRanks.Name = "listRanks";
            this.listRanks.Size = new System.Drawing.Size(933, 263);
            this.listRanks.TabIndex = 116;
            this.listRanks.UseCompatibleStateImageBehavior = false;
            // 
            // listLocations
            // 
            this.listLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLocations.Location = new System.Drawing.Point(951, 114);
            this.listLocations.Name = "listLocations";
            this.listLocations.Size = new System.Drawing.Size(601, 83);
            this.listLocations.TabIndex = 115;
            this.listLocations.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 33);
            this.label1.TabIndex = 119;
            this.label1.Text = "Emblem appearances go here!";
            // 
            // lablRanks
            // 
            this.lablRanks.AutoSize = true;
            this.lablRanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablRanks.Location = new System.Drawing.Point(12, 471);
            this.lablRanks.Name = "lablRanks";
            this.lablRanks.Size = new System.Drawing.Size(51, 18);
            this.lablRanks.TabIndex = 120;
            this.lablRanks.Text = "Ranks";
            // 
            // lablMembers
            // 
            this.lablMembers.AutoSize = true;
            this.lablMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablMembers.Location = new System.Drawing.Point(946, 471);
            this.lablMembers.Name = "lablMembers";
            this.lablMembers.Size = new System.Drawing.Size(71, 18);
            this.lablMembers.TabIndex = 121;
            this.lablMembers.Text = "Members";
            // 
            // lablGroups
            // 
            this.lablGroups.AutoSize = true;
            this.lablGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablGroups.Location = new System.Drawing.Point(952, 197);
            this.lablGroups.Name = "lablGroups";
            this.lablGroups.Size = new System.Drawing.Size(58, 18);
            this.lablGroups.TabIndex = 122;
            this.lablGroups.Text = "Groups";
            // 
            // lablLocations
            // 
            this.lablLocations.AutoSize = true;
            this.lablLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablLocations.Location = new System.Drawing.Point(946, 93);
            this.lablLocations.Name = "lablLocations";
            this.lablLocations.Size = new System.Drawing.Size(73, 18);
            this.lablLocations.TabIndex = 123;
            this.lablLocations.Text = "Locations";
            // 
            // AsoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1564, 767);
            this.Controls.Add(this.lablLocations);
            this.Controls.Add(this.lablGroups);
            this.Controls.Add(this.lablMembers);
            this.Controls.Add(this.lablRanks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listMembers);
            this.Controls.Add(this.listGroups);
            this.Controls.Add(this.listRanks);
            this.Controls.Add(this.listLocations);
            this.Name = "AsoEdit";
            this.Controls.SetChildIndex(this.listNotes, 0);
            this.Controls.SetChildIndex(this.NotesLabel, 0);
            this.Controls.SetChildIndex(this.textName, 0);
            this.Controls.SetChildIndex(this.textDescription, 0);
            this.Controls.SetChildIndex(this.listLocations, 0);
            this.Controls.SetChildIndex(this.listRanks, 0);
            this.Controls.SetChildIndex(this.listGroups, 0);
            this.Controls.SetChildIndex(this.listMembers, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lablRanks, 0);
            this.Controls.SetChildIndex(this.lablMembers, 0);
            this.Controls.SetChildIndex(this.lablGroups, 0);
            this.Controls.SetChildIndex(this.lablLocations, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listMembers;
        private System.Windows.Forms.ListView listGroups;
        private System.Windows.Forms.ListView listRanks;
        private System.Windows.Forms.ListView listLocations;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lablRanks;
        public System.Windows.Forms.Label lablMembers;
        public System.Windows.Forms.Label lablGroups;
        public System.Windows.Forms.Label lablLocations;
    }
}
