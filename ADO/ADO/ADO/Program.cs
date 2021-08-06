using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            GetConnectionStrings();
            Console.ReadLine();
        }

        private static void GetConnectionStrings()
        {
            ConnectionStringSettingsCollection settings =
            ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                OpenConnection(settings);
                
            }
        }

        private static void OpenConnection(ConnectionStringSettingsCollection settings)
        {
            foreach (ConnectionStringSettings cs in settings)
            {
                Console.WriteLine("Name: " + cs.Name);
                Console.WriteLine("Provider: " + cs.ProviderName);
                Console.WriteLine("Connection String: " + cs.ConnectionString);
                SqlConnection connection = new SqlConnection(cs.ConnectionString);
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        Console.WriteLine("State: {0}", connection.State);
                        Console.WriteLine("ConnectionTimeout: {0}",
                                connection.ConnectionTimeout);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                }


            }
        }
    }
}
