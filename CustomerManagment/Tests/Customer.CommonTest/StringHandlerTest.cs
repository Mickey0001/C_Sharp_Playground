using Customer.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Customer.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            var source = "ImperialBlaster";
            var expected = "Imperial Blaster";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            var source = "Imperial Blaster";
            var expected = "Imperial Blaster";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }
    }
}
