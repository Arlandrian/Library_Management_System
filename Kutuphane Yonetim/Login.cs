using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using System.Collections;

namespace Kutuphane_Yonetim {
    public partial class Login : MaterialForm {
        MaterialSkin.ColorScheme colorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Amber600, MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Blue700, MaterialSkin.Accent.Cyan400, MaterialSkin.TextShade.WHITE);
        MaterialSkin.MaterialSkinManager skinManager;

        private string adminUserName = "admin";
        private string adminPassword = "admin";


        public Insan aktifKullanici;

        public Login() {
            InitializeComponent();
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Roboto", 19f,FontStyle.Bold);
#if !DEBUG
            textboxUsername.Text = adminUserName;
            textboxPassword.Text = adminPassword;
#endif      
            getSinirsFromDB();
            RememberMe();
            SetColor();
            //SetBackgroundPicture(210,0);
            //pictureBoxBG.Visible = false;
        }


        void RememberMe() {
            if (Properties.Settings.Default.rememberMe) {
                textboxUsername.Text = Properties.Settings.Default.username;
                textboxPassword.Text = Properties.Settings.Default.password;
                checkboxRemeberMe.Checked = true;
            }
        }
        bool IsNumeric(string str) {
            for (int i = 0; i < str.Length; i++) {
                if (!(str[i] >= '0' && str[i] <= '9')) {
                    return false;
                }
            }
            return true;
        }
        private void loginButton_Click_1(object sender, EventArgs e) {


            if(string.IsNullOrEmpty(textboxPassword.Text) || string.IsNullOrEmpty(textboxUsername.Text)) {
                return;
            } else if(textboxPassword.Text == adminPassword && textboxUsername.Text == adminUserName){
                AdminPage adminPage = new AdminPage(this);
                adminPage.Show();
                this.Hide();
                CheckRememberMeState();
                return;
            } else if (textboxPassword.Text == "0") {
                TestForm testForm = new TestForm();
                this.Hide();
                testForm.Show();
                CheckRememberMeState();
                return;
            }

            try {

                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                NpgsqlCommand command;
                if (IsNumeric(textboxUsername.Text)) {//ak_id
                    command = new NpgsqlCommand("SELECT * FROM kisi WHERE ak_id = " + textboxUsername.Text, connection);
                } else {//eposta
                    command = new NpgsqlCommand("SELECT * FROM kisi WHERE eposta = '" + textboxUsername.Text + "'", connection);
                }

                NpgsqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader[0] != null) {
                    string password = reader[5].ToString();

                    if (password == textboxPassword.Text) {
                        string id = reader[0].ToString();
                        string ad = reader[1].ToString();
                        string soyad = reader[2].ToString();
                        AkilliKart kart = new AkilliKart(0, reader[3].ToString());
                        string eposta = reader[4].ToString();
                        aktifKullanici = new Insan(id, ad, soyad, kart, eposta, password);
                        MessageBox.Show("Basarili bir sekilde giris yapildi");
                        CheckRememberMeState();
                        UserPage userPage = new UserPage(this);
                        Hide();
                        userPage.Show();
                    }else{
                        MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz");

                    }

                } else {
                    MessageBox.Show("Veri gelmedi");
                }
                reader.Close();
                connection.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
                
            }
        }

        private void getSinirsFromDB() {

            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM sinir", connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                reader.Read();

                Ogrenci.kitapSiniri = int.Parse(reader[0].ToString());
                OgretimUyesi.kitapSiniri = int.Parse(reader[1].ToString());
                Memur.kitapSiniri = int.Parse(reader[2].ToString());

                Ogrenci.oduncSuresi = int.Parse(reader[3].ToString());
                OgretimUyesi.oduncSuresi = int.Parse(reader[4].ToString());
                Memur.oduncSuresi = int.Parse(reader[5].ToString());
                reader.Close();
                connection.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #region layoutInit
        private void SetBackgroundPicture(int opacity, int x) {
            Bitmap pic = new Bitmap(Kutuphane_Yonetim.Properties.Resources.images2);
            for (int w = 0; w < pic.Width; w++) {
                for (int h = 0; h < pic.Height; h++) {
                    Color c = pic.GetPixel(w, h);
                    Color newC = Color.FromArgb(opacity, c.R + x < 0 ? 0 : c.R + x, c.G + x < 0 ? 0 : c.G + x, c.B + x < 0 ? 0 : c.B + x);
                    pic.SetPixel(w, h, newC);
                }
            }
            pictureBoxBG.Image = pic;
        }
        public void SetColor() {

            skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.ColorScheme = colorScheme;
        }

        #endregion

        #region takeEnter
        private void Login_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                loginButton.PerformClick();
            }
        }

        private void textboxPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                loginButton.PerformClick();
            }
        }
        #endregion

        private void registerButton_Click(object sender, EventArgs e) {
            Register registerForm = new Register(this);
            this.Hide();
            registerForm.Show();
            
        }

        private void checkboxRemeberMe_CheckedChanged(object sender, EventArgs e) {
            CheckRememberMeState();
        }

        private void CheckRememberMeState() {
            if (checkboxRemeberMe.CheckState == CheckState.Checked) {
                Properties.Settings.Default.rememberMe = true;
                Properties.Settings.Default.username = textboxUsername.Text;
                Properties.Settings.Default.password = textboxPassword.Text;
            } else {
                Properties.Settings.Default.rememberMe = false;
                Properties.Settings.Default.username = string.Empty;
                Properties.Settings.Default.password = string.Empty;
            }
            Properties.Settings.Default.Save();
        }
    }
}
