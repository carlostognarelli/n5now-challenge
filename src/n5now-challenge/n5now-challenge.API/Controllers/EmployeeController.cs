using Microsoft.AspNetCore.Mvc;
using n5now_challenge.Domain.Entities;
using n5now_challenge.Domain.Interfaces;

namespace n5now_challenge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet(Name = "GetEmployees")]
        public async Task<IEnumerable<Employee>> Get()
        {
            var employees = await _employeeRepository.GetAll();

            return employees.ToArray();
        }

    }
}
