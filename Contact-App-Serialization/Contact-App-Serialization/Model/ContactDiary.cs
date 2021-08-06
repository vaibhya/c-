using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contact_App_Serialization.Model
{
    class ContactDiary
    {
        private List<Contact> _contactList = new List<Contact>();
        public void AddToContact(Contact contact)
        {
            _contactList.Add(contact);
        }
        public List<Contact> ContactList
        {
            get { return _contactList; }
        }
    }
}
