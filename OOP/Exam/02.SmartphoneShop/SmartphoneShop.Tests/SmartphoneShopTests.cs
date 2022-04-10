using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {

        [Test]
        public void TestingConstructor_WithValidData_PositiveTest()
        {
            var shop = new Shop(5);
            Assert.AreEqual(5, shop.Capacity);
            Assert.IsNotNull(shop);            
        }

        [Test]
        public void TestingConstructor_WithInvalidData_ShouldThwoException()
        {
            Assert.Throws<ArgumentException>(() => new Shop(-1), "Invalid capacity.");
        }

        [Test]
        public void TestingAdd_WithValidData_PositiveTest()
        {
            var shop = new Shop(5);
            var phone = new Smartphone("Iphone", 100);
            var phone2 = new Smartphone("Motorola", 70);
            shop.Add(phone);
            shop.Add(phone2);
            Assert.AreEqual(2, shop.Count);
        }

        [Test]
        public void TestingAdd_WithInvalidData_ShouldThrowException()
        {
            var shop = new Shop(5);
            var phone = new Smartphone("Iphone", 100);
            shop.Add(phone);

            Assert.Throws<InvalidOperationException>(() => shop.Add(phone));
        }

        [Test]
        public void TestingAdd_WithFullCapacity_ShouldThrowException()
        {
            var shop = new Shop(3);
            var phone = new Smartphone("Iphone", 100);
            var phone1 = new Smartphone("Motorola", 70);
            var phone2 = new Smartphone("Samsung", 80);
            var phone3 = new Smartphone("Nokia", 90);
            shop.Add(phone);
            shop.Add(phone1);
            shop.Add(phone2);

            Assert.Throws<InvalidOperationException>(() => shop.Add(phone3));
        }

        [Test]
        public void TestingRemove_WithInvalidPhone_ShouldThrowException()
        {
            var shop = new Shop(3);
            var phone = new Smartphone("Iphone", 100);
            var phone1 = new Smartphone("Motorola", 70);
            shop.Add(phone);
            shop.Add(phone1);

            Assert.Throws<InvalidOperationException>(() => shop.Remove(null));
        }

        [Test]
        public void TestingRemove_WithValidData_PositiveTest()
        {
            var shop = new Shop(3);
            var phone = new Smartphone("Iphone", 100);
            var phone1 = new Smartphone("Motorola", 70);
            shop.Add(phone);
            shop.Add(phone1);
            shop.Remove("Iphone");

            Assert.AreEqual(1, shop.Count);
        }

        [Test]
        public void TestingTestPhone_WithInvalidPhone_ShouldThrowException()
        {
            var shop = new Shop(3);
            var phone = new Smartphone("Iphone", 100);
            var phone1 = new Smartphone("Motorola", 70);
            shop.Add(phone);
            shop.Add(phone1);
            shop.Remove("Iphone");

            Assert.Throws<InvalidOperationException>(() => shop.TestPhone("Iphone", 100));
        }

        [Test]
        public void TestingTestPhone_WithLowBattery_ShouldThrowException()
        {
            var shop = new Shop(3);
            var phone = new Smartphone("Iphone", 90);
            var phone1 = new Smartphone("Motorola", 70);
            shop.Add(phone);
            shop.Add(phone1);            

            Assert.Throws<InvalidOperationException>(() => shop.TestPhone("Iphone", 100));
        }

        [Test]
        public void TestingTestPhone_WithVaidData_PositiveTest()
        {
            var shop = new Shop(3);
            var phone = new Smartphone("Iphone", 90);
            var phone1 = new Smartphone("Motorola", 70);
            shop.Add(phone);
            shop.Add(phone1);
            shop.TestPhone("Motorola", 60);

            Assert.AreEqual(10, phone1.CurrentBateryCharge);
        }

        [Test]
        public void TestingChargePhone_WithVaidData_PositiveTest()
        {
            var shop = new Shop(3);
            var phone = new Smartphone("Iphone", 90);
            var phone1 = new Smartphone("Motorola", 100);
            shop.Add(phone);
            shop.Add(phone1);
            shop.TestPhone("Motorola", 60);
            shop.ChargePhone("Motorola");

            Assert.AreEqual(100, phone1.CurrentBateryCharge);
        }

        [Test]
        public void TestingChargePhone_WithInvaidData_ShouldThrowException()
        {
            var shop = new Shop(3);
            var phone = new Smartphone("Iphone", 90);
            var phone1 = new Smartphone("Motorola", 100);
            shop.Add(phone);
            shop.Add(phone1);
            shop.TestPhone("Motorola", 60);
            Assert.Throws<InvalidOperationException>(() => shop.ChargePhone(null));
        }
        //public void ChargePhone(string modelName)
        //{
        //    Smartphone currentPhone = this.phones.FirstOrDefault(x => x.ModelName == modelName);

        //    if (currentPhone == null)
        //    {
        //        throw new InvalidOperationException($"The phone model {modelName} doesn't exist.");
        //    }

        //    currentPhone.CurrentBateryCharge = currentPhone.MaximumBatteryCharge;
        //}
    }
}