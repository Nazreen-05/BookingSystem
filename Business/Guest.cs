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
        private string guestId;
        private string name;
        private string address;
        private string phoneNumber;
        private string email;
        private string creditCardNumber;
        private string loyaltyCardNumber;
        #endregion

        #region Property Methods
        public string GuestID
        {
            get { return guestId; }
            set { guestId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
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

        public string CreditCardNumber
        {
            get { return creditCardNumber; }
            set { creditCardNumber = value; }
        }

        public string LoyaltyCardNumber
        {
            get { return loyaltyCardNumber; }
            set { loyaltyCardNumber = value; }
        }
        #endregion

        #region Constructor
        public Guest(string guestId, string name, string address, string phoneNumber, string email, string creditCardNumber, string loyaltyCardNumber)
        {
            this.guestId = guestId;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.creditCardNumber = creditCardNumber;
            this.loyaltyCardNumber = loyaltyCardNumber;
        }
        #endregion

    }


}

