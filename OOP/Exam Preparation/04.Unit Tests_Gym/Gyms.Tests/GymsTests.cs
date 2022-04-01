using NUnit.Framework;
using System;

namespace Gyms.Tests
{
    public class GymsTests
    {
        [Test]
        public void TestingConstructor_WithValidData_PositiveTest()
        {
            var gym = new Gym("33", 10);
            Assert.AreEqual("33", gym.Name);
            Assert.AreEqual(10, gym.Capacity);
        }

        [Test]
        public void TestingConstructor_WithInValidData_ShouldThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => new Gym(null, 10));
            Assert.Throws<ArgumentException>(() => new Gym("33", -1));
        }

        [Test]
        public void TestingAddAthlete_WithValidData_PositiveTest()
        {
            var gym = new Gym("33", 10);
            Athlete athlete = new Athlete("Pesho");

            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete);

            Assert.AreEqual(3, gym.Count);
        }

        [Test]
        public void TestingAddAthlete_WithInValidData_ShouldThrowException()
        {
            var gym = new Gym("33", 2);
            Athlete athlete = new Athlete("Pesho");

            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete);

            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(athlete));
        }

        [Test]
        public void TestingRemoveAthlete_WithValidData_PositiveTest()
        {
            var gym = new Gym("33", 10);
            Athlete athlete = new Athlete("Pesho");
            Athlete athlete1 = new Athlete("Gosho");

            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete1);
            gym.RemoveAthlete("Gosho");

            Assert.AreEqual(1, gym.Count);
        }

        [Test]
        public void TestingRemoveAthlete_WithInValidData_ShuldThrowexception()
        {
            var gym = new Gym("33", 10);
            Athlete athlete = new Athlete("Pesho");
            Athlete athlete1 = new Athlete("Gosho");

            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete1);
            gym.RemoveAthlete("Gosho");

            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("Gosho"));
        }

        [Test]
        public void TestingInjuryAthlete_WithValidData_PositiveTest()
        {
            var gym = new Gym("33", 10);
            Athlete athlete = new Athlete("Pesho");
            Athlete athlete1 = new Athlete("Gosho");

            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete1);
            gym.InjureAthlete("Gosho");

            Assert.IsTrue(athlete1.IsInjured);
        }

        [Test]
        public void TestingInjuryAthlete_WithInValidData_ShouldThrowException()
        {
            var gym = new Gym("33", 10);
            Athlete athlete = new Athlete("Pesho");
            Athlete athlete1 = new Athlete("Gosho");

            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete1);
            gym.InjureAthlete("Gosho");
            gym.InjureAthlete("Pesho");

            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete("Kiro"));
        }

        [Test]
        public void TestingReport_WithValidData_PosititveTest()
        {
            var gym = new Gym("33", 10);
            Athlete athlete = new Athlete("Pesho");
            Athlete athlete1 = new Athlete("Gosho");

            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete1);            
            gym.InjureAthlete("Pesho");

            Assert.AreEqual("Active athletes at 33: Gosho", gym.Report());
        }
    }
}
