using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Presentation
{
    public partial class CreateAccount : Form
    {
        private DB db = new DB();
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
                if (txtCreateAccPhone.TextLength != 10)
                {
                    MessageBox.Show("Please enter a valid Phone Number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   //Creating unique IDs for a primary key in the guest table
                    string accNo = GenerateUniqueAccountNumber();

                    //Guest details
                    string guestName = txtCreateAccName.Text;
                    string guestSName = txtCreateAccSName.Text;
                    string guestEmail = txtCreateAccEmail.Text;
                    string guestPhoneNo = txtCreateAccPhone.Text;
                    string street = txtCreateAccStreet.Text;
                    string suburb = txtCreateAccSuburb.Text;
                    string city = txtCreateAccCity.Text;
                    string postal = txtCreateAccPostal.Text;
                    string guestAddress = street + ", " + suburb+ ", " + city + ", " + postal;

                    if (accNo != null)
                    {
                        // Add guest to the database using the DB class
                        bool isAdded = db.AddGuest(accNo, guestName, guestSName, guestEmail, guestPhoneNo, guestAddress);

                        if (isAdded)
                        {
                            MessageBox.Show($"Guest added successfully with Account Number: {accNo}","Succesfully Added",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCreateAccName.Clear();
                            txtCreateAccSName.Clear();
                            txtCreateAccEmail.Clear();
                            txtCreateAccPhone.Clear();
                            txtCreateAccStreet.Clear();
                            txtCreateAccSuburb.Clear();
                            txtCreateAccCity.Clear();
                            txtCreateAccPostal.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add guest.", "Error Occurred", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to generate a unique account number.","Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }
        #region Methods
        private string GenerateUniqueAccountNumber()
        {
            Random random = new Random();
            string accountNumber;
            bool isUnique = false;

            while (!isUnique)
            {
                // Generate a random 6-digit number
                accountNumber = random.Next(100000, 1000000).ToString();

                // Check if the account number is unique
                if (db.IsAccountNumberUnique(accountNumber))
                {
                    isUnique = true;
                    return accountNumber;
                }
            }

            return null; // This return statement will never be reached, it's just to satisfy the compiler
        }

        #endregion
    }
}
