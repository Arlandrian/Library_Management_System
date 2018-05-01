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
    public partial class AdminPage : MaterialForm {
        Login loginForm;

        public AdminPage(Login login) {
            InitializeComponent();
            loginForm = login;
            getSinirsToTextBox();
            GetAllItems();
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
            } catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        void GetAllItemsWithCategory(string categoryName) {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                //Urun urun;
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM urun WHERE tip = '"+ categoryName+"'", connection);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            listViewProducts.Items.Clear();
            string cat = listBox1.SelectedItem.ToString();
            if (cat == "Tüm") {
                GetAllItems();
            } else {
                GetAllItemsWithCategory(cat);
            }
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e) {

            if(listViewProducts.SelectedItems.Count == 1) {
                ListViewItem item = listViewProducts.SelectedItems[0];
                textboxName.Text = item.SubItems[1].Text;
                comboboxCategory.Text = item.SubItems[5].Text;
                textboxToplamAdet.Text = item.SubItems[2].Text;
                textboxAnlıkAdet.Text = item.SubItems[3].Text;
                textboxRezerveAdet.Text = item.SubItems[4].Text;
            }
        }

        #region Done
        private void backButton_Click(object sender, EventArgs e) {
            loginForm.Show();
            this.Close();
        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e) {
            loginForm.Show();
        }
        #endregion

        private void buttonUpdate_Click(object sender, EventArgs e) {
            if(listViewProducts.SelectedItems.Count == 1) {
                UpdateItem(listViewProducts.SelectedItems[0]);
            }
        }

        private void UpdateItem(ListViewItem item) {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                string values = "'" + textboxName.Text + "','" + textboxToplamAdet.Text + "','" + textboxAnlıkAdet.Text + "','" + textboxRezerveAdet.Text + "','" + comboboxCategory.Text + "'";
                NpgsqlCommand command = new NpgsqlCommand("UPDATE urun SET (ad,toplamadet,anlikadet,rezerveadet,tip) = ("+values+")  WHERE id ="+item.SubItems[0].Text, connection);
                command.ExecuteNonQuery();
                connection.Close();

            } catch (NpgsqlException ex) {
                MessageBox.Show(ex.Message.ToString());
            }
            listViewProducts.Items.Clear();
            if(listBox1.SelectedItem == null) {
                GetAllItems();
            } else {
                GetAllItemsWithCategory(listBox1.SelectedItem.ToString());
            }
        }

        private void AddItem() {
            try {
                
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                string values = "'" + textboxName.Text + "','" + textboxToplamAdet.Text + "','" + textboxAnlıkAdet.Text + "','" + textboxRezerveAdet.Text + "','" + comboboxCategory.Text + "'";
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO urun (ad,toplamadet,anlikadet,rezerveadet,tip) VALUES (" + values + ")",connection);
                command.ExecuteNonQuery();
                connection.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
            

        }

        private void textboxSearch_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                listViewProducts.Items.Clear();
                GetAllItemsWithName(textboxSearch.Text);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            AddItem();
            listViewProducts.Items.Clear();
            if (listBox1.SelectedItem == null) {
                GetAllItems();
            } else {
                GetAllItemsWithCategory(listBox1.SelectedItem.ToString());
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) {
            setSinirsFromTextBox();
        }

        private void getSinirsToTextBox() {

            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM sinir", connection) ;
                NpgsqlDataReader reader = command.ExecuteReader();
                reader.Read();

                txtOgrenciKitap.Text = reader[0].ToString();
                txtOgretimKitap.Text = reader[1].ToString();
                txtMemurKitap.Text = reader[2].ToString();

                txtOgrenciSure.Text = reader[3].ToString();
                txtOgretimSure.Text = reader[4].ToString();
                txtMemurSure.Text = reader[5].ToString();
                reader.Close();
                connection.Close();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void setSinirsFromTextBox() {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                string values = "(" + txtOgrenciKitap.Text + ",";
                values += txtOgretimKitap.Text + ",";
                values += txtMemurKitap.Text + ",";
                values += txtOgrenciSure.Text + ",";
                values += txtOgretimSure.Text + ",";
                values += txtMemurSure.Text + ")";

                NpgsqlCommand command = new NpgsqlCommand("UPDATE sinir SET (ogrencikitap_sinir,ogretimuyekitap_sinir,memurkitap_sinir,ogrencisure_sinir,ogretimuyesure_sinir,memursure_sinir)=" + values, connection);
                command.ExecuteNonQuery();
                
                connection.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
            OgretimUyesi.kitapSiniri = int.Parse(txtOgretimKitap.Text);
            OgretimUyesi.oduncSuresi = int.Parse(txtOgretimSure.Text);
            Memur.kitapSiniri = int.Parse(txtMemurKitap.Text);
            Memur.oduncSuresi = int.Parse(txtMemurSure.Text);
            Ogrenci.kitapSiniri = int.Parse(txtOgrenciKitap.Text);
            Ogrenci.oduncSuresi = int.Parse(txtOgrenciSure.Text);

        }

    }
}
