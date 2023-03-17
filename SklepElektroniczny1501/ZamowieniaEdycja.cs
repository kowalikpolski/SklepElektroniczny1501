using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SklepElektroniczny1501
{
    
    public partial class ZamowieniaEdycja : Form
    {
        private IEnumerable orderList;
        private DataContext dc; 
        private string orderNr;
        public ZamowieniaEdycja(string order)
        {
            InitializeComponent();
            
            dc = new DataContext("Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            Table<produkt> produkt = dc.GetTable<produkt>();
            Table<zamowienie_produkt> zamowienie_produkt = dc.GetTable<zamowienie_produkt>();
            Table<zamowienie> zamowienie = dc.GetTable<zamowienie>();
            if(order != null)
            {
                var orderItems = (from zp in zamowienie_produkt
                             join prod in produkt on zp.id_produkt equals prod.id
                             join zam in zamowienie on zp.id_zamowienie equals zam.id
                             where zam.numer_zamowienia == order
                             select new
                             {
                                 prod.nazwa,
                                 prod.model,
                                 zp.ilosc,
                                 zp.cena,
                             }).ToList();
                dataGridView1.DataSource = orderItems;
                orderNr = order;
                labelSum.Text=orderItems.Sum(x=>x.cena).ToString();
            }
            else
            {
                labelSum.Text = "0";
                var query = (from zam in zamowienie
                              group zam by true into r
                              select new { maxOrder = r.Max(x => x.numer_zamowienia) }).ToList()[0];
                var str=query.maxOrder.Split('/');
                if (str[0] == DateTime.Now.Year.ToString())
                {
                    str[1] = String.Format("{0:000}", int.Parse(str[1]) + 1);
                    orderNr = str[0] + "/" + str[1];
                }
                else
                {
                    str[0] = DateTime.Now.Year.ToString();
                    str[1] = "001";
                }
                    orderNr = str[0] + "/" + str[1];
                    
            }
            labelOrder.Text = orderNr;


            /*SELECT        produkt.nazwa, produkt.model, zamowienie_produkt.ilosc, zamowienie_produkt.cena
FROM            zamowienie_produkt INNER JOIN
                         produkt ON zamowienie_produkt.id_produkt = produkt.id*/
        }

        private void nowaPozycjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                
               
                Form zamowieniePozycjeEdycja = new ZamowieniePozycjeEdycja(null,null);
                zamowieniePozycjeEdycja.ShowDialog();
                this.Close();
            
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null)
            {
                var selectedItem = dataGridView1.SelectedCells[0].RowIndex;
                var name = dataGridView1.Rows[selectedItem].Cells[0].Value.ToString();
                var model = dataGridView1.Rows[selectedItem].Cells[1].Value.ToString();
                Form zamowieniePozycjeEdycja = new ZamowieniePozycjeEdycja(name, model);
                zamowieniePozycjeEdycja.ShowDialog();
                this.Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null)
            {
                var selectedItem = dataGridView1.SelectedCells[0].RowIndex;
                var name = dataGridView1.Rows[selectedItem].Cells[0].Value.ToString();
                var model = dataGridView1.Rows[selectedItem].Cells[1].Value.ToString();
                Form zamowieniePozycjeEdycja = new ZamowieniePozycjeEdycja(name, model);
                zamowieniePozycjeEdycja.ShowDialog();
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
