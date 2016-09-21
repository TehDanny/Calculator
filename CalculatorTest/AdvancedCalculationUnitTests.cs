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
            double sum;
            double number = 9;
            double expectedResult = 3;

            // act
            sum = AdvancedCalculations.SquareRoot(number);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        public void U_AdvancedCalculations_SquareRoot_AllDataOK_Sum2()
        {
            // arange
            double number = 1;
            double actual;
            double expected = 1;

            // act
            actual = AdvancedCalculations.SquareRoot(number);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_AdvancedCalculations_SquareRoot_AllDataOK_Sum3()
        {
            // arange
            double number = 12.25;
            double actual;
            double expected = 3.5;

            // act
            actual = AdvancedCalculations.SquareRoot(number);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.
        }

        [TestMethod]
        public void U_AdvancedCalculations_Solve_AllDataOK_X() // solve x, where x is unknown. Syntax is a string with "
        {
            // arange
            string mathProblem = "3+x=10,x";
            double expected;
            double actual = 7;

            // act
            expected = AdvancedCalculations.Solve(mathProblem);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
