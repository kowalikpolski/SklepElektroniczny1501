using SklepElektroniczny;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private void refreshList()
        {
            Table<produkt> produkt = dc.GetTable<produkt>();
            Table<zamowienie_produkt> zamowienie_produkt = dc.GetTable<zamowienie_produkt>();
            Table<zamowienie> zamowienie = dc.GetTable<zamowienie>();
            Table<orderitems_view> oItemsView=dc.GetTable<orderitems_view>();
            var orderItems = (from oiv in oItemsView
                              where oiv.numer_zamowienia == orderNr
                              select oiv).ToList();
            dataGridView1.DataSource = orderItems;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["numer_zamowienia"].Visible=false;
            labelSum.Text = orderItems.Sum(x => x.cena).ToString();
        }
        public ZamowieniaEdycja(int id)
        {
            InitializeComponent();
            
            dc = new DataContext(ConfigurationManager.ConnectionStrings["SklepElektroniczny1501.Properties.Settings.masterConnectionString"].ToString());
            Table<zamowienie> zamowienie = dc.GetTable<zamowienie>();
            if(id !=-1)
            {
                existingOrder = true;
                orderNr=zamowienie.Single(x=>x.id==id).numer_zamowienia;
                refreshList();
            }
            else
            {
                existingOrder= false;
                labelSum.Text = "0";
                var maxOrderNumber = (from zam in zamowienie
                              group zam by true into r
                              select new { maxOrder = r.Max(x => x.numer_zamowienia) }).ToList()[0];
                var str=maxOrderNumber.maxOrder.Split('/');
                if (str[0] == DateTime.Now.Year.ToString())
                {
                    str[1] = String.Format("{0:000}", int.Parse(str[1]) + 1);
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
            var zam=zamowienie.Single(x=>x.numer_zamowienia == orderNr);
                Form zamowieniePozycjeEdycja = new ZamowieniePozycjeEdycja(-1, zam.id);
                zamowieniePozycjeEdycja.ShowDialog();
            refreshList();

        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
                editSelectedItem();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            editSelectedItem();
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
            this.Close();
        }
        private void pushNewOrderToDatabase()
        {
            Table<zamowienie> zamowienie = dc.GetTable<zamowienie>();
            var myOrder = new zamowienie()
            {
                numer_zamowienia = orderNr,
                data_zamowienia = DateTime.Now,
            };
            zamowienie.InsertOnSubmit(myOrder);
            dc.SubmitChanges();
            existingOrder = true;
            
        }
        private void editSelectedItem()
        {
            if (dataGridView1.SelectedCells != null)
            {
                Table<zamowienie> zamowienie = dc.GetTable<zamowienie>();
                var zam = zamowienie.Single(x => x.numer_zamowienia == orderNr);
                Table<zamowienie_produkt> zamowienie_produkt = dc.GetTable<zamowienie_produkt>();
                var selectedItem = dataGridView1.SelectedCells[0].RowIndex;
                var name = dataGridView1.Rows[selectedItem].Cells[0].Value.ToString();
                var zProdukt = zamowienie_produkt.Single(x => x.id == (int)dataGridView1.Rows[selectedItem].Cells[0].Value);
                Form zamowieniePozycjeEdycja = new ZamowieniePozycjeEdycja(zProdukt.id, zam.id);
                zamowieniePozycjeEdycja.ShowDialog();
                refreshList();
            }
        }
    }
}
