using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Test
{
    class IntegersTest
    {
        private Integers x;
        private Integers y;

        [SetUp]
        public void SetUp()
        {
            x = new Integers(4);
            y = new Integers(2);
        }

        [Test]
        public void CreateIntegersTest()
        {
            var integer = new Integers(x);
            Assert.NotNull(integer);
            Assert.AreEqual(4, integer.Int_num);
        }

        [Test]
        public void AddTest()
        {
            var expected = new Integers(6);
            var actual = x + y;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractTest()
        {
            var expected = new Integers(2);
            var actual = x - y;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyTest()
        {
            var expected = new Integers(8);
            var actual = x * y;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideTest()
        {
            var dividByZero = new Integers(0);
            bool triggeredException = false;
            try
            {
                var result = x / dividByZero;
            }
            catch (DivideByZeroException e)
            {
                triggeredException = true;
            }

            Assert.True(triggeredException);
            Assert.AreEqual(2, (int)(x / y));
        }

        [Test]
        public void ToStringTest()
        {
            Assert.AreEqual("Integer: 4", x.ToString());
            Assert.AreEqual("Integer: 2", y.ToString());
        }

    }
}
