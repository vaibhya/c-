using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Contact_App_Serialization.Model
{
    class Serialization
    {
        public void SerializeContacts(List<Contact> contactList)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream("contactList.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, contactList);
                    Console.WriteLine("Serialization Success");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
