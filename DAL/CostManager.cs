using System;
using Entities;

namespace DAL
{
    public class CostManager : ICosting
    {
        public float ApplyDiscounts(Order order)
        {
            var price = order.Product.Price;
            var discountPercent = order.Product.DiscountPercent;
            Console.WriteLine("A discount of {0}% has been applied on the product's price of {1}", discountPercent, price);
            
            return order.Product.Price = price - discountPercent / 100 * price;
        }
    }
}
