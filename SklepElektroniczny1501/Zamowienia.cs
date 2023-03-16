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
    }
}
