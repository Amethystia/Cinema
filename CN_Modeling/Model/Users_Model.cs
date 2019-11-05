using System;

namespace CN_Modeling
{
    public class Users_Model
    {
        // deklarasi Variable
        public string UserId;
        public string Name;
        public string Password;
        public string Status;
        public string Address;
        public string Sex;
        public DateTime BirthDate;
        public Boolean IsActive;

        public String _UserId
        {
            get
            { return UserId; }
            set
            { UserId = value; }
        }
        public string _Name
        {
            get
            { return Name; }
            set
            { Name = value; }
        }
        public string _Password
        {
            get
            { return Password; }
            set
            { Password = value; }
        }
        public string _Status
        {
            get
            {
                return Status;
            }

            set
            {
                Status = value;
            }
        }
        public string _Address
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }
        public string _Sex
        {
            get
            {
                return Sex;
            }

            set
            {
                Sex = value;
            }
        }
        public DateTime _BirthDate
        {
            get
            {
                return BirthDate;
            }

            set
            {
                BirthDate = value;
            }
        }
        public Boolean _IsActive
        {
            get
            {
                return IsActive;
            }

            set
            {
                IsActive = value;
            }
        }

    }
}
