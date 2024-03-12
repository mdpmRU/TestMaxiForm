using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace RepositoriesSQL
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public IEnumerable<Department> GetAll()
        {
            yield break;
        }

        public Department GetById(int id)
        {
            return null;
        }

        public void Insert(Department entity)
        {
        }

        public void Update(Department entity)
        {
        }

        public void DeleteById(int id)
        {
        }
    }
}
