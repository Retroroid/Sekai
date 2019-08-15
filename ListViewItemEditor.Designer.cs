namespace Sekai {
    partial class ListViewItemEditor {
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
            this.buttonLVIESave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textListItemEditor = new System.Windows.Forms.TextBox();
            this.listFields = new System.Windows.Forms.ListView();
            this.ListViewItemEditorColumnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewItemEditorColumnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonLVIESave
            // 
            this.buttonLVIESave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLVIESave.Location = new System.Drawing.Point(377, 137);
            this.buttonLVIESave.Name = "buttonLVIESave";
            this.buttonLVIESave.Size = new System.Drawing.Size(166, 38);
            this.buttonLVIESave.TabIndex = 7;
            this.buttonLVIESave.Text = "Save Item";
            this.buttonLVIESave.UseVisualStyleBackColor = true;
            this.buttonLVIESave.Click += new System.EventHandler(this.ButtonLVIESave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit Value Below";
            // 
            // textListItemEditor
            // 
            this.textListItemEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textListItemEditor.Location = new System.Drawing.Point(365, 37);
            this.textListItemEditor.Multiline = true;
            this.textListItemEditor.Name = "textListItemEditor";
            this.textListItemEditor.Size = new System.Drawing.Size(192, 80);
            this.textListItemEditor.TabIndex = 5;
            this.textListItemEditor.TextChanged += new System.EventHandler(this.TextListItemEditor_TextChanged);
            // 
            // listFields
            // 
            this.listFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListViewItemEditorColumnID,
            this.ListViewItemEditorColumnValue});
            this.listFields.FullRowSelect = true;
            this.listFields.GridLines = true;
            this.listFields.Location = new System.Drawing.Point(12, 12);
            this.listFields.Name = "listFields";
            this.listFields.Size = new System.Drawing.Size(347, 179);
            this.listFields.TabIndex = 4;
            this.listFields.UseCompatibleStateImageBehavior = false;
            this.listFields.View = System.Windows.Forms.View.Details;
            this.listFields.SelectedIndexChanged += new System.EventHandler(this.ListFields_SelectedIndexChanged);
            // 
            // ListViewItemEditorColumnID
            // 
            this.ListViewItemEditorColumnID.Text = "Field";
            this.ListViewItemEditorColumnID.Width = 116;
            // 
            // ListViewItemEditorColumnValue
            // 
            this.ListViewItemEditorColumnValue.Text = "Value";
            this.ListViewItemEditorColumnValue.Width = 226;
            // 
            // ListViewItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 195);
            this.Controls.Add(this.buttonLVIESave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textListItemEditor);
            this.Controls.Add(this.listFields);
            this.Name = "ListViewItemEditor";
            this.Text = "ListViewItemEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLVIESave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textListItemEditor;
        private System.Windows.Forms.ListView listFields;
        private System.Windows.Forms.ColumnHeader ListViewItemEditorColumnID;
        private System.Windows.Forms.ColumnHeader ListViewItemEditorColumnValue;
    }
}