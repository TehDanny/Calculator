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
        public static int Exponential(int number1, int number2)
        {
            int sum = number1;

            for (int i = 1; i < number2; i++)
            {
                sum = sum * number1;
            }

            return sum;
        }

        public static double SquareRoot(double number)
        {
            double root = number; // I chose this value, because the squareroot of 1 is 1
            double error = number - (root * root);
            for (int i = 1; i < 10000; i++)
            {
                if (error == 0)
                    return root;
                else if (error > 0)
                    root = root * (1 + error / 10);
                else if (error < 0)
                    root = root / (1 - error / 10);

                error = number - (root * root);
            }
            return root;
        }


        /*
        public static double SquareRoot(double number)
        {
            return SquareRootRecursive(0, number, number);
        }

        private static double SquareRootRecursive(double first, double last, double input)
        {
            double middle = (first + last) / 2;
            //double middle = input; // I chose this middle value, because the squareroot of 1 is 1

            if (middle * middle == input)
                return middle;
            else if (middle < input)
                first = middle + 1;
            else if (middle > input)
                last = middle - 1;

            if (first <= last)
                return SquareRootRecursive(first, last, input);

            return -1; // probably unreachable code
        }
        */

        public static double Solve(string mathProblem)
        {
            throw new NotImplementedException();
        }
    }
}
