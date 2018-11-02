using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDRealWorld
{
    internal class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; internal set; }
        public Calculator Calculator { get; }

        public double Total
        {
            get
            {
                var prices = Items.Select(item =>
                                Calculator.Multiply(item.Price, item.Quantity)
                            ).ToArray();
                return Calculator.Add(prices);
            }
        }

        public object TotalWithTax
        {
            get
            {
                return Calculator.Multiply(Total, Tax);
            }
        }

        public double Tax { get; set; }

        public ShoppingCart(Calculator calculator)
        {
            Items = new List<ShoppingCartItem>();
            Calculator = calculator;
            Tax = 1.078;
        }

        internal void AddItem(ShoppingCartItem item)
        {
            Items.Add(item);
        }
    }
}