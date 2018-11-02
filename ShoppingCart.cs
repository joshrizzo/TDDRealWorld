using System;
using System.Collections.Generic;

namespace TDDRealWorld
{
    internal class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; internal set; }

        public ShoppingCart()
        {
            Items = new List<ShoppingCartItem>();
        }

        internal void AddItem(ShoppingCartItem item)
        {
            Items.Add(item);
        }
    }
}