using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Booking
    {
        #region Data Members
        private string bookingId;
        private string guestAccNo;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private string bookingStatus;
        private string season;
        private DateTime bookingDate;
        private decimal totalCost;
        private string depositPaid;
        #endregion

        #region Property Methods
        public string BookingID
        {
            get { return bookingId; }
            set { bookingId = value; }
        }

        public string GuestAccNo
        {
            get { return guestAccNo; }
            set { guestAccNo = value; }
        }

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }


        public string BookingStatus
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }

        // Property method for the new fields
        public string Season
        {
            get { return season; }
            set { season = value; }
        }

        public DateTime BookingDate
        {
            get { return bookingDate; }
            set { bookingDate = value; }
        }

        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public string DepositPaid
        {
            get { return depositPaid; }
            set { depositPaid = value; }
        }
        #endregion

        #region Constructor
        public Booking()
        {
            //default constructor
        }
        // Constructor including the new fields
        public Booking(string bookingId, string guestAccNo, DateTime bookingDate, DateTime checkInDate, DateTime checkOutDate, decimal totalCost, string depositPaid, string bookingStatus, string season)
        {
            this.bookingId = bookingId;
            this.guestAccNo = guestAccNo;
            this.bookingDate = bookingDate;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.totalCost = totalCost;
            this.depositPaid = depositPaid;
            this.bookingStatus = bookingStatus;
            this.season = season;
        }
        #endregion
    }
}
