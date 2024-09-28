using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Business
{
    public class Guest
    {
        #region Data Members
        private string guestAccNo;
        private string name;
        private string surname;
        private string address;
        private string phoneNumber;
        private string email;
        #endregion

        #region Property Methods
        public string GuestAccNo
        {
            get { return guestAccNo; }
            set { guestAccNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        #region Constructor
        public Guest()
        {
            //default constructor
        }
        public Guest(string guestAccNo, string name ,string surname, string address, string phoneNumber, string email)
        {
            this.guestAccNo = guestAccNo;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            
        }
        #endregion

    }


}

