namespace SklepElektroniczny
{
    partial class Zamowienia
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
            this.Numer_zamowienia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma_sprzedarzy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_zamowienia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numer_zamowienia,
            this.Suma_sprzedarzy,
            this.Data_zamowienia});
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(961, 726);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista zamówień:";
            // 
            // numer_zamowienia
            // 
            this.Numer_zamowienia.HeaderText = "Numer zamówienia";
            this.Numer_zamowienia.Name = "numer_zamowienia";
            // 
            // suma_sprzedarzy
            // 
            this.Suma_sprzedarzy.HeaderText = "Suma Sprzedaży";
            this.Suma_sprzedarzy.Name = "suma_sprzedarzy";
            // 
            // data_zamowienia
            // 
            this.Data_zamowienia.HeaderText = "Data zamówienia";
            this.Data_zamowienia.Name = "data_zamowienia";
            // 
            // Zamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 794);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zamowienia";
            this.Text = "Zamowienia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numer_zamowienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma_sprzedarzy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_zamowienia;
    }
}