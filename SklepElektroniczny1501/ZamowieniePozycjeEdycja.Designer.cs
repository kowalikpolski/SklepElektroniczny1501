namespace SklepElektroniczny1501
{
    partial class ZamowieniePozycjeEdycja
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxProdukt = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.47938F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.52062F));
            this.tableLayoutPanel1.Controls.Add(this.labelPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAmount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxProdukt, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 43);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 303);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrice.Location = new System.Drawing.Point(167, 214);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(362, 77);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produkt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 77);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ilość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(13, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 77);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cena";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAmount.Location = new System.Drawing.Point(167, 113);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.textBoxAmount.MinimumSize = new System.Drawing.Size(4, 22);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(362, 22);
            this.textBoxAmount.TabIndex = 6;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // comboBoxProdukt
            // 
            this.comboBoxProdukt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProdukt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProdukt.FormattingEnabled = true;
            this.comboBoxProdukt.Location = new System.Drawing.Point(167, 12);
            this.comboBoxProdukt.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.comboBoxProdukt.Name = "comboBoxProdukt";
            this.comboBoxProdukt.Size = new System.Drawing.Size(362, 24);
            this.comboBoxProdukt.TabIndex = 8;
            this.comboBoxProdukt.SelectedIndexChanged += new System.EventHandler(this.comboBoxProdukt_SelectedIndexChanged);
            // 
            // ZamowieniePozycjeEdycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 416);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZamowieniePozycjeEdycja";
            this.Text = "ZamowieniePozycjeEdycja";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxProdukt;
    }
}