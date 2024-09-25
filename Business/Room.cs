using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Room
    {
        #region Data Members
        private string roomNumber;
        private string is_available;
        private decimal price_per_night;
        #endregion

        #region Property Methods
        public string RoomNumber
        {
            get { return roomNumber; }
            set {roomNumber = value; }
        }

        public string Avail
        {
            get { return is_available; }
            set { is_available = value; }
        }

        public decimal PricePerNight
        {
            get { return price_per_night; }
            set { price_per_night = value; }
        }

        #endregion

        #region Constructor
        public Room()
        {
            //default constructor
        }
        public Room(string roomNumber, string is_available, decimal price_per_night)
        {
            this.roomNumber = roomNumber;
            this.is_available = is_available;
            this.price_per_night= price_per_night;
        }
        #endregion
    }
}
