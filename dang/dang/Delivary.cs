using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dang
{
    internal class Delivary: IDelivery
    {

        public Order Order { get; set; }

        public void SetOrder(Order order)
        {
            Order = order;
        }

        public Order GetOrder()
        {
            return Order;
        }

        public void Deliver()
        {
            // Deliver the order to the customer
        }
    }
}
