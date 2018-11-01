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
    }
}
