using System;
using Entities;

namespace DAL
{
    public class OrderVerificationManager : IOrderVerify
    {
        public bool VerifyShippingAddress(Order order)
        {
            Console.WriteLine($"The product can be shipped to the pincode {order.PaymentInfo.PinCode}.");
            return true;
        }
    }
}
