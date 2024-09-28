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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new HomePage();
            form.ShowDialog();
            this.Show();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Error Handling - to see if data has been enetered in all fields
            if (txtCreateAccName.Text == "" || txtCreateAccSName.Text == "" || txtCreateAccEmail.Text == "" || txtCreateAccPhone.Text == "" || txtCreateAccStreet.Text == "" || txtCreateAccSuburb.Text == "" || txtCreateAccCity.Text == "" || txtCreateAccPostal.Text == "")
            {
                MessageBox.Show("Please enter in all required fields", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Error Handling - making sure the phone number is a valid number
                if (txtCreateAccPhone.TextLength != 9)
                {
                    MessageBox.Show("Please enter a valid Phone Number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   //Creating unique IDs for a primary key in the guest table
                    Random random = new Random();
                    int ran = random.Next(100000, 1000000);
                    string accNo = ran.ToString();
                }
            }
        }
    }
}
