using Shop.Core.Entities;
using Shop.Core.Repositories;

namespace Shop.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }
        public Product GetProductById(int id)
        {
            return _context.Products.ToList().Find(p => p.Id == id);
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }
        public void UpdateProduct(int id, Product product)
        {
            Product product1 = _context.Products.ToList().Find(p => p.Id == id);
            if (product1 != null)
                _context.Products.Remove(product1);
            _context.Products.Add(product);
        }
        public void UpdateProductPrice(int id, int price)
        {
            Product product = _context.Products.ToList().Find(p => p.Id == id);
            if (product != null)
                _context.Products.ToList().Find(p => p.Id == id).Price = price;
        }
        public void DeleteProduct(int id)
        {
            Product p = _context.Products.ToList().Find(p => p.Id == id);
            if(p != null)
                _context.Products.Remove(p);    
        }
    }
}
