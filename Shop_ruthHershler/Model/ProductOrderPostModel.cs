using Shop.Core.Entities;

namespace Shop.API.Model
{
    public class ProductOrderPostModel
    {
      //  public int OrderId { get; set; }
        public int ProductId { get; set; }
     //   public Order Order { get; set; }
     //   public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
