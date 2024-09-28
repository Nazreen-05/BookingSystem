using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Presentation
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }


        private void MovePanel(Control btn)
        {
            panelControl.Left = btn.Left;
            panelControl.Width = btn.Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            MovePanel(btnAddBooking);
            this.Hide();
            var form = new BookingForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnBookingList_Click(object sender, EventArgs e)
        {
            MovePanel(btnBookingList);
            this.Hide();
            var form = new BookingListingForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            MovePanel (btnAddGuest);
            this.Hide();
            var form = new CreateAccount();
            form.ShowDialog();
            this.Show();
        }

        private void btnGuestList_Click(object sender, EventArgs e)
        {
            MovePanel(btnGuestList);
            this.Hide();
            var form = new Accounts();
            form.ShowDialog();
            this.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            MovePanel(btnAnalytics);
            this.Hide();
            var form = new Analytics();
            form.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
