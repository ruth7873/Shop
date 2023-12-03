namespace Shop.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Count {  get; set; }
        public int ProviderId { get; set; }
        public  int SumOrder { get; set; }

    }
}
