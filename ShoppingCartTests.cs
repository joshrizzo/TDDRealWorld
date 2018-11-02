using System;
using Xunit;

namespace TDDRealWorld
{
    public class ShoppingCartTests
    {
        private ShoppingCart target = new ShoppingCart();

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
        public void Total_with2Items_shouldSumTo24()
        {
            var item1 = new ShoppingCartItem() { Price = 12 };
            var item2 = new ShoppingCartItem() { Price = 12 };
            target.AddItem(item1);
            target.AddItem(item2);
            Assert.Equal(24, target.Total);
        }
    }
}
