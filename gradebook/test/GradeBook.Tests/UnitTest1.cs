using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            var x = 5;
            var y = 2;
            var expected = 7;
            var actual = x + y;

            Assert.AreEqual(expected, actual);
        }
    }
}