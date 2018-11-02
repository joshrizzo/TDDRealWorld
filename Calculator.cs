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

        virtual internal double Multiply(params double[] numbers)
        {
            double total = 1;
            foreach (var number in numbers) {
                total *= number;
            }
            return total; 
        }
    }
}