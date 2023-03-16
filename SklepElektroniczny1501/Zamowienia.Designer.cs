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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetZamowienia = new SklepElektroniczny1501.DataSetZamowienia();
            this.zamowienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamowienieTableAdapter = new SklepElektroniczny1501.DataSetZamowieniaTableAdapters.zamowienieTableAdapter();
            this.numerzamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerzamowieniaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.datazamowieniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zamowienieBindingSource;
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
            // dataSetZamowienia
            // 
            this.dataSetZamowienia.DataSetName = "DataSetZamowienia";
            this.dataSetZamowienia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamowienieBindingSource
            // 
            this.zamowienieBindingSource.DataMember = "zamowienie";
            this.zamowienieBindingSource.DataSource = this.dataSetZamowienia;
            // 
            // zamowienieTableAdapter
            // 
            this.zamowienieTableAdapter.ClearBeforeFill = true;
            // 
            // numerzamowieniaDataGridViewTextBoxColumn
            // 
            this.numerzamowieniaDataGridViewTextBoxColumn.DataPropertyName = "numer_zamowienia";
            this.numerzamowieniaDataGridViewTextBoxColumn.HeaderText = "Numer zamówienia";
            this.numerzamowieniaDataGridViewTextBoxColumn.Name = "numerzamowieniaDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Suma Sprzedaży";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // datazamowieniaDataGridViewTextBoxColumn
            // 
            this.datazamowieniaDataGridViewTextBoxColumn.DataPropertyName = "data_zamowienia";
            this.datazamowieniaDataGridViewTextBoxColumn.HeaderText = "Data Zamówienia";
            this.datazamowieniaDataGridViewTextBoxColumn.Name = "datazamowieniaDataGridViewTextBoxColumn";
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
            this.Load += new System.EventHandler(this.Zamowienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numer_zamowienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma_sprzedarzy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_zamowienia;
        private SklepElektroniczny1501.DataSetZamowienia dataSetZamowienia;
        private System.Windows.Forms.BindingSource zamowienieBindingSource;
        private SklepElektroniczny1501.DataSetZamowieniaTableAdapters.zamowienieTableAdapter zamowienieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerzamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazamowieniaDataGridViewTextBoxColumn;
    }
}