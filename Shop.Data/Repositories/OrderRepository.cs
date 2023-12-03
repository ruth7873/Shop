using Shop.Core.Entities;
using Shop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }
        public Order GetOrderById(int id)
        {
            return _context.Orders.Find(o => o.Id == id);  
        }
        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
        }
        public void UpdateOrder(int id, Order order)
        {
            Order order1 = _context.Orders.Find(o => o.Id == id);
        if(order1 != null) 
                _context.Orders.Remove(order1);
            _context.Orders.Add(order);
        }
        public void DeleteOrder(int id)
        {
            _context.Orders.Remove(_context.Orders.Find(o =>o.Id == id));
        }
    }
}
