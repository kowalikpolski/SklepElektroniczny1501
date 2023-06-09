﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace SklepElektroniczny1501
{
    public partial class ZamowieniePozycjeEdycja : Form
    {
        private DataContext dc;
        private zamowienie_produkt zProdukt;
        private Boolean isNewPos;

        public ZamowieniePozycjeEdycja(int id, int id_zamowienie)
        {
            zProdukt = new zamowienie_produkt();
            InitializeComponent();
            dc = new DataContext(ConfigurationManager.ConnectionStrings["SklepElektroniczny1501.Properties.Settings.masterConnectionString"].ToString());
            Table<zamowienie_produkt> zamowienie_produkt = dc.GetTable<zamowienie_produkt>();
            Table<produkt> produkt = dc.GetTable<produkt>();
            var productList = (from prod in produkt
                               select new
                               {
                                   prod.id,
                                   prod.nazwa,
                                   prod.model,
                                   prod.cena,
                                   prod.ilosc_dostepna,
                               }).ToArray();
            List<string> produkty = new List<string>();

            foreach (var x in productList)
            {
                produkty.Add(x.nazwa + "; " + x.model + "; Cena: " + x.cena + " Dostępne: " + x.ilosc_dostepna);
            }
            comboBoxProdukt.Items.AddRange(produkty.ToArray());
            zProdukt.id_zamowienie = id_zamowienie;
            if (id != -1)
            {
                zProdukt.id = id;
                zProdukt = zamowienie_produkt.Single(x => x.id == id);
                isNewPos = false;
                labelPrice.Text = zProdukt.cena.ToString();
                textBoxAmount.Text = zProdukt.ilosc.ToString();
                var selectedProduct = produkt.Single(x => x.id == zProdukt.id_produkt);
                comboBoxProdukt.SelectedItem = selectedProduct.nazwa + "; " + selectedProduct.model + "; Cena: " + selectedProduct.cena + " Dostępne: " + selectedProduct.ilosc_dostepna;
            }
            else
                isNewPos = true;
        }
        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            recalculatePrice();
        }

        private void comboBoxProdukt_SelectedIndexChanged(object sender, EventArgs e)
        {
            recalculatePrice();
        }
        private void recalculatePrice()
        {
            try
            {
                if (comboBoxProdukt.SelectedItem != null)
                {
                    if (textBoxAmount.Text != "")
                    {
                        Table<produkt> produkt = dc.GetTable<produkt>();
                        var str = comboBoxProdukt.SelectedItem.ToString().Split(';');
                        var prod = produkt.Single(x => x.nazwa.Trim() == str[0].Trim() && x.model.Trim() == str[1].Trim());
                        labelPrice.Text = (prod.cena * int.Parse(textBoxAmount.Text)).ToString();
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Table<zamowienie_produkt> zamowienie_produkt = dc.GetTable<zamowienie_produkt>();
            Table<produkt> produkt = dc.GetTable<produkt>();
            try
            {
                if (comboBoxProdukt.SelectedIndex == -1) { throw new IndexOutOfRangeException(); }
                if (!int.TryParse(textBoxAmount.Text, out int amount)) { throw new ArgumentException(); }
                var str = comboBoxProdukt.SelectedItem.ToString().Split(';');
                var prod = produkt.Single(x => x.nazwa.Trim() == str[0].Trim() && x.model.Trim() == str[1].Trim());
                ProductValidator pValidator = new ProductValidator();
                OrderProductValidator opValidator = new OrderProductValidator();
                if (isNewPos)
                {
                    zProdukt.id_produkt = prod.id;
                    zProdukt.cena = decimal.Parse(labelPrice.Text);
                    zProdukt.ilosc = amount;
                    prod.ilosc_dostepna = prod.ilosc_dostepna - amount;
                    pValidator.ValidateAndThrow(prod);
                    opValidator.ValidateAndThrow(zProdukt);
                    zamowienie_produkt.InsertOnSubmit(zProdukt);
                }
                else
                {
                    var zp = zamowienie_produkt.Single(x => x.id == zProdukt.id);
                    zp.id_produkt = prod.id;
                    zp.cena = decimal.Parse(labelPrice.Text);
                    prod.ilosc_dostepna = prod.ilosc_dostepna - amount + zp.ilosc;
                    zp.ilosc = amount;
                    opValidator.ValidateAndThrow(zProdukt);
                    pValidator.ValidateAndThrow(prod);
                }
                dc.SubmitChanges();

                this.Close();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Wybierz produkt");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Wpisz liczby do pola ilość");
            }
            catch (FluentValidation.ValidationException ex)
            {
                MessageBox.Show(ex.Message);
                dc.Refresh(RefreshMode.OverwriteCurrentValues,produkt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }

}
