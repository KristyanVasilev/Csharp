namespace Presents.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class PresentsTests
    {
        private Bag bag;
        private Present presentField;

        [SetUp]
        public void SetUp()
        {
            this.bag = new Bag();
            presentField = new Present("aaa", 2);
        }

        [Test]
        public void TestingConstructor_WithValidData_PositiveTest()
        {
            Assert.IsNotNull(bag);
            Assert.IsNotNull(presentField);
        }

        [Test]
        public void TestingCreate_WithInvalidData_ShouldThrowException()
        {
            Assert.Throws<ArgumentNullException>((() => bag.Create(null)), "Present is null");
        }

        [Test]
        public void TestingCreate_WithExistingPresent_ShouldThrowException()
        {
            var present = new Present("Candy", 12);
            bag.Create(present);

            Assert.Throws<InvalidOperationException>((() => bag.Create(present)), "This present already exists!");
        }

        [Test]
        public void TestingCreate_WithValidData_PositiveTest()
        {
            var present = new Present("Candy", 12);
            var present2 = new Present("Book", 15);
            bag.Create(present);
            var message = bag.Create(present2);

            Assert.AreEqual(2, bag.GetPresents().Count);
            Assert.AreEqual("Successfully added present Book.", message);
        }

        [Test]
        public void TestingRemove_WithValidData_PositiveTest()
        {
            var present = new Present("Candy", 12);
            var present2 = new Present("Book", 15);
            bag.Create(present);
            bag.Create(present2);
            bool IsRemoved = bag.Remove(present2);

            Assert.AreEqual(1, bag.GetPresents().Count);
            Assert.IsTrue(IsRemoved);
        }

        [Test]
        public void TestingRemove_WithInvalidData_ShouldReturnFalse()
        {
            var present = new Present("Candy", 12);
            var present2 = new Present("Book", 15);
            bag.Create(present);
            bag.Create(present2);
            bag.Remove(present2);

            bool IsRemoved = bag.Remove(present2);
            Assert.AreEqual(false, IsRemoved);
        }

        [Test]
        public void TestingGetPresentWithLeastMagic_WithValidData_PositiveTest()
        {
            var present = new Present("Candy", 12);
            var present2 = new Present("Book", 15);
            var present3 = new Present("br", 20);
            bag.Create(present);
            bag.Create(present2);
            bag.Create(present3);
            bag.Remove(present3);
            var presentWithLeastMagic = bag.GetPresentWithLeastMagic();

            Assert.AreEqual(present, presentWithLeastMagic);
        }

        [Test]
        public void TestingGetPresentWithLeastMagic_WithInvalidData_PositiveTest()
        {
            var present = new Present("Candy", 12);
            var present1 = new Present("book", 12);

            bag.Create(present);
            bag.Create(present1);
            bag.Remove(present);

            var presentWithLeastMagic = bag.GetPresentWithLeastMagic();

            Assert.AreEqual(present1, presentWithLeastMagic);
        }

        [Test]
        public void TestingGetPresent_WithValidData_PositiveTest()
        {
            var present = new Present("Candy", 12);
            var present2 = new Present("Book", 15);
            var present3 = new Present("br", 20);
            bag.Create(present);
            bag.Create(present2);
            bag.Create(present3);
            bag.Remove(present3);
            var presentWithLeastMagic = bag.GetPresent("Candy");

            Assert.AreEqual(present, presentWithLeastMagic);
        }

        [Test]
        public void TestingGetPresent_WithInvalidData_ShouldReturnNull()
        {
            var present = new Present("Candy", 12);
            var present2 = new Present("Book", 15);
            var present3 = new Present("pr", 20);
            bag.Create(present);
            bag.Create(present2);
            bag.Create(present3);
            bag.Remove(present3);
            var presentWithLeastMagic = bag.GetPresent("Barby");

            Assert.AreEqual(null, presentWithLeastMagic);
        }
    }
}
