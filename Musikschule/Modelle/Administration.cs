using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musikschule.Modelle
{
    public class Administration:User
    {
        public Administration(int User_iD, string lastName, string firstName, string birthplace, string birthdate, string email, string phoneNumber, int iD, string userName, string password) : base(iD, lastName, firstName, birthplace, birthdate, email, phoneNumber, iD, userName, password)
        {

        }
    }
}
