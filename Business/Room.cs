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
        private string roomId; //room Number should be removed, either make room id or room number . both is unique
        private string is_available;
        private decimal price_per_night;
        #endregion

        #region Property Methods
        public string RoomID
        {
            get { return roomId; }
            set {roomId = value; }
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
        public Room(string roomId, string is_available, decimal price_per_night)
        {
            this.roomId = roomId;
            this.is_available = is_available;
            this.price_per_night= price_per_night;
        }
        #endregion
    }
}
