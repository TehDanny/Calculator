using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorDomain;

namespace CalculatorTest
{
    [TestClass]
    public class AdvancedCalculationUnitTests
    {
        [TestMethod]
        public void U_AdvancedCalculations_Exponentiel_AllDataOK_Sum()
        {
            // arange
            int sum;
            int number1 = 3;
            int number2 = 2;
            int expectedResult = 9;

            // act
            sum = AdvancedCalculations.Exponential(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        public void U_AdvancedCalculations_Exponentiel_AllDataOK_Sum2()
        {
            // arange
            int sum;
            int number1 = 3;
            int number2 = 3;
            int expectedResult = 27;

            // act
            sum = AdvancedCalculations.Exponential(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        public void U_AdvancedCalculations_SquareRoot_AllDataOK_Sum()
        {
            // arange
            int sum;
            int number = 9;
            int expectedResult = 3;

            // act
            sum = AdvancedCalculations.SquareRoot(number);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

    }
}
