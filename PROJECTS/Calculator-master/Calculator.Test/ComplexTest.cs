using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace Calculator.Test
{
    class ComplexTest
    {
        private Complex x;
        private Complex y;

        [SetUp]
        public void Setup()
        {
            x = new Complex(2.5, 1);
            y = new Complex(1.5, 2);
        }

        [Test]
        public void CreateFractionTest()
        {
            var complex = new Complex(2.5, 1);
            Assert.NotNull(complex);
            Assert.AreEqual(2.5, complex.Real);
            Assert.AreEqual(1, complex.Imag);
        }
        
        /*[Test]
        public void TriggerExceptionWithNunit()
        {
            Assert.Throws<ArgumentException>(() => new Complex(0, 0));
        }*/

        [Test]
        public void AddTest()
        {
            var expected = new Complex(4, 3);
            var actual = x + y;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubTest()
        {
            Assert.AreEqual(new Complex(1, -1), x - y);
        }

        [Test]
        public void MultTest()
        {
            Assert.AreEqual(new Complex(1.75, 6.5), (x * y));
        }

        [Test]
        public void DivTest()
        {
            /*
            var res = Math.Pow(x.Real, 2) + Math.Pow(y.Imag, 2);
            bool triggeredException = false;

            try
            {
                var result = new Complex((x.Real * y.Real + x.Imag * y.Imag) / res,
                                (x.Imag * y.Real - x.Real * y.Imag) / res);
            }
            catch (DivideByZeroException e)
            {
                triggeredException = true;
            }
            Assert.True(triggeredException);*/
            Assert.AreEqual(new Complex(0.92, -0.56), (x / y));
        }

        public void ToStringTest()
        {
            Assert.AreEqual("2.5 + 1i", x.ToString());
            Assert.AreEqual("1.5 + 2i", y.ToString());
        }
    }
}
