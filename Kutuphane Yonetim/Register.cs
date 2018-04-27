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

        }

        private void MakeRegister() {
            try {
                string connString = 
            }catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
