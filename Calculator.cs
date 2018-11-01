using System;
using System.Linq;

namespace TDDRealWorld
{
    internal class Calculator
    {
        internal int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}