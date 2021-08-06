using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contact_App_Serialization.Model;


namespace Contact_App_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contact contact1 = new Contact(123, "vaibhav");
            //Contact contact2 = new Contact(234,"atul");
            //ContactDiary contact = new ContactDiary();
            //contact.AddToContact(contact1);
            //contact.AddToContact(contact2);
            
            //Serialization serialize = new Serialization();
            //serialize.SerializeContacts(contact.ContactList);
            Deserialization deserialization = new Deserialization();
            List<Contact> dsContactList = deserialization.DeserializeContacts();
            //List<Contact> dsContactList = serialize.DeserializeContacts();
            printContactDetails(dsContactList);
        }

        private static void printContactDetails(List<Contact> dsContactList)
        {
            foreach(Contact contact in dsContactList)
            {
                Console.WriteLine(contact.ContactName + " : " + contact.ContactNumber);
            }
        }
    }
}
