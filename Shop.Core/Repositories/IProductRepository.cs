using Shop.Core.Entities;

namespace Shop.Core.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> AddProductAsync(Product product);
        Task<Product> UpdateProductAsync(int id, Product product);
        Task<Product> UpdateProductPriceAsync(int id, int price);
        void DeleteProductAsync(int id);

    }
}
