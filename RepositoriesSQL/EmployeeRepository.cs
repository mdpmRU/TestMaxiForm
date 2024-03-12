using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace RepositoriesSQL
{
    public class EmployeeRepository: BaseRepository, IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            yield break;
        }

        public Employee GetById(int id)
        {
            return null;
        }

        public void Insert(Employee entity)
        {
        }

        public void Update(Employee entity)
        {
        }

        public void DeleteById(int id)
        {
        }

        public IEnumerable<Employee> GetByLastName(string lastName)
        {
            yield break;
        }
    }
}
