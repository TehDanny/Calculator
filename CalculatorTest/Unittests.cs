using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorDomain;
using System.Collections.Generic;

namespace CalculatorTest
{
    [TestClass]
    public class Unittests
    {
        [TestMethod]
        public void U_SimpleCalculations_Add_AllDataOk_SumReturned()
        {
            // arrange 
            int number1 = 5;
            int number2 = 5;
            int sum;
            int expectedResult = 10;

            // act
            sum = SimpleCalculations.Add(number1, number2);

            // assert
            Assert.AreEqual(sum, expectedResult);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Add_Overflow_Exception()
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
        public void U_SimpleCalculations_Add_List_AllDataOk_SumReturned()
        {
            // arrange 
            List<int> numberList = new List<int> { 3, 7, 5 };
            int sum;
            int expectedResult = 15;
            
            // act
            sum = SimpleCalculations.Add(numberList);

            // assert
            Assert.AreEqual(sum, expectedResult);
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
        public void U_SimpleCalculations_Substract_AllDataOk_SumReturned()
        {
            // arrange 
            int number1 = 8;
            int number2 = 3;
            int sum;
            int expectedResult = 5;

            // act
            sum = SimpleCalculations.Substract(number1, number2);

            // assert
            Assert.AreEqual(sum, expectedResult);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Substract_Overflow_Exception()
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
        public void U_SimpleCalculations_Substract_List_AllDataOk_SumReturned()
        {
            // arrange 
            List<int> numberList = new List<int> { 20, 5, 5 };
            int sum;
            int expectedResult = 10;

            // act
            sum = SimpleCalculations.Substract(numberList);

            // assert
            Assert.AreEqual(sum, expectedResult);
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
        public void U_SimpleCalculations_Multiply_AllDataOK_SumReturned()
        {
            // arrange
            int number1 = 3;
            int number2 = 5;
            int sum;
            int expectedResult = 15;

            // act
            sum = SimpleCalculations.Multiply(number1, number2);

            // assert
            Assert.AreEqual(sum, expectedResult);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Multiply_Overflow_Exception()
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
        public void U_SimpleCalculations_Divide_AllDataOK_SumReturned()
        {
            // arrange
            int number1 = 25;
            int number2 = 5;
            int sum;
            int expectedResult = 5;

            // act
            sum = SimpleCalculations.Divide(number1, number2);

            // assert
            Assert.AreEqual(sum, expectedResult);
        }
    }
}
