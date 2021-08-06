using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMerchantSolnApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection conn;
            //SqlCommand comm1, comm2, comm3,comm4;
            //SqlTransaction trans;
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
            String cBalance="",mBalance="";
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
            try
            {
                SqlDataReader readerCust = custCom.ExecuteReader();
                while (readerCust.Read())
                {
                    cBalance = readerCust["CBALANCE"].ToString();
                    Console.WriteLine(cBalance);
                }
                readerCust.Close();
                SqlDataReader readerMer = custMer.ExecuteReader();
                while (readerMer.Read())
                {
                    mBalance = readerMer["MBALANCE"].ToString();
                    Console.WriteLine(mBalance);
                }

                UpdateDatabase(purchaseAmount, cId, cBalance, mId, mBalance);
                readerMer.Close();
                conn.Close();
            }catch(Exception e)
            {
                Console.WriteLine("Error occured!!");
            }
            
        }

        private static void UpdateDatabase(string purchaseAmount, string cId, string cBalance, string mId, string mBalance)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand custCom = new SqlCommand("Update Merchant Set MBALANCE=@mbalance where MID=@mId", conn);
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@mbalance", (Double.Parse(mBalance) + Double.Parse(purchaseAmount)));
            param[1] = new SqlParameter("@mId", mId);
            custCom.Parameters.Add(param[0]);
            custCom.Parameters.Add(param[1]);

            
            SqlCommand merCom = new SqlCommand("Update Customer Set CBALANCE=@cbalance where CID=@cId", conn);
            SqlParameter[] paramC = new SqlParameter[2];
            paramC[0] = new SqlParameter("@cbalance", (Double.Parse(cBalance) - Double.Parse(purchaseAmount)));
            paramC[1] = new SqlParameter("@cId", cId);
            merCom.Parameters.Add(paramC[0]);
            merCom.Parameters.Add(paramC[1]);

            SqlTransaction transaction = conn.BeginTransaction();
            custCom.Transaction = transaction;
            merCom.Transaction = transaction;

            try
            {
                custCom.ExecuteNonQuery();
                merCom.ExecuteNonQuery();
                transaction.Commit();
                Console.WriteLine("Transaction Complted. ");
            }
            catch (Exception)
            {
                transaction.Rollback();
                Console.WriteLine("Transaction Failed..");
            }




        }
    }
}
