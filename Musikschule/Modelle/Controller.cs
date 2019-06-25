using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Musikschule.Modelle
{
    public class Controller
    {
        public static List<Teacher> ShowTeachers()
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = "Server=(LocalDb)\\MSSQLLocalDB;Database=MusikschuleDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            List<Teacher> resultList = new List<Teacher>();

            SqlCommand command = cnn.CreateCommand();

            command.CommandText = "SELECT " +
                "dbo.Users.Id, " +
                "dbo.Person.last_name, " +
                "dbo.Person.first_name, " +
                "dbo.Person.birthplace, " +
                "dbo.Person.birthdate, " +
                "dbo.Person.email, " +
                "dbo.Person.phonenumber, " +
                "dbo.Person.Id, " +
                "dbo.Users.username, " +
                "dbo.Users.password, " +
                "dbo.Teacher.Id, " +
                "dbo.Teacher.salary_per_hour " +
                "From dbo.Teacher INNER JOIN dbo.Users ON dbo.teacher.fk_user = dbo.Users.id INNER JOIN dbo.Person ON dbo.Users.fk_person = dbo.Person.ID";

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                object[] obj = new object[reader.FieldCount];
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    reader.GetValues(obj);
                }
                
                resultList.Add(new Teacher()
                {
                    User_ID = Convert.ToInt32(obj[0]),
                    LastName = Convert.ToString(obj[1]),
                    FirstName = Convert.ToString(obj[2]),
                    Birthplace = Convert.ToString(obj[3]),
                    Birthdate = Convert.ToDateTime(obj[4]),
                    Email = Convert.ToString(obj[5]),
                    PhoneNumber = Convert.ToString(obj[6]),
                    Person_ID = Convert.ToInt32(obj[7]),
                    UserName = Convert.ToString(obj[8]),
                    Password = Convert.ToString(obj[9]),
                    Teacher_ID = Convert.ToInt32(obj[10]),
                    SalaryPerHour = Convert.ToString(obj[11])
                });
            }

            return resultList;
        }

        public static string DBConnect(string _query)
        {
            string connStr = "Server=(LocalDb)\\MSSQLLocalDB;Database=MusikschuleDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            string dataset = "";
            using (SqlConnection myConnection = new SqlConnection(connStr))
            {
                
                string query = _query;
                SqlCommand oCmd = new SqlCommand(_query, myConnection);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        IDataRecord record = (IDataRecord)oReader;
                        int lenght = record.FieldCount;
                        for (int count = 0; lenght > count; count++)
                        {

                            dataset = dataset + Convert.ToString(record[count]) + ";";
                            if (count == lenght - 1)
                            {
                                dataset = dataset + "|";
                            }
                        }
                        //Teacher teacher = new Teacher(record.GetInt32(0), record.GetString(10), record.GetString(11), record.GetString(12), record.GetDateTime(13), record.GetString(14), record.GetString(15), record.GetInt32(5), record.GetString(6), record.GetString(7), record.GetInt32(0), record.GetString(2));
                    }
                    myConnection.Close();
                }
            }
            return dataset;
            //SqlCommand oCmd = new SqlCommand(query, connStr);
        }
        //public static getallTeachers()
        //{
            
        //}

        //public static string TrimDataset(string _dataset)
        //{
        //    string[] seperatedRows;
        //    string[] seperatedData;

        //    string trim = _dataset;

        //    seperatedRows = trim.Split("|");

        //    foreach ()

           


        //    return trimdata;
        //}




    }
}
