using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("NameOfTestAssembly")]

namespace CalculatorDomain
{
    public static class AdvancedCalculations
    {
        internal static int Exponential(int number1, int number2)
        {
            int sum = number1;

            for (int i = 1; i < number2; i++)
            {
                sum = sum * number1;
            }

            return sum;
        }

        internal static int SquareRoot(int number)
        {
            int sum = 0;



            return sum;
        }
    }
}
