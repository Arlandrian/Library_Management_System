using MaterialSkin.Controls;
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
        bool isOgretimGorevlisi = true;
        private event Action<ListViewItem> OnListViewUpdate;

        public UserPage(Login loginForm,Insan aktifKullanici) {
            this.loginForm = loginForm;
            InitializeComponent();
            this.aktifKullanici = aktifKullanici;
            if (aktifKullanici.GetType() != typeof(OgretimUyesi)) {
                listBox1.Items.RemoveAt(2);
                isOgretimGorevlisi = false;
            }
            labelWelcome.Text += aktifKullanici.ad + " " + aktifKullanici.soyad + " " + aktifKullanici.GetType().Name;
            labelBakiye.Text += aktifKullanici.kart.getBakiye().ToString() + " TL"; 
            GetAllItems();
            GetAllUserItems();


        }

        private void UserPage_Load(object sender, EventArgs e) {

        }

        private void UserPage_FormClosing(object sender, FormClosingEventArgs e) {
            if(!exit)
                Application.Exit();
            //loginForm.Show();
        }

        #region GetItems

        void listViewChanged() {
            if (aktifKullanici.GetType() != typeof(OgretimUyesi))

                for (int i = 0; i < listViewProducts.Items.Count; i++) {
                    if (listViewProducts.Items[i].SubItems[5].Text == "DersKitabı") {
                        listViewProducts.Items.RemoveAt(i);
                    }
                }
        }

        void GetAllItems() {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                NpgsqlCommand command;
                if (isOgretimGorevlisi) {
                    command = new NpgsqlCommand("SELECT * FROM urun", connection);
                } else {
                    command = new NpgsqlCommand("SELECT * FROM urun WHERE tip != 'DersKitabi'", connection);
                }
                NpgsqlDataReader reader = command.ExecuteReader();
                for (int i = 0; reader.Read(); i++) {
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
                NpgsqlCommand command;
                if (isOgretimGorevlisi) {
                    command = new NpgsqlCommand("SELECT * FROM urun WHERE lower(ad) LIKE '%" + productName + "%'", connection);
                } else {
                    command = new NpgsqlCommand("SELECT * FROM urun WHERE tip != 'DersKitabi' AND lower(ad) LIKE '%" + productName + "%'", connection);
                }
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
        
        void GetAllUserItems() {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                NpgsqlCommand command;
                
                command = new NpgsqlCommand("select urun.ad,urun.tip,kisi_urun.tarih from kisi_urun ,urun WHERE kisi_id = "+aktifKullanici.id+" AND urun.id = urun_id", connection);
                
                NpgsqlDataReader reader = command.ExecuteReader();
                for (int i = 0; reader.Read(); i++) {
                    ListViewItem item = new ListViewItem(reader[0].ToString());
                    //item.SubItems.Add();//isim
                    item.SubItems.Add(reader[1].ToString());//tip
                    item.SubItems.Add(DateTime.Parse(reader[2].ToString()).ToString("yyyy-MM-dd"));//tarih
                    listViewMyBooks.Items.Add(item);
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
        bool exit = false;
        private void pictureBoxExit_Click(object sender, EventArgs e) {
            
            loginForm.Show();
            exit = true;
            this.Close();
        }

        private void textboxSearch_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                listViewProducts.Items.Clear();
                GetAllItemsWithName(textboxSearch.Text);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e) {

        }

        void ReturnBook(ListViewItem item) {

        }
    }
}
