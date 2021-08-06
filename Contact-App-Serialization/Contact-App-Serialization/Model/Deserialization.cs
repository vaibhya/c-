using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Contact_App_Serialization.Model
{
    class Deserialization
    {
        public List<Contact> DeserializeContacts()
        {
            List<Contact> dsContactList;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream("contactList.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    dsContactList = (List<Contact>)bf.Deserialize(fsin);
                    return dsContactList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;

        }
    }
}
