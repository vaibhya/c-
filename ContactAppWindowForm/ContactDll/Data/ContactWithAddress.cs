using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDll.Service
{
    public class ContactWithAddress
    {
        private Guid _guid;
        private String _contactName;
        private String _contactNo;
        private String _address;
        public ContactWithAddress(Guid guid,String contactName,String contactNo,String address)
        {
            _guid = guid;
            _contactName = contactName;
            _contactNo = contactNo;
            _address = address;
        }
        public Guid Guid
        {
            get { return _guid; }
        }
        public String ContactName
        {
            get { return _contactName; }
        }
        public String ContactNo
        {
            get { return _contactNo; }
        }
        public String Address
        {
            get { return _address; }
        }
    }
}
