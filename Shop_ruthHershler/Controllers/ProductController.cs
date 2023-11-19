using Microsoft.AspNetCore.Mvc;
using Shop_ruthHershler.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly static List<Product> products = new List<Product>();
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var prod = products[id];
            if (prod == null)
                return NotFound();
            return Ok(prod);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            products.Add(product);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<Product> Put(int id, [FromBody] Product product)
        {
            var prod = products.Find(e => e.Id == id);
            if (prod == null)
                return NotFound();
            products.Remove(prod);
            products.Add(product);
            return Ok();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<Product> Delete(int id)
        {
            var product = products.Find(e => e.Id == id);
            if (product == null)
                return NotFound();
            products.Remove(product);
            return Ok();
        }
    }
}
