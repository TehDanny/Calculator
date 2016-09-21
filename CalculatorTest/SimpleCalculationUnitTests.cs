using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorDomain;
using System.Collections.Generic;

namespace CalculatorTest
{
    [TestClass]
    public class SimpleCalculationUnitTests
    {
        [TestMethod]
        public void U_SimpleCalculations_Add_Int_AllDataOk_Sum()
        {
            // arrange 
            int number1 = 5;
            int number2 = 5;
            int sum;
            int expectedResult = 10;

            // act
            sum = SimpleCalculations.Add(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Add_Int_Overflow_Exception()
        {
            // arrange 
            int number1 = 2000000000;
            int number2 = 2000000000;
            int sum;

            // act
            sum = SimpleCalculations.Add(number1, number2);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Add_List_AllDataOk_Sum()
        {
            // arrange 
            List<int> numberList = new List<int> { 3, 7, 5 };
            int sum;
            int expectedResult = 15;
            
            // act
            sum = SimpleCalculations.Add(numberList);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Add_List_Overflow_Exception()
        {
            // arrange 
            List<int> numberList = new List<int> { 1000000000, 1000000000, 1000000000 };
            int sum;

            // act
            sum = SimpleCalculations.Add(numberList);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void U_SimpleCalculations_Add_List_EmptyList_Exception()
        {
            // arrange 
            List<int> numberList = new List<int>();
            int sum;

            // act
            sum = SimpleCalculations.Add(numberList);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Substract_Int_AllDataOk_Sum()
        {
            // arrange 
            int number1 = 8;
            int number2 = 3;
            int sum;
            int expectedResult = 5;

            // act
            sum = SimpleCalculations.Substract(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Substract_Int_Overflow_Exception()
        {
            // arrange 
            int number1 = -2000000000;
            int number2 = 2000000000;
            int sum;

            // act
            sum = SimpleCalculations.Substract(number1, number2);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Substract_List_AllDataOk_Sum()
        {
            // arrange 
            List<int> numberList = new List<int> { 20, 5, 5 };
            int sum;
            int expectedResult = 10;

            // act
            sum = SimpleCalculations.Substract(numberList);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Substract_List_Overflow_Exception()
        {
            // arrange 
            List<int> numberList = new List<int> { -1000000000, 1000000000, 1000000000 };
            int sum;

            // act
            sum = SimpleCalculations.Substract(numberList);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void U_SimpleCalculations_Substract_List_EmptyList_Exception()
        {
            // arrange 
            List<int> numberList = new List<int>();
            int sum;

            // act
            sum = SimpleCalculations.Substract(numberList);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Multiply_AllDataOK_Sum()
        {
            // arrange
            int number1 = 3;
            int number2 = 5;
            int sum;
            int expectedResult = 15;

            // act
            sum = SimpleCalculations.Multiply(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Multiply_Int_Overflow_Exception()
        {
            // arrange 
            int number1 = 1000000000;
            int number2 = 1500000000;
            int sum;

            // act
            sum = SimpleCalculations.Multiply(number1, number2);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Multiply_Int_Overflow_Exception2()
        {
            // arrange 
            int number1 = -1000000000;
            int number2 = 1500000000;
            int sum;

            // act
            sum = SimpleCalculations.Multiply(number1, number2);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Multiply_ListInt_AllDataOK_Sum()
        {
            // arrange 
            List<int> numberlist = new List<int> { 2, 5, 3 };
            int sum;
            int expectedResult = 30;

            // act
            sum = SimpleCalculations.Multiply(numberlist);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        public void U_SimpleCalculations_Divide_AllDataOK_Sum()
        {
            // arrange
            int number1 = 25;
            int number2 = 5;
            int sum;
            int expectedResult = 5;

            // act
            sum = SimpleCalculations.Divide(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        public void U_SimpleCalculations_Divide_Int_AllDataOK_Sum2()
        {
            // arrange
            int number1 = 5;
            int number2 = 2;
            int sum;
            int expectedResult = 2;

            // act
            sum = SimpleCalculations.Divide(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void U_SimpleCalculations_Divide_Int_DivideByZero_Exception()
        {
            // arrange
            int number1 = 25;
            int number2 = 0;
            int sum;

            // act
            sum = SimpleCalculations.Divide(number1, number2);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Divide_Double_AllDataOK_Sum()
        {
            // arrange
            double number1 = 5;
            double number2 = 2;
            double sum;
            double expectedResult = 2.5;

            // act
            sum = SimpleCalculations.Divide(number1, number2);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        public void U_SimpleCalculations_Divide_ListInt_AllDataOK_Sum()
        {
            // arrange
            List<int> numberList = new List<int> { 100, 10, 2 };
            int sum;
            int expectedResult = 5;

            // act
            sum = SimpleCalculations.Divide(numberList);

            // assert
            Assert.AreEqual(expectedResult, sum);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void U_SimpleCalculations_Divide_ListInt_DivideByZero_Exception()
        {
            // arrange
            List<int> numberList = new List<int> { 100, 10, 0 };
            int sum;

            // act
            sum = SimpleCalculations.Divide(numberList);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_SwitchSign_PositiveNumber_NegativeNumber()
        {
            // arrange
            int number = 5;
            int actual;
            int expected = -5;

            // act
            actual = SimpleCalculations.SwitchSign(number);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_SimpleCalculations_SwitchSign_NegativeNumber_PositiveNumber()
        {
            // arrange
            int number = -17;
            int actual;
            int expected = 17;

            // act
            actual = SimpleCalculations.SwitchSign(number);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
