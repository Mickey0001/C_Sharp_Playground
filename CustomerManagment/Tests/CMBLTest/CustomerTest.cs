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
            CustomerDetails2 customer = new CustomerDetails2
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
            var c1 = new CustomerDetails2();
            c1.FirstName = "Zgembo";
            CustomerDetails2.InstanceCount += 1;

            var c2 = new CustomerDetails2();
            c2.FirstName = "Frodo";
            CustomerDetails2.InstanceCount += 1;

            var c3 = new CustomerDetails2();
            c3.FirstName = "Samwise";
            CustomerDetails2.InstanceCount += 1;

            Assert.AreEqual(3, CustomerDetails2.InstanceCount);
        }

        [TestMethod]
        public void ValidateIfValid()
        {
            var customer = new CustomerDetails2
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
            var customer = new CustomerDetails2
            {
                EmailAdrress = "futofutavi@footer.com"
            };

            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
