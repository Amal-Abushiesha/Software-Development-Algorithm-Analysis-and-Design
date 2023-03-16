using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dang
{
    internal class Bill:IBill
    {
     
        public Bill()
        {
            Console.WriteLine("Want Ur Bill Billy? *BUHHAHAHA");
        }
        public Order Order { get; set; }

        public void SetOrder(Order order)
        {
            Order = order;
        }

        public Order GetOrder()
        {
            return Order;
        }

        public decimal CalculateBill()
        {
            decimal billAmount = 0;
            // Calculate bill amount based on the items in the order
            return billAmount;
        }
    }
}