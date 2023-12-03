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
        IEnumerable<Product> IProductService.GetProducts()
        {
            return _productRepository.GetProducts();
        }
        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }
        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }
        public void UpdateProduct(int id, Product product)
        {
            _productRepository.UpdateProduct(id, product);
        }
        public void UpdateProductPrice(int id, int price)
        {
            _productRepository.UpdateProductPrice(id, price);
        }
        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }
    }
}
