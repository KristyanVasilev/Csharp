namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class WarriorTests
    {
        [TestCaseSource("TestCaseConstructorWithValidData")]
        public void TestingConstructor_WithValidData_PositiveTest(string name, int damage, int hp)
        {
            Warrior warrior = new Warrior(name, damage, hp);

            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(hp, warrior.HP);
        }

        [TestCaseSource("TestCaseConstructorWithInvalidData")]
        public void TestingConstructor_WithInvalidData_ShouldThrowException(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
        }

        [TestCaseSource("TestCaseFightMethodWithInvalidData")]
        public void TestingFightMethod_WithInvalidData_ShouldThrowException(Warrior attacker, Warrior defender)
        {
            Warrior attackingWarrior = attacker;
            Warrior defendingWarrior = defender;

            Assert.Throws<InvalidOperationException>(() => attackingWarrior.Attack(defendingWarrior));
        }

        [Test]
        public void TestingFightMethod_WithValidData_PositiveTest()
        {
            Warrior attacker = new Warrior("Mitko", 101, 100);
            Warrior deffender = new Warrior("lubcho", 60, 100);

            attacker.Attack(deffender);
            Assert.AreEqual(40, attacker.HP);
            Assert.AreEqual(0, deffender.HP);

            attacker = new Warrior("Mitko", 50, 100);
            deffender = new Warrior("lubcho", 50, 100);
 
            attacker.Attack(deffender);
            Assert.AreEqual(50, attacker.HP);
            Assert.AreEqual(50, deffender.HP);
        }
        static IEnumerable<TestCaseData> TestCaseFightMethodWithInvalidData()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(new Warrior("Mitko", 50, 5), new Warrior("Pesho", 50, 50)),
                new TestCaseData(new Warrior("Gosho", 50, 100), new Warrior("Ico", 50, 5)),
                new TestCaseData(new Warrior("Dimi", 50, 50), new Warrior("Alonso", 100, 100)),
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
        static IEnumerable<TestCaseData> TestCaseConstructorWithInvalidData()
        {
            TestCaseData[] testCases = new TestCaseData[]
            {
                new TestCaseData(null, 100,100),
                new TestCaseData("", 100,100),
                new TestCaseData(" ", 100,100),
                new TestCaseData("Mitko", 0,100),
                new TestCaseData("Mitko", -1,100),
                new TestCaseData("Mitko", 0,0)
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
                new TestCaseData("Mitko", 1,0),
                new TestCaseData("Mitko", 100,100),
            };

            foreach (var item in testCases)
            {
                yield return item;
            }
        }
    }
}