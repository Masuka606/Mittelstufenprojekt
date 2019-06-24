using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Musikschule.Modelle
{
    public class Controller
    {
        public static string DBConnect(string _query)
        {
            string connStr = "Server=(LocalDb)\\MSSQLLocalDB;Database=MusikschuleDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            string dataset = "";
            string OneDataSet = "";
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
    }
}
