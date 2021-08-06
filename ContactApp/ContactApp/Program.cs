using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_App_Serialization.Model;

namespace ContactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact1 = new Contact(12345, "vaibhav");
            Contact contact2 = new Contact(9889, "atul");
            Contact contact3 = new Contact(4433, "akash");
            AddToContact(contact1);
        }

        private static void AddToContact(Contact contact1)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Insert into CONTACTLIST values('"+contact1.ContactName+"',"+contact1.ContactNumber+")";
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Insert Query executed!");
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
    }
}
