using System;

using NUnit.Framework;

namespace Calculator.Test
{
    class DecimalsTest
    {
        private Decimals x;
        private Decimals y;

        [SetUp]
        public void Setup()
        {
            x = new Decimals(2.75);
            y = new Decimals(1.25);
        }

        [Test]
        public void CreateDecimalsTest()
        {
            var decimals = new Decimals(1.25);
            Assert.NotNull(decimals);
            Assert.AreEqual(1.25, decimals.Dec_num);
        }

        /*[Test]
        public void TriggerExceptionWithNunit()
        {
            Assert.Throws<ArgumentException>(() => new Decimals(0.00));
        }*/

        [Test]
        public void AddTest()
        {
            var expected = new Decimals(4);
            var actual = x + y;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubTest()
        {
            Assert.AreEqual(new Decimals(1.5), x - y);
        }

        [Test]
        public void MultTest()
        {
            Assert.AreEqual(new Decimals(3.4375), x * y);
        }

        [Test]
        public void DivTest()
        {
            var divByZero = new Decimals(0);
            bool triggeredException = false;

            try
            {
                double result = x / divByZero;
            }
            catch (DivideByZeroException e)
            {
                triggeredException = true;
            }
            Assert.True(triggeredException);
            Assert.AreEqual(2.2d, (double)(x / y));
            //Assert.That(2.2, Is.EqualTo(x / y).Within(10).Percent);
        }

        [Test]
        public void ToStringTest()
        {
            Assert.AreEqual("Answer: 2.75", x.ToString());
            Assert.AreEqual("Answer: 1.25", y.ToString());
        }
    }
}
