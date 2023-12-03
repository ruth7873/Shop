using Shop.Core.Entities;

namespace Shop.Core.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order GetOrderById(int id);
        void AddOrder(Order order);
        void UpdateOrder(int id,Order order);
        void DeleteOrder(int id);
    }
}
