using System;

namespace CustomerManagmentBusinessLayer
{
    public class OrderRepository
    {
        public Order Retrieve(int orderID)
        {
            Order order = new Order(orderID);

            if (orderID == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }
        public bool Save(Order order)
        {
            return true;
        }
    }
}
