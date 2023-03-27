using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            dc = new DataContext(ConfigurationManager.ConnectionStrings["SklepElektroniczny1501.Properties.Settings.masterConnectionString"].ToString());
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
                var editedProduct= (from pk in produkt_kategoria
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
                prodId = editedProduct.id;
                textBoxName.Text = editedProduct.nazwa;
                textBoxModel.Text = editedProduct.model;
                textBoxPrice.Text = editedProduct.cena.ToString();
                textBoxAmount.Text = editedProduct.ilosc_dostepna.ToString();
                comboBoxCategory.SelectedItem = editedProduct.kategoria1;
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
                if (comboBoxCategory.SelectedIndex == -1) { throw new IndexOutOfRangeException(); }
                if (!int.TryParse(textBoxAmount.Text,out int amount)){ throw new ArgumentException(); }
                if (!decimal.TryParse(textBoxPrice.Text, out decimal price)){ throw new ArgumentException(); }
                if (amount < 0) { throw new ArgumentException(); }
                if (price < 0) { throw new ArgumentException(); }
                var selectedCategory = kategoria.Single(x => x.kategoria1 == kategorie[comboBoxCategory.SelectedIndex]);
                if (prodId==-1)
                {
                    //insertintotable

                    var myProdukt = new produkt()
                    {
                        nazwa = textBoxName.Text,
                        model = textBoxModel.Text,
                        opis = null,
                        ilosc_dostepna = amount,
                        cena = price,
                    };
                    produkt.InsertOnSubmit(myProdukt);
                    dc.SubmitChanges();
                    var myProduktKategoria = new produkt_kategoria()
                    {
                        
                        id_produkt = myProdukt.id,
                        id_kategoria = selectedCategory.id,
                    };
                    
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
                    pk.id_kategoria = selectedCategory.id;
                }

                dc.SubmitChanges();
                Produkty produkty = new Produkty();
                produkty.Show();
                this.Close();
            }
            catch (IndexOutOfRangeException ex)
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
