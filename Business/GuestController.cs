using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    internal class GuestController
    {
        /*
        #region Data Members
        private HotelManagementDB guestDB; // Data access object to communicate with the database
        private Collection<Guest> guests; // Collection to hold all guest objects
        #endregion

        #region Properties
        // Property to expose the collection of guests
        public Collection<Guest> AllGuests
        {
            get { return guests; }
        }
        #endregion

        #region Constructor
        // Constructor to instantiate the GuestDB object and initialize the guest collection
        public GuestController()
        {
            guestDB= new HotelManagementDB(); // Instantiate the data access object
            guests = guestDB.AllGuests; // Fetch all guests from the database
        }
        #endregion

        #region Database Communication
        // Method to perform a data maintenance operation on the guests collection
        public void DataMaintenance(Guest aGuest, DB.DBOperation operation)
        {
            int index = 0;
            //hotelManagementDB.DataSetChange(aGuest, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    guests.Add(aGuest);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aGuest);
                    if (index != -1)
                    {
                        guests[index] = aGuest;
                    }
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aGuest);
                    if (index != -1)
                    {
                        guests.RemoveAt(index);
                    }
                    break;
            }
        }

        // Method to commit changes to the database
         public bool FinalizeChanges()
        {
           return hotelManagementD.UpdateDataSource();
        }
        #endregion

        #region Search Methods
        // Find a guest by ID
        public Guest Find(string guestID)
        {
            int index = 0;
            bool found = (guests.Count > 0 && guests[index].GuestID == guestID);
            while (!found && (index < guests.Count - 1))
            {
                index++;
                found = (guests[index].GuestID == guestID);
            }
            return found ? guests[index] : null;
        }

        // Find the index of a guest in the collection
        public int FindIndex(Guest aGuest)
        {
            int counter = 0;
            bool found = (aGuest.GuestID == guests[counter].GuestID);

            while (!found && counter < guests.Count - 1)
            {
                counter++;
                found = (aGuest.GuestID == guests[counter].GuestID);
            }

            return found ? counter : -1;
        }
        #endregion
        */
    }
}
