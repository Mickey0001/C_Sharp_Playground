using CustomerManagmentBusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CMBLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAdrress = "bobosmard@xvideos.com",
                FirstName = "Bobo ",
                LastName = "Smrad"
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAdrress, actual.EmailAdrress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
