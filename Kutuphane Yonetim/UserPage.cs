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
        //private event Action<ListViewItem> OnListViewUpdate;
        #region Global

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
            setPersonalInfoTextBox(aktifKullanici);

        }

        private void UserPage_Load(object sender, EventArgs e) {

        }

        private void UserPage_FormClosing(object sender, FormClosingEventArgs e) {
            if(!exit)
                Application.Exit();
            //loginForm.Show();
        }
        bool exit = false;
        private void pictureBoxExit_Click(object sender, EventArgs e) {

            loginForm.Show();
            exit = true;
            this.Close();
        }
        #endregion

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
                
                command = new NpgsqlCommand("select urun.ad,urun.tip,kisi_urun.tarih,kisi_urun.rezerve,urun.id from kisi_urun ,urun WHERE kisi_id = "+aktifKullanici.id+" AND urun.id = urun_id", connection);
                
                NpgsqlDataReader reader = command.ExecuteReader();
                for (int i = 0; reader.Read(); i++) {
                    ListViewItem item = new ListViewItem(reader[0].ToString());
                    //item.SubItems.Add();//isim
                    item.SubItems.Add(reader[1].ToString());//tip
                    item.SubItems.Add(DateTime.Parse(reader[2].ToString()).ToString("yyyy-MM-dd"));//tarih
                    item.SubItems.Add(reader[3].ToString());
                    item.SubItems.Add(reader[4].ToString());
                    listViewMyBooks.Items.Add(item);
                }
                reader.Close();
                connection.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #endregion

        #region KitapAL
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

        private void textboxSearch_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                listViewProducts.Items.Clear();
                GetAllItemsWithName(textboxSearch.Text);
            }
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e) {
            int x = listViewProducts.SelectedItems.Count;
            if (x == 1) {
                labelName.Text = listViewProducts.SelectedItems[0].SubItems[1].Text;
                labelType.Text = listViewProducts.SelectedItems[0].SubItems[5].Text;
            } else if (x == 0) {
                labelName.Text = "-";
                labelType.Text = "-";
            }
        }

        private void MakeRezervation() {
            if(listViewProducts.SelectedItems.Count == 1) {
                try {
                    string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                    NpgsqlConnection connection = new NpgsqlConnection(connString);
                    connection.Open();
                    NpgsqlCommand command;
                    command = new NpgsqlCommand("INSERT INTO kisi_urun (kisi_id,urun_id,rezerve) values (" + aktifKullanici.id + "," + listViewProducts.SelectedItems[0].SubItems[0].Text + ",TRUE)", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Rezervasyonunuz başarılı bir şekilde gerçekleşmiştir.");

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            } else {
                MessageBox.Show("Lütfen bir kitap seçin");
            }
            
            
        }

        private void buttonRezervation_Click(object sender, EventArgs e) {
            MakeRezervation();
            listViewMyBooks.Items.Clear();
            GetAllUserItems();
        }

        #endregion

        #region AldıgımKitaplar

        private void CancelRezervation() {

            if (listViewMyBooks.SelectedItems.Count == 1) {
                if(listViewMyBooks.SelectedItems[0].SubItems[3].Text.ToLower() == "false") {
                    MessageBox.Show("Seçtiginiz Ürün rezervasyon değildir.");
                    return;
                }
                try {
                    string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                    NpgsqlConnection connection = new NpgsqlConnection(connString);
                    connection.Open();
                    NpgsqlCommand command;
                    command = new NpgsqlCommand("DELETE FROM kisi_urun WHERE kisi_id = "+aktifKullanici.id+"AND urun_id="+listViewMyBooks.SelectedItems[0].SubItems[4].Text, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Rezervasyonunuz İptal Edilmiştir.");

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            } else {
                MessageBox.Show("Lütfen bir kitap seçin");
            }
        }

        private void buttonCancelRez_Click(object sender, EventArgs e) {
            CancelRezervation();
            listViewMyBooks.Items.Clear();
            GetAllUserItems();
        }


        #endregion

        #region PersonalInfo
        void setPersonalInfoTextBox(Insan kisi) {
            txtName.Text = kisi.ad;
            txtSurname.Text = kisi.soyad;
            txtEmail.Text = kisi.eposta;
            txtPass.Text = kisi.password;
        }
        void setAktifKullaniciFromTextBox(Insan kisi) {
            kisi.ad = txtName.Text;
            kisi.soyad = txtSurname.Text;
            kisi.eposta = txtEmail.Text;
            kisi.password = txtPass.Text;
        }

        void getAndSetPersonalInfo() {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                NpgsqlCommand command;
                string values = "'" + txtName.Text + "','" + txtSurname.Text + "','" + txtEmail.Text + "','" + txtPass.Text + "'";
                command = new NpgsqlCommand("UPDATE kisi SET (ad,soyad,eposta,pass) = (" + values + ") WHERE id =" + aktifKullanici.id, connection);

                command.ExecuteNonQuery();
                setAktifKullaniciFromTextBox(aktifKullanici);

                connection.Close();
                MessageBox.Show("Bilgileriniz başarılı bir şekilde güncellenmiştir.");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonUpdateInfos_Click(object sender, EventArgs e) {
            getAndSetPersonalInfo();
        }

        #endregion


        private void buttonReturn_Click(object sender, EventArgs e) {
            
        }

        void ReturnBook(ListViewItem item) {

        }

        private void listViewMyBooks_SelectedIndexChanged(object sender, EventArgs e) {
            
        }


    }
}
