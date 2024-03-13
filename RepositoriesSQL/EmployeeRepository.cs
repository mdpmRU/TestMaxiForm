using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.VisualBasic;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace RepositoriesSQL
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            string command = $"""
                              SELECT [EmployeeID]
                                    ,[FirstName]
                                    ,[LastName]
                                    ,[Email]
                                    ,[DateOfBirth]
                                    ,[dbo].[Departments].[DepartmentName]
                                    ,[dbo].[Positions].[PositionName]
                                FROM [dbo].[{TableNameEmployees}]
                              JOIN [dbo].[Departments] ON [dbo].[{TableNameEmployees}].[DepartmentID] = [dbo].[Departments].[ID]
                              JOIN [dbo].[Positions] ON [dbo].[{TableNameEmployees}].[PositionID] = [dbo].[Positions].[ID]
                              """;
            var result = ExecuteQueryWithData(command).Rows;
            return (from DataRow row in result select ParseEmployee(row)).ToList();
        }

        public Employee GetById(int id)
        {
            string command = $"""
                              SELECT [EmployeeID]
                                    ,[FirstName]
                                    ,[LastName]
                                    ,[Email]
                                    ,[DateOfBirth]
                                    ,[dbo].[Departments].[DepartmentName]
                                    ,[dbo].[Positions].[PositionName]
                                FROM [dbo].[{TableNameEmployees}]
                              JOIN [dbo].[Departments] ON [dbo].[{TableNameEmployees}].[DepartmentID] = [dbo].[Departments].[ID]
                              JOIN [dbo].[Positions] ON [dbo].[{TableNameEmployees}].[PositionID] = [dbo].[Positions].[ID]
                              WHERE [dbo].[{TableNameEmployees}].[EmployeeID] = {id}
                              """;
            //TODO Добавить проверку на Null
            var result = ExecuteQueryWithData(command).Rows[0];
            return ParseEmployee(result);
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
            string command = $"""
                             EXECUTE [dbo].[FindByLastName]
                                '{lastName}'
                             """;
            var result = ExecuteQueryWithData(command).Rows;
            return (from DataRow row in result select ParseEmployee(row)).ToList();
        }

        public Employee GetByIdOnlyEmployee(int id)
        {
            string command = $"""
                              SELECT * FROM {TableNameEmployees}
                              WHERE [dbo].[{TableNameEmployees}].[EmployeeID] = {id};
                              """;
            var result = ExecuteQueryWithData(command).Rows[0];
            return ParseEmployee(result);
        }

        private Employee ParseEmployee(DataRow result)
        {
            return new Employee
            {
                Id = Int32.Parse(result[0].ToString()),
                Name = result[1].ToString(),
                LastName = result[2].ToString(),
                Email = result[3].ToString(),
                DateOfBirth = DateTime.Parse(result[4].ToString()),
                Department = new Department() { Id = 0, Name = result[5].ToString() },
                Position = new Position() { Id = 0, Name = result[6].ToString() }
            };
        }
    }
}
