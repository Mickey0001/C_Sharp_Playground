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
        public void BookCalculatesAverageGrade()
        {
            //Arrange
            var book = new Book("");
            book.AddGrade(89.2);
            book.AddGrade(90.4);
            book.AddGrade(77.1);

            //Act
            var result = book.GetStatistics();

            //Assert
            Assert.AreEqual(89.2, result.Average, 1);
            Assert.AreEqual(77.1, result.Low, 1);
            Assert.AreEqual(90.4, result.High, 1);
        }  
    }
}