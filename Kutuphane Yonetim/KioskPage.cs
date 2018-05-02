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
            panelList.Add(metroPanel4);
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
                //Urun urun;
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
            if (UrunOkut(txt0UrunOkut.Text) == 1) {
                label1Urun.Text = aktifUrun.ad;
                ChangeState(1);
            }
        }

        private void button0KartıOkut_Click(object sender, EventArgs e) {
            if(KartOkut(txt0KartOkut.Text) == 1) {
                label2AdSoyad.Text = aktifKullanici.ad + " " + aktifKullanici.soyad;
                ChangeState(2);
            }
        }

        #endregion
        int gunSinir;
        int adetSinir;
        private int KitapIadeEtVEYAAl(string kisiID,string urunID) {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();

                NpgsqlCommand controlCommand = new NpgsqlCommand("SELECT COUNT(*) FROM kisi_urun WHERE urun_id=" + urunID + " AND kisi_id =" + kisiID + " AND rezerve =" + "FALSE", connection);
                int count = (int)controlCommand.ExecuteScalar();
                NpgsqlCommand command;
                if (count > 0) {
                    command = new NpgsqlCommand("DELETE FROM kisi_urun WHERE urun_id=" + urunID + " AND kisi_id =" + kisiID, connection);
                    command.ExecuteNonQuery();

                    command = new NpgsqlCommand("SELECT CURRENT_DATE-(SELECT tarih FROM kisi_urun WHERE urun_id=" + urunID + " AND kisi_id =" + kisiID+" )",connection);
                    int gun = (int)command.ExecuteScalar();

                    command = new NpgsqlCommand("SELECT tip FROM kisi WHERE id = "+kisiID, connection);
                    int tip = (int)command.ExecuteScalar();
                    if(tip == 0) {
                        gunSinir = Ogrenci.oduncSuresi;
                        adetSinir = Ogrenci.kitapSiniri;
                    }else if(tip == 1) {
                        gunSinir = OgretimUyesi.oduncSuresi;
                        adetSinir = OgretimUyesi.kitapSiniri;
                    } else {
                        gunSinir = Memur.oduncSuresi;
                        adetSinir = Memur.kitapSiniri;
                    }

                    if (gun > gunSinir) {//CEZA
                        command = new NpgsqlCommand("UPDATE akillikart SET bakiye = bakiye "+(-gun).ToString(), connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürünü geç getirdiğiniz için "+gun.ToString()+" TL bakiyenizden düşülmüştür.");
                    }
                } else {
                    command = new NpgsqlCommand("INSERT INTO ", connection);



                    connection.Close();
                    throw new Exception("Bu kitap sizde yok");

                }
                connection.Close();
                MetroFramework.MetroMessageBox.Show(this,"Kitap iade edilmiştir");
                return 1;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }

        #region State 1



        private void button1KartOkut_Click(object sender, EventArgs e) {
            if (KartOkut(txt1KartOkut.Text) == 1) {
                
                ChangeState(3);
            }
        }


        #endregion

        #region State 2

        private void button2UrunOkut_Click(object sender, EventArgs e) {
            if (UrunOkut(txt2UrunOkut.Text) == 1) {
                ChangeState(3);
            }
        }

        #endregion


    }
}
