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
        public ProduktyEdycja(string name, string model)
        {
            InitializeComponent();
            DataContext dc = new DataContext("Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            Table<produkt_kategoria> produkt_kategoria = dc.GetTable<produkt_kategoria>();
            Table<produkt> produkt = dc.GetTable<produkt>();
            Table<kategoria> kategoria = dc.GetTable<kategoria>();
            if (name == null)
            {
                //nowy element
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
                textBoxName.Text = query.nazwa;
                textBoxModel.Text = query.model;
                textBoxPrice.Text = query.cena.ToString();
                textBoxAmount.Text = query.ilosc_dostepna.ToString();
                comboBoxCategory.Text= query.kategoria1;
            }

           
        }
    } }
