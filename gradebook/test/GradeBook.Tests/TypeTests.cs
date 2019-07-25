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
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}