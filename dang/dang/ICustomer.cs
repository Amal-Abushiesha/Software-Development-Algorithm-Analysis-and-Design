using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dang
{
    internal interface ICustomer
    {
        string GetName();
        void SetName(string name);
        string GetAddress();
        void SetAddress(string address);
    }
}
