namespace Book.Tests
{
    using System;

    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void TestingConstructor_WithValidData_PositiveTest()
        {
            var book = new Book("Pod Igoto", "Ivan Vazov");
            Assert.AreEqual("Pod Igoto", book.BookName);
            Assert.AreEqual("Ivan Vazov", book.Author);
        }

        [Test]
        public void TestingBookName_WithInValidData_ShouldThrowException()
        {
           Assert.Throws<ArgumentException>(() => new Book(null, "Ivan Vazov"));
        }

        [Test]
        public void TestingAuthor_WithInValidData_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Book("Pod Igoto", null));
        }

        [Test]
        public void TestingAddFootnote_WithValidData_PositiveTest()
        {
            var book = new Book("Pod Igoto", "Ivan Vazov");

            book.AddFootnote(10, "Pesho");
            book.AddFootnote(12, "Pesho2");
            book.AddFootnote(13, "Pesho3");

            Assert.AreEqual(3, book.FootnoteCount);
        }

        [Test]
        public void TestingAddFootnote_WithInValidData_ShouldThrowException()
        {
            var book = new Book("Pod Igoto", "Ivan Vazov");

            book.AddFootnote(10, "Pesho");

            Assert.Throws<InvalidOperationException>(() => book.AddFootnote(10, "Pesho"));
        }

        [Test]
        public void TestingFindFootnote_WithValidData_PositiveTest()
        {
            var book = new Book("Pod Igoto", "Ivan Vazov");

            book.AddFootnote(10, "Pesho");
            book.AddFootnote(12, "Pesho2");
            book.AddFootnote(13, "Pesho3");

           var text = book.FindFootnote(10);

            Assert.AreEqual($"Footnote #10: Pesho", text);
        }

        [Test]
        public void TestingFindFootnote_WithInValidData_ShouldThrowException()
        {
            var book = new Book("Pod Igoto", "Ivan Vazov");

            book.AddFootnote(10, "Pesho");
            book.AddFootnote(12, "Pesho2");
            book.AddFootnote(13, "Pesho3");

            Assert.Throws<InvalidOperationException>(() => book.FindFootnote(1123));
        }

        [Test]
        public void TestingAlterFootnote_WithValidData_PositiveTest()
        {
            var book = new Book("Pod Igoto", "Ivan Vazov");

            book.AddFootnote(10, "Pesho");
            book.AlterFootnote(10, "Gosho");

            var text = book.FindFootnote(10);

            Assert.AreEqual($"Footnote #10: Gosho", text);
        }

        [Test]
        public void TestingAlterFootnote_WithInValidData_ShouldThrowException()
        {
            var book = new Book("Pod Igoto", "Ivan Vazov");

            book.AddFootnote(10, "Pesho");
           
            Assert.Throws<InvalidOperationException>(() => book.AlterFootnote(1123, "Gosho"));
        }
    }
}