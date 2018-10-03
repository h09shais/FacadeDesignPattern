using Entities;

namespace DAL
{
    public interface IOrderVerify
    {
        bool VerifyShippingAddress(Order order);
    }
}
