namespace CustomerManagmentBusinessLayer
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemID)
        {
            OrderItemID = orderItemID;
        }

        public int OrderItemID { get; private set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; private set; }

        public OrderItem Retrieve(int orderItem)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductID <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
