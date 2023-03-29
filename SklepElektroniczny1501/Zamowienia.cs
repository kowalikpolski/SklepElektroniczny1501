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
            // TODO: This line of code loads data into the 'dataSetZamowienia1.zamowienie' table. You can move, or remove it, as needed.
            this.zamowienieTableAdapter.Fill(this.dataSetZamowienia1.zamowienie);
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form zamowienie = new ZamowieniaEdycja(-1);
            zamowienie.ShowDialog();
            this.zamowienieTableAdapter.Fill(this.dataSetZamowienia1.zamowienie);
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editSelectedOrder();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            editSelectedOrder();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells == null)
                edytujToolStripMenuItem.Enabled = false;
            else
                edytujToolStripMenuItem.Enabled = true;
        }
        private void editSelectedOrder()
        {
            if (dataGridView1.SelectedCells != null)
            {
                var selectedItem = dataGridView1.SelectedCells[0].RowIndex;
                var id = (int)dataGridView1.Rows[selectedItem].Cells[2].Value;
                Form zamowienie = new ZamowieniaEdycja(id);
                zamowienie.ShowDialog();
                this.zamowienieTableAdapter.Fill(this.dataSetZamowienia1.zamowienie);
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            var dv = new DataView();
            dv = this.dataSetZamowienia1.zamowienie.DefaultView;
            dv.RowFilter = "Substring(numer_zamowienia,1," + textBoxFilter.Text.Length + ")='" + textBoxFilter.Text.ToString() + "'";
            dataGridView1.DataSource = dv;
        }
    }
}
