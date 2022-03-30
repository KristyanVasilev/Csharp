namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    public class RobotsTests
    {
        [Test]
        public void TestingConstructor_WithValidData_PositiveTest()
        {
            var robotoManager = new RobotManager(4);
            Assert.AreEqual(4, robotoManager.Capacity);

            var robot = new RobotManager(0);
            Assert.AreEqual(0, robot.Capacity);
        }

        [Test]
        public void TestingConstructor_WithInvalidData_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new RobotManager(-1));
        }

        [Test]
        public void TestingAddMethod_WithValidData_PositiveTest()
        {
            var robotoManager = new RobotManager(2);

            var robot = new Robot("mitko", 100);
            var robot1 = new Robot("mitko1", 100);
            robotoManager.Add(robot);
            robotoManager.Add(robot1);

            Assert.AreEqual(2, robotoManager.Count);
        }

        [Test]
        public void TestingAddMethod_WithInValidRobots_ShouldThrowException()
        {
            var robotoManager = new RobotManager(2);

            var robot = new Robot("mitko", 100);
            robotoManager.Add(robot);
            
            Assert.Throws<InvalidOperationException>(()=> robotoManager.Add(robot));
        }

        [Test]
        public void TestingAddMethod_WithInValidCapacity_ShouldThrowException()
        {
            var robotoManager = new RobotManager(0);

            var robot = new Robot("mitko", 100);

            Assert.Throws<InvalidOperationException>(() => robotoManager.Add(robot));
        }

        [Test]
        public void TestingRemoveMethod_WithInValidData_ShouldThrowException()
        {
            var robotoManager = new RobotManager(2);

            robotoManager.Add(new Robot("r", 100));

            robotoManager.Remove("r");

            Assert.Throws<InvalidOperationException>(() => robotoManager.Remove("r"));
        }

        [Test]
        public void TestingRemoveMethod_WithValidData_PositiveTest()
        {
            var robotoManager = new RobotManager(2);

            robotoManager.Add(new Robot("r", 100));

            robotoManager.Remove("r");

            Assert.AreEqual(0, robotoManager.Count);
        }

        [Test]
        public void TestingWorkMethod_WithValidData_PositiveTest()
        {
            var robotoManager = new RobotManager(2);

            var robot = new Robot("r", 100);
            robotoManager.Add(robot);
            robotoManager.Work("r", "cleaning", 60);

            Assert.AreEqual(40, robot.Battery);
        }

        [Test]
        public void TestingWorkMethod_WithInValidData_ShouldThrowException()
        {
            var robotoManager = new RobotManager(2);

            var robot = new Robot("r", 100);
            robotoManager.Add(robot);
            

            Assert.Throws<InvalidOperationException>(() => robotoManager.Work("rx", "cleaning", 60));
        }

        [Test]
        public void TestingWorkMethod_WithInValidBatteryUsage_ShouldThrowException()
        {
            var robotoManager = new RobotManager(2);

            var robot = new Robot("rx", 30);
            robotoManager.Add(robot);


            Assert.Throws<InvalidOperationException>(() => robotoManager.Work("rx", "cleaning", 60));
        }

        [Test]
        public void TestingChargeMethod_WithInValidData_ShouldThrowException()
        {
            var robotoManager = new RobotManager(2);

            var robot = new Robot("r", 30);
            robotoManager.Add(robot);


            Assert.Throws<InvalidOperationException>(() => robotoManager.Charge("rx"));
        }

        [Test]
        public void TestingChargeMethod_WithValidData_PositiveTest()
        {
            var robotoManager = new RobotManager(2);

            var robot = new Robot("r", 100);
            robotoManager.Add(robot);
            robotoManager.Work("r", "cleaning", 60);
            robotoManager.Charge("r");

            Assert.AreEqual(100, robot.Battery);
        }
    }
}
