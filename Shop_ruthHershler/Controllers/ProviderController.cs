using Microsoft.AspNetCore.Mvc;
using Shop.Core.Entities;
using Shop.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderService _providerService;
        public ProviderController(IProviderService providerService)
        {
            _providerService = providerService;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_providerService.GetProviders());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var provider = _providerService.GetProviderById(id);
            if(provider == null)
                return NotFound();
            return Ok(provider);  
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult Post([FromBody] Provider provider)
        {
           return Ok(_providerService.AddProvider(provider));
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Provider provider)
        {
              return Ok(_providerService.UpdateProvider(id, provider));    
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           _providerService.DeleteProvider(id);
            return Ok();
        }
    }
}
