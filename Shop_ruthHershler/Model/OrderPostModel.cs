using Shop.Core.Entities;

namespace Shop.API.Model
{
    public class OrderPostModel
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int SumOrder { get; set; }
        public List<ProductOrderPostModel> Products { get; set; }

    }
}
