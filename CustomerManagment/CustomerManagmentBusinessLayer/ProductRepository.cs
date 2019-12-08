namespace CustomerManagmentBusinessLayer
{
    public class ProductRepository
    {
        public Product Retrieve(int productID)
        {
            Product product = new Product(productID);

            if (productID == 2)
            {
                product.ProductName = "Lightsaber";
                product.ProductDescription = "An elegant weapon for a more civilized age...";
                product.CurrentPrice = 66;
            }
            return product;
        }
        public bool Save(Product product)
        {
            return true;
        }
     
    }
}
