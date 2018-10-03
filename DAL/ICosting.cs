using Entities;

namespace DAL
{
    public interface ICosting
    {
        float ApplyDiscounts(Order order);
    }
}
