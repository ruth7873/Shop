using Shop.Core.DTOs;
using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core
{
    public class Mapping
    {
        public OrderDto MapToOrderDto(Order order)
        {
            return new OrderDto { Id = order.Id, ProviderId = order.ProviderId, SumOrder = order.SumOrder  };
        }
    }
}
