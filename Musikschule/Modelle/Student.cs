using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musikschule.Modelle
{
    public class Student:Person
    {
        public Student(int User_iD, string lastName, string firstName, string birthplace, DateTime birthdate, string email, string phoneNumber) : base(User_iD, lastName, firstName, birthplace, birthdate, email, phoneNumber)
        {
            
        }
    }
}
