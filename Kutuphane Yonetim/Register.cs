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

namespace Kutuphane_Yonetim {
    public partial class Register : MaterialForm {
        Login loginForm;
        MaterialSkin.MaterialSkinManager skinManager;
        MaterialSkin.ColorScheme colorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Teal400, MaterialSkin.Primary.Blue700, MaterialSkin.Accent.Cyan400, MaterialSkin.TextShade.WHITE);
        
        public Register(Login login) {
            InitializeComponent();
            loginForm = login;

            SetColor();
        }
        private void SetColor() {

            skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.ColorScheme = colorScheme;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            loginForm.SetColor();
            loginForm.Show();
            this.Close();

        }


        private void registerButton_Click(object sender, EventArgs e) {
            if (!checkBoxes()) {
                MessageBox.Show("Lütfen tüm boslukları doldurun.");
            } else {
                MakeRegister();
            }
        }

        private bool checkBoxes() {
            if( string.IsNullOrEmpty(textboxEmail.Text) ||
                string.IsNullOrEmpty(textboxPassword.Text) ||
                string.IsNullOrEmpty(textboxName.Text) ||
                string.IsNullOrEmpty(textboxLastname.Text))
            {
                return false;
            } else {
                return true;
            }
        }

        private Insan MakeRegister() {
            try {
                string connString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
                NpgsqlConnection connection = new NpgsqlConnection(connString);
                connection.Open();

                NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO akillikart(bakiye) VALUES(0)", connection);
                command1.ExecuteNonQuery();

                NpgsqlCommand command2 = new NpgsqlCommand("SELECT MAX(id) FROM akillikart", connection);
                NpgsqlDataReader reader =command2.ExecuteReader();
                reader.Read();
                int kartID = int.Parse(reader[0].ToString());
                reader.Close();

                NpgsqlCommand command3 = new NpgsqlCommand("INSERT INTO kisi (eposta,pass,ad,soyad,ak_id) VALUES( '" + (textboxEmail.Text) + "','" + (textboxPassword.Text) + "','" + (textboxName.Text) + "','" + (textboxLastname.Text)+"',"+kartID.ToString()+");",connection);
                command3.ExecuteNonQuery();

                NpgsqlCommand command4 = new NpgsqlCommand("SELECT MAX(id) FROM kisi", connection);
                reader = command4.ExecuteReader();
                reader.Read();
                int id = int.Parse(reader[0].ToString());
                reader.Close();

                Insan notRobot = new Insan(id.ToString(), textboxName.Text, textboxLastname.Text, new AkilliKart(0, kartID.ToString()), textboxEmail.Text,textboxPassword.Text);
                connection.Close();
                MessageBox.Show("Basarılı bir sekilde kayıt oldunuz.");
                return notRobot;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }

    }
}
