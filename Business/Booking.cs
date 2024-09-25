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
        private string guestId;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private string roomType;
        private string bookingStatus;
        private string season;
        private DateTime bookingDate;
        private decimal totalCost;
        private decimal depositPaid;
        #endregion

        #region Property Methods
        public string BookingID
        {
            get { return bookingId; }
            set { bookingId = value; }
        }

        public string GuestID
        {
            get { return guestId; }
            set { guestId = value; }
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

        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
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

        public decimal DepositPaid
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
        public Booking(string bookingId, string guestId, DateTime bookingDate, DateTime checkInDate, DateTime checkOutDate, string roomType, decimal totalCost, decimal depositPaid, string bookingStatus, string season)
        {
            this.bookingId = bookingId;
            this.guestId = guestId;
            this.bookingDate = bookingDate;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.roomType = roomType;
            this.totalCost = totalCost;
            this.depositPaid = depositPaid;
            this.bookingStatus = bookingStatus;
            this.season = season;
        }
        #endregion
    }
}
