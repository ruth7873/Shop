using Microsoft.AspNetCore.Mvc;
using Shop.Core.Entities;
using Shop.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetProducts());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var prod = _productService.GetProductById(id);
            if (prod == null)
                return NotFound();
            return Ok(prod);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
          return Ok(_productService.AddProduct(product));
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Product product)
        {
            return Ok(   _productService.UpdateProduct(id, product));
        }
        // PUT api/<EmployeeController>/5
        [HttpPut("{id}/price")]
        public ActionResult Put(int id, [FromBody]  int price)
        {
          return Ok( _productService.UpdateProductPrice(id, price));
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
          _productService.DeleteProduct(id);
            return Ok();
        }
    }
}
