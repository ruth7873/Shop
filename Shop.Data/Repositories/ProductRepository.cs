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
            return _context.Products.Find(id);
        }
        public Product AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;

        }
        public Product UpdateProduct(int id, Product product)
        {
            Product product1 = _context.Products.Find(id);
            if (product1 != null)
            {
                product1.Price = product.Price;
                product1.Qty = product.Qty;
                product1.Name=product.Name;
            }
            _context.SaveChanges();
            return product1;

        }
        public Product UpdateProductPrice(int id, int price)
        {
            Product product = _context.Products.Find(id);
            if (product != null)
                _context.Products.Find(id).Price = price;
            _context.SaveChanges();
            return product;

        }
        public void DeleteProduct(int id)
        {
            Product p = _context.Products.Find(id);
            if(p != null)
                _context.Products.Remove(p);   
            _context.SaveChanges();
        }
    }
}
