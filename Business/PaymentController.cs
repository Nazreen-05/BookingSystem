using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class PaymentController
    {
        #region Data Members
        private HotelManagementDB paymentDB; // Data access object to communicate with HotelManagementDB
        private Collection<Payment> payments; // Collection to hold all payment objects
        #endregion

        #region Properties
        // Property to expose the collection of payments
        public Collection<Payment> AllPayments
        {
            get { return payments; }
        }
        #endregion

        #region Constructor
        // Constructor to instantiate the HotelManagementDB object and initialize the payment collection
        public PaymentController()
        {
            paymentDB= new HotelManagementDB(); // Instantiate the data access object
            payments = paymentDB.AllPayment; // Fetch all payments from the database
        }
        #endregion

        #region Database Communication
        // Method to perform a data maintenance operation on the payments collection
        public void DataMaintenance(Payment aPayment, DB.DBOperation operation)
        {
            int index = 0;
            paymentDB.DataSetChange(aPayment, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    payments.Add(aPayment);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aPayment);
                    if (index != -1)
                    {
                        payments[index] = aPayment;
                    }
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aPayment);
                    if (index != -1)
                    {
                        payments.RemoveAt(index);
                    }
                    break;
            }
        }

        // Method to commit changes to the database
        public bool FinalizeChanges()
        {
            return paymentDB.UpdateDataSource();
        }
        #endregion

        #region Search Methods
        // Find a payment by ID
        public Payment Find(string paymentID)
        {
            int index = 0;
            bool found = (payments.Count > 0 && payments[index].PaymentID == paymentID);
            while (!found && (index < payments.Count - 1))
            {
                index++;
                found = (payments[index].PaymentID == paymentID);
            }
            return found ? payments[index] : null;
        }

        // Find the index of a payment in the collection
        public int FindIndex(Payment aPayment)
        {
            int counter = 0;
            bool found = (aPayment.PaymentID == payments[counter].PaymentID);

            while (!found && counter < payments.Count - 1)
            {
                counter++;
                found = (aPayment.PaymentID == payments[counter].PaymentID);
            }

            return found ? counter : -1;
        }
        #endregion
    }
