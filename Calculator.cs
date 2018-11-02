using System;
using System.Linq;

namespace TDDRealWorld
{
    internal class Calculator
    {
        internal double Add(params double[] numbers)
        {
            return numbers.Sum();
        }
    }
}