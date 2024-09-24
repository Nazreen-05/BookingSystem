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
        /*
        #region Data Members
        private HotelManagementDB bookingDB; // Data access object to communicate with HotelManagementDB
        private Collection<Booking> bookings; // Collection to hold all booking objects
        #endregion

        #region Properties
        // Property to expose the collection of bookings
        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }
        #endregion

        #region Constructor
   
        public BookingController()
        {
            bookingDB = new HotelManagementDB(); 
            bookings =bookingDB.AllBookings;
        }
        #endregion

        #region Database Communication
        // Method to perform a data maintenance operation on the bookings collection
        public void DataMaintenance(Booking aBooking, DB.DBOperation operation)
        {
            int index = 0;
            bookingDB.DataSetChange(aBooking, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    bookings.Add(aBooking);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aBooking);
                    if (index != -1)
                    {
                        bookings[index] = aBooking;
                    }
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aBooking);
                    if (index != -1)
                    {
                        bookings.RemoveAt(index);
                    }
                    break;
            }
        }

        // Method to commit changes to the database
        public bool FinalizeChanges()
        {
            return bookingDB.UpdateDataSource();
        }
        #endregion

        #region Search Methods
        // Find a booking by ID
        public Booking Find(string bookingID)
        {
            int index = 0;
            bool found = (bookings.Count > 0 && bookings[index].BookingID == bookingID);
            while (!found && (index < bookings.Count - 1))
            {
                index++;
                found = (bookings[index].BookingID == bookingID);
            }
            return found ? bookings[index] : null;
        }

        // Find the index of a booking in the collection
        public int FindIndex(Booking aBooking)
        {
            int counter = 0;
            bool found = (aBooking.BookingID == bookings[counter].BookingID);

            while (!found && counter < bookings.Count - 1)
            {
                counter++;
                found = (aBooking.BookingID == bookings[counter].BookingID);
            }

            return found ? counter : -1;
        }
        #endregion
        */
    }
}
