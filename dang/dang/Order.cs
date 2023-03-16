using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dang
{
    internal abstract class Order
    {
        public string OrderID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal TotalBillAmount { get; set; }
        public Customer Customer { get; set; }

        public string GetOrderID()
        {
            return OrderID;
        }

        public void SetOrderID(string orderID)
        {
            OrderID = orderID;
        }

        public string GetItemName()
        {
            return ItemName;
        }

        public void SetItemName(string itemName)
        {
            ItemName = itemName;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public decimal GetTotalBillAmount()
        {
            return TotalBillAmount;
        }

        public void SetTotalBillAmount(decimal totalBillAmount)
        {
            TotalBillAmount = totalBillAmount;
        }

        public void SetCustomer(Customer customer)
        {
            Customer = customer;
        }

        public Customer GetCustomer()
        {
            return Customer;
        }

        public void PrepareOrder()
        {
            // Prepare the order for delivery
        }

    }

}

