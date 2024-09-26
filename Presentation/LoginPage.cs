using BookingSystem.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMin_MouseHover(object sender, EventArgs e)
        {

        }

        private void pBclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            txtPassword.UseSystemPasswordChar = true;
            pictureBoxHide.Show();

        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            txtPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Minimize");
        }

        private void pBclose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pBclose, "Close");
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnLogin, "Log in");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new HotelMangementMDI();
            form.ShowDialog();
            this.Show();


        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
