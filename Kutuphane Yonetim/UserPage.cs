﻿using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Yonetim {
    public partial class UserPage : MetroFramework.Forms.MetroForm {
        Insan aktifKullanici;
        Login loginForm;
        public UserPage(Login loginForm,Insan aktifKullanici) {
            this.loginForm = loginForm;
            InitializeComponent();
            this.aktifKullanici = aktifKullanici;
            labelWelcome.Text += aktifKullanici.ad + " " + aktifKullanici.soyad + " " + aktifKullanici.GetType().BaseType;
            labelBakiye.Text += aktifKullanici.kart.getBakiye().ToString() + " TL"; 
            GetAllItems();

        }

        private void UserPage_Load(object sender, EventArgs e) {

        }

        private void UserPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        #region GetItems

        void GetAllItems() {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                //Urun urun;
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM urun", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                for (int i = 0; reader.Read(); i++) {
                    //urun = new Urun(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[3].ToString()), int.Parse(reader[2].ToString()), int.Parse(reader[4].ToString()),reader[5].ToString());
                    ListViewItem item = new ListViewItem(reader[0].ToString());//id
                    item.SubItems.Add(reader[1].ToString());//isim
                    item.SubItems.Add(reader[2].ToString());//toplam Adet
                    item.SubItems.Add(reader[3].ToString());//anlık Adet
                    item.SubItems.Add(reader[4].ToString());//rezerve
                    item.SubItems.Add(reader[5].ToString());//tip
                    listViewProducts.Items.Add(item);
                }
                reader.Close();
                connection.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        void GetAllItemsWithCategory(string categoryName) {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                //Urun urun;
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM urun WHERE tip = '" + categoryName + "'", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                for (int i = 0; reader.Read(); i++) {
                    //urun = new Urun(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[3].ToString()), int.Parse(reader[2].ToString()), int.Parse(reader[4].ToString()),reader[5].ToString());
                    ListViewItem item = new ListViewItem(reader[0].ToString());//id
                    item.SubItems.Add(reader[1].ToString());//isim
                    item.SubItems.Add(reader[2].ToString());//toplam Adet
                    item.SubItems.Add(reader[3].ToString());//anlık Adet
                    item.SubItems.Add(reader[4].ToString());//rezerve
                    item.SubItems.Add(reader[5].ToString());//tip
                    listViewProducts.Items.Add(item);
                }
                reader.Close();
                connection.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        void GetAllItemsWithName(string productName) {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                //Urun urun;
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM urun WHERE lower(ad) LIKE '%" + productName + "%'", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                for (int i = 0; reader.Read(); i++) {
                    //urun = new Urun(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[3].ToString()), int.Parse(reader[2].ToString()), int.Parse(reader[4].ToString()),reader[5].ToString());
                    ListViewItem item = new ListViewItem(reader[0].ToString());//id
                    item.SubItems.Add(reader[1].ToString());//isim
                    item.SubItems.Add(reader[2].ToString());//toplam Adet
                    item.SubItems.Add(reader[3].ToString());//anlık Adet
                    item.SubItems.Add(reader[4].ToString());//rezerve
                    item.SubItems.Add(reader[5].ToString());//tip
                    listViewProducts.Items.Add(item);
                }
                reader.Close();
                connection.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        #endregion
        //category changed
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            listViewProducts.Items.Clear();
            string cat = listBox1.SelectedItem.ToString();
            if (cat == "Tüm") {
                GetAllItems();
            } else {
                GetAllItemsWithCategory(cat);
            }
        }

        private void UserPage_Load_1(object sender, EventArgs e) {

        }
    }
}
