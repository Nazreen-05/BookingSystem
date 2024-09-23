using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Payment
    {
        #region Data Members
        private string paymentID;
        private decimal amount;
        private DateTime paymentDate;
        private string paymentMethod;
        private string bookingID;

        #endregion


        #region Property Methods
        
        public string PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }

        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }

        public string BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        #endregion

        #region Constructor
        public Payment(string paymentId, decimal amount, DateTime paymentDate, string paymentMethod, string bookingId)
        {
            this.paymentID = paymentId;
            this.amount = amount;
            this.paymentDate = paymentDate;
            this.paymentMethod = paymentMethod;
            this.bookingID = bookingId;
        }
        #endregion

        #region Methods
        public void DisplayPaymentDetails()
        {
            Console.WriteLine($"Payment ID: {PaymentID}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Payment Date: {PaymentDate.ToShortDateString()}");
            Console.WriteLine($"Payment Method: {PaymentMethod}");
            Console.WriteLine($"Booking ID: {BookingID}");
        }
        #endregion






    }
}
