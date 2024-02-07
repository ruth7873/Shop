using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int SumOrder { get; set; }
        public List<ProductOrderDto> Products { get; set; }

    }
}
