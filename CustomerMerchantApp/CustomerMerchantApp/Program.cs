using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMerchantApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Customer Id:");
            String cId = Console.ReadLine();
            Console.WriteLine("Merchant Id:");
            String mId = Console.ReadLine();
            Console.WriteLine("Enter Purchase Amount:");
            String purchaseAmount = Console.ReadLine();
            SelectCustomerMerchant(cId, mId, purchaseAmount);
        }

        private static void SelectCustomerMerchant(string cId, string mId, string purchaseAmount)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand custCom = new SqlCommand("select * from Customer where CID=@cid", conn);
            SqlCommand custMer = new SqlCommand("select * from Merchant where MID=@mid", conn);

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@cid", cId);
            param[1] = new SqlParameter("@mid", mId);
            custCom.Parameters.Add(param[0]);
            custMer.Parameters.Add(param[1]);

            SqlDataReader readerCust =  custCom.ExecuteReader();
            while (readerCust.Read())
            {
                string cBalance = readerCust["CBALANCE"].ToString();
                UpdateCutomer(purchaseAmount,cId,cBalance);
            }
            readerCust.Close();
            SqlDataReader readerMer = custMer.ExecuteReader();
            while (readerMer.Read())
            {
                string mBalance = readerMer["MBALANCE"].ToString();
                UpdateMerchant(purchaseAmount, mId, mBalance);
            }
            
            readerMer.Close();
            conn.Close();
        }

        private static void UpdateMerchant(string purchaseAmount, string mId, string mBalance)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand custCom = new SqlCommand("Update Merchant Set MBALANCE=@mbalance where MID=@mId", conn);
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@mbalance", (int.Parse(mBalance) + int.Parse(purchaseAmount)));
            param[1] = new SqlParameter("@mId", mId);
            custCom.Parameters.Add(param[0]);
            custCom.Parameters.Add(param[1]);

            int query = custCom.ExecuteNonQuery();
            Console.WriteLine(query + " Rows affected!");
            Console.WriteLine("Merchant Balance: "+(int.Parse(mBalance) + int.Parse(purchaseAmount)));
            conn.Close();
        }

        private static void UpdateCutomer(string purchaseAmount,String cid,String cBalance)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand merCom = new SqlCommand("Update Customer Set CBALANCE=@cbalance where CID=@cId",conn);
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@cbalance", (int.Parse(cBalance) - int.Parse(purchaseAmount)));
            param[1] = new SqlParameter("@cId", cid);
            merCom.Parameters.Add(param[0]);
            merCom.Parameters.Add(param[1]);


            int query = merCom.ExecuteNonQuery();
            Console.WriteLine(query + " Rows affected!");
            Console.WriteLine("Customer Balance: " + (int.Parse(cBalance) - int.Parse(purchaseAmount)));
            conn.Close();
        }
    }
}
