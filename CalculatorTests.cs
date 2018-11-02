using System;
using Xunit;

namespace TDDRealWorld
{
    public class CalculatorTests
    {
        private Calculator target = new Calculator();

        [Fact]
        public void Add_2Plus2_shouldEqual4()
        {
            var result = target.Add(2, 2);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Add_5Minus3_shouldEqual2()
        {
            var result = target.Add(5, -3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_5Minus3Plus5_shouldEqual7()
        {
            var result = target.Add(5, -3, 5);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Multiple_5and3_shouldEqual15()
        {
            var result = target.Multiply(5, 3);
            Assert.Equal(15, result);
        }
    }
}
