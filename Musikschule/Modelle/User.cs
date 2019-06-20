using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musikschule.Modelle
{
    public class User:Person
    {
        private int User_ID;
        private string UserName;
        private string Password;

        public User(int User_iD, string lastName, string firstName, string birthplace, string birthdate, string email, string phoneNumber, int iD, string userName, string password) : base( iD, lastName,  firstName,  birthplace, birthdate, email, phoneNumber)
        {
            User_ID = User_iD;
            UserName = userName;
            Password = password;
        }
    }
}
