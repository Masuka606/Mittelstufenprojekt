using Microsoft.AspNetCore.Mvc;
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
        /// <summary>
        /// Öffnet Datenbankverbindung und führt ein SELECT aus
        /// </summary>
        /// <returns>List(Teacher) returnlist</returns>
        public List<Teacher> ShowTeachers()
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = "Server=(LocalDb)\\MSSQLLocalDB;Database=MusikschuleDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            List<Teacher> resultList = new List<Teacher>();

            SqlCommand command = cnn.CreateCommand();
            //Alle Lehrer anzeigen
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
                "From dbo.Teacher INNER JOIN dbo.Users ON dbo.teacher.fk_user = dbo.Users.id " +
                "INNER JOIN dbo.Person ON dbo.Users.fk_person = dbo.Person.ID";

            //Select Statement wird gelesen und in ein Array mit der Feldlänge des Ergebnisses gespeichert.
            //Die Werte werden in dem Array gespeichert.
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                object[] obj = new object[reader.FieldCount];
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    reader.GetValues(obj);
                }
                
                //Aus den Ausgelesenen Werten wird ein Lehrer Objekt erstellt.
                //Der Lehrer wird der Ergebnisliste hinzugefügt.
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

        public List<Student> ShowStudents()
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = "Server=(LocalDb)\\MSSQLLocalDB;Database=MusikschuleDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            List<Student> resultList = new List<Student>();

            SqlCommand command = cnn.CreateCommand();
            //das gewünschte SQL Statement
            command.CommandText = "SELECT " +
                "dbo.Person.last_name, " +
                "dbo.Person.first_name, " +
                "dbo.Person.birthplace, " +
                "dbo.Person.birthdate, " +
                "dbo.Person.email, " +
                "dbo.Person.phonenumber, " +
                "dbo.Person.Id " +
                "From dbo.Student INNER JOIN dbo.Person ON dbo.Student.fk_person = dbo.Person.Id";

            //Select Statement wird gelesen und in ein Array mit der Feldlänge des Ergebnisses gespeichert.
            //Die Werte werden in dem Array gespeichert.
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                object[] obj = new object[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    reader.GetValues(obj);
                }

                //Aus den Ausgelesenen Werten wird ein Lehrer Objekt erstellt.
                //Der Lehrer wird der Ergebnisliste hinzugefügt.
                resultList.Add(new Student()
                {
                    LastName = Convert.ToString(obj[0]),
                    FirstName = Convert.ToString(obj[1]),
                    Birthplace = Convert.ToString(obj[2]),
                    Birthdate = Convert.ToDateTime(obj[3]),
                    Email = Convert.ToString(obj[4]),
                    PhoneNumber = Convert.ToString(obj[5]),
                    Person_ID = Convert.ToInt32(obj[6]),

                });
            }
            return resultList;
        }

        [HttpPost]
        public void Test()
        {
            
        }
    }
}
