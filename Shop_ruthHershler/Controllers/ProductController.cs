using Microsoft.AspNetCore.Mvc;
using Shop_ruthHershler.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private DataContext context;
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return context.Products ;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var prod = context.Products.Find(x => x.Id == id);
            if (prod == null)
                return NotFound();
            return Ok(prod);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            context.Products.Add(product);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            var prod = context.Products.Find(e => e.Id == id);
            if (prod == null)
                return NotFound();
            context.Products.Remove(prod);
            context.Products.Add(product);
            return Ok();
        }
        // PUT api/<EmployeeController>/5
        [HttpPut("{id}/price")]
        public IActionResult Put(int id, [FromBody]  int price)
        {
            var prod = context.Products.Find(e => e.Id == id);
            if (prod == null)
                return NotFound();
            prod.Price = price;
            return Ok();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(e => e.Id == id);
            if (product == null)
                return NotFound();
            context.Products.Remove(product);
            return Ok();
        }
    }
}
