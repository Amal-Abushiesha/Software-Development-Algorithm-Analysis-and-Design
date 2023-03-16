using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dang
{
    internal interface IOrder
    {
        string GetOrderID();
        void SetOrderID(string orderID);
        string GetItemName();
        void SetItemName(string itemName);
        int GetQuantity();
        void SetQuantity(int quantity);
        decimal GetTotalBillAmount();
        void SetTotalBillAmount(decimal totalBillAmount);
        void PrepareOrder();
    }
}
