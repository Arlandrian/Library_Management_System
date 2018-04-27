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
    public partial class Login : MaterialForm {
        MaterialSkin.ColorScheme colorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Amber600, MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Blue700, MaterialSkin.Accent.Cyan400, MaterialSkin.TextShade.WHITE);
        MaterialSkin.MaterialSkinManager skinManager;

        Insan currentInsan;

        public Login() {
            InitializeComponent();
            labelTitle.AutoSize = false;
            labelTitle.Font = new System.Drawing.Font("Roboto", 18f,FontStyle.Bold);

            SetColor();
            //SetBackgroundPicture(210,0);
            //pictureBoxBG.Visible = false;
        }

        private void loginButton_Click_1(object sender, EventArgs e) {
            textboxUsername.Text += "k";
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
    }
}
