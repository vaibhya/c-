using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlConnectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertOperation();
            //UpdateOperation();
            //DeleteOperation();
            FetchData();
            Console.ReadLine();
        }

        private static void DeleteOperation()
        {
            int id = 7;
            
            string constr = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            String query = "Delete from EMP where ID="+id;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Update successful!");
        }

        private static void UpdateOperation()
        {
            int id = 7;
            String name = "vishalV";
            string constr = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            String query = "Update EMP set NAME='"+name+"' where ID="+id;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Update successful!");
        }

        private static void InsertOperation()
        {
            int id = 7;
            String name = "vishal";
            String designation = "Tester";
            int salary = 3000;
            string constr = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            String query = "insert into EMP values(" + id + ",'" + name + "','" + designation + "'," + salary + ")";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Insertion successful!");
        }

        private static void FetchData()
        {
            string constr = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM EMP");
            MySqlDataAdapter sda = new MySqlDataAdapter();
                    
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(string.Format("id = {0} Name = {1} Designation={2} Salary={3}", 
                    dr["ID"].ToString(),
                    dr["NAME"].ToString(), 
                    dr["DESIGNATION"].ToString(), 
                    dr["SALARY"].ToString()));
            }
            cmd.Dispose();
            con.Close(); 
        }

        
    }
}
