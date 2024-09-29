using BookingSystem.Business;
using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Presentation
{
    public partial class BookingForm : Form
    {
        private HotelManagementDB DB;
        private BookingController bookingController;
        private Collection<Booking> bookings;
       // private FormStates state;
        public BookingForm(BookingController aController)
        {
            InitializeComponent();
            //  DB = db;
            bookingController = aController;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
            setUpBookingListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Booking newBooking = new Booking
                {
                    BookingID = txtBookingID.Text, // Or however you generate IDs
                    GuestAccNo = txtGuestAcc.Text.Trim(),
                    BookingDate = dpkBookingDate.Value,
                    CheckInDate = dpkCheckInDate.Value,
                    CheckOutDate = dpkCheckOutDate.Value,
                    TotalCost = decimal.Parse(txtTotalCost.Text),
                    DepositPaid = cmbDepositPaid.SelectedItem.ToString(),
                    BookingStatus = cmbBookingStatus.SelectedItem.ToString(),
                    Season = cmbSeason.SelectedItem.ToString()
                };
                //   HotelManagementDB.UpdateDataSource(newBooking);
                bookings.Add(newBooking);
                setUpBookingListView();
                MessageBox.Show("Booking added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when adding booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        
        }
        public void setUpBookingListView()
        {
           // bookings = null;
            if (bookings ==null)
            {
                bookings = new Collection<Booking>();
            }
            bookingListView.Clear();

            bookingListView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(1, "GuestAccNo", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(2, "Booking date", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(3, "Check In Date", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(4, "Check Out Date", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(5, "Total Cost", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(6, "Deposit Paid", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(7, "Booking Status", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(8, "Season", 120, HorizontalAlignment.Left);

            foreach (Booking booking in bookings)
            {
               ListViewItem bookingDetails = new ListViewItem();
                bookingDetails.Text = booking.BookingID.ToString();
                bookingDetails.SubItems.Add(booking.GuestAccNo.ToString());
                bookingDetails.SubItems.Add(booking.BookingDate.ToString());
                bookingDetails.SubItems.Add(booking.CheckInDate.ToString());
                bookingDetails.SubItems.Add(booking.CheckOutDate.ToString());
                bookingDetails.SubItems.Add(booking.TotalCost.ToString("C"));
                bookingDetails.SubItems.Add(booking.DepositPaid.ToString());
                bookingDetails.SubItems.Add(booking.BookingStatus.ToString());
                bookingDetails.SubItems.Add(booking.Season.ToString());

                bookingListView.Items.Add(bookingDetails);
            }
            bookingListView.Refresh();
            bookingListView.GridLines = true;

        }
            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BookingForm_Activated(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
            setUpBookingListView();
           
        }
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }

    }
}
