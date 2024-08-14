﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            double sum = num1 + num2;
            double answer = SimpleMath.Add(num1, num2);

            Assert.AreEqual(sum, answer);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-2, -2)]
        [DataRow(5, -5)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method
            double product = num1 * num2;
            double answer = SimpleMath.Multiply(num1, num2);

            Assert.AreEqual(product, answer);
        }

        [TestMethod]
        [DataRow(5, 0)]
        [DataRow(-10, 0)]
        [DataRow(0, 100)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
            
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        public void Divide_TwoValidNumbers_ThrowsArgumentException(double num1, double num2)
        {
            Assert.Fail();
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        public void Subtract_TwoValidNumbers_ThrowsArgumentException(double num1, double num2)
        {
            Assert.Fail();
        }
    }
}