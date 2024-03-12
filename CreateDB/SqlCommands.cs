using System.Diagnostics;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
using Entities;

namespace Create
{
    public class SqlCommands(string dbName)
    {
        public const string ConnectionString = "Data Source=DESKTOP-GA8U1F2\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";


        public async void CreateDataBase()
        {
            await using SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                SqlCommand command = new();
                command.CommandText = $"CREATE DATABASE {dbName}";
                command.Connection = connection;
                command.ExecuteNonQuery();
                Debug.WriteLine("База успешно удалена");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        public async void DropDataBase()
        {
            await using SqlConnection connection = new(ConnectionString);
            try
            {
                connection.Open();
                SqlCommand command = new();
                command.CommandText = $"DROP DATABASE IF EXISTS {dbName}";
                command.Connection = connection;
                command.ExecuteNonQuery();
                Debug.WriteLine("База успешно удалена");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        public async void CreateTables()
        {
            await using SqlConnection connection = new(ConnectionString);
            try
            {
                connection.Open();
                SqlCommand command = new();
                command.CommandText = $"USE {dbName}" + "\r\n" +
                                       //"GO" + "\r\n" +
                                       "CREATE TABLE Departments (" + "\r\n" +
                                       "ID INT PRIMARY KEY IDENTITY," + "\r\n" +
                                       "DepartmentName NVARCHAR(50)" + "\r\n" +
                                       ");" + "\r\n" +
                                       "CREATE TABLE Positions (" + "\r\n" +
                                       "ID INT PRIMARY KEY IDENTITY," + "\r\n" +
                                       "PositionName NVARCHAR(50)" + "\r\n" +
                                       ");" + "\r\n" +
                                       //"GO" + "\r\n" +
                                       "CREATE TABLE Employees (" + "\r\n" +
                                       "EmployeeID INT PRIMARY KEY IDENTITY," + "\r\n" +
                                       "FirstName NVARCHAR(50)," + "\r\n" +
                                       "LastName NVARCHAR(50)," + "\r\n" +
                                       "Email NVARCHAR(100)," + "\r\n" +
                                       "DateOfBirth DATE," + "\r\n" +
                                       "DepartmentID INT REFERENCES Departments (ID) " + "\r\n" +
                                       "ON DELETE SET NULL," + "\r\n" +
                                       "PositionID INT REFERENCES Positions (ID) " + "\r\n" +
                                       "ON DELETE SET NULL" + "\r\n" +
                                       ");";
                command.Connection = connection;
                command.ExecuteNonQuery();
                Debug.WriteLine("Таблицы успешно созданы");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }


        }

        public async void CreateTestValues(List<Employee> employees, List<Position> positions, List<Department> departments)
        {
            await using SqlConnection connection = new(ConnectionString);
            try
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

                connection.Open();
                SqlCommand command = new();
                command.CommandText = $"USE {dbName}" + "\r\n" + queryDep + "\r\n" + queryPos + "\r\n" + queryEmp + ";";
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
