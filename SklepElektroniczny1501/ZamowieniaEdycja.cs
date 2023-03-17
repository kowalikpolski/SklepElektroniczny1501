using SklepElektroniczny;
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
        private Boolean existingOrder;
        private void refreshList(string orderNr)
        {
            Table<produkt> produkt = dc.GetTable<produkt>();
            Table<zamowienie_produkt> zamowienie_produkt = dc.GetTable<zamowienie_produkt>();
            Table<zamowienie> zamowienie = dc.GetTable<zamowienie>();
            var orderItems = (from zp in zamowienie_produkt
                              join prod in produkt on zp.id_produkt equals prod.id
                              join zam in zamowienie on zp.id_zamowienie equals zam.id
                              where zam.numer_zamowienia == orderNr
                              select new
                              {
                                  zp.id,
                                  prod.nazwa,
                                  prod.model,
                                  zp.ilosc,
                                  zp.cena,
                              }).ToList();
            dataGridView1.DataSource = orderItems;
            dataGridView1.Columns["id"].Visible = false;
            labelSum.Text = orderItems.Sum(x => x.cena).ToString();
        }
        public ZamowieniaEdycja(string order)
        {
            InitializeComponent();
            orderNr= order;
            dc = new DataContext("Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            Table<zamowienie> zamowienie = dc.GetTable<zamowienie>();
            if(order != null)
            {
                existingOrder = true;
                refreshList(orderNr);
            }
            else
            {
                existingOrder= false;
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


        }

        private void nowaPozycjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table<zamowienie> zamowienie = dc.GetTable<zamowienie>();
            if (!existingOrder)
                pushNewOrderToDatabase();
            var query=zamowienie.Single(x=>x.numer_zamowienia == orderNr);
                Form zamowieniePozycjeEdycja = new ZamowieniePozycjeEdycja(0, query.id);
                zamowieniePozycjeEdycja.ShowDialog();
            refreshList(orderNr);

        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null)
            {
                Table<zamowienie> zamowienie = dc.GetTable<zamowienie>();
                var query = zamowienie.Single(x => x.numer_zamowienia == orderNr);
                Table<zamowienie_produkt> zamowienie_produkt = dc.GetTable<zamowienie_produkt>();
                var selectedItem = dataGridView1.SelectedCells[0].RowIndex;
                var name = dataGridView1.Rows[selectedItem].Cells[0].Value.ToString();
                var zProdukt = zamowienie_produkt.Single(x => x.id == (int)dataGridView1.Rows[selectedItem].Cells[0].Value);
                Form zamowieniePozycjeEdycja = new ZamowieniePozycjeEdycja(zProdukt.id,query.id);
                zamowieniePozycjeEdycja.ShowDialog();
                refreshList(orderNr);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null)
            {
                Table<zamowienie> zamowienie = dc.GetTable<zamowienie>();
                var query = zamowienie.Single(x => x.numer_zamowienia == orderNr);
                Table<zamowienie_produkt> zamowienie_produkt = dc.GetTable<zamowienie_produkt>();
                var selectedItem = dataGridView1.SelectedCells[0].RowIndex;
                var name = dataGridView1.Rows[selectedItem].Cells[0].Value.ToString();
                var zProdukt = zamowienie_produkt.Single(x => x.id == (int)dataGridView1.Rows[selectedItem].Cells[0].Value);
                Form zamowieniePozycjeEdycja = new ZamowieniePozycjeEdycja(zProdukt.id, query.id);
                zamowieniePozycjeEdycja.ShowDialog();
                refreshList(orderNr);
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells == null)
                edytujToolStripMenuItem.Enabled = false;
            else
                edytujToolStripMenuItem.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!existingOrder)
                pushNewOrderToDatabase();
            Form zamowienia = new Zamowienia();
            zamowienia.Show();
            this.Close();
        }
        private void pushNewOrderToDatabase()
        {
            Table<zamowienie> zamowienie = dc.GetTable<zamowienie>();
            var query1 = (from zam in zamowienie
                          group zam by true into r
                          select new { maxId = r.Max(x => x.id) }).ToList()[0];
            var myOrder = new zamowienie()
            {
                id = query1.maxId+1,
                numer_zamowienia = orderNr,
                data_zamowienia = DateTime.Now,
            };
            zamowienie.InsertOnSubmit(myOrder);
            dc.SubmitChanges();
            existingOrder = true;
            
        }
    }
}
