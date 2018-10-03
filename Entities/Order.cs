using System;
using System.Linq;

namespace Entities
{
    public class Order
    {
        public Address Address { get; }
        public PaymentInfo PaymentInfo { get; }
        public Product Product { get; }

        private readonly Product[] _products = {
            new Product(1,
                "Product1",
                "Product description",
                500,
                10),
            new Product(2,
                "Product2",
                "Product description2",
                100,
                5)
        };
        public Order(int productId, string addressLine1, string addressLine2, string zip, int pinCode, string cardNo)
        {
            this.Product = _products.FirstOrDefault(src => src.Id == productId);
            this.Address = new Address(addressLine1, addressLine2, zip);
            this.PaymentInfo = new PaymentInfo(pinCode, cardNo);
        }
    }
}
