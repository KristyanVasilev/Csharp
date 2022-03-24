namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class CarManagerTests
    {
        [TestCaseSource("TestCaseConstructorWithValidData")]
        public void TestingConstructor_WithValidData_PositiveTest(string make, string model, 
            double fuelConsumption, double fuelCapacity)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
        }

        [TestCaseSource("TestCaseConstructorWithInvalidData")]
        public void TestingConstructor_WithInvalidData_ShouldThrowException(string make, string model,
           double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [TestCaseSource("TestCaseConstructorWithValidData")]
        public void TestingRefuel_WithValidData_ShouldRefuelCarsFuelAmmount(string make, string model,
                    double fuelConsumption, double fuelCapacity)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            car.Refuel(45.5);
            Assert.AreEqual(45.5, car.FuelAmount);

            car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(100);
            Assert.AreEqual(car.FuelCapacity, car.FuelAmount);
        }

        [TestCaseSource("TestCaseConstructorWithValidData")]
        public void TestingRefuel_WithInvalidData_ShouldThrowException(string make, string model,
                    double fuelConsumption, double fuelCapacity)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.Throws<ArgumentException>(() => car.Refuel(0));

            car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.Throws<ArgumentException>(() => car.Refuel(-1));
        }

        [TestCaseSource("TestCaseConstructorWithValidData")]
        public void TestingDrive_WithValidData_ShouldReduceFuelAmmount(string make, string model,
                    double fuelConsumption, double fuelCapacity)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            car.Refuel(50);
            car.Drive(100);

            Assert.AreEqual(car.FuelAmount, 50-fuelConsumption);
        }

        [TestCaseSource("TestCaseConstructorWithValidData")]
        public void TestingDrive_WithInvalidData_ShouldThrowsException(string make, string model,
                    double fuelConsumption, double fuelCapacity)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(50);
            Assert.Throws<InvalidOperationException>(() => car.Drive(100000));
        }
        static IEnumerable<TestCaseData> TestCaseConstructorWithInvalidData()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(null, "M3", 10.5, 55.5),
                new TestCaseData("Audi", null, 13.5, 50.5),
                new TestCaseData("Audi", "rs3", 0, 50.5),
                new TestCaseData("Audi", "rs3", -1, 50.5),
                new TestCaseData("Audi", "rs3", 10.6, 0),
                new TestCaseData("Audi", "rs3", 10.6, -1.5),
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
        static IEnumerable<TestCaseData> TestCaseConstructorWithValidData()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData("Bmw", "M3", 10.5, 55.5),
                new TestCaseData("Audi", "rs3", 13.5, 50.5),
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
    }
}