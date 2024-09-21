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
    internal class DB
    {
        //edit after database is created
       // string strConn = Settings.Default.EmployeeDatabaseConnectionString;
        DataSet dsMain = new DataSet();
        SqlConnection cnMain = new SqlConnection(@"");
        SqlDataAdapter daMain = new SqlDataAdapter();

        public DB() //constructor
        {
            try
            {
                cnMain.Open();
                dsMain = new DataSet();
            }
            catch (Exception err0bj)
            {
                MessageBox.Show(err0bj.Message);
            }
        }

        public void FillDataSet(string aSQLstring, string aTable)
        {
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                dsMain.Clear();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception err0bj)
            {
                MessageBox.Show(err0bj.Message + " " + err0bj.StackTrace);
            }
        }

        public bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success = false;

            try
            {
                cnMain.Open();
                SqlCommandBuilder UpdateDatabase = new SqlCommandBuilder(daMain);
                daMain.Update(dsMain, table);

                cnMain.Close();

                FillDataSet(sqlLocal, table);

                success = true;
            }
            catch (Exception err0bj)
            {
                MessageBox.Show(err0bj.Message + " " + err0bj.StackTrace);
            }
            finally
            {
            }
            return success;


        }
    }
}//lol
