using NUnit.Framework;
using System;
using System.Linq;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault bank;

        [SetUp]
        public void SetUp()
        {
            this.bank = new BankVault();
        }

        [Test]
        public void TestingConstructor_WithValidData_PositiveTest()
        {
            Assert.IsNotNull(bank.VaultCells);
        }

        [Test]
        public void TestingAdd_WithInvalidCell_ShouldThrowException()
        {
            var item = new Item("Mitko", "024318");
            
            Assert.Throws<ArgumentException>(() => bank.AddItem("E5", item));
        }

        [Test]
        public void TestingAdd_WithTakenCell_ShouldThrowException()
        {
            var item = new Item("Mitko", "024318");
            var item2 = new Item("Lube", "034216");
            bank.AddItem("A1", item);

            Assert.Throws<ArgumentException>(() => bank.AddItem("A1", item2));
        }

        [Test]
        public void TestingAdd_WithDuplicateCell_ShouldThrowException()
        {
            var item = new Item("Mitko", "024318");
            bank.AddItem("A1", item);

            Assert.Throws<InvalidOperationException>(() => bank.AddItem("A2", item));
        }

        [Test]
        public void TestingAdd_WithValidData_PositiveTest()
        {
            var item = new Item("Mitko", "024318");
            var item2 = new Item("Lube", "034216");
            var message = bank.AddItem("A1", item);
            bank.AddItem("A2", item2);

            Assert.AreEqual(2, bank.VaultCells.Where(x => x.Value != null).Count());
            Assert.AreEqual("Item:024318 saved successfully!", message);
        }

        [Test]
        public void TestingRemove_WithInvalidCell_ShouldThrowException()
        {
            var item = new Item("Mitko", "024318");
            
            Assert.Throws<ArgumentException>(() => bank.RemoveItem("E5", item));
        }

        [Test]
        public void TestingRemove_WithWrongCell_ShouldThrowException()
        {
            var item = new Item("Mitko", "024318");
            bank.AddItem("A1", item);

            Assert.Throws<ArgumentException>(() => bank.RemoveItem("A2", item));
        }

        [Test]
        public void TestingRemove_WithValidData_PositiveTest()
        {
            var item = new Item("Mitko", "024318");
            var item2 = new Item("Lube", "034216");
            bank.AddItem("A1", item);
            bank.AddItem("A2", item2);
            var message = bank.RemoveItem("A2", item2);

            Assert.AreEqual(1, bank.VaultCells.Where(x => x.Value != null).Count());
            Assert.AreEqual("Remove item:034216 successfully!", message);
        }
    }
}