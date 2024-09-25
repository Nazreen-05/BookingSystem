using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class RoomController
    {
        #region Data Members
        HotelManagementDB roomDB; // Data access object to communicate with the database
        Collection<Room> rooms; // Collection to hold all guest objects
        #endregion

        #region Properties
        // Property to expose the collection of rooms
        public Collection<Room> AllRooms
        {
            get { return rooms; }
        }
        #endregion

        #region Constructor
        // default constructor?
        // Constructor to instantiate the roomDB object and initialize the room collection
        public RoomController()
        {
            roomDB = new HotelManagementDB(); // Instantiate the data access object
            rooms = roomDB.AllRooms; // Fetch all rooms from the database
        }
        #endregion

        #region Database Communication
        // Method to perform a data maintenance operation on the room collection
        public void DataMaintenance(Room aRoom, DB.DBOperation operation)
        {
            int index = 0;
            roomDB.DataSetChange(aRoom, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    rooms.Add(aRoom);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aRoom);
                    if (index != -1)
                    {
                        rooms[index] = aRoom;
                    }
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aRoom);
                    if (index != -1)
                    {
                        rooms.RemoveAt(index);
                    }
                    break;
            }
        }

        // Method to commit changes to the database
        public bool FinalizeChanges(Room room)
        {
            return roomDB.UpdateDataSource(room);
        }
        #endregion

        #region Search Methods
        // Find a room by roomNum
        public Room Find(string roomNumber)
        {
            int index = 0;
            bool found = (rooms.Count > 0 && rooms[index].RoomNumber == roomNumber);
            int count = rooms.Count;

            while (!(found) && (index < rooms.Count - 1))
            {
                index++;
                found = (rooms[index].RoomNumber == roomNumber);
            }
            return rooms[index];
        }

        // Find the index of a room in the collection
        public int FindIndex(Room aRoom)
        {
            int counter = 0;
            bool found = false;
            found = (aRoom.RoomNumber == rooms[counter].RoomNumber);
            while (!found && counter < rooms.Count)
            {
                counter++;
                found = (aRoom.RoomNumber == rooms[counter].RoomNumber);
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
