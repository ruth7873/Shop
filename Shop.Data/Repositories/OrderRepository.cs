using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return await _context.Orders.Include(o => o.Products).ToListAsync();
        }
        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _context.Orders.Include(o=>o.Products).FirstAsync(o=>o.Id==id);
        }
        public async Task<Order> AddOrderAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }
        public async Task<Order> UpdateOrderAsync(int id, Order order)
        {
            Order order1 = _context.Orders.Find(id);
            if (order1 != null)
            {
                //order1.Count=order.Count;
                order1.SumOrder = order.SumOrder;
                //order1.ProductId = order.ProductId;
                order1.ProviderId = order.ProviderId;
            }
            await _context.SaveChangesAsync();
            return order1;

        }
        public async void DeleteOrderAsync(int id)
        {
            var ord = await _context.Orders.FindAsync(id);
            if (ord != null)
            {
                _context.Orders.Remove(ord);
                await _context.SaveChangesAsync();
            }

        }
    }
}
