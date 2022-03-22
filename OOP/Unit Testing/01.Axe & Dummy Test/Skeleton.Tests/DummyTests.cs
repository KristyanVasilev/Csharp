using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLoseHealthWhenIsAttacked()
        {
            Axe axe = new Axe(5, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(5, dummy.Health);
        }

        [Test]
        public void DummyThrowErrorWhenAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            });
        }

        [Test]
        public void AliveDummyCanNotGiveExperience()
        {
            Axe axe = new Axe(5, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            });
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            Axe axe = new Axe(20, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            dummy.GiveExperience();
        }
    }
}