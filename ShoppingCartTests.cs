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
            var item1 = new ShoppingCartItem();
            var item2 = new ShoppingCartItem();
            target.AddItem(item1);
            target.AddItem(item2);
            Assert.Equal(2, target.Items.Count);
        }

        [Fact]
        public void Total_with2Items_shouldSum2Items()
        {
            var item1 = new ShoppingCartItem() { Price = 12 };
            var item2 = new ShoppingCartItem() { Price = 13 };
            target.AddItem(item1);
            target.AddItem(item2);
            var result = target.Total;
            Assert.Equal(0, result);
        }
    }

    internal class FakeCalculator : Calculator
    {
        override internal double Add(params double[] numbers)
        {
            return 0;
        }
    }
}
