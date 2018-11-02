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
            ShoppingCartItem item1 = new ShoppingCartItem();
            ShoppingCartItem item2 = new ShoppingCartItem();
            target.AddItem(item1);
            target.AddItem(item2);
            Assert.Equal(2, target.Items.Count);
        }
    }
}
