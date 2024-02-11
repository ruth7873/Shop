using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderByIDAsync(int id);
        Task<Order> AddOrderAsync(Order order);
        Task<Order> UpdateOrderAsync(int id, Order order);
        void DeleteOrderAsync(int id);
    }
}
