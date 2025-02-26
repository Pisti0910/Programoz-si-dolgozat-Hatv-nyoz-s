using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HatvanyozasCLI;

namespace HatvanyozasTest
{
    [TestClass]
    public class PowerCalculatorTests
    {
        [TestMethod]
        public void TestPositiveExponent()
        {
            var power = new PowerCalculator();
            int basee = 2;  int exponent = 3;
            int result = power.CalculatePower(basee, exponent);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void TestZeroExponent()
        {
            var power = new PowerCalculator();
            int basee = 5; int exponent = 0;
            int result = power.CalculatePower(basee, exponent);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestNegativeExponent()
        {
            var power = new PowerCalculator();
            int basee = 2; int exponent = -2;
            int result = power.CalculatePower(basee, exponent);
            Assert.AreEqual(0.25, result);
        }
        [TestMethod]
        public void TestZeroBasePositiveExponent()
        {
            var power = new PowerCalculator();
            int basee = 0; int exponent = 5;
            int result = power.CalculatePower(basee, exponent);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestZeroBaseZeroExponent()
        {
            var power = new PowerCalculator();
            int basee = 0; int exponent = 0;
            int result = power.CalculatePower(basee, exponent);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestOneBaseAnyExponent()
        {
            var power = new PowerCalculator();
            int basee = 1; int exponent = 100;
            int result = power.CalculatePower(basee, exponent);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestNegativeBaseEvenExponent()
        {
            var power = new PowerCalculator();
            int basee = -3; int exponent = 4;
            int result = power.CalculatePower(basee, exponent);
            Assert.AreEqual(81, result);
        }
        [TestMethod]
        public void TestNegativeBaseOddExponent()
        {
            var power = new PowerCalculator();
            int basee = -2; int exponent = 3;
            int result = power.CalculatePower(basee, exponent);
            Assert.AreEqual(-8, result);
        }
        [TestMethod]
        public void TestNegativeBaseNegativeExponent()
        {
            var power = new PowerCalculator();
            int basee = -2; int exponent = -2;
            int result = power.CalculatePower(basee, exponent);
            Assert.AreEqual(0.25, result);
        }
    }
}
