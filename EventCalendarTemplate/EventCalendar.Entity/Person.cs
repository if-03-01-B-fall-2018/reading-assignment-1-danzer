using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalendar.Entity
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _mailAdress;
        private string _phoneNumber;

        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string mailAdress
        {
            get { return _mailAdress; }
            set { _mailAdress = value; }
        }

        public string phoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
    }
}
