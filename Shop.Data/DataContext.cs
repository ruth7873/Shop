using Shop.Core.Entities;

namespace Shop.Data
{
    public class DataContext
    {
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public List<Provider> Providers { get; set; } 


        public DataContext()
        {
            Orders= new List<Order>();
            Products =  new List<Product>();
            Providers= new List<Provider>();
        }

    }
}
