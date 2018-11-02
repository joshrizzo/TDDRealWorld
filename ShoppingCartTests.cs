using System;
using System.Collections.Generic;
using Xunit;

namespace TDDRealWorld
{
    public class ShoppingCartTests
    {
        private static readonly FakeCalculator calculator = new FakeCalculator();
        private ShoppingCart target = new ShoppingCart(calculator);

        [Fact]
        public void AddItem_2Items_shouldHave2Items()
        {
            AddTestData();
            Assert.Equal(2, target.Items.Count);
        }

        [Fact]
        public void Total_with2Items_shouldSum2Items()
        {
            AddTestData();
            var result = target.Total;
            Assert.Equal(new double[] { 0, 0 }, calculator.calledSumWith);
        }

        [Fact]
        public void Total_with2Items_shouldCalculateTax()
        {
            AddTestData();
            var result = target.TotalWithTax;
            Assert.Equal(new double[] { 0, 1.078 }, calculator.calledMultiplyWith);
        }

        private void AddTestData()
        {
            var item1 = new ShoppingCartItem() { Price = 12, Quantity = 2 };
            var item2 = new ShoppingCartItem() { Price = 13, Quantity = 1 };
            target.AddItem(item1);
            target.AddItem(item2);
        }
    }

    internal class FakeCalculator : Calculator
    {
        public double[] calledSumWith;
        override internal double Add(params double[] numbers)
        {
            calledSumWith = numbers;
            return 0;
        }

        public double[] calledMultiplyWith;
        override internal double Multiply(params double[] numbers)
        {
            calledMultiplyWith = numbers;
            return 0;
        }
    }
}
