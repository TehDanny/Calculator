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

        internal static int Add(List<int> numberList)
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
    }
}
