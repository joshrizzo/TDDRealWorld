using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDRealWorld
{
    internal class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; internal set; }
        public double Total { get {
            var prices = Items.Select(item => item.Price).ToArray();
            return new Calculator().Add(prices);
        } }

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