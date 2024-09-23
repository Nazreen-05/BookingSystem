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
        private string paymentId;
        private string guestId;
        private string bookingId;
        private decimal paymentAmount;
        private DateTime paymentDate;
        private string paymentMethod;
        #endregion

        #region Property Methods
        public string PaymentID
        {
            get { return paymentId; }
            set { paymentId = value; }
        }

        public string GuestID
        {
            get { return guestId; }
            set { guestId = value; }
        }

        public string BookingID
        {
            get { return bookingId; }
            set { bookingId = value; }
        }

        public decimal PaymentAmount
        {
            get { return paymentAmount; }
            set { paymentAmount = value; }
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
        #endregion

        #region Constructor
        public Payment(string paymentId, string guestId, string bookingId, decimal paymentAmount, DateTime paymentDate, string paymentMethod)
        {
            this.paymentId = paymentId;
            this.guestId = guestId;
            this.bookingId = bookingId;
            this.paymentAmount = paymentAmount;
            this.paymentDate = paymentDate;
            this.paymentMethod = paymentMethod;
        }
        #endregion









    }
}
