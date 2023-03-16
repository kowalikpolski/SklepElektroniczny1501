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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.produktBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProdukty = new SklepElektroniczny1501.DataSetProdukty();
            this.dataSetProduktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktTableAdapter = new SklepElektroniczny1501.DataSetProduktyTableAdapters.produktTableAdapter();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscdostepnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProdukty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.kategoriaDataGridViewTextBoxColumn,
            this.iloscdostepnaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produktBindingSource;
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
            // dataSetProdukty
            // 
            this.dataSetProdukty.DataSetName = "DataSetProdukty";
            this.dataSetProdukty.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetProduktyBindingSource
            // 
            this.dataSetProduktyBindingSource.DataSource = this.dataSetProdukty;
            this.dataSetProduktyBindingSource.Position = 0;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "produkt";
            this.produktBindingSource.DataSource = this.dataSetProdukty;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            this.kategoriaDataGridViewTextBoxColumn.DataPropertyName = "kategoria";
            this.kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            // 
            // iloscdostepnaDataGridViewTextBoxColumn
            // 
            this.iloscdostepnaDataGridViewTextBoxColumn.DataPropertyName = "ilosc_dostepna";
            this.iloscdostepnaDataGridViewTextBoxColumn.HeaderText = "Ilość dostępna";
            this.iloscdostepnaDataGridViewTextBoxColumn.Name = "iloscdostepnaDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
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
            this.Load += new System.EventHandler(this.Produkty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProdukty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource produktBindingSource1;
        private System.Windows.Forms.BindingSource dataSetProduktyBindingSource;
        private DataSetProdukty dataSetProdukty;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private DataSetProduktyTableAdapters.produktTableAdapter produktTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscdostepnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
    }
}

