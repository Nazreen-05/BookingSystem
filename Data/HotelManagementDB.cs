using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Data
{
    public class HotelManagementDB : DB
    {

        #region Data Members
        private string table1 = "Booking";
        private string sqlLocal1 = "SELECT * FROM Booking";

        private string table2 = "Guests";
        private string sqlLocal2 = "SELECT * FROM Guests";

        private string table3 = "Payments";
        private string sqlLocal3 = "SELECT * FROM Payments";

        private string table4 = "Rooms";
        private string sqlLocal4 = "SELECT * FROM Rooms";

        private string table5 = "Staff";
        private string sqlLocal5 = "SELECT * FROM Staff";

        private string table6 = "UserLogin";
        private string sqlLocal6 = "SELECT * FROM UserLogin";

        private Collection<Booking> bookings;
        private Collection<Guest> guests;
        private Collection<Payment> payments;
        private Collection<Room> rooms;
        //private Collection<Staff> staff;
        //private Collection<UserLogin> userLogins;
        #endregion

        #region Properties : collection
        public Collection<Booking> AllBookings { get { return bookings; } }
        public Collection<Guest> AllGuests { get { return guests; } }
        public Collection<Payment> AllPayments { get { return payments; } }
        public Collection<Room> AllRooms { get { return rooms; } }
        //public Collection<Staff> AllStaff { get { return staff; } }
        // public Collection<UserLogin> AllUserLogins { get { return userLogins; } }
        #endregion

        #region Constructor
        public HotelManagementDB() : base()
        {
            bookings = new Collection<Booking>();
            guests = new Collection<Guest>();
            payments = new Collection<Payment>();
            rooms = new Collection<Room>();
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
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string table)
        // populates collections with data from your database. Gets data from db, goes through row of each table , creates an objects and adds it to the collection
        // populates properties in each tabel iterating through rows
        // so that you are able to display , (operations include: search , edit and display)
        {
            DataSet ds = GetDataSet();
            switch (table)
            {
                case "Booking":
                    foreach (DataRow row in ds.Tables[table].Rows)
                    {
                        if (!(row.RowState == DataRowState.Deleted))
                        {
                            Booking aBooking = new Booking();
                            aBooking.BookingID = row["booking_id"].ToString().Trim();
                            aBooking.GuestAccNo = row["guestAccNo"].ToString().Trim();
                            aBooking.CheckInDate = Convert.ToDateTime(row["check_in_date"]);
                            aBooking.CheckOutDate = Convert.ToDateTime(row["check_out_date"]);
                            aBooking.TotalCost = Convert.ToDecimal(row["total_cost"]);
                            aBooking.DepositPaid = row["deposit_Paid"].ToString().Trim();
                            aBooking.BookingStatus = row["booking_status"].ToString().Trim();
                            aBooking.Season = row["season"].ToString().Trim();
                            bookings.Add(aBooking);
                        }
                    }
                    break;

                case "Guests":
                    foreach (DataRow row in dsMain.Tables[table].Rows)
                    {
                        if (!(row.RowState == DataRowState.Deleted))
                        {
                            Guest guest = new Guest();
                            guest.GuestAccNo = row["guest_id"].ToString().Trim();
                            guest.Name = row["name"].ToString().Trim();
                            guest.Address = row["address"].ToString().Trim();
                            guest.PhoneNumber = row["phone_number"].ToString().Trim();
                            guest.Email = row["email"].ToString().Trim();
                            guests.Add(guest);
                        }
                    }
                    break;

                case "Payments":
                    foreach (DataRow row in ds.Tables[table].Rows)
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


                case "Rooms":
                    foreach (DataRow row in ds.Tables[table].Rows)
                    {
                        if (!(row.RowState == DataRowState.Deleted))
                        {
                            Room room = new Room();
                            room.RoomNumber = row["room_number"].ToString().Trim();
                            room.Avail = row["is_available"].ToString().Trim();
                            room.PricePerNight = Convert.ToDecimal(row["price_per_night"]);
                            rooms.Add(room);
                        }
                    }
                    break;
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
                        id = guest.GuestAccNo;
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
                aRow["guestAccNo"] = guest.GuestAccNo;
                aRow["guestName"] = guest.Name;
                aRow["guestSurname"] = guest.Surname;
                aRow["guestPhoneNo"] = guest.PhoneNumber;
                aRow["guestEmail"] = guest.Email;
                aRow["guestAddress"] = guest.Address;
            }
            else if (obj is Booking booking)
            {
                aRow["booking_id"] = booking.BookingID;
                aRow["guest_AccNo"] = booking.GuestAccNo;
                aRow["check_in_date"] = booking.CheckInDate;
                aRow["check_out_date"] = booking.CheckOutDate;
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
            else if (obj is Room room)
            {
                aRow["room_number"] = room.RoomNumber;
                aRow["is_available"] = room.Avail;
                aRow["price_per_night"] = room.PricePerNight;
            }


        }
        #region Database Operations CRUD
        public void DataSetChange(object obj, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = string.Empty;

            // Determine the table name based on the object type
            if (obj is Guest) dataTable = table2;
            else if (obj is Booking) dataTable = table1;
            else if (obj is Payment) dataTable = table3;
            else if (obj is Room) dataTable = table4;

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


        #endregion

        public void AddBooking(Booking newBooking)
        {
            DataSetChange(newBooking, DB.DBOperation.Add);
        }



        #region Build Parameters, Create Commands & Update database //done for all 4 tables 
        private void Build_INSERT_Parameters(Booking aBooking)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@booking_id", SqlDbType.NVarChar, 15, "booking_id");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@guestAccNo", SqlDbType.NVarChar, 10, "guestAccNo");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@booking_date", SqlDbType.DateTime, 10, "booking_date");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@check_in_date", SqlDbType.DateTime, 10, "@check_in_date");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@check_out_date", SqlDbType.DateTime, 10, "@check_out_date");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@total_cost", SqlDbType.Money, 8, "total_cost");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@deposit_paid", SqlDbType.NVarChar, 8, "deposit_paid");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@booking_status", SqlDbType.NVarChar, 15, "booking_status");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@season", SqlDbType.NVarChar, 15, "season");
            daMain.InsertCommand.Parameters.Add(param);

      
        }

        private void Create_INSERT_Command(Booking aBooking)
        {
            //Create the command that must be used to insert values into the Books table..

            daMain.InsertCommand = new SqlCommand("INSERT INTO  (booking_id, guestAccNo, check_in_date, check_out_date, total_cost, deposit_paid, booking_status, season) VALUES (@booking_id, @guestAccNo, @check_in_date, @check_out_date, @total_cost, @deposit_paid, @booking_status, @season)", cnMain);
            Build_INSERT_Parameters(aBooking);
        }

        public bool UpdateDataSource(Booking aBooking)
        {
            return UpdateDataSource(sqlLocal1, table1);
        }
        //guest

        private void Build_INSERT_Parameters(Guest aGuest)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            //please insert code here , with correct properties
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@guest_AccNo", SqlDbType.NVarChar, 10, "guestAccNo");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@guestName", SqlDbType.NVarChar, 100, "guestName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@guestSurname", SqlDbType.NVarChar, 100, "guestSurname");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@guestEmail", SqlDbType.NVarChar, 100, "guestEmail");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@guestPhoneNo", SqlDbType.NVarChar, 100, "guestPhoneNo");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@guestAddress", SqlDbType.NVarChar, 255, "guestAddress");
            daMain.InsertCommand.Parameters.Add(param);

           

       
        }

        private void Create_INSERT_Command(Guest aGuest)
        {
            //Create the command that must be used to insert values into the Books table..
        
            daMain.InsertCommand = new SqlCommand("INSERT INTO guests (guestAccNo, guestName, guestSurname, guestEmail, guestPhoneNo, guestAddress) VALUES (@guestAccNo, @guestName, @guestSurname, @ guestEmail, @guestPhoneNo, @guestAddress)", cnMain);
            Build_INSERT_Parameters(aGuest);
        }

        public bool UpdateDataSource(Guest aGuest)
        {
            return UpdateDataSource(sqlLocal2, table2);
        }


        //payments
        private void Build_INSERT_Parameters(Payment aPayment)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            //please insert code here , with correct properties
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@payment_id", SqlDbType.NVarChar, 15, "payment_id");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@guest_id", SqlDbType.NVarChar, 10, "guest_id");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@booking_id", SqlDbType.DateTime, 10, "booking_id");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@payment_amount", SqlDbType.DateTime, 10, "payment_amount");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@payment_method", SqlDbType.DateTime, 10, "payment_method");
            daMain.InsertCommand.Parameters.Add(param);

            

           
        }

        private void Create_INSERT_Command(Payment aPayment)
        {
            //Create the command that must be used to insert values into the Books table..

            //please insert code here , with correct properties
            Build_INSERT_Parameters(aPayment);
        }

        public bool UpdateDataSource(Payment aPayment)
        {
            return UpdateDataSource(sqlLocal3, table3);
        }


        //rooms
        private void Build_INSERT_Parameters(Room aRoom)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            //please insert code here , with correct properties
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@room_number", SqlDbType.NVarChar, 15, "room_number");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@is_available", SqlDbType.NVarChar, 10, "is_available");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@pricer_per_night", SqlDbType.DateTime, 10, "price_per_night");
            daMain.InsertCommand.Parameters.Add(param);

           

       
        }

        private void Create_INSERT_Command(Room aRoom)
        {
            //Create the command that must be used to insert values into the Books table..

            //please insert code here , with correct properties
            Build_INSERT_Parameters(aRoom);
        }

        public bool UpdateDataSource(Room aRoom)
        {
            return UpdateDataSource(sqlLocal4, table4);
        }

      



        #endregion

    }
}
