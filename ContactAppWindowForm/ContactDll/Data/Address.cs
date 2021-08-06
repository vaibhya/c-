using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDll.Service
{
    class Address
    {
        private String _address;
        private Guid _guid;
        public Address(String address,Guid guid)
        {
            _address = address;
            _guid = guid;
        }
        public String CAddress
        {
            get { return _address; }
        }
        public Guid Guid
        {
            get { return _guid; }
        }
    }
}
