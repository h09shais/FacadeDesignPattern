using Entities;

namespace BLL
{
    interface ICustomerOrder
    {
        void Finalize(Order[] orderDetails);
    }
}
