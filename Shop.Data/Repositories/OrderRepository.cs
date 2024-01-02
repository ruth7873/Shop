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
            return _context.Orders.Find(id);
        }
        public Order AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }
        public Order UpdateOrder(int id, Order order)
        {
            Order order1 = _context.Orders.Find(id);
            if (order1 != null)
            {
                order1.Count=order.Count;
                order1.SumOrder = order.SumOrder;
                order1.ProductId = order.ProductId;
                order1.ProviderId = order.ProviderId;
            }
            _context.SaveChanges();
            return order1;

        }
        public void DeleteOrder(int id)
        {
            _context.Orders.Remove(_context.Orders.Find(id));
            _context.SaveChanges();

        }
    }
}
