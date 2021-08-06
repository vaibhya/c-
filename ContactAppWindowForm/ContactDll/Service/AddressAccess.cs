using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDll
{
    public class AddressAccess
    {
        public String GetAddress(String gid)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand empComm = new SqlCommand("select P_ADD from Address where CID=@guid", conn);
            SqlParameter[] aParam = new SqlParameter[1];
            aParam[0] = new SqlParameter("@guid", gid);
            empComm.Parameters.Add(aParam[0]);
            String addresses = "";
            SqlDataReader reader = empComm.ExecuteReader();
            while (reader.Read())
            {
                addresses += reader["P_ADD"].ToString();
                //return reader["P_ADD"].ToString();
                return addresses;
            }
            conn.Close();

            return "";
        }
    }
}
