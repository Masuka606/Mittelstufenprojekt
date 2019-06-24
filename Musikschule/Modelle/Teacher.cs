using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musikschule.Modelle
{
    public class Teacher:User
    {
        
        public int Teacher_ID { get; set; }
        string SalaryPerHour;

        public Teacher()
        {

        }
        public Teacher(int User_iD, string lastName, string firstName, string birthplace, DateTime birthdate, string email, string phoneNumber, int iD, string userName, string password, int teacher_iD, string salaryPerHour) : base(iD, lastName, firstName, birthplace, birthdate, email, phoneNumber, teacher_iD, userName, password)
        {
            Teacher_ID = teacher_iD;
            SalaryPerHour = salaryPerHour;
        }
        
    }
}
