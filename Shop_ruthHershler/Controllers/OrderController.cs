using Microsoft.AspNetCore.Mvc;
using Shop_ruthHershler.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly static List<Order> orders = new List<Order>();
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return orders;
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var ord = orders.Find(e => e.Id == id);
            if (ord == null)
                return NotFound();
            return Ok(ord);
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            orders.Add(order);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Order order)
        {
            var ord = orders.Find(e => e.Id == id);
            if (ord == null)
                return NotFound();
            orders.Remove(ord);
            orders.Add(order);
            return Ok();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var ord = orders.Find(e => e.Id == id);
            if (ord == null)
                return NotFound();
            orders.Remove(ord);
            return Ok();
        }
    }
}
