using Microsoft.AspNetCore.Mvc;
using Shop.Core.Entities;
using Shop.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;     
        }
        
        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_orderService.GetAllOrders());
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var ord = _orderService.GetOrderByID(id);
            if (ord == null)
                return NotFound();
            return Ok(ord);
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult Post([FromBody] Order order)
        {
           return Ok( _orderService.AddOrder(order));
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Order order)
        {
          return Ok( _orderService.UpdateOrder(id,order));
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _orderService.DeleteOrder(id);
            return Ok();
        }
    }
}
