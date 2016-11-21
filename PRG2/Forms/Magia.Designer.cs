namespace PRG2
{
    partial class Form_Magia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Magia = new System.Windows.Forms.Button();
            this.listView_Magias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_Magia
            // 
            this.button_Magia.Location = new System.Drawing.Point(106, 225);
            this.button_Magia.Name = "button_Magia";
            this.button_Magia.Size = new System.Drawing.Size(75, 23);
            this.button_Magia.TabIndex = 1;
            this.button_Magia.Text = "Usar Magia";
            this.button_Magia.UseVisualStyleBackColor = true;
            this.button_Magia.Click += new System.EventHandler(this.button_Magia_Click);
            // 
            // listView_Magias
            // 
            this.listView_Magias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Magias.GridLines = true;
            this.listView_Magias.Location = new System.Drawing.Point(15, 31);
            this.listView_Magias.Name = "listView_Magias";
            this.listView_Magias.Size = new System.Drawing.Size(265, 187);
            this.listView_Magias.TabIndex = 2;
            this.listView_Magias.UseCompatibleStateImageBehavior = false;
            this.listView_Magias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dano";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mana";
            this.columnHeader3.Width = 68;
            // 
            // Form_Magia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 259);
            this.Controls.Add(this.listView_Magias);
            this.Controls.Add(this.button_Magia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Magia";
            this.Text = "Magia";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Magia;
        private System.Windows.Forms.ListView listView_Magias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}