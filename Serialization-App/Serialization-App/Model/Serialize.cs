using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using AccountApp.Model;

namespace Serialization_App.Model
{
    class Serialize
    {
        public void SerializeAccount(Account account){
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream("account.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, account);
                    Console.WriteLine("Serialization Success");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Account DeserializeAccount()
        {
            Account dsAccount;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream("account.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    dsAccount = (Account)bf.Deserialize(fsin);
                    return dsAccount;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
