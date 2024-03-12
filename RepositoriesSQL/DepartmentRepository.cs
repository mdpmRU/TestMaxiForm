using Contracts;
using System;
using System.Collections.Generic;
using System.Data;
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
            var result = ExecuteQueriWithData(command).Rows[0];
            return ParseDepartment(result);
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

        private Department ParseDepartment(DataRow result)
        {
            return new Department() { Id = Int32.Parse(result[0].ToString()), Name = result[1].ToString() };
        }
    }
}
