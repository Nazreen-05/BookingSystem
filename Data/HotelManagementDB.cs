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
    internal class HotelManagementDB : DB
    {
        #region Data Members
        private string table1 = "Booking";
        private string sqlLocal1 = "SELECT * FROM Booking";

        private string table2 = "Guests";
        private string sqlLocal2 = "SELECT * FROM Guests";

        private string table3 = "Payments";
        private string sqlLocal3 = "SELECT * FROM Payments";

        private string table4 = "RoomService";
        private string sqlLocal4 = "SELECT * FROM RoomService";

        private string table5 = "Rooms";
        private string sqlLocal5 = "SELECT * FROM Rooms"; // Assume single room type

        private string table6 = "Seasons";
        private string sqlLocal6 = "SELECT * FROM Seasons"; // Could be taken out if not used

        private string table7 = "Staff";
        private string sqlLocal7 = "SELECT * FROM Staff";

        private string table8 = "UserLogin";
        private string sqlLocal8 = "SELECT * FROM UserLogin";

        private Collection<Booking> bookings;
        private Collection<Guest> guests;
        private Collection<Payment> payments;
        //private Collection<RoomService> roomServices;
        //private Collection<Room> rooms;
        //private Collection<Season> seasons;
        //private Collection<Staff> staff;
        //private Collection<UserLogin> userLogins;
        #endregion

        #region Properties
        public Collection<Booking> AllBookings { get { return bookings; } }
        public Collection<Guest> AllGuests { get { return guests; } }
        public Collection<Payment> AllPayments { get { return payments; } }
        // public Collection<RoomService> AllRoomServices { get { return roomServices; } }
        // public Collection<Room> AllRooms { get { return rooms; } }
        //public Collection<Season> AllSeasons { get { return seasons; } }
        //public Collection<Staff> AllStaff { get { return staff; } }
        // public Collection<UserLogin> AllUserLogins { get { return userLogins; } }
        #endregion

        #region Constructor
        public HotelManagementDB()
        {
            bookings = new Collection<Booking>();
            guests = new Collection<Guest>();
            payments = new Collection<Payment>();
            //roomServices = new Collection<RoomService>();
            //rooms = new Collection<Room>();
            //seasons = new Collection<Season>();
            //staff = new Collection<Staff>();
            //userLogins = new Collection<UserLogin>();

            // Fill data sets and add to collections
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);

            FillDataSet(sqlLocal2, table2);
            Add2Collection(table2);

            FillDataSet(sqlLocal3, table3);
            Add2Collection(table3);

            FillDataSet(sqlLocal4, table4);
            Add2Collection(table4);

            FillDataSet(sqlLocal5, table5);
            Add2Collection(table5);

            FillDataSet(sqlLocal6, table6);
            Add2Collection(table6);

            FillDataSet(sqlLocal7, table7);
            Add2Collection(table7);

            FillDataSet(sqlLocal8, table8);
            Add2Collection(table8);
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            switch (table)
            {
                case "Booking":
                    foreach (DataRow row in dsMain.Tables[table].Rows)
                    {
                        if (!(row.RowState == DataRowState.Deleted))
                        {
                            Booking booking = new Booking();
                            booking.BookingID = row["booking_id"].ToString().Trim();
                            booking.GuestID = row["guest_id"].ToString().Trim();
                            booking.CheckInDate = Convert.ToDateTime(row["check_in_date"]);
                            booking.CheckOutDate = Convert.ToDateTime(row["check_out_date"]);
                            booking.RoomType = row["room_type"].ToString().Trim();
                            booking.TotalCost = Convert.ToDecimal(row["total_cost"]);
                            booking.DepositPaid = Convert.ToDecimal(row["deposit_paid"]);
                            booking.BookingStatus = row["booking_status"].ToString().Trim();
                            booking.Season = row["season"].ToString().Trim();
                            bookings.Add(booking);
                        }
                    }
                    break;

                case "Guests":
                    foreach (DataRow row in dsMain.Tables[table].Rows)
                    {
                        if (!(row.RowState == DataRowState.Deleted))
                        {
                            Guest guest = new Guest();
                            guest.GuestID = row["guest_id"].ToString().Trim();
                            guest.Name = row["name"].ToString().Trim();
                            guest.Address = row["address"].ToString().Trim();
                            guest.PhoneNumber = row["phone_number"].ToString().Trim();
                            guest.Email = row["email"].ToString().Trim();
                            guest.CreditCardNumber = row["credit_card_number"].ToString().Trim();
                            guest.LoyaltyCardNumber = row["loyalty_card_number"].ToString().Trim();
                            guests.Add(guest);
                        }
                    }
                    break;

                case "Payments":
                    foreach (DataRow row in dsMain.Tables[table].Rows)
                    {
                        if (!(row.RowState == DataRowState.Deleted))
                        {
                            Payment payment = new Payment();
                            payment.PaymentID = row["payment_id"].ToString().Trim();
                            payment.GuestID = row["guest_id"].ToString().Trim();
                            payment.BookingID = row["booking_id"].ToString().Trim();
                            payment.PaymentAmount = Convert.ToDecimal(row["payment_amount"]);
                            payment.PaymentDate = Convert.ToDateTime(row["payment_date"]);
                            payment.PaymentMethod = row["payment_method"].ToString().Trim();
                            payments.Add(payment);
                        }
                    }
                    break;

                    // You would repeat similar logic for "RoomService", "Rooms", "Seasons", "Staff", and "UserLogin"
                    // Ensure to create the correct objects and set the fields from your dataset
            }
        }
        #endregion

        private int FindRow(object obj, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                myRow = row;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    string id = string.Empty;

                    // Determine the ID to search based on the object type
                    if (obj is Guest guest)
                        id = guest.GuestID;
                    else if (obj is Booking booking)
                        id = booking.BookingID;
                    else if (obj is Payment payment)
                        id = payment.PaymentID;
                    // Add other cases for RoomService, Room, etc.

                    if (id == myRow["ID"].ToString())
                    {
                        returnValue = rowIndex;
                        break;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }

        private void FillRow(DataRow aRow, object obj, DB.DBOperation operation)
        {
            if (obj is Guest guest)
            {
                aRow["guest_id"] = guest.GuestID;
                aRow["name"] = guest.Name;
                aRow["address"] = guest.Address;
                aRow["phone_number"] = guest.PhoneNumber;
                aRow["email"] = guest.Email;
                aRow["credit_card_number"] = guest.CreditCardNumber;
                aRow["loyalty_card_number"] = guest.LoyaltyCardNumber;
            }
            else if (obj is Booking booking)
            {
                aRow["booking_id"] = booking.BookingID;
                aRow["guest_id"] = booking.GuestID;
                aRow["check_in_date"] = booking.CheckInDate;
                aRow["check_out_date"] = booking.CheckOutDate;
                aRow["room_type"] = booking.RoomType;
                aRow["total_cost"] = booking.TotalCost;
                aRow["deposit_paid"] = booking.DepositPaid;
                aRow["booking_status"] = booking.BookingStatus;
                aRow["season"] = booking.Season;
            }
            else if (obj is Payment payment)
            {
                aRow["payment_id"] = payment.PaymentID;
                aRow["guest_id"] = payment.GuestID;
                aRow["booking_id"] = payment.BookingID;
                aRow["payment_amount"] = payment.PaymentAmount;
                aRow["payment_date"] = payment.PaymentDate;
                aRow["payment_method"] = payment.PaymentMethod;
            }


        }

        public void DataSetChange(object obj, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = string.Empty;

            // Determine the table name based on the object type
            if (obj is Guest) dataTable = table2;
            else if (obj is Booking) dataTable = table1;
            else if (obj is Payment) dataTable = table3;
            // Handle other cases for RoomService, Room, etc.

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, obj, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;

                case DB.DBOperation.Edit:
                    int rowIndex = FindRow(obj, dataTable);
                    if (rowIndex != -1)
                    {
                        aRow = dsMain.Tables[dataTable].Rows[rowIndex];
                        FillRow(aRow, obj, operation);
                    }
                    else
                    {
                        throw new Exception($"{dataTable} record not found");
                    }
                    break;

                case DB.DBOperation.Delete:
                    rowIndex = FindRow(obj, dataTable);
                    if (rowIndex != -1)
                    {
                        aRow = dsMain.Tables[dataTable].Rows[rowIndex];
                        aRow.Delete();
                    }
                    else
                    {
                        throw new Exception($"{dataTable} record not found");
                    }
                    break;
            }
        }

        public bool UpdateDataSource()
        {
            bool success = true;

            // Update each table
            success &= UpdateDataSource(sqlLocal1, table1);
            success &= UpdateDataSource(sqlLocal2, table2);
            success &= UpdateDataSource(sqlLocal3, table3);
            // Add other tables...

            return success;
        }
    }



}
