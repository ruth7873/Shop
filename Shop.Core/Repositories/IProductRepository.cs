using Shop.Core.Entities;

namespace Shop.Core.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(int id,Product product);
        void UpdateProductPrice(int id, int price);
        void DeleteProduct(int id);

    }
}
