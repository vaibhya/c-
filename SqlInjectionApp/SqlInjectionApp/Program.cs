using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInjectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Number:");
            String empNo = Console.ReadLine();
            PrintDetails(empNo);
        }

        private static void PrintDetails(string empNo)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM EMP where EMPNO="+empNo;
                cmd.CommandType = CommandType.Text;
                connection.Open();
                
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["ENAME"].ToString()
                            + " " + reader["JOB"].ToString());

                    }
                }
                    
                
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
