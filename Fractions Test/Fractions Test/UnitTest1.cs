using System;
using Fractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fractions_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_1()
        {
            var a = new Fraction(2, 3); // 2/3
            var b = new Fraction(1, 4); // 1/4
            Assert.AreEqual("11/12", a.plus(b).ToString());
        }

        [TestMethod]
        public void test_2()
        {
            var a = new Fraction(2, 3);
            var b = new Fraction(1, 4);
            Assert.AreEqual("5/12", a.minus(b).ToString());
        }

        [TestMethod]
        public void test_3()
        {
            var a = new Fraction(2, 3);
            var b = new Fraction(1, 4);
            Assert.AreEqual("2/12", a.multiplyBy(b).ToString());
        }

        [TestMethod]
        public void test_4()
        {
            var a = new Fraction(2, 3);
            var b = new Fraction(1, 4);
            Assert.AreEqual("8/3", a.divideBy(b).ToString());
        }
    }
}
