using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("CalculatorTest")]

namespace CalculatorDomain
{
    public static class SimpleCalculations
    {
        public static int Add(int number1, int number2)
        {
            int sum;

            try
            {
                sum = checked(number1 + number2);
            }
            catch (OverflowException)
            {
                throw;
            }

            return sum;
        }

        public static int Add(List<int> numberList)
        {
            int sum = 0;

            if (numberList.Count == 0)
                throw new ArgumentNullException();

            try
            {
                foreach (var number in numberList)
                {
                    sum = checked(sum + number);
                }
            }
            catch (OverflowException)
            {
                throw;
            }

            return sum;
        }

        public static int Substract(int number1, int number2)
        {
            int sum = 0;

            try
            {
                sum = checked(number1 - number2);
            }
            catch (OverflowException)
            {
                throw;
            }

            return sum;
        }

        public static int Substract(List<int> numberList)
        {
            int sum = 0;
            bool firstNumber = true;

            if (numberList.Count == 0)
                throw new ArgumentNullException();

            foreach (var number in numberList)
            {
                if (firstNumber == true)
                {
                    sum = number;
                    firstNumber = false;
                }
                else
                    sum = checked(sum - number);
            }

            return sum;
        }

        public static int Multiply(int number1, int number2)
        {
            int sum;

            sum = checked(number1 * number2);

            return sum;
        }

        public static int Multiply(List<int> numberlist)
        {
            int sum = 0;
            bool firstNumber = true;

            foreach (var number in numberlist)
            {
                if (firstNumber == true)
                {
                    sum = number;
                    firstNumber = false;
                }
                else
                    sum = sum * number;
            }

            return sum;
        }

        public static int Divide(int number1, int number2)
        {
            int sum = 0;

            sum = number1 / number2;

            return sum;
        }

        public static double Divide(double number1, double number2)
        {
            double sum = 0;

            sum = number1 / number2;

            return sum;
        }

        public static int Divide(List<int> numberList)
        {
            int sum = 0;
            bool firstNumber = true;

            foreach (var number in numberList)
            {
                if (firstNumber == true)
                {
                    sum = number;
                    firstNumber = false;
                }
                else
                    sum = checked(sum / number);
            }

            return sum;
        }

        public static int SwitchSign(int number)
        {
            int switchedNumber;

            switchedNumber = number * -1;

            return switchedNumber;
        }

        public static int Modulus(int number1, int number2)
        {
            int remainder;

            remainder = number1 % number2;

            return remainder;
        }
    }
}
