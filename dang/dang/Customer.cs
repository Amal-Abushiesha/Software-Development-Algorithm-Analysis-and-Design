using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dang
{
    internal class Customer:ICustomer
    {

        public Customer()
        {
            Name = "";
            Address = "";
        }
        public string Name { get; set; }
        public string Address { get; set; }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetAddress()
        {
            return Address;
        }

        public void SetAddress(string address)
        {
            Address = address;
        }
    }
}
