using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SklepElektroniczny1501
{
    public partial class Produkty : Form
    {
        public Produkty()
        {
            InitializeComponent();
        }

        private void Produkty_Load(object sender, EventArgs e)
        {

            this.produktTableAdapter.Fill(this.dataSetProdukty.produkt);

        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            editSelectedProduct();
           
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells == null)
                edytujToolStripMenuItem.Enabled = false;
            else
                edytujToolStripMenuItem.Enabled = true;
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form produkt = new ProduktyEdycja(null, null);
            produkt.Show();
            this.Close();
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editSelectedProduct();
        }
        private void editSelectedProduct()
        {
            if (dataGridView1.SelectedCells != null)
            {
                var selectedItem = dataGridView1.SelectedCells[0].RowIndex;
                var name = dataGridView1.Rows[selectedItem].Cells[0].Value.ToString();
                var model = dataGridView1.Rows[selectedItem].Cells[1].Value.ToString();
                Form produkt = new ProduktyEdycja(name, model);
                produkt.Show();
                this.Close();
            }
        }
    }
}
