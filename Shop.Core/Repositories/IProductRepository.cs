using Shop.Core.Entities;

namespace Shop.Core.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        Product AddProduct(Product product);
        Product UpdateProduct(int id,Product product);
        Product UpdateProductPrice(int id, int price);
        void DeleteProduct(int id);

    }
}
