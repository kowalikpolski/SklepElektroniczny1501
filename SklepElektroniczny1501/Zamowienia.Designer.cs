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
            this.numerzamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowienieBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZamowienia = new SklepElektroniczny1501.DataSetZamowienia();
            this.label1 = new System.Windows.Forms.Label();
            this.zamowienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamowienieTableAdapter = new SklepElektroniczny1501.DataSetZamowieniaTableAdapters.zamowienieTableAdapter();
            this.zamowienieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zamowienieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerzamowieniaDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.datazamowieniaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zamowienieBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(961, 726);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // numerzamowieniaDataGridViewTextBoxColumn
            // 
            this.numerzamowieniaDataGridViewTextBoxColumn.DataPropertyName = "numer_zamowienia";
            this.numerzamowieniaDataGridViewTextBoxColumn.HeaderText = "Numer Zamówienia";
            this.numerzamowieniaDataGridViewTextBoxColumn.Name = "numerzamowieniaDataGridViewTextBoxColumn";
            this.numerzamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numerzamowieniaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Suma Sprzedaży";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // datazamowieniaDataGridViewTextBoxColumn
            // 
            this.datazamowieniaDataGridViewTextBoxColumn.DataPropertyName = "data_zamowienia";
            this.datazamowieniaDataGridViewTextBoxColumn.HeaderText = "Data Zamówienia";
            this.datazamowieniaDataGridViewTextBoxColumn.Name = "datazamowieniaDataGridViewTextBoxColumn";
            this.datazamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datazamowieniaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // zamowienieBindingSource3
            // 
            this.zamowienieBindingSource3.DataMember = "zamowienie";
            this.zamowienieBindingSource3.DataSource = this.dataSetZamowienia;
            // 
            // dataSetZamowienia
            // 
            this.dataSetZamowienia.DataSetName = "DataSetZamowienia";
            this.dataSetZamowienia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // zamowienieBindingSource
            // 
            this.zamowienieBindingSource.DataMember = "zamowienie";
            this.zamowienieBindingSource.DataSource = this.dataSetZamowienia;
            // 
            // zamowienieTableAdapter
            // 
            this.zamowienieTableAdapter.ClearBeforeFill = true;
            // 
            // zamowienieBindingSource1
            // 
            this.zamowienieBindingSource1.DataMember = "zamowienie";
            this.zamowienieBindingSource1.DataSource = this.dataSetZamowienia;
            // 
            // zamowienieBindingSource2
            // 
            this.zamowienieBindingSource2.DataMember = "zamowienie";
            this.zamowienieBindingSource2.DataSource = this.dataSetZamowienia;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.edytujToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.Enabled = false;
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            this.edytujToolStripMenuItem.Click += new System.EventHandler(this.edytujToolStripMenuItem_Click);
            // 
            // Zamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 794);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Zamowienia";
            this.Text = "Zamowienia";
            this.Load += new System.EventHandler(this.Zamowienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.BindingSource zamowienieBindingSource3;
        private System.Windows.Forms.BindingSource zamowienieBindingSource1;
        private System.Windows.Forms.BindingSource zamowienieBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerzamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
    }
}