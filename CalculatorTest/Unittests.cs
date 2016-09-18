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
            int sum;
            int expectedResult = 10;

            // act
            sum = SimpleCalculations.Add(5, 5);

            // assert
            Assert.AreEqual(sum, expectedResult);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void U_SimpleCalculations_Add_Overflow_Exception()
        {
            // arrange 
            int sum;

            // act
            sum = SimpleCalculations.Add(2000000000, 2000000000);

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
    }
}
