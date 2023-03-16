using SklepElektroniczny;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SklepElektroniczny1501
{
    public partial class Sklep : Form
    {
        public Sklep()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form produkty = new Produkty();
            produkty.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form zamowienia = new Zamowienia();
            zamowienia.Show();
        }
    }
  
}
