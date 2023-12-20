using Microsoft.EntityFrameworkCore;
using n5now_challenge.Domain.Entities;
using n5now_challenge.Domain.Interfaces;
using n5now_challenge.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5now_challenge.Infraestructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly N5NowChallengeDbContext _context;

        public EmployeeRepository(N5NowChallengeDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAll()
        {
            return await _context.Employee.ToListAsync();
        }
    }
}
