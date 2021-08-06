using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInjectionSolution
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
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ToString();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                String sqlQuery = "select ENAME,JOB from EMP where EMPNO =@EmpNo";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlParameter param = new SqlParameter("@EmpNo", empNo);
                cmd.Parameters.Add(param);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["ENAME"] + " " + reader["JOB"]);
                }
                cmd.Dispose();
                conn.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
