using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }
        public async Task<Product> AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task<Product> UpdateProductAsync(int id, Product product)
        {
            Product product1 = _context.Products.Find(id);
            if (product1 != null)
            {
                product1.Price = product.Price;
                product1.Quantity = product.Quantity;
                product1.Name = product.Name;
            }
            await _context.SaveChangesAsync();
            return product1;

        }
        public async Task<Product> UpdateProductPriceAsync(int id, int price)
        {
            Product product = _context.Products.Find(id);
            if (product != null)
                _context.Products.Find(id).Price = price;
            await _context.SaveChangesAsync();
            return product;

        }
        public async void DeleteProductAsync(int id)
        {
            Product p = _context.Products.Find(id);
            if (p != null)
                _context.Products.Remove(p);
            await _context.SaveChangesAsync();
        }
    }
}
