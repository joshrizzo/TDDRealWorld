using System;
using System.Linq;

namespace TDDRealWorld
{
    internal class Calculator
    {
        virtual internal double Add(params double[] numbers)
        {
            return numbers.Sum();
        }
    }
}