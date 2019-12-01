using CustomerManagmentBusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CMBLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange 
            Customer customer = new Customer
            {
                FirstName = "Bobo",
                LastName = "Smrad"
            };
            string expected = "Smrad, Bobo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Zgembo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Samwise";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateIfValid()
        {
            var customer = new Customer
            {
                LastName = "Fotavac",
                EmailAdrress = "futofutavi@footer.com"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValideteIsLastNameMissing()
        {
            var customer = new Customer
            {
                EmailAdrress = "futofutavi@footer.com"
            };

            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
