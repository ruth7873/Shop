using Microsoft.AspNetCore.Mvc;
using Shop_ruthHershler.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop_ruthHershler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly static List<Employee> employees = new List<Employee>();
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var emp = employees.Find(match => match.Id == id);
            if (emp == null)
                return NotFound();
            return Ok(emp);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            employees.Add(employee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            var emp = employees.Find(e => e.Id == id);
            if (emp == null)
                return NotFound();
            employees.Remove(emp);
            employees.Add(employee);
            return Ok();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<Employee> Delete(int id)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null)
                return NotFound();
            employees.Remove(employee);
            return Ok();
        }
    }
}
