using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SklepElektroniczny1501
{
    public partial class ZamowieniePozycjeEdycja : Form
    {
        private DataContext dc;
        private zamowienie_produkt zProdukt;
        private Boolean isNewPos;

        public ZamowieniePozycjeEdycja(int id,int id_zamowienie)
        {
            zProdukt=new zamowienie_produkt();
            InitializeComponent();
            dc = new DataContext("Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            Table<zamowienie_produkt> zamowienie_produkt = dc.GetTable<zamowienie_produkt>();
            Table<produkt> produkt = dc.GetTable<produkt>();
            var query = (from prod in produkt
                         select new
                         {
                             prod.id,
                             prod.nazwa,
                             prod.model,
                             prod.cena,
                             prod.ilosc_dostepna,
                         }).ToArray();
            List<string> produkty=new List<string>();
            
            foreach (var x in query )
            {
                produkty.Add( x.nazwa+"; "+x.model+"; Cena: "+x.cena+" Dostępne: "+x.ilosc_dostepna);
            }
            comboBoxProdukt.Items.AddRange(produkty.ToArray());
            zProdukt.id_zamowienie = id_zamowienie;
            if (id != 0)
            {
                zProdukt.id=id;
                zProdukt = zamowienie_produkt.Single(x => x.id == id);
                isNewPos = false;
                labelPrice.Text = zProdukt.cena.ToString();
                textBoxAmount.Text = zProdukt.ilosc.ToString();
                var query2 = produkt.Single(x => x.id == zProdukt.id_produkt);
                comboBoxProdukt.SelectedItem = query2.nazwa + "; " + query2.model + "; Cena: " + query2.cena + " Dostępne: " + query2.ilosc_dostepna;
            }
            else
                isNewPos = true;
            
        }

        

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProdukt.SelectedItem != null)
                {
                    if (textBoxAmount.Text != "")
                    {
                        Table<produkt> produkt = dc.GetTable<produkt>();
                        var str = comboBoxProdukt.SelectedItem.ToString().Split(';');
                        var query = produkt.Single(x => x.nazwa.Trim() == str[0].Trim() && x.model.Trim() == str[1].Trim());
                        labelPrice.Text = (query.cena * int.Parse(textBoxAmount.Text)).ToString();
                    }
                }
            }
            catch(Exception ex) { }
            
        }

        private void comboBoxProdukt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProdukt.SelectedItem != null)
                {
                    if (textBoxAmount.Text != "")
                    {
                        Table<produkt> produkt = dc.GetTable<produkt>();
                        var str = comboBoxProdukt.SelectedItem.ToString().Split(';');
                        var query = produkt.Single(x => x.nazwa.Trim() == str[0].Trim() && x.model.Trim() == str[1].Trim());
                        labelPrice.Text = (query.cena * int.Parse(textBoxAmount.Text)).ToString();
                    }
                }
            }
            catch(Exception ex) { }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Table<zamowienie_produkt> zamowienie_produkt = dc.GetTable<zamowienie_produkt>();
            Table<produkt> produkt = dc.GetTable<produkt>();
            try
            {
                if (textBoxAmount.Text.Length == 0) { throw new ArgumentNullException(); }
                if (comboBoxProdukt.SelectedIndex == -1) { throw new IndexOutOfRangeException(); }
                if (!int.TryParse(textBoxAmount.Text, out int amount)) { throw new ArgumentException(); }
                if (amount < 0) { throw new ArgumentException(); }
                
                var query1 = (from zp in zamowienie_produkt
                              group zp by true into r
                              select new { maxId = r.Max(x => x.id) }).ToList()[0];
                var str = comboBoxProdukt.SelectedItem.ToString().Split(';');
                var prod = produkt.Single(x => x.nazwa.Trim() == str[0].Trim() && x.model.Trim() == str[1].Trim());
                
                if (isNewPos)
                {
                    if(prod.ilosc_dostepna-amount<0) throw new ArgumentOutOfRangeException();
                    zProdukt.id = query1.maxId + 1;
                    zProdukt.id_produkt = prod.id;
                    zProdukt.cena = decimal.Parse(labelPrice.Text);
                    zProdukt.ilosc = amount;
                    zamowienie_produkt.InsertOnSubmit(zProdukt);
                    prod.ilosc_dostepna = prod.ilosc_dostepna - amount;
                }
                else
                {
                    
                    var zp = zamowienie_produkt.Single(x => x.id == zProdukt.id);
                    if (prod.ilosc_dostepna - amount+zp.ilosc< 0) throw new ArgumentOutOfRangeException();
                    zp.id_produkt = prod.id;
                    zp.cena = decimal.Parse(labelPrice.Text);
                    prod.ilosc_dostepna = prod.ilosc_dostepna - amount+zp.ilosc;
                    zp.ilosc = amount;
                    
                }
                
                dc.SubmitChanges();
                this.Close();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Wybierz produkt");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Wypełnij wszystkie pola");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Wybrano zbyt dużą ilość");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Wpisz liczby dodatnie do pola ilość");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }

}
