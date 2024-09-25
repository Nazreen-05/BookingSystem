using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class BookingController
    {      
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
        public bool FinalizeChanges(Booking booking)
        {
            return bookingDB.UpdateDataSource(booking);
        }
        #endregion

        #region Search Methods
        // Find a booking by ID
        public Booking Find(string bookingID)
        {
            int index = 0;
            bool found = (bookings.Count > 0 && bookings[index].BookingID == bookingID);
            int count = bookings.Count;

            while (!(found) && (index < bookings.Count - 1))
            {
                index++;
                found = (bookings[index].BookingID == bookingID);
            }
            if (index >= bookings.Count)
                return null;

            return bookings[index];
        }

        // Find the index of a booking in the collection
        public int FindIndex(Booking aBooking)
        {
            int counter = 0;
            bool found = false;
            found = (aBooking.BookingID == bookings[counter].BookingID);
            while (!found && counter < bookings.Count)
            {
                counter++;
                found = (aBooking.BookingID == bookings[counter].BookingID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion

    }
}
