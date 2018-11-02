using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDRealWorld
{
    internal class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; internal set; }
        public Calculator Calculator { get; }

        public double Total { get {
            var prices = Items.Select(item => item.Price).ToArray();
            return Calculator.Add(prices);
        } }

        public ShoppingCart(Calculator calculator)
        {
            Items = new List<ShoppingCartItem>();
            Calculator = calculator;
        }

        internal void AddItem(ShoppingCartItem item)
        {
            Items.Add(item);
        }
    }
}