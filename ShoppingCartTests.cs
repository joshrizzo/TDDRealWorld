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
        public void Total_with2Items_shouldCalculateTaxOnApplicableItems()
        {
            AddTestData();
            var result = target.TotalWithTax;
            Assert.Equal(2, calculator.calledMultiplyWith.Count);
            Assert.Contains(new double[] { 12, 2, 0.078 }, calculator.calledMultiplyWith);
            Assert.Contains(new double[] { 13, 1, 1 }, calculator.calledMultiplyWith);
        }

        private void AddTestData()
        {
            var item1 = new ShoppingCartItem() { Price = 12, Quantity = 2, Taxable = true };
            var item2 = new ShoppingCartItem() { Price = 13, Quantity = 1, Taxable = false };
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

        public List<double[]> calledMultiplyWith = new List<double[]>();
        override internal double Multiply(params double[] numbers)
        {
            calledMultiplyWith.Add(numbers);
            return 0;
        }
    }
}
