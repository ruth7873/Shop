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

        public ProviderController(IProviderService providerService, IMapper mapper)
        {
            _providerService = providerService;
            _mapper = mapper;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var p=await _providerService.GetProvidersAsync();
            return Ok(p);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var provider =await _providerService.GetProviderByIdAsync(id);
            if (provider == null)
                return NotFound();
            return Ok(provider);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProviderPostModel provider)
        {
            var providerToAdd = _mapper.Map<Provider>(provider);
            var addedProvider =await _providerService.AddProviderAsync(providerToAdd);
            var newProduct =await _providerService.GetProviderByIdAsync(addedProvider.Id);
            //var productDto = _mapper.Map<OrderDto>(newProduct);
            return Ok(newProduct);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Provider provider)
        {
            var p = await _providerService.UpdateProviderAsync(id, provider);
            return Ok(p);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _providerService.DeleteProviderAsync(id);
            return Ok();
        }
    }
}
