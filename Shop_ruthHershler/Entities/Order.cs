namespace Shop_ruthHershler.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Dictionary<Product,int> Products { get; set; }
        public Provider CurrentProvider { get; set; }
        public  int SumOrder { get; set; }

    }
}
