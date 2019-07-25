using System;
using NUnit.Framework;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");

            Assert.AreEqual("Book1", book1.Name);
            Assert.AreEqual("Book2", book2.Name);
            Assert.AreNotSame(book1, book2);
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }

        [Test]
        public void TwoVaribablesCanRefrenceTheSameType()
        {
            var book1 = GetBook("Book1");
            var book2 = book1;

            Assert.AreSame(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }
    }
}