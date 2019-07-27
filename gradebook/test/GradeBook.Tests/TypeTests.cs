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
        public void ValuesAlsoPassedByValue()
        {
            var x = GetInt();
            SetInt(x);

            Assert.AreEqual(42, x);
        }

        private void SetInt(int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        
        [Test]
        public void CShaprIsPassByValue()
        {
            var book1 = GetBook("Book1");
            GetBookSetName(book1, "Books of Knjige");

            Assert.AreEqual("Books of Knjige", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Test]
        public void TesSetName()
        {
            var book1 = GetBook("Book1");
            SetName(book1, "Books of Knjige");

            Assert.AreEqual("Book1", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
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