using DAL;
using Entities;

namespace BLL
{
    public class CustomerOrder : ICustomerOrder
    {
        private readonly IInventory _inventory = new InventoryManager();
        private readonly IOrderVerify _orderVerify = new OrderVerificationManager();
        private readonly ILogistics _logistics = new LogisticsManager();
        public void Finalize(Order[] order)
        {
            foreach (var item in order)
            {
                SimpleFinalize(item);
            }
        }

        private void SimpleFinalize(Order order)
        {
            //Apparently poor logic, just for fun!

            var isUpdated = _inventory.Update(order);
            if (!isUpdated) return;

            var isVerified = _orderVerify.VerifyShippingAddress(order);
            if (!isVerified) return;

            _logistics.ShipProduct(order);
        }
    }
}
