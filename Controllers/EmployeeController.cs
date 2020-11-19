using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using organisation_x_api.Entities;

namespace organisation_x_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly OrganisationXContext _context;

        public EmployeeController(OrganisationXContext _context)
        {
            this._context = _context;
        }

        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _context.Employees;
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.id == id);
        }

        // POST: api/Employee
        [HttpPost]
        public ActionResult Post([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
            }

            return Ok(employee);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Employee employee)
        {
            if (ModelState.IsValid)
            {
                var isFound = _context.Employees.Find

                try
                {
                    _context.Employees.Update(employee);

                    return Ok(employee);
                }
                catch
                {
                    ;
                }
            }

            return BadRequest("Employee Not found!");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            if (String.IsNullOrEmpty(id.ToString()))
                return BadRequest();

            var employee = await _context.Employees.FindAsync(id);

            _context.Employees.Remove(employee);

            return Accepted("Employee Deleted!");
        }

        public bool isFound(Employee employee)
        {
            return _context.Employees.Any(e => e.id == employee.id);
        }
    }
}
