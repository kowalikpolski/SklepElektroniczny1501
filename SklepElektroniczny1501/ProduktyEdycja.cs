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
    public partial class ProduktyEdycja : Form
    {
        private DataContext dc;
        private int prodId;
        private string[] kategorie;
        public ProduktyEdycja(string name, string model)
        {
            InitializeComponent();
            dc = new DataContext("Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            Table<produkt_kategoria> produkt_kategoria = dc.GetTable<produkt_kategoria>();
            Table<produkt> produkt = dc.GetTable<produkt>();
            Table<kategoria> kategoria = dc.GetTable<kategoria>();
            kategorie=(from kat in kategoria 
                        select kat.kategoria1).ToArray();
            comboBoxCategory.Items.AddRange(kategorie);
            if (name == null)
            {  //nowy element
                prodId = -1;
            }
            else
            {
                var query= (from pk in produkt_kategoria
                            join prod in produkt on pk.id_produkt equals prod.id
                            join kat in kategoria on pk.id_kategoria equals kat.id
                            where prod.nazwa==name 
                           where prod.model==model
                           select new{
                                prod.id,
                                prod.nazwa,
                                prod.model,
                                prod.cena,
                                prod.ilosc_dostepna,
                                kat.kategoria1,
                }).ToList()[0];
                prodId = query.id;
                textBoxName.Text = query.nazwa;
                textBoxModel.Text = query.model;
                textBoxPrice.Text = query.cena.ToString();
                textBoxAmount.Text = query.ilosc_dostepna.ToString();
                comboBoxCategory.SelectedItem = query.kategoria1;
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table<produkt_kategoria> produkt_kategoria = dc.GetTable<produkt_kategoria>();
            Table<produkt> produkt = dc.GetTable<produkt>();
            Table<kategoria> kategoria = dc.GetTable<kategoria>();
            try
            {
                if (textBoxModel.Text.Length == 0) { throw new ArgumentNullException(); }
                if (textBoxName.Text.Length == 0) { throw new ArgumentNullException(); }
                if (textBoxAmount.Text.Length == 0) { throw new ArgumentNullException(); }
                if (textBoxPrice.Text.Length == 0) { throw new ArgumentNullException(); }
                if (comboBoxCategory.SelectedIndex == -1) { throw new ArgumentOutOfRangeException(); }
                if (!int.TryParse(textBoxAmount.Text,out int amount)){ throw new ArgumentException(); }
                if (!decimal.TryParse(textBoxPrice.Text, out decimal price)){ throw new ArgumentException(); }
                if (amount < 0) { throw new ArgumentException(); }
                if (price < 0) { throw new ArgumentException(); }
                var query3 = kategoria.Single(x => x.kategoria1 == kategorie[comboBoxCategory.SelectedIndex]);
                if (prodId==-1)
                {
                    //insertintotable
                    var query1 = (from prod in produkt
                                  group prod by true into r
                                  select new { maxId = r.Max(x => x.id) }).ToList()[0];
                    var query2 = (from pk in produkt_kategoria
                                  group pk by true into r
                                  select new { maxId = r.Max(x => x.id) }).ToList()[0];
                    var myProdukt = new produkt()
                    {
                        id = query1.maxId + 1,
                        nazwa = textBoxName.Text,
                        model = textBoxModel.Text,
                        opis = null,
                        ilosc_dostepna = amount,
                        cena = price,
                    };

                    var myProduktKategoria = new produkt_kategoria()
                    {
                        id = query2.maxId + 1,
                        id_produkt = query1.maxId + 1,
                        id_kategoria = query3.id,
                    };
                    produkt.InsertOnSubmit(myProdukt);
                    produkt_kategoria.InsertOnSubmit(myProduktKategoria);

                }
                else
                {
                    //update
                    var prod = produkt.Single(x => x.id == prodId);
                    prod.nazwa = textBoxName.Text;
                    prod.model = textBoxModel.Text;
                    prod.ilosc_dostepna =amount;
                    prod.cena = price;
                    var pk = produkt_kategoria.Single(x => x.id_produkt == prodId);
                    pk.id_kategoria = query3.id;
                }

                dc.SubmitChanges();
                Produkty produkty = new Produkty();
                produkty.Show();
                this.Close();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Wybierz kategorię");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Wypełnij wszystkie pola");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Wpisz liczby dodatnie do pól cena i ilość dostępna");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    } }
