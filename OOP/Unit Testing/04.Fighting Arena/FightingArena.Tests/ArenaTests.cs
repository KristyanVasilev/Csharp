namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class ArenaTests
    {
        [Test]
        public void TestingConstructor_PositiveTest()
        {
            Arena arena = new Arena();

            Assert.IsNotNull(arena.Warriors);

            Assert.AreEqual(arena.Warriors.Count, arena.Count);

            Assert.AreEqual(0, arena.Count);
        }

        [Test]
        public void TestingEnrolMethod_WithValidData_PositiveTest()
        {
            Arena arena = new Arena();

            var warrior = new Warrior("Mitko", 100, 100);

            arena.Enroll(warrior);

            Assert.AreEqual(1, arena.Count);
            Assert.True(arena.Warriors.Any(x => x.Name == "Mitko"));
        }

        [Test]
        public void TestingEnrolMethod_WithInvalidData_ShouldThrowException()
        {
            Arena arena = new Arena();

            var warrior = new Warrior("Mitko", 100, 100);

            arena.Enroll(warrior);
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }

        [Test]
        public void TestingFightMethod_WithValidData_ShouldReduceHp()
        {
            Arena arena = new Arena();

            Warrior attacker = new Warrior("Mitko", 101, 100);
            Warrior deffender = new Warrior("lubcho", 60, 100);

            arena.Enroll(attacker);
            arena.Enroll(deffender);

            arena.Fight("Mitko", "lubcho");
            Assert.AreEqual(40, attacker.HP);
            Assert.AreEqual(0, deffender.HP);
        }

        [Test]
        public void TestingFightMethod_WithInvalidData_ShouldThrowException()
        {
            Arena arena = new Arena();

            Assert.Throws<InvalidOperationException>(() => arena.Fight("Mitko", "lubcho"));

            arena.Enroll(new Warrior("Mitko", 101, 100));
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Mitko", "lubcho"));
        }
    }
}
