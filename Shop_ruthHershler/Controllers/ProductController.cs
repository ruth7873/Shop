using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.API.Model;
using Shop.Core.DTOs;
using Shop.Core.Entities;
using Shop.Core.Service;
using Shop.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetProductsAsync();
            return Ok(products);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var prod = await _productService.GetProductByIdAsync(id);
            if (prod == null)
                return NotFound();
            return Ok(prod);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductPostModel product)
        {
            var productToAdd = _mapper.Map<Product>(product);
            var addedProduct = await _productService.AddProductAsync(productToAdd);
            var newProduct = await _productService.GetProductByIdAsync(addedProduct.Id);
            //var productDto = _mapper.Map<OrderDto>(newProduct);
            return Ok(newProduct);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Product product)
        {
            var p = await _productService.UpdateProductAsync(id, product);
            return Ok(p);
        }
        // PUT api/<EmployeeController>/5
        [HttpPut("{id}/price")]
        public async Task<IActionResult> Put(int id, [FromBody] int price)
        {
            var p = await _productService.UpdateProductPriceAsync(id, price);
            return Ok(p);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _productService.DeleteProductAsync(id);
            return Ok();
        }
    }
}
