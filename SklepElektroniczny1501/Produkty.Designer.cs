namespace SklepElektroniczny1501
{
    partial class Produkty
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc_dostepna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.Model,
            this.Kategoria,
            this.Ilosc_dostepna,
            this.Cena});
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 662);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista produktów:";
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            // 
            // model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // Kategoria
            // 
            this.Kategoria.HeaderText = "Kategoria";
            this.Kategoria.Name = "Kategoria";
            // 
            // ilosc_dostepna
            // 
            this.Ilosc_dostepna.HeaderText = "Ilość dostępna";
            this.Ilosc_dostepna.Name = "Ilosc_dostepna";
            // 
            // cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            // 
            // Produkty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 748);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Produkty";
            this.Text = "Produkty";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc_dostepna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
    }
}

