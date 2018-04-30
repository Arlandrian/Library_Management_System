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

namespace Kutuphane_Yonetim
{
    public partial class UserPage : MaterialForm
    {

        Login loginForm;
        public UserPage(Login loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {

        }

        private void UserPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        private void categoroiesLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserPage_Load_1(object sender, EventArgs e)
        {

        }
    }
}
