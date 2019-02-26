using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arithmeticns;

namespace TestArithmetic
{
    [TestClass] //used for running tests and defines the class
    public class TestSqr
    {
        [TestMethod]
        public void TestValidAddition()
        {
            var actual = Arithmetic.Add(-49, -48);
            Assert.AreEqual(-97, actual);
            actual = Arithmetic.Add(5,-2);
            Assert.AreEqual(3, actual);
            actual = Arithmetic.Add(0,44);
            Assert.AreEqual(44, actual);
            actual = Arithmetic.Add(48, 49);
            Assert.AreEqual(97, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidAddition()
        {
            Arithmetic.Add(-65, 50);
            Arithmetic.Add(-51, 51);
            Arithmetic.Add(80, 2000);

        }
        [TestMethod]
        public void TestValidSubtraction()
        {
            var actual = Arithmetic.Subtract(-49, -48);
            Assert.AreEqual(-1, actual);
            actual = Arithmetic.Subtract(5, -2);
            Assert.AreEqual(7, actual);
            actual = Arithmetic.Subtract(0, 44);
            Assert.AreEqual(-44, actual);
            actual = Arithmetic.Subtract(48, 49);
            Assert.AreEqual(-1, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidSubtraction()
        {
            Arithmetic.Subtract(-65, 50);
            Arithmetic.Subtract(-51, 51);
            Arithmetic.Subtract(80, 2000);

        }
        [TestMethod]
        public void TestValidMultiply()
        {
            var actual = Arithmetic.Multiply(-49, -48);
            Assert.AreEqual(2352, actual);
            actual = Arithmetic.Multiply(5, -2);
            Assert.AreEqual(-10, actual);
            actual = Arithmetic.Multiply(0, 44);
            Assert.AreEqual(0, actual);
            actual = Arithmetic.Multiply(48, 49);
            Assert.AreEqual(2352, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidMuliply()
        {
            Arithmetic.Multiply(-65, 50);
            Arithmetic.Multiply(-51, 51);
            Arithmetic.Multiply(80, 2000);

        }
        [TestMethod]
        public void TestValidDivision()
        {
            var actual = Arithmetic.Divide(-49, -48);
            Assert.AreEqual(1, actual);
            actual = Arithmetic.Divide(5, -2);
            Assert.AreEqual(-2, actual);
            actual = Arithmetic.Divide(44, 2);
            Assert.AreEqual(22, actual);
            actual = Arithmetic.Divide(49, 49);
            Assert.AreEqual(1, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidDivision()
        {
            Arithmetic.Divide(-65, 50);
            Arithmetic.Divide(-51, 51);
            Arithmetic.Divide(80, 2000);
            Arithmetic.Divide(49, 0);


        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidminus127()
        {
            Arithmetic.sqr(-127);
        }
        [TestMethod]
        public void TestValid()   
        {
            var actual = Arithmetic.sqr(10);
            Assert.AreEqual(100, actual, "sqr(10) is not 100");
            actual = Arithmetic.sqr(11);
            Assert.AreEqual(121, actual);
            actual = Arithmetic.sqr(53);
            Assert.AreEqual(2809, actual);
            actual = Arithmetic.sqr(99);
            Assert.AreEqual(9801, actual, "sqr(99) is not 9801");
            actual = Arithmetic.sqr(100);
            Assert.AreEqual(10000, actual);
        }
    }
}
