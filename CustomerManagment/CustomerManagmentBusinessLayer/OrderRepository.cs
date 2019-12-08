namespace CustomerManagmentBusinessLayer
{
    public class OrderRepository
    {
        public Order Retrieve(int orderID)
        {
            Order order = new Order(orderID);

            if (orderID == 1)
            {
                
            }
            return order;


        }
        public bool Save(Order order)
        {
            return true;
        }
    }
}
