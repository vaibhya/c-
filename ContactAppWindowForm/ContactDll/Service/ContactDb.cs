using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactDll.Service;

namespace ContactDll
{
    public class ContactDb
    {
        //public Boolean SaveContactDetails(String name,String contact,String address)
        public Boolean SaveContactDetails(ContactWithAddress contact)
        {
            //Guid obj = Guid.NewGuid();
            
            String connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //insert Contact
            SqlCommand contactComm = new SqlCommand("insert into Contact Values(@gid,@contName,@contNo)", conn);
            SqlParameter[] cParam = new SqlParameter[3];
            cParam[0] = new SqlParameter("@gid", contact.Guid.ToString());
            cParam[1] = new SqlParameter("@contName", contact.ContactName);
            cParam[2] = new SqlParameter("@contNo", int.Parse(contact.ContactNo));
            
            contactComm.Parameters.Add(cParam[0]);
            contactComm.Parameters.Add(cParam[1]);
            contactComm.Parameters.Add(cParam[2]);



            //insert Address
            SqlCommand addressComm = new SqlCommand("insert into Address Values(@add,@guid)", conn);
            SqlParameter[] aParam = new SqlParameter[2];
            aParam[0] = new SqlParameter("@add", contact.Address);
            aParam[1] = new SqlParameter("@guid", contact.Guid.ToString());
            addressComm.Parameters.Add(aParam[0]);
            addressComm.Parameters.Add(aParam[1]);

            
            //begin transaction
            SqlTransaction transaction = conn.BeginTransaction();
            addressComm.Transaction = transaction;
            contactComm.Transaction = transaction;

            try
            {
                contactComm.ExecuteNonQuery();
                addressComm.ExecuteNonQuery();
                
                transaction.Commit();
                
                return true;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
