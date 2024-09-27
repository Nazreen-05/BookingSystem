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
            MovePanel(btnBooking);
        }

        private void btnBookingList_Click(object sender, EventArgs e)
        {
            MovePanel(btnBookingList);
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            MovePanel (btnGuest);
        }

        private void btnGuestList_Click(object sender, EventArgs e)
        {
            MovePanel(btnGuestList);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            MovePanel(btnAnalytics);
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
