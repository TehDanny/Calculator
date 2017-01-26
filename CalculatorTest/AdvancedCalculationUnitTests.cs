using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorDomain;

namespace CalculatorTest
{
    [TestClass]
    public class AdvancedCalculationUnitTests
    {
        [TestMethod]
        public void U_AdvancedCalculations_Exponentiel_AllDataOK_Sum1()
        {
            // arange
            int number1 = 3;
            int number2 = 2;
            int actual;
            int expected = 9;

            // act
            actual = AdvancedCalculations.Exponential(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_AdvancedCalculations_Exponentiel_AllDataOK_Sum2()
        {
            // arange
            int number1 = 3;
            int number2 = 3;
            int actual;
            int expected = 27;

            // act
            actual = AdvancedCalculations.Exponential(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_AdvancedCalculations_SquareRoot_AllDataOK_Sum1()
        {
            // arange
            double number = 9;
            double actual;
            double expected = 3;

            // act
            actual = AdvancedCalculations.SquareRoot(number);

            // assert
            Assert.AreEqual(expected, actual);
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
        }

        [TestMethod]
        public void U_AdvancedCalculations_Solve_AllDataOK_X() // solve x, where x is unknown. Syntax is a string with "
        {
            // arange
            string mathProblem = "3+x=10,x";
            double actual;
            double expected = 7;

            // act
            actual = AdvancedCalculations.Solve(mathProblem);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_AdvancedCalculations_Factorial_AllDataOK_Sum1()
        {
            // arange
            int number = 4;
            int actual;
            int expected = 24;

            // act
            actual = AdvancedCalculations.Factorial(number);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_AdvancedCalculations_Factorial_AllDataOK_Sum2()
        {
            // arange
            int number = 10;
            int actual;
            int expected = 3628800;

            // act
            actual = AdvancedCalculations.Factorial(number);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_AdvancedCalculations_Factorial_AllDataOK_Sum3()
        {
            // arange
            int number = 1;
            int actual;
            int expected = 1;

            // act
            actual = AdvancedCalculations.Factorial(number);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void U_AdvancedCalculations_Factorial_InvalidData_Exception()
        {
            // arange
            int number = -5;
            int actual;

            // act
            actual = AdvancedCalculations.Factorial(number);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_AdvancedCalculations_Sum_AllDataOK_Sum1()
        {
            // arange
            int number = 4;
            int actual;
            int expected = 10;

            // act
            actual = AdvancedCalculations.Sum(number);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_AdvancedCalculations_Sum_AllDataOK_Sum2()
        {
            // arange
            int number = 25;
            int actual;
            int expected = 325;

            // act
            actual = AdvancedCalculations.Sum(number);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void U_AdvancedCalculations_Sum_InvalidData_Exception()
        {
            // arange
            int number = -5;
            int actual;

            // act
            actual = AdvancedCalculations.Sum(number);

            // assert is handled by the ExpectedException
        }
    }
}
