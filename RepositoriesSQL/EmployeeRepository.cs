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
                              LEFT JOIN [dbo].[Departments] ON [dbo].[{TableNameEmployees}].[DepartmentID] = [dbo].[Departments].[ID]
                              LEFT JOIN [dbo].[Positions] ON [dbo].[{TableNameEmployees}].[PositionID] = [dbo].[Positions].[ID]
                              """;
            var result = ExecuteQueryWithData(command).Rows;
            return (from DataRow row in result select Parse(row)).ToList();
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

        public void Insert(Employee entity)
        {
            string command = $"""
                             INSERT {TableNameEmployees} VALUES
                             ('{entity.Name}','{entity.LastName}','{entity.Email}','{entity.DateOfBirth.Date}',{entity.Department.Id},{entity.Position.Id})
                             """;
            Execute(command);
        }

        public void Update(Employee entity)
        {
            string command = $"""
                              UPDATE [dbo].[{TableNameEmployees}]
                              SET [FirstName] = '{entity.Name}',
                                  [LastName] = '{entity.LastName}',
                                  [Email] = '{entity.Email}',
                                  [DateOfBirth] = '{entity.DateOfBirth.Date}',
                                  [DepartmentID] = {entity.Department.Id},
                                  [PositionID] = {entity.Position.Id}
                              WHERE [EmployeeID] = {entity.Id};
                              """;
            Execute(command);
        }

        public void DeleteById(int id)
        {
            string command = $"""
                              DELETE FROM {TableNameEmployees}
                              WHERE [dbo].[{TableNameEmployees}].[EmployeeID] = {id}
                              """;
            Execute(command);
        }

        public IEnumerable<Employee> GetByLastName(string lastName)
        {
            string command = $"""
                             EXECUTE [dbo].[FindByLastName]
                                '{lastName}'
                             """;
            var result = ExecuteQueryWithData(command).Rows;
            return (from DataRow row in result select Parse(row)).ToList();
        }

        public Employee GetByIdOnlyEmployee(int id)
        {
            string command = $"""
                              SELECT * FROM {TableNameEmployees}
                              WHERE [dbo].[{TableNameEmployees}].[EmployeeID] = {id};
                              """;
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

        private Employee Parse(DataRow result)
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
