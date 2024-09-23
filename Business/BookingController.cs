using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    internal class BookingController
    {
        private HotelManagementDB hotelManagementDB; // Reference to HotelManagementDB
        private Collection<Booking> bookings;

        // Constructor
        public BookingController()
        {
            hotelManagementDB = new HotelManagementDB(); // Initialize correctly
            bookings = new Collection<Booking>();
        }

        #region Database Communication 

        public void DataMaintence(Booking anBK)
        {
            hotelManagementDB.
        }
    }
}
