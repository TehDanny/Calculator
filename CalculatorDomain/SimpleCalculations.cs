using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("CalculatorTest")]

namespace CalculatorDomain
{
    public class SimpleCalculations
    {
        public SimpleCalculations()
        {
        }

        internal static void Add(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
