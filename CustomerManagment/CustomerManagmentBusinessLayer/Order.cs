using System;

namespace CustomerManagmentBusinessLayer
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderID)
        {
            OrderID = orderID;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; set; }

        public Order Retrieve(int orderID)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
