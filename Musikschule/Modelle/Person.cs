using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musikschule.Modelle
{
    public class Person
    {
        public int Person_ID;
        public string LastName;
        public string FirstName;
        public string Birthplace;
        public DateTime Birthdate;
        public string Email;
        public string PhoneNumber;

        public Person()
        {

        }
        public Person(int Person_iD, string lastName, string firstName, string birthplace, DateTime birthdate, string email, string phoneNumber)
        {
            Person_ID = Person_iD;
            LastName = lastName;
            FirstName = firstName;
            Birthplace = birthplace;
            Birthdate = birthdate;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
