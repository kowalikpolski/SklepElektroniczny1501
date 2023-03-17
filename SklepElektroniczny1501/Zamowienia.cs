using SklepElektroniczny1501;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SklepElektroniczny
{
    public partial class Zamowienia : Form
    {
        public Zamowienia()
        {
            InitializeComponent();
        }

        private void Zamowienia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetZamowienia.zamowienie' table. You can move, or remove it, as needed.
            this.zamowienieTableAdapter.Fill(this.dataSetZamowienia.zamowienie);
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form zamowienie = new ZamowieniaEdycja(null);
            zamowienie.Show();
            this.Close();
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null)
            {
                var selectedItem = dataGridView1.SelectedCells[0].RowIndex;
                var order= dataGridView1.Rows[selectedItem].Cells[0].Value.ToString();
                Form zamowienie = new ZamowieniaEdycja(order);
                zamowienie.Show();
                this.Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null)
            {
                var selectedItem = dataGridView1.SelectedCells[0].RowIndex;
                var order = dataGridView1.Rows[selectedItem].Cells[0].Value.ToString();
                Form zamowienie = new ZamowieniaEdycja(order);
                zamowienie.Show();
                this.Close();
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells == null)
                edytujToolStripMenuItem.Enabled = false;
            else
                edytujToolStripMenuItem.Enabled = true;
        }
    }
}
