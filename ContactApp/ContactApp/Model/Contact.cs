using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contact_App_Serialization.Model
{
    [Serializable()]
    class Contact
    {
        private int _contactNumber;
        private String _contactName;
        
        public Contact(int contactNumber,String contactName)
        {
            _contactNumber = contactNumber;
            _contactName = contactName;
        }
        public override string ToString()
        {
            return "Contact Name: "+_contactName+"Contact Number: "+_contactNumber;
        }
        public int ContactNumber
        {
            get { return _contactNumber; }
        }
        public String ContactName
        {
            get { return _contactName; }
        }
    }
}
