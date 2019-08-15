namespace Sekai {
    partial class GhlEdit {
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
            this.listQuestboard = new System.Windows.Forms.ListView();
            this.listCommonRoom = new System.Windows.Forms.ListView();
            this.listStaff = new System.Windows.Forms.ListView();
            this.listServices = new System.Windows.Forms.ListView();
            this.lablQuestboard = new System.Windows.Forms.Label();
            this.lablCommonRoom = new System.Windows.Forms.Label();
            this.lablServices = new System.Windows.Forms.Label();
            this.lablStaff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listQuestboard
            // 
            this.listQuestboard.Location = new System.Drawing.Point(12, 399);
            this.listQuestboard.Name = "listQuestboard";
            this.listQuestboard.Size = new System.Drawing.Size(933, 323);
            this.listQuestboard.TabIndex = 111;
            this.listQuestboard.UseCompatibleStateImageBehavior = false;
            // 
            // listCommonRoom
            // 
            this.listCommonRoom.Location = new System.Drawing.Point(951, 521);
            this.listCommonRoom.Name = "listCommonRoom";
            this.listCommonRoom.Size = new System.Drawing.Size(601, 201);
            this.listCommonRoom.TabIndex = 112;
            this.listCommonRoom.UseCompatibleStateImageBehavior = false;
            // 
            // listStaff
            // 
            this.listStaff.Location = new System.Drawing.Point(951, 116);
            this.listStaff.Name = "listStaff";
            this.listStaff.Size = new System.Drawing.Size(601, 141);
            this.listStaff.TabIndex = 113;
            this.listStaff.UseCompatibleStateImageBehavior = false;
            // 
            // listServices
            // 
            this.listServices.Location = new System.Drawing.Point(951, 281);
            this.listServices.Name = "listServices";
            this.listServices.Size = new System.Drawing.Size(601, 141);
            this.listServices.TabIndex = 114;
            this.listServices.UseCompatibleStateImageBehavior = false;
            // 
            // lablQuestboard
            // 
            this.lablQuestboard.AutoSize = true;
            this.lablQuestboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablQuestboard.Location = new System.Drawing.Point(9, 378);
            this.lablQuestboard.Name = "lablQuestboard";
            this.lablQuestboard.Size = new System.Drawing.Size(86, 18);
            this.lablQuestboard.TabIndex = 122;
            this.lablQuestboard.Text = "Questboard";
            // 
            // lablCommonRoom
            // 
            this.lablCommonRoom.AutoSize = true;
            this.lablCommonRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablCommonRoom.Location = new System.Drawing.Point(948, 500);
            this.lablCommonRoom.Name = "lablCommonRoom";
            this.lablCommonRoom.Size = new System.Drawing.Size(117, 18);
            this.lablCommonRoom.TabIndex = 123;
            this.lablCommonRoom.Text = "Common Room";
            // 
            // lablServices
            // 
            this.lablServices.AutoSize = true;
            this.lablServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablServices.Location = new System.Drawing.Point(948, 260);
            this.lablServices.Name = "lablServices";
            this.lablServices.Size = new System.Drawing.Size(65, 18);
            this.lablServices.TabIndex = 124;
            this.lablServices.Text = "Services";
            // 
            // lablStaff
            // 
            this.lablStaff.AutoSize = true;
            this.lablStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablStaff.Location = new System.Drawing.Point(948, 95);
            this.lablStaff.Name = "lablStaff";
            this.lablStaff.Size = new System.Drawing.Size(38, 18);
            this.lablStaff.TabIndex = 125;
            this.lablStaff.Text = "Staff";
            // 
            // GhlEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1564, 734);
            this.Controls.Add(this.lablStaff);
            this.Controls.Add(this.lablServices);
            this.Controls.Add(this.lablCommonRoom);
            this.Controls.Add(this.lablQuestboard);
            this.Controls.Add(this.listServices);
            this.Controls.Add(this.listStaff);
            this.Controls.Add(this.listCommonRoom);
            this.Controls.Add(this.listQuestboard);
            this.Name = "GhlEdit";
            this.Controls.SetChildIndex(this.listNotes, 0);
            this.Controls.SetChildIndex(this.NotesLabel, 0);
            this.Controls.SetChildIndex(this.textName, 0);
            this.Controls.SetChildIndex(this.textDescription, 0);
            this.Controls.SetChildIndex(this.listQuestboard, 0);
            this.Controls.SetChildIndex(this.listCommonRoom, 0);
            this.Controls.SetChildIndex(this.listStaff, 0);
            this.Controls.SetChildIndex(this.listServices, 0);
            this.Controls.SetChildIndex(this.lablQuestboard, 0);
            this.Controls.SetChildIndex(this.lablCommonRoom, 0);
            this.Controls.SetChildIndex(this.lablServices, 0);
            this.Controls.SetChildIndex(this.lablStaff, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listQuestboard;
        private System.Windows.Forms.ListView listCommonRoom;
        private System.Windows.Forms.ListView listStaff;
        private System.Windows.Forms.ListView listServices;
        public System.Windows.Forms.Label lablQuestboard;
        public System.Windows.Forms.Label lablCommonRoom;
        public System.Windows.Forms.Label lablServices;
        public System.Windows.Forms.Label lablStaff;
    }
}
