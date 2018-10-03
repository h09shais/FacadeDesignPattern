using System;
using Entities;

namespace DAL
{
    public class PaymentGatewayManager : IPaymentGateway
    {
        public bool VerifyCardDetails(Order order)
        {
            var cardNo = order.PaymentInfo.CardNo;
            Console.WriteLine($"Card# {cardNo} has been verified and is accepted.");
            return true;
        }

        public bool ProcessPayment(Order order)
        {
            var cardNo = order.PaymentInfo.CardNo;
            var cost = order.Product.Price;
            Console.WriteLine($"Card# {cardNo} is used to make a payment of {cost}.");
            return true;
        }
    }
}
