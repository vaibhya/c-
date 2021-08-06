using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDll
{
    public class ContactsAccess
    {
        public DataSet DisplayContactDetails()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand empComm = new SqlCommand("select * from Contact", conn);
           
            SqlDataAdapter empDA = new SqlDataAdapter();
            empDA.SelectCommand = empComm;

            DataSet data = new DataSet();
            empDA.Fill(data, "empTable");
            conn.Close();

            return data;
        }
    }
}
