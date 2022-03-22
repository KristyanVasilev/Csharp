using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLooseDurabilityAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints);
        }

        [Test]
        public void AxeWithZeroDurabilityMustThrowError()
        {
            Axe axe = new Axe(10, 1);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

           Assert.Throws<InvalidOperationException>( ()=>
           {
               axe.Attack(dummy);
           });           
        }

        [Test]
        public void AxeWithNegativeDurabilityMustThrowError()
        {
            Axe axe = new Axe(10, -1);
            Dummy dummy = new Dummy(10, 10);
            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            });
        }
    }
}