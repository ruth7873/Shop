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
        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetOrders();
        }
        public Order GetOrderByID(int id)
        {
            return _orderRepository.GetOrderById(id);
        }
        public Order AddOrder(Order order)
        {
            return _orderRepository.AddOrder(order);
        }
        public Order UpdateOrder(int id, Order order)
        {
         return _orderRepository.UpdateOrder(id, order);
        }
        public void DeleteOrder(int id)
        {
            _orderRepository.DeleteOrder(id);
        }
    }
}
