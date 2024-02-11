using Shop.Core.Entities;
using Shop.Core.Repositories;
using Shop.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetOrdersAsync();
        }
        public async Task<Order> GetOrderByIDAsync(int id)
        {
            return await _orderRepository.GetOrderByIdAsync(id);
        }
        public async Task<Order> AddOrderAsync(Order order)
        {
            return await _orderRepository.AddOrderAsync(order);
        }
        public async Task<Order> UpdateOrderAsync(int id, Order order)
        {
         return await _orderRepository.UpdateOrderAsync(id, order);
        }
        public void DeleteOrder(int id)
        {
            _orderRepository.DeleteOrderAsync(id);
        }
    }
}
