using System;

namespace Entities
{
    public class Product
    {
        public Product(int id, string productName, string productDescription, float price, float discount)
        {
            this.Id = id;
            this.ProductName = productName;
            this.ProductDescription = productDescription;
            this.Price = price;
            this.DiscountPercent = discount;
        }

        public int Id { get; }
        public string ProductName { get; }
        public string ProductDescription { get; }
        public float Price { get; set; }
        public float DiscountPercent { get; }
    }
}