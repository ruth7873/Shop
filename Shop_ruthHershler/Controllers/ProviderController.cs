using Microsoft.AspNetCore.Mvc;
using Shop_ruthHershler.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        readonly static List<Provider> providers = new List<Provider>();
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Provider> Get()
        {
            return providers;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var provider = providers.Find(x => x.Id == id);
            if(provider == null)
                return NotFound();
            return Ok(provider);  
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Provider provider)
        {
            providers.Add(provider);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Provider provider)
        {
            var provider2 = providers.Find(e => e.Id == id);
            if (provider2 == null)
                return NotFound();
            providers.Remove(provider2);
            providers.Add(provider);
            return Ok();            
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var provider = providers.Find(e => e.Id == id);
            if(provider == null)
                return NotFound();
            providers.Remove(provider);
            return Ok();
        }
    }
}
