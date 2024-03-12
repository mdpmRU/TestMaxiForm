using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace RepositoriesSQL
{
    public class DepartmentRepository : BaseRepository, IDepartmentRepository
    {
        public IEnumerable<Department> GetAll()
        {
            yield break;
        }

        public Department GetById(int id)
        {
            string command = $"SELECT * FROM {TableNameDepartments} WHERE ID = {id};";
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
