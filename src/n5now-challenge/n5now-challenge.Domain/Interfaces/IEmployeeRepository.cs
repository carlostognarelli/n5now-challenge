using n5now_challenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5now_challenge.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAll();
    }
}
