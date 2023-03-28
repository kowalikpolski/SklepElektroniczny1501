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
            // TODO: This line of code loads data into the 'dataSetProdukty1.produkt' table. You can move, or remove it, as needed.
            this.produktTableAdapter.Fill(this.dataSetProdukty1.produkt);

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
            Form produkt = new ProduktyEdycja(-1);
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
                int id = (int)dataGridView1.Rows[selectedItem].Cells[5].Value;
                Form produkt = new ProduktyEdycja(id);
                produkt.Show();
                this.Close();
            }
        }
    }
}
