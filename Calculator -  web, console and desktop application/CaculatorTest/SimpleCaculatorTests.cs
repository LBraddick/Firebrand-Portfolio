using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.Caculator.Libary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Caculator.Libary.Tests
{
    [TestClass()]
    public class SimpleCaculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            SimpleCaculator calc = new SimpleCaculator();
            int ExpectedResult = 15;
            int ActualResult = 0;

            ActualResult = calc.Add(10, 5);

            Assert.AreEqual(ExpectedResult, ActualResult, "Expexted and actual values do not match");

        }

        [TestMethod()]
        public void SubTest()
        {
            SimpleCaculator calc = new SimpleCaculator();
            int ExpectedResult = 5;
            int ActualResult = 0;

            ActualResult = calc.Sub(10, 5);

            Assert.AreEqual(ExpectedResult, ActualResult, "Expexted and actual values do not match");
        }

        [TestMethod()]
        public void DivTest()
        {
            SimpleCaculator calc = new SimpleCaculator();
            int ExpectedResult = 2;
            int ActualResult = 0;

            ActualResult = calc.Div(10, 5);

            Assert.AreEqual(ExpectedResult, ActualResult, "Expexted and actual values do not match");
        }

        [TestMethod()]
        public void MulTest()
        {
            SimpleCaculator calc = new SimpleCaculator();
            int ExpectedResult = 50;
            int ActualResult = 0;

            ActualResult = calc.Mul(10, 5);

            Assert.AreEqual(ExpectedResult, ActualResult, "Expexted and actual values do not match");
        }
    }
}