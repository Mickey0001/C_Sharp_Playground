using System;

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
            object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;

            if(product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {
                        //Call an imaginery store procedure
                    }
                    else
                    {
                        //Call an imaginery updated sproc
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
     
    }
}
