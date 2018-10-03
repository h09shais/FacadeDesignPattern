using Entities;

namespace DAL
{
    public interface IPaymentGateway
    {
        bool VerifyCardDetails(Order order);
        bool ProcessPayment(Order order);
    }
}
