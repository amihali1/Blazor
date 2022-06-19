using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorEmployeeEF.Data
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly SqlDbContext _dbContext;

        public EmployeesController(SqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/employees
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        // GET api/employees/{id}
        [HttpGet("{id:int}")]
        public async Task<Employee?> Get(int id)
        {
            if (_dbContext?.Employees?.Any() == true)
                return await _dbContext.Employees.FindAsync(id);

            return null;
        }

        // POST api/employees
        [HttpPost]
        public async Task<int> Post([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Employees.Add(employee);
                try
                {
                    await _dbContext.SaveChangesAsync();
                    return employee.Id;
                }
                catch (DbUpdateException)
                {
                    return -1;
                }
            }
            else 
                return -1;
        }

        // PUT api/employees/{id}
        [HttpPut("{id}")]
        public async Task<bool> Put(int id, [FromBody] Employee employee)
        {
            if (id != employee.Id)
            {
                return false;
            }

            _dbContext.Entry(employee).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        // DELETE api/employees/{id}
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            var employee = _dbContext.Employees.Find(id);
            if (employee == null)
                return false;

            try
            {
                _dbContext.Employees.Remove(employee);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
    }
}
