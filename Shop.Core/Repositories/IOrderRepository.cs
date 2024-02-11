using Shop.Core.Entities;

namespace Shop.Core.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetOrdersAsync();
        Task<Order> GetOrderByIdAsync(int id);
        Task<Order> AddOrderAsync(Order order);
        Task<Order> UpdateOrderAsync(int id, Order order);
        void DeleteOrderAsync(int id);
    }
}
