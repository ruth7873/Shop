using Microsoft.AspNetCore.Mvc;
using Shop_ruthHershler.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private DataContext context;
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return context.Orders;
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var ord = context.Orders.Find(e => e.Id == id);
            if (ord == null)
                return NotFound();
            return Ok(ord);
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            context.Orders.Add(order);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Order order)
        {
            var ord = context.Orders.Find(e => e.Id == id);
            if (ord == null)
                return NotFound();
            context.Orders.Remove(ord);
            context.Orders.Add(order);
            return Ok();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var ord = context.Orders.Find(e => e.Id == id);
            if (ord == null)
                return NotFound();
            context.Orders.Remove(ord);
            return Ok();
        }
    }
}
