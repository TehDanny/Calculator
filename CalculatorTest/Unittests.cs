using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorDomain;

namespace CalculatorTest
{
    [TestClass]
    public class Unittests
    {
        [TestMethod]
        public void TestMethod1()
        {
            SimpleCalculations.Add(5, 5);
        }
    }
}
