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
            int actual;
            int expected = 10;

            // act
            actual = SimpleCalculations.Add(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Add_Int_Overflow_Exception()
        {
            // arrange 
            int number1 = 2000000000;
            int number2 = 2000000000;
            int actual;

            // act
            actual = SimpleCalculations.Add(number1, number2);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Add_List_AllDataOk_Sum()
        {
            // arrange 
            List<int> numberList = new List<int> { 3, 7, 5 };
            int actual;
            int expected = 15;
            
            // act
            actual = SimpleCalculations.Add(numberList);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Add_List_Overflow_Exception()
        {
            // arrange 
            List<int> numberList = new List<int> { 1000000000, 1000000000, 1000000000 };
            int actual;

            // act
            actual = SimpleCalculations.Add(numberList);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void U_SimpleCalculations_Add_List_EmptyList_Exception()
        {
            // arrange 
            List<int> numberList = new List<int>();
            int actual;

            // act
            actual = SimpleCalculations.Add(numberList);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Substract_Int_AllDataOk_Sum()
        {
            // arrange 
            int number1 = 8;
            int number2 = 3;
            int actual;
            int expected = 5;

            // act
            actual = SimpleCalculations.Substract(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Substract_Int_Overflow_Exception()
        {
            // arrange 
            int number1 = -2000000000;
            int number2 = 2000000000;
            int actual;

            // act
            actual = SimpleCalculations.Substract(number1, number2);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Substract_List_AllDataOk_Sum()
        {
            // arrange 
            List<int> numberList = new List<int> { 20, 5, 5 };
            int actual;
            int expected = 10;

            // act
            actual = SimpleCalculations.Substract(numberList);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Substract_List_Overflow_Exception()
        {
            // arrange 
            List<int> numberList = new List<int> { -1000000000, 1000000000, 1000000000 };
            int actual;

            // act
            actual = SimpleCalculations.Substract(numberList);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void U_SimpleCalculations_Substract_List_EmptyList_Exception()
        {
            // arrange 
            List<int> numberList = new List<int>();
            int actual;

            // act
            actual = SimpleCalculations.Substract(numberList);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Multiply_AllDataOK_Sum()
        {
            // arrange
            int number1 = 3;
            int number2 = 5;
            int actual;
            int expected = 15;

            // act
            actual = SimpleCalculations.Multiply(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Multiply_Int_Overflow_Exception()
        {
            // arrange 
            int number1 = 1000000000;
            int number2 = 1500000000;
            int actual;

            // act
            actual = SimpleCalculations.Multiply(number1, number2);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Multiply_Int_Overflow_Exception2()
        {
            // arrange 
            int number1 = -1000000000;
            int number2 = 1500000000;
            int actual;

            // act
            actual = SimpleCalculations.Multiply(number1, number2);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Multiply_ListInt_AllDataOK_Sum()
        {
            // arrange 
            List<int> numberlist = new List<int> { 2, 5, 3 };
            int actual;
            int expected = 30;

            // act
            actual = SimpleCalculations.Multiply(numberlist);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_SimpleCalculations_Divide_AllDataOK_Sum1()
        {
            // arrange
            int number1 = 25;
            int number2 = 5;
            int actual;
            int expected = 5;

            // act
            actual = SimpleCalculations.Divide(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_SimpleCalculations_Divide_Int_AllDataOK_Sum2()
        {
            // arrange
            int number1 = 5;
            int number2 = 2;
            int actual;
            int expected = 2;

            // act
            actual = SimpleCalculations.Divide(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void U_SimpleCalculations_Divide_Int_DivideByZero_Exception()
        {
            // arrange
            int number1 = 25;
            int number2 = 0;
            int actual;

            // act
            actual = SimpleCalculations.Divide(number1, number2);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Divide_Double_AllDataOK_Sum()
        {
            // arrange
            double number1 = 5;
            double number2 = 2;
            double actual;
            double expected = 2.5;

            // act
            actual = SimpleCalculations.Divide(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_SimpleCalculations_Divide_ListInt_AllDataOK_Sum()
        {
            // arrange
            List<int> numberList = new List<int> { 100, 10, 2 };
            int actual;
            int expectedResult = 5;

            // act
            actual = SimpleCalculations.Divide(numberList);

            // assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void U_SimpleCalculations_Divide_ListInt_DivideByZero_Exception()
        {
            // arrange
            List<int> numberList = new List<int> { 100, 10, 0 };
            int actual;

            // act
            actual = SimpleCalculations.Divide(numberList);

            // assert is handled by the ExpectedException
        }

        [TestMethod]
        public void U_SimpleCalculations_Modulus_int_AllDataOK_Remainder()
        {
            // arrange
            int number1 = 10;
            int number2 = 3;
            int actual;
            int expected = 1;

            // act
            actual = SimpleCalculations.Modulus(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void U_SimpleCalculations_Modulus_int_AllDataOK_Remainder2()
        {
            // arrange
            int number1 = 9;
            int number2 = 3;
            int actual;
            int expected = 0;

            // act
            actual = SimpleCalculations.Modulus(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
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
