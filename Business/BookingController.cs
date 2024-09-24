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
            private HotelManagementDB hoteManagementDB; //reference

            private Collection<Booking> bookings;

            //constructor
            public BookingController()
            {
                HotelManagementDB = new HotelManagementDB();
                bookings = new Collection<Booking>();

            }

            #region Database Communication

            public void DataMaintenance(Employee anEmp)
            {
                employeeDB.DataSetChange(anEmp);
                employees.Add(anEmp);
            }

            public bool FinalizeChanges(Employee employee)
            {
                return employeeDB.UpdateDataSource(employee);
            }

            #endregion
        }
    }
}
