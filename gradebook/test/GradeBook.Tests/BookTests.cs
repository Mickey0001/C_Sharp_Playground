using NUnit.Framework;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var book = new Book("");
            book.AddGrade(89.2);
            book.AddGrade(90.4);
            book.AddGrade(77.1);

            //Act
            var result = book.GetStatistics();

            //Assert
            Assert.AreEqual(89.2, result.Average);
            Assert.AreEqual(77.1, result.Low);
            Assert.AreEqual(90.4, result.High);
           
    }
}