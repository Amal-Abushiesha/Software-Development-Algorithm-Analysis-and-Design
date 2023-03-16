using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dang
{
    internal class LunchOrder : Order

    {
        public LunchOrder(string orderId, string itemName, int quant, int totalBillAmt)
        {
            this.OrderID = OrderID;
        }

        public void prepareOrder()
        {
            Console.WriteLine("Bier Oder Wasser bitte");
            Console.WriteLine(OrderID);


        }
    }
}
