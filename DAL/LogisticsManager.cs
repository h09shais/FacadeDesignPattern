using System;
using Entities;

namespace DAL
{
    public class LogisticsManager : ILogistics
    {
        public void ShipProduct(Order order)
        {
            var productName = order.Product.ProductName;
            var shippingAddress = $"{order.Address.AddressLine1}, {order.Address.AddressLine2} - {order.PaymentInfo.PinCode}.";
            Console.WriteLine($"Congratulations your product {productName} has been shipped at the following address: {shippingAddress}");
        }
    }
}
