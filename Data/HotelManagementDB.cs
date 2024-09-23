using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Data
{
    internal class HotelManagementDB: DB
    {
        private string table1 = "Booking";
        private string sqlLocal1 = "SELECT * FROM Booking";

        private string table2 = "Guests";
        private string sqlLocal2 = "SELECT * FROM Guests";

        private string table3 = "Payments";
        private string sqlLocal3 = "SELECT * FROM Payments";

        private string table4 = "Room Service";
        private string sqlLocal4 = "SELECT * FROM Room Service";

        private string table5 = "Rooms";
        private string sqlLocal5 = "SELECT * FROM Rooms"; //assume single room type

        private string table6 = "Seasons";
        private string sqlLocal6 = "SELECT * FROM Seasons"; // could be taken out?

        private string table7 = "Staff";
        private string sqlLocal7 = "SELECT * FROM Staff"; 

        private string table8 = "Userlogin";
        private string sqlLocal8 = "SELECT * FROM Userlogin";

        private Collection<Booking> bookings;
        private Collection<Guest> guests;
        


        public Collection<Guest> AllGuests
        {
            get { return guests; }
        }

        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }

        public HotelManagementDB()
        {
            bookings = new Collection<Booking>(); // Initialize the collection correctly
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);

            FillDataSet(sqlLocal2, table2);
            Add2Collection(table2);

            FillDataSet(sqlLocal3, table3);
            Add2Collection(table3);
        }


        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        #endregion
    }
}
