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
            this.button1 = new System.Windows.Forms.Button();
            this.textValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nyumWeight = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nyumWeight)).BeginInit();
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
            this.listElements.SelectedIndexChanged += new System.EventHandler(this.ListElements_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(763, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 53);
            this.button1.TabIndex = 113;
            this.button1.Text = "Choose at Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textValue
            // 
            this.textValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValue.Location = new System.Drawing.Point(457, 589);
            this.textValue.Multiline = true;
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(488, 133);
            this.textValue.TabIndex = 114;
            this.textValue.TextChanged += new System.EventHandler(this.TextValue_TextChanged);
            this.textValue.MouseLeave += new System.EventHandler(this.TextValue_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 115;
            this.label1.Text = "Element Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 116;
            this.label2.Text = "Element Weight";
            // 
            // nyumWeight
            // 
            this.nyumWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyumWeight.Location = new System.Drawing.Point(855, 558);
            this.nyumWeight.Maximum = new decimal(new int[] {
            2147000000,
            0,
            0,
            0});
            this.nyumWeight.Name = "nyumWeight";
            this.nyumWeight.Size = new System.Drawing.Size(90, 26);
            this.nyumWeight.TabIndex = 117;
            this.nyumWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nyumWeight.ValueChanged += new System.EventHandler(this.NyumWeight_ValueChanged);
            this.nyumWeight.Leave += new System.EventHandler(this.TextValue_MouseLeave);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(603, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 53);
            this.button2.TabIndex = 118;
            this.button2.Text = "Add some data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(455, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 53);
            this.button3.TabIndex = 119;
            this.button3.Text = "update d100";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // DohEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1564, 734);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nyumWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listElements);
            this.Name = "DohEdit";
            this.Controls.SetChildIndex(this.listElements, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.textValue, 0);
            this.Controls.SetChildIndex(this.NotesLabel, 0);
            this.Controls.SetChildIndex(this.listNotes, 0);
            this.Controls.SetChildIndex(this.textName, 0);
            this.Controls.SetChildIndex(this.textDescription, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.nyumWeight, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nyumWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listElements;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nyumWeight;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
