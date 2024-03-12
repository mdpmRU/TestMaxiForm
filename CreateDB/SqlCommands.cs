using System.Diagnostics;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
using Entities;

namespace Create
{
    public class SqlCommands(string dbName)
    {
        private const string ConnectionStringForCreate = "Data Source=DESKTOP-GA8U1F2\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";

        private string ConnectionStringForDB = $"Data Source=DESKTOP-GA8U1F2\\SQLEXPRESS;Initial Catalog={dbName};Integrated Security=True;TrustServerCertificate=True";
        public async void CreateDataBase()
        {
            var command = $"CREATE DATABASE {dbName}";
            var goodResult = "Создание БД успешно";
            await ExecuteRequest(command, goodResult, true);
        }

        public async void DropDataBase()
        {
            var command = $"DROP DATABASE IF EXISTS {dbName}";
            var goodResult = "База успешно удалена";
            await ExecuteRequest(command, goodResult, true);
        }

        public async void CreateTables()
        {
            var command = $"""
                                   USE {dbName}
                                   CREATE TABLE Departments (
                                   ID INT PRIMARY KEY IDENTITY,
                                   DepartmentName NVARCHAR(50)
                                   );
                                   CREATE TABLE Positions (
                                   ID INT PRIMARY KEY IDENTITY,
                                   PositionName NVARCHAR(50)
                                   );
                                   CREATE TABLE Employees (
                                   ID INT PRIMARY KEY IDENTITY,
                                   FirstName NVARCHAR(50),
                                   LastName NVARCHAR(50),
                                   Email NVARCHAR(100),
                                   DateOfBirth DATE,
                                   DepartmentID INT REFERENCES Departments (ID)
                                   ON DELETE SET NULL,
                                   PositionID INT REFERENCES Positions (ID)
                                   ON DELETE SET NULL
                                   );
                                   """;

            var goodResult = "Таблицы успешно созданы";
            await ExecuteRequest(command, goodResult, false);
        }

        public async void CreateTestValues(List<Employee> employees, List<Position> positions, List<Department> departments)
        {
            //TODO вынести в отдельный метод, если будет время и хороший вариант реализации
            var queryDep = "INSERT Departments VALUES\r\n" + string.Join(",\r\n", departments.Select(entity => $"('{entity.Name}')"));
            var queryPos = "INSERT Positions VALUES\r\n" + string.Join(",\r\n", positions.Select(entity => $"('{entity.Name}')"));
            var queryEmp = "INSERT Employees VALUES\r\n" + string.Join(",\r\n", employees.Select(entity =>
                $"('{entity.Name}'," +
                $" '{entity.LastName}'," +
                $" '{entity.Email}'," +
                $" '{entity.DateOfBirth}'," +
                $" {entity.Department.Id}," +
                $" {entity.Position.Id})"));
            var command = $"USE {dbName}" + "\r\n" + queryDep + "\r\n" + queryPos + "\r\n" + queryEmp + ";";
            var goodResult = "Данные успешно записаны";
            await ExecuteRequest(command, goodResult, false);
        }

        public async void CreateStoreProcedure()
        {
            string command = $"""
                                   CREATE PROCEDURE TestLike
                                   @lastName NVARCHAR(50)
                                   AS

                                   BEGIN
                                   	SELECT * FROM Employees
                                   	WHERE LastName LIKE @lastName
                                   END;
                                   """;
            string goodResult = "Хранимая процедура успешно создана";
            await ExecuteRequest(command, goodResult, false);
        }

        private async Task ExecuteRequest(string commandText, string goodResult, bool isCreateDB)
        {
            var conn = isCreateDB ? ConnectionStringForCreate : ConnectionStringForDB;
            
            await using SqlConnection connection = new(conn);
            try
            {
                connection.Open();
                SqlCommand command = new();
                command.CommandText = commandText;
                command.Connection = connection;
                command.ExecuteNonQuery();
                Debug.WriteLine(goodResult);
                connection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
