using CRM.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRM.Controllers
{
    [Authorize]

    [Route("api/[controller]")]
    [ApiController]
    
    public class EmployeeController : ControllerBase
    {
        private readonly EdidynamiqueHbcContext _employeeContext;

        public EmployeeController(EdidynamiqueHbcContext employeeContext)

        {
            _employeeContext = employeeContext;


        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            if (_employeeContext.Employees == null)
            {
                return NotFound();
            }
            return await _employeeContext.Employees.ToListAsync();
        }
        [HttpGet("{Ematricule}")]
        public async Task<ActionResult<Employee>> GetEmployee(String Ematricule)
        {
            if (_employeeContext.Employees == null)
            {
                return NotFound();
            }
            var Employee = await _employeeContext.Employees.FindAsync(Ematricule);

            if (Employee == null)
            {
                return NotFound();
            }

            return Employee;
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _employeeContext.Employees.Add(employee);
            await _employeeContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEmployee), new { ematricule = employee.Ematricule }, employee);

        }
        [HttpPut("{ematricule}")]
        public async Task<IActionResult> PutEmployee(string ematricule, Employee employee)
        {
            if (ematricule != employee.Ematricule)
            {
                return BadRequest();
            }

            _employeeContext.Entry(employee).State = EntityState.Modified;

            try
            {
                await _employeeContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(ematricule))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
            
        }
        private bool EmployeeExists(string ematricule)
        {
            return _employeeContext.Employees.Any(e => e.Ematricule == ematricule);
        }
        [HttpDelete("{ematricule}")]
        public async Task<ActionResult> DeleteEmployee(string ematricule)
        {
            if (_employeeContext.Employees == null)
            {
                return NotFound();

            }
            var employee = await _employeeContext.Employees.FindAsync(ematricule);
            if (employee == null)
            {
                return NotFound();
            }

            _employeeContext.Employees.Remove(employee);
            await _employeeContext.SaveChangesAsync();
            return Ok();

        }




    }
}