using System;
using NUnit.Framework;
using Calculator;

namespace CalcTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1,3,4)]
        [TestCase(-1, -3, -4)]
  
        [TestCase(3.2, 3.2,6.4)]
        [TestCase(-3.2,-3.2,-6.4)]

        public void TestSumMethod(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().Sum(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(1, 3, 0.33333)]
        [TestCase(-1, -3, 0.33333)]

        [TestCase(3.2, 3.2, 1)]
        [TestCase(-3.2, -3.2, 1)]


        public void TestDivMethod(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().Division(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(3, 0, "бесконечность" )]
        public void TestDivByZeroMethod(double number1, double number2, string expRes)
        {
            double actRes = new Calculation().Division(number1, number2);
            Assert.AreEqual(expRes, actRes.ToString());
        }
        [TestCase(1, 3, -2)]
        [TestCase(-1, -3, 2)]

        [TestCase(3.2, 3.2, 0)]
        [TestCase(-3.2, -3.2, 0)]

        public void TestMethodDiff(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().Diff(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(1, 3, 3)]
        [TestCase(-1, -3, 3)]

        [TestCase(3.2, 3.2, 10.24)]
        [TestCase(-3.2, -3.2, 10.24)]

        public void TestMethodMultiply(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().Multiply(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase(10, 3, 1)]
        [TestCase(-10, -3, -1)]

        [TestCase(6.5, 3.2, 0.1)]
        [TestCase(-6.5, -3.2, -0.1)]

        public void TestMethodReminderOfDivision(double number1, double number2, double expRes)
        {
            double actRes = new Calculation().RemainderOfDivision(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }
    }
}
