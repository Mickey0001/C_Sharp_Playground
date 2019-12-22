using Customer.Common;
using CustomerManagmentBusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Customer.CommonTest
{
    [TestClass]
    public class LogginServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new CustomerDetails2(1)
            {
                EmailAdrress = "bobosmard@xvideos.com",
                FirstName = "Bobo ",
                LastName = "Smrad",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Lightsaber",
                ProductDescription = "An elegant weapon for a more civilized age...",
                CurrentPrice = 66
            };
            changedItems.Add(product);

            LogginService.WriteToFile(changedItems);
        }
    }
}
