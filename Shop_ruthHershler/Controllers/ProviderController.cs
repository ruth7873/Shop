using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.API.Model;
using Shop.Core.Entities;
using Shop.Core.Service;
using Shop.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderService _providerService;
        private readonly IMapper _mapper;

        public ProviderController(IProviderService providerService,IMapper mapper)
        {
            _providerService = providerService;
            _mapper = mapper;
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
        public ActionResult Post([FromBody] ProviderPostModel provider)
        {
            var providerToAdd = _mapper.Map<Provider>(provider);
            var addedProvider = _providerService.AddProvider(providerToAdd);
            var newProduct = _providerService.GetProviderById(addedProvider.Id);
            //var productDto = _mapper.Map<OrderDto>(newProduct);
            return Ok(newProduct);
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
