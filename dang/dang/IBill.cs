using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dang
{
    internal interface IBill
    {
        void SetOrder(Order order);
        Order GetOrder();
        decimal CalculateBill();
    }
}
