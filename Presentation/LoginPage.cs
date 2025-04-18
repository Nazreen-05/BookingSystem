﻿using BookingSystem.Business;
using BookingSystem.Data;
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

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            txtPassword.UseSystemPasswordChar = true;
            pbVisible.Show();

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
            //Error handling - to see if data has been inserted
            if(txtUsername.Text == "" ||  txtPassword.Text == "")
            {
                MessageBox.Show("Please enter in all required fields", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Error handling - to see if the username and password is correct
                if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
                {
                    this.Hide();
                    var form = new HomePage();
                    form.ShowDialog();
                    this.Show();
                    
                }
                else
                {
                   //Error message if inseretd login is wrong
                    MessageBox.Show("Incorrect Username or Password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbVisible_Click(object sender, EventArgs e)
        {
            pbVisible.Hide();
            txtPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
