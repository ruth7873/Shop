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
        IEnumerable<Order> GetAllOrders();
        Order GetOrderByID(int id);
        void AddOrder(Order order);
        void UpdateOrder(int id,Order order);
        void DeleteOrder(int id);
    }
}
