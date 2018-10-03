using System;
using Entities;

namespace DAL
{
    public class InventoryManager : IInventory
    {
        private readonly IPaymentGateway _paymentGateWay = new PaymentGatewayManager();
        private readonly ICosting _costManger = new CostManager();
        public bool Update(Order order)
        {
            if (_paymentGateWay.VerifyCardDetails(order))
            {
                _costManger.ApplyDiscounts(order);
                _paymentGateWay.ProcessPayment(order);
                return InternalUpdate(order);
            }

            return false;
        }

        private bool InternalUpdate(Order order)
        {
            Console.WriteLine($"Product# {order.Product.Id} is subtracted from the store's inventory.");
            return true;
        }
    }
}
