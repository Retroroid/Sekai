namespace Sekai {
    partial class FacEdit {
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
            this.listStaff = new System.Windows.Forms.ListView();
            this.listServices = new System.Windows.Forms.ListView();
            this.listClients = new System.Windows.Forms.ListView();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.textFocus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label313 = new System.Windows.Forms.Label();
            this.lablServices = new System.Windows.Forms.Label();
            this.lablStaff = new System.Windows.Forms.Label();
            this.lablClients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listStaff
            // 
            this.listStaff.Location = new System.Drawing.Point(530, 381);
            this.listStaff.Name = "listStaff";
            this.listStaff.Size = new System.Drawing.Size(504, 341);
            this.listStaff.TabIndex = 111;
            this.listStaff.UseCompatibleStateImageBehavior = false;
            // 
            // listServices
            // 
            this.listServices.Location = new System.Drawing.Point(12, 381);
            this.listServices.Name = "listServices";
            this.listServices.Size = new System.Drawing.Size(504, 341);
            this.listServices.TabIndex = 112;
            this.listServices.UseCompatibleStateImageBehavior = false;
            // 
            // listClients
            // 
            this.listClients.Location = new System.Drawing.Point(1048, 381);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(504, 341);
            this.listClients.TabIndex = 113;
            this.listClients.UseCompatibleStateImageBehavior = false;
            // 
            // textLocation
            // 
            this.textLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLocation.Location = new System.Drawing.Point(951, 146);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(247, 31);
            this.textLocation.TabIndex = 114;
            // 
            // textFocus
            // 
            this.textFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFocus.Location = new System.Drawing.Point(955, 254);
            this.textFocus.Multiline = true;
            this.textFocus.Name = "textFocus";
            this.textFocus.Size = new System.Drawing.Size(243, 65);
            this.textFocus.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(951, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 116;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(955, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 117;
            this.label2.Text = "Focus";
            // 
            // label313
            // 
            this.label313.AutoSize = true;
            this.label313.Location = new System.Drawing.Point(1333, 211);
            this.label313.Name = "label313";
            this.label313.Size = new System.Drawing.Size(93, 13);
            this.label313.TabIndex = 118;
            this.label313.Text = "Image Goes Here!";
            // 
            // lablServices
            // 
            this.lablServices.AutoSize = true;
            this.lablServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablServices.Location = new System.Drawing.Point(9, 378);
            this.lablServices.Name = "lablServices";
            this.lablServices.Size = new System.Drawing.Size(65, 18);
            this.lablServices.TabIndex = 122;
            this.lablServices.Text = "Services";
            // 
            // lablStaff
            // 
            this.lablStaff.AutoSize = true;
            this.lablStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablStaff.Location = new System.Drawing.Point(527, 378);
            this.lablStaff.Name = "lablStaff";
            this.lablStaff.Size = new System.Drawing.Size(38, 18);
            this.lablStaff.TabIndex = 123;
            this.lablStaff.Text = "Staff";
            // 
            // lablClients
            // 
            this.lablClients.AutoSize = true;
            this.lablClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablClients.Location = new System.Drawing.Point(1045, 378);
            this.lablClients.Name = "lablClients";
            this.lablClients.Size = new System.Drawing.Size(53, 18);
            this.lablClients.TabIndex = 124;
            this.lablClients.Text = "Clients";
            // 
            // FacEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1564, 734);
            this.Controls.Add(this.lablClients);
            this.Controls.Add(this.lablStaff);
            this.Controls.Add(this.lablServices);
            this.Controls.Add(this.label313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFocus);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.listClients);
            this.Controls.Add(this.listServices);
            this.Controls.Add(this.listStaff);
            this.Name = "FacEdit";
            this.Controls.SetChildIndex(this.listNotes, 0);
            this.Controls.SetChildIndex(this.NotesLabel, 0);
            this.Controls.SetChildIndex(this.textName, 0);
            this.Controls.SetChildIndex(this.textDescription, 0);
            this.Controls.SetChildIndex(this.listStaff, 0);
            this.Controls.SetChildIndex(this.listServices, 0);
            this.Controls.SetChildIndex(this.listClients, 0);
            this.Controls.SetChildIndex(this.textLocation, 0);
            this.Controls.SetChildIndex(this.textFocus, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label313, 0);
            this.Controls.SetChildIndex(this.lablServices, 0);
            this.Controls.SetChildIndex(this.lablStaff, 0);
            this.Controls.SetChildIndex(this.lablClients, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listStaff;
        private System.Windows.Forms.ListView listServices;
        private System.Windows.Forms.ListView listClients;
        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.TextBox textFocus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label313;
        public System.Windows.Forms.Label lablServices;
        public System.Windows.Forms.Label lablStaff;
        public System.Windows.Forms.Label lablClients;
    }
}
