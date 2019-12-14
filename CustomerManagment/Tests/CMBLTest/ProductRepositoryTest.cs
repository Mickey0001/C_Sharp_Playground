using CustomerManagmentBusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CMBLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Lightsaber",
                ProductDescription = "An elegant weapon for a more civilized age...",
                CurrentPrice = 66
            };
            var actual = productRepository.Retrieve(2);

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod()]
        public void SaveTestValid()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Mikri Mausova Jahta",
                ProductName = "Jahtung",
                HasChanges = true
            };

            var actual = productRepository.Save(updatedProduct);

            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "ta ja na",
                ProductName = "Cincilator",
                HasChanges = true
            };

            var actual = productRepository.Save(updatedProduct);

            Assert.AreEqual(false, actual);
        }
    }
}
