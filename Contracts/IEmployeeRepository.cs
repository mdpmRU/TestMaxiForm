using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        public IEnumerable<Employee> GetByLastName(string lastName);
    }
}
