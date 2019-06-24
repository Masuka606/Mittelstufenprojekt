using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Musikschule.Modelle
{
    public class TeacherRepository
    {
        
        public static string GetallTeachers()
        {
            string OneTeacher = "";
            //var con = ConfigurationManager.ConnectionStrings["Musikschule"];
            string connStr = "Server=(LocalDb)\\MSSQLLocalDB;Database=MusikschuleDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            List<Teacher> AllTeachers = new List<Teacher>();

            using (SqlConnection myConnection = new SqlConnection(connStr))
            {
                
                string oString = "Select * From dbo.Teacher INNER JOIN dbo.Users ON dbo.teacher.fk_user = dbo.Users.id INNER JOIN dbo.Person ON dbo.Users.fk_person = dbo.Person.ID";
                //string oString = "Select * from Employees where FirstName=@fName";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                //oCmd.Parameters.AddWithValue("@Fname", fName);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        //string Test = oReader.
                        //SQLTeacher = oReader.ToString();
                        OneTeacher = oReader["first_name"].ToString();


                        //matchingPerson.firstName = oReader["FirstName"].ToString();
                        //matchingPerson.lastName = oReader["LastName"].ToString();
                    }

                    myConnection.Close();
                }
            }
            return OneTeacher;
        }
    }
}
