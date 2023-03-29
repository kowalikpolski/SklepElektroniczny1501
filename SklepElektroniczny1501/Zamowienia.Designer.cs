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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.zamowienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZamowienia1 = new SklepElektroniczny1501.DataSetZamowienia();
            this.dataSetZamowienia = new SklepElektroniczny1501.DataSetZamowienia();
            this.zamowienieTableAdapter = new SklepElektroniczny1501.DataSetZamowieniaTableAdapters.zamowienieTableAdapter();
            this.numerzamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suma_sprzedazy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZamowienia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZamowienia)).BeginInit();
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
            this.datazamowieniaDataGridViewTextBoxColumn,
            this.suma_sprzedazy,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zamowienieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1281, 894);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista zamówień:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1313, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.edytujToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.Enabled = false;
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            this.edytujToolStripMenuItem.Click += new System.EventHandler(this.edytujToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1010, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wyszukaj";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(1081, 43);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(216, 22);
            this.textBoxFilter.TabIndex = 5;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // zamowienieBindingSource
            // 
            this.zamowienieBindingSource.DataMember = "zamowienie";
            this.zamowienieBindingSource.DataSource = this.dataSetZamowienia1;
            // 
            // dataSetZamowienia1
            // 
            this.dataSetZamowienia1.DataSetName = "DataSetZamowienia";
            this.dataSetZamowienia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetZamowienia
            // 
            this.dataSetZamowienia.DataSetName = "DataSetZamowienia";
            this.dataSetZamowienia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamowienieTableAdapter
            // 
            this.zamowienieTableAdapter.ClearBeforeFill = true;
            // 
            // numerzamowieniaDataGridViewTextBoxColumn
            // 
            this.numerzamowieniaDataGridViewTextBoxColumn.DataPropertyName = "numer_zamowienia";
            this.numerzamowieniaDataGridViewTextBoxColumn.HeaderText = "Numer zamówienia";
            this.numerzamowieniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numerzamowieniaDataGridViewTextBoxColumn.Name = "numerzamowieniaDataGridViewTextBoxColumn";
            this.numerzamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numerzamowieniaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numerzamowieniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datazamowieniaDataGridViewTextBoxColumn
            // 
            this.datazamowieniaDataGridViewTextBoxColumn.DataPropertyName = "data_zamowienia";
            this.datazamowieniaDataGridViewTextBoxColumn.HeaderText = "Data zamowienia";
            this.datazamowieniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datazamowieniaDataGridViewTextBoxColumn.Name = "datazamowieniaDataGridViewTextBoxColumn";
            this.datazamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datazamowieniaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.datazamowieniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // suma_sprzedazy
            // 
            this.suma_sprzedazy.DataPropertyName = "suma_sprzedazy";
            this.suma_sprzedazy.HeaderText = "Suma sprzedaży";
            this.suma_sprzedazy.MinimumWidth = 6;
            this.suma_sprzedazy.Name = "suma_sprzedazy";
            this.suma_sprzedazy.ReadOnly = true;
            this.suma_sprzedazy.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // Zamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 977);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Zamowienia";
            this.Text = "Zamowienia";
            this.Load += new System.EventHandler(this.Zamowienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZamowienia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZamowienia)).EndInit();
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
        private SklepElektroniczny1501.DataSetZamowieniaTableAdapters.zamowienieTableAdapter zamowienieTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private SklepElektroniczny1501.DataSetZamowienia dataSetZamowienia1;
        private System.Windows.Forms.BindingSource zamowienieBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerzamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suma_sprzedazy;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}