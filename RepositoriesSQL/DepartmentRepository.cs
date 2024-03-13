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
            string command = $"SELECT * FROM {TableNameDepartments};";
            var result = ExecuteQueryWithData(command).Rows;
            var list = new List<Department>();
            foreach (DataRow row in result)
            {
                list.Add(Parse(row));
            }
            return list;
        }

        public Department GetById(int id)
        {
            string command = $"SELECT * FROM {TableNameDepartments} WHERE ID = {id};";
            var queryResult = ExecuteQueryWithData(command);
            if (queryResult.Rows.Count != 0)
            {
                return Parse(queryResult.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public void Insert(Department entity)
        {
            string command = $"INSERT {TableNameDepartments} VALUES ('{entity.Name}')";
            Execute(command);
        }

        public void Update(Department entity)
        {
            string command = $"""
                              UPDATE {TableNameDepartments}
                              SET DepartmentName = '{entity.Name}' WHERE ID = {entity.Id}
                              """;
            Execute(command);
        }

        public void DeleteById(int id)
        {
            string command = $"DELETE FROM {TableNameDepartments} WHERE ID = {id}";
            Execute(command);
        }

        private Department Parse(DataRow result)
        {
            return new Department() { Id = Int32.Parse(result[0].ToString()), Name = result[1].ToString() };
        }
    }
}
