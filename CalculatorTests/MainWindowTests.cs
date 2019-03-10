using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass]
    public class MainWindowTests
    {
        [TestMethod]
        public void CheckAddition()
        {
            Calc TestCalc = new Calc();
            TestCalc.firstNumber = 5;
            TestCalc.secondNumber = 8;
            TestCalc.answer = TestCalc.Add();
            Assert.AreEqual(13, TestCalc.answer, "Normal addition failed.");
        }

        [TestMethod]
        public void CheckAdditionWithDecimals()
        {
            Calc TestCalc = new Calc();
            TestCalc.firstNumber = 6.98;
            TestCalc.secondNumber = 4.0008;
            TestCalc.answer = TestCalc.Add();
            Assert.AreEqual(10.9808, TestCalc.answer, "Addition with decimals failed.");
        }

        [TestMethod]
        public void CheckSubtraction()
        {
            Calc TestCalc = new Calc();
            TestCalc.firstNumber = 23;
            TestCalc.secondNumber = 8;
            TestCalc.answer = TestCalc.Subtract();
            Assert.AreEqual(15, TestCalc.answer, "Normal subtraction failed.");
        }

        [TestMethod]
        public void CheckSubtractionWithDecimals()
        {
            Calc TestCalc = new Calc();
            TestCalc.firstNumber = 6.05;
            TestCalc.secondNumber = 0.05;
            TestCalc.answer = TestCalc.Subtract();
            Assert.AreEqual(6, TestCalc.answer, "Subtraction with decimals failed.");
        }

        [TestMethod]
        public void CheckMultiplication()
        {
            Calc TestCalc = new Calc();
            TestCalc.firstNumber = 30;
            TestCalc.secondNumber = 5;
            TestCalc.answer = TestCalc.Multiply();
            Assert.AreEqual(150, TestCalc.answer, "Normal multiplication failed.");
        }

        [TestMethod]
        public void CheckMultiplicationWithDecimals()
        {
            Calc TestCalc = new Calc();
            TestCalc.firstNumber = 1.25;
            TestCalc.secondNumber = 9.05;
            TestCalc.answer = TestCalc.Multiply();
            Assert.AreEqual(11.3125, TestCalc.answer, "Multiplication with decimals failed.");
        }

        [TestMethod]
        public void CheckDivision()
        {
            Calc TestCalc = new Calc();
            TestCalc.firstNumber = 30;
            TestCalc.secondNumber = 5;
            TestCalc.answer = TestCalc.Divide();
            Assert.AreEqual(6, TestCalc.answer, "Normal division failed.");
        }

        [TestMethod]
        public void CheckDivisionWithDecimals()
        {
            Calc TestCalc = new Calc();
            TestCalc.firstNumber = 7.5;
            TestCalc.secondNumber = 1.5;
            TestCalc.answer = TestCalc.Divide();
            Assert.AreEqual(5, TestCalc.answer, "Division with decimals failed.");
        }

        [TestMethod]
        public void CheckExponentiation()
        {
            Calc TestCalc = new Calc();
            TestCalc.firstNumber = 2;
            TestCalc.secondNumber = 4;
            TestCalc.answer = TestCalc.Exponentiate();
            Assert.AreEqual(16, TestCalc.answer, "Normal exponentiation failed.");
        }

        [TestMethod]
        public void CheckExponentiationWithDecimals()
        {
            Calc TestCalc = new Calc();
            TestCalc.firstNumber = 5.5;
            TestCalc.secondNumber = 2;
            TestCalc.answer = TestCalc.Exponentiate();
            Assert.AreEqual(30.25, TestCalc.answer, "Exponentiation with decimals failed.");
        }
        
    }
}