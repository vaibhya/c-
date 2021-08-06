using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace CommandApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            //InsertIntoTable();
            //UpdateTableValues();
            //DeleteTableValue();
            SelectEmpTable();
            Console.ReadLine();
        }

        private static void DeleteTableValue()
        {
            int id = 6;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Delete from EMP where ID="+id;
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Delete Query executed!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private static void UpdateTableValues()
        {
            int id = 6;
            String name = "mahesh";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "update EMP set NAME='"+name+"' where ID="+id;
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Update Query executed!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private static void InsertIntoTable()
        {
            int id = 6;
            String name = "monu";
            String designation = "Designer";
            int salary = 3500;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "insert into EMP values(" + id + ",'" + name + "','" + designation + "'," + salary + ")";
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Insert Query executed!");
            }catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private static void SelectEmpTable()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM EMP";
                cmd.CommandType = CommandType.Text;
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected + " rows affected");

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["ID"].ToString() 
                            +" "+ reader["NAME"].ToString()
                            +" "+ reader["DESIGNATION"].ToString()
                            +" "+ reader["SALARY"].ToString());
                    }
                }
                cmd.Dispose();
                connection.Dispose();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
