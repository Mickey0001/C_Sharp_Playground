namespace CustomerManagmentBusinessLayer
{
    public class ProductRepository
    {
        public Product Retrieve(int productID)
        {
            Product product = new Product(productID);

            if (productID == 1)
            {

            }
            return product;
        }
        public bool Save(Product product)
        {
            return true;
        }
     
    }
}
