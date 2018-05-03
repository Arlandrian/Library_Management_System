using MetroFramework.Forms;
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
    public partial class KioskPage : MetroForm {
        Login loginForm;
        private int panelState = 0;
        private List<Panel> panelList = new List<Panel>();

        Insan aktifKullanici;
        Urun aktifUrun;

        public KioskPage(Login loginForm) {
            InitializeComponent();
            this.loginForm = loginForm;
            panelList.Add(metroPanel1);
            panelList.Add(metroPanel2);
            panelList.Add(metroPanel3);
            ChangeState(0);
            


        }

        #region Global

        private void ChangeState(int go) {
            
            switch (go) {
                case 0:
                    panelList[0].BringToFront();
                    
                    panelState = 0;
                    break;
                case 1:
                    panelList[1].BringToFront();
                    panelState = 1;
                    break;
                case 2:
                    panelList[2].BringToFront();
                    panelState = 2;
                    break;
                case 3:
                    panelList[0].BringToFront();
                    panelState = 0;
                    break;

                default:
                    MessageBox.Show("State numarası hatası");
                    break;
            }
            buttonBack.Parent = panelList[panelState];
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void KioskPage_FormClosing(object sender, FormClosingEventArgs e) {
            loginForm.Show();
        }

        private int KartOkut(string kartID) {
            
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM kisi,akillikart WHERE kisi.ak_id = akillikart.id AND akillikart.id = "+kartID, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if(!reader.HasRows) {
                    throw new Exception("ID niz bulunamadı");
                }
                int tip = int.Parse(reader[6].ToString());
                if(tip == 0) {
                    aktifKullanici = new Ogrenci(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), new AkilliKart(float.Parse(reader[8].ToString()), reader[7].ToString()), reader[4].ToString(), reader[5].ToString());
                }else if(tip == 1) {
                    aktifKullanici = new OgretimUyesi(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), new AkilliKart(float.Parse(reader[8].ToString()), reader[7].ToString()), reader[4].ToString(), reader[5].ToString());
                } else {
                    aktifKullanici = new Memur(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), new AkilliKart(float.Parse(reader[8].ToString()), reader[7].ToString()), reader[4].ToString(), reader[5].ToString());
                }
                reader.Close();
                connection.Close();
                return 1;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }

        private int UrunOkut(string urunID) {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                //Urun urun;
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM urun WHERE id = " + urunID, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (!reader.HasRows) {
                    throw new Exception("Urun ID'si bulunamadı");
                }

                int anlikAdet = int.Parse(reader[3].ToString());
                int toplamAdet = int.Parse(reader[2].ToString()); 
                int rezerveAdet = int.Parse(reader[4].ToString());

                aktifUrun = new Urun(reader[0].ToString(), reader[1].ToString(), anlikAdet, toplamAdet, rezerveAdet, reader[5].ToString());
                
                reader.Close();
                connection.Close();
                return 1;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }


        #endregion

        #region State 0

        private void button0UrunOkut_Click(object sender, EventArgs e) {
            if(txt0UrunOkut.Text != string.Empty) {
                if (UrunOkut(txt0UrunOkut.Text) == 1) {
                    label1Urun.Text = aktifUrun.ad;
                    ChangeState(1);
                }
            } else {
                MessageBox.Show("Lütfen kutucuğu doldurun.");
            }
            
        }

        private void button0KartıOkut_Click(object sender, EventArgs e) {
            if (txt0KartOkut.Text != string.Empty) {
                if (KartOkut(txt0KartOkut.Text) == 1) {
                    label2AdSoyad.Text = aktifKullanici.ad + " " + aktifKullanici.soyad;
                    label2Bakiye.Text = "Bakiyeniz : " + aktifKullanici.kart.getBakiye().ToString();
                    ChangeState(2);
                }
            } else {
                MessageBox.Show("Lütfen kutucuğu doldurun.");
            }
        }

        #endregion

        private void RezervasyonSilKitabıVer(NpgsqlConnection connection) {
            try {
                NpgsqlCommand command;
                command = new NpgsqlCommand("DELETE FROM kisi_urun WHERE kisi_id=" + aktifKullanici.id + " AND urun_id=" + aktifUrun.id + " AND rezerve = ", connection);
                command.ExecuteNonQuery();
                command = new NpgsqlCommand("INSERT INTO kisi_urun (kisi_id,urun_id,rezerve) VALUES (" + aktifKullanici.id + "," + aktifUrun.id + ",TRUE)", connection);
                command.ExecuteNonQuery();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        int gunSinir;
        int adetSinir;
        //0: Hicbisey  1: rezervasyon  2: AL  3: Iade Et -1 :HATA
        private int KitapIadeEtVEYAAl(string kisiID,string urunID) {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                NpgsqlCommand command;
                //Kitap kullanıcıda var mı?
                //Kitabı daha önceden rezerve etmiş mi?
                NpgsqlCommand controlCommand = new NpgsqlCommand("SELECT COUNT(*) FROM kisi_urun WHERE urun_id=" + urunID + " AND kisi_id =" + kisiID + " AND rezerve =" + "FALSE", connection);
                NpgsqlDataReader reader = controlCommand.ExecuteReader();
                reader.Read();
                int elindekiAdet = int.Parse(reader[0].ToString());
                reader.Close();
                //Int64 elindekiAdet = (Int64)controlCommand.ExecuteScalar();

                if (elindekiAdet > 0) {//Kitap adamda var
                    

                    command = new NpgsqlCommand("SELECT CURRENT_DATE-(SELECT tarih FROM kisi_urun WHERE urun_id=" + urunID + " AND kisi_id =" + kisiID + " )", connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    int gun = int.Parse(reader[0].ToString());
                    reader.Close();
                    //int gun = (int)command.ExecuteScalar();

                    command = new NpgsqlCommand("SELECT tip FROM kisi WHERE id = " + kisiID, connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    int tip = int.Parse(reader[0].ToString());
                    reader.Close();

                    command = new NpgsqlCommand("DELETE FROM kisi_urun WHERE urun_id=" + urunID + " AND kisi_id =" + kisiID, connection);
                    command.ExecuteNonQuery();

                    //int tip = (int)command.ExecuteScalar();
                    if (tip == 0) {
                        gunSinir = Ogrenci.oduncSuresi;
                        adetSinir = Ogrenci.kitapSiniri;
                    } else if (tip == 1) {
                        gunSinir = OgretimUyesi.oduncSuresi;
                        adetSinir = OgretimUyesi.kitapSiniri;
                    } else {
                        gunSinir = Memur.oduncSuresi;
                        adetSinir = Memur.kitapSiniri;
                    }

                    if (gun > gunSinir) {//CEZA
                        command = new NpgsqlCommand("UPDATE akillikart SET bakiye = bakiye " + (-gun).ToString(), connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürünü geç getirdiğiniz için " + gun.ToString() + " TL bakiyenizden düşülmüştür.");
                    } else {
                        MessageBox.Show("Ürünü zamanında  teslim ettiğiniz için teşekkür ederiz.");
                    }
                    return 3;
                } else {

                    //Stokta kitap var mı
                    command = new NpgsqlCommand("SELECT anlikAdet FROM urun WHERE id=" + urunID, connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    int anlikAdet = int.Parse(reader[0].ToString());
                    reader.Close();
                    //int anlikAdet = (int)command.ExecuteScalar();

                    controlCommand = new NpgsqlCommand("SELECT COUNT(*) FROM kisi_urun WHERE urun_id=" + urunID + " AND kisi_id =" + kisiID + " AND rezerve =" + "TRUE", connection);
                    reader = controlCommand.ExecuteReader();
                    reader.Read();
                    int countRezerve = int.Parse(reader[0].ToString());
                    reader.Close();
                    //Int64 countRezerve = (Int64)controlCommand.ExecuteScalar();

                    if (anlikAdet < 0) {//stokta kitap yok
                        
                        DialogResult dialogResult = MessageBox.Show(this, "Şu anda bu kitap elimizde bulunmamaktadır.\nRezerve Etmek istermisiniz?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes) {
                            command = new NpgsqlCommand("INSERT INTO kisi_urun (kisi_id,urun_id,rezerve) VALUES ("+kisiID+","+urunID+",TRUE)",connection);
                            command.ExecuteNonQuery();
                            return 1;
                        } else if (dialogResult == DialogResult.No) {
                            return 0;
                        } else {
                            return 0;
                        }
                        
                    } else {//stokta kitap var
                        
                        if (countRezerve > 0) {
                            RezervasyonSilKitabıVer(connection);
                        } else {
                            command = new NpgsqlCommand("INSERT INTO kisi_urun (kisi_id,urun_id) VALUES (" + kisiID + "," + urunID + ")", connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Kitabı aldınız");
                        }
                        return 2;
                    }
                    //connection.Close();
                    
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }

        #region State 1



        private void button1KartOkut_Click(object sender, EventArgs e) {
            if (txt1KartOkut.Text != string.Empty) {
                if (KartOkut(txt1KartOkut.Text) == 1) {
                    KitapIadeEtVEYAAl(aktifKullanici.id, aktifUrun.id);
                    ChangeState(3);
                    Npgsql.NpgsqlConnection.ClearAllPools();
                }
            } else {
                MessageBox.Show("Lütfen kutucuğu doldurun.");
            }
        }


        #endregion

        #region State 2

        private void button2UrunOkut_Click(object sender, EventArgs e) {
            if (txt2UrunOkut.Text != string.Empty) {
                if (UrunOkut(txt2UrunOkut.Text) == 1) {
                    KitapIadeEtVEYAAl(aktifKullanici.id, aktifUrun.id);
                    ChangeState(3);
                    Npgsql.NpgsqlConnection.ClearAllPools();
                }
            } else {
                MessageBox.Show("Lütfen kutucuğu doldurun");
            }
        }

        private void button2BorcOde_Click(object sender, EventArgs e) {
            if (txt2BorcOde.Text.ToString() != string.Empty) {

                try {
                    string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                    NpgsqlConnection connection = new NpgsqlConnection(connString);
                    connection.Open();
                    NpgsqlCommand command;
                    float bakiye = aktifKullanici.kart.getBakiye();
                    float x = float.Parse(txt2BorcOde.Text);
                    float son = bakiye + x;
                    command = new NpgsqlCommand("UPDATE akillikart SET bakiye= " + son + "WHERE id = " + aktifKullanici.kart.id, connection);
                    label2Bakiye.Text = "Bakiyeniz : " + son.ToString();
                    command.ExecuteNonQuery();

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }


            } else
                MessageBox.Show("Lütfen kutucuğu doldurun.");
        }

        #endregion


    }
}
