using Shop.Core.Entities;
using Shop.Core.Repositories;
using Shop.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
       public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productRepository.GetProductsAsync();
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetProductByIdAsync(id);
        }
        public async Task<Product> AddProductAsync(Product product)
        {
           return await _productRepository.AddProductAsync(product);
        }
        public async Task<Product> UpdateProductAsync(int id, Product product)
        {
           return await _productRepository.UpdateProductAsync(id, product);
        }
        public async Task<Product> UpdateProductPriceAsync(int id, int price)
        {
           return await _productRepository.UpdateProductPriceAsync(id, price);
        }
        public void DeleteProductAsync(int id)
        {
            _productRepository.DeleteProductAsync(id);
        }
    }
}
