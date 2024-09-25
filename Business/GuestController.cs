using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class GuestController
    {
        #region Data Members
        HotelManagementDB guestDB; // Data access object to communicate with the database
        Collection<Guest> guests; // Collection to hold all guest objects
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
            guestDB.DataSetChange(aGuest, operation);

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
         public bool FinalizeChanges(Guest guest)
         {
           return guestDB.UpdateDataSource(guest);
         }
        #endregion

        #region Search Methods
        // Find a guest by ID
        public Guest Find(string guestID)
        {
            int index = 0;
            bool found = (guests.Count > 0 && guests[index].GuestID == guestID);
            int count = guests.Count;

            while (!(found) && (index < guests.Count - 1))
            {
                index++;
                found = (guests[index].GuestID == guestID);
            }
            return guests[index];
        }

        // Find the index of a guest in the collection
        public int FindIndex(Guest aGuest)
        {
            int counter = 0;
            bool found = false;
            found = (aGuest.GuestID == guests[counter].GuestID);
            while (!found && counter < guests.Count)
            {
                counter++;
                found = (aGuest.GuestID == guests[counter].GuestID);
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
