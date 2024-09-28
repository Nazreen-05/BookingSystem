using BookingSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;//database communication and access
using System.Data;//local data management
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookingSystem.Data
{
    public class DB
    {
        #region Variables
        //***Once the database is created you can find the correct connection string by using the Settings.Default object to select the correct connection string
        private string strConn = Settings.Default.HotelManagementDBConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;
        #endregion

        #region Constructor
        public DB()
        {
            try
            {
                // opens a connection and creates object
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }
        #endregion

        #region Update the DateSet
        public void FillDataSet(string aSQLstring, string aTable)
        {
            //refreshes and fills dataset from database 
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                dsMain.Clear();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }

        #endregion

        #region Update the data source 
        public bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                //open connection
                cnMain.Open();
                //***update the database table via the data adapter
                daMain.Update(dsMain, table);
                //---close the connection
                cnMain.Close();
                //refresh the dataset
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion

        #region Check Account Number is Unique
        // Method to check if the account number is unique
        public bool IsAccountNumberUnique(string accountNumber)
        {
            string query = "SELECT COUNT(*) FROM Guests WHERE guestAccNo = @guestAccNo";
            using (SqlCommand command = new SqlCommand(query, cnMain))
            {
                command.Parameters.AddWithValue("@guestAccNo", accountNumber);

                try
                {
                    cnMain.Open();
                    int count = (int)command.ExecuteScalar();
                    cnMain.Close();
                    return count == 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking account number uniqueness: " + ex.Message);
                    return false;
                }
                finally
                {
                    if (cnMain.State == ConnectionState.Open)
                    {
                        cnMain.Close();
                    }
                }
            }
        }
        #endregion

        #region Add Guest to Database
        // Method to add a guest to the database
        public bool AddGuest(string guestAccNo, string guestName, string guestSName, string guestEmail, string guestPhoneNo, string guestAddress)
        {
            string query = "INSERT INTO Guests (guestAccNo, guestName, guestSName, guestEmail, guestPhoneNo, guestAddress) " +
                           "VALUES (@guestAccNo, @guestName, @guestSName, @guestEmail, @guestPhoneNo, @guestAddress)";
            using (SqlCommand command = new SqlCommand(query, cnMain))
            {
                command.Parameters.AddWithValue("@guestAccNo", guestAccNo);
                command.Parameters.AddWithValue("@guestName", guestName);
                command.Parameters.AddWithValue("@guestSName", guestSName);
                command.Parameters.AddWithValue("@guestEmail", guestEmail);
                command.Parameters.AddWithValue("@guestPhoneNo", guestPhoneNo);
                command.Parameters.AddWithValue("@guestAddress", guestAddress);

                try
                {
                    cnMain.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding guest: " + ex.Message);
                    return false;
                }
                finally
                {
                    if (cnMain.State == ConnectionState.Open)
                    {
                        cnMain.Close();
                    }
                }
            }
        }
        #endregion


        public enum DBOperation
        {
            Add,
            Edit,
            Delete
        }





    }
}
