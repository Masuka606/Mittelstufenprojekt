using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musikschule.Modelle
{
    public class Person
    {
        private int Person_ID;
        private string LastName;
        private string FirstName;
        private string Birthplace;
        private string Birthdate;
        private string Email;
        private string PhoneNumber;

        public Person(int Person_iD, string lastName, string firstName, string birthplace, string birthdate, string email, string phoneNumber)
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
