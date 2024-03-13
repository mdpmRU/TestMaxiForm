using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace RepositoriesSQL
{
    public abstract class BaseRepository
    {
        internal string connectionString = $"Data Source=DESKTOP-GA8U1F2\\SQLEXPRESS;Initial Catalog=EmployeeManagement;Integrated Security=True;TrustServerCertificate=True";
        internal const string TableNamePositions = "Positions";
        internal const string TableNameDepartments = "Departments";
        internal const string TableNameEmployees = "Employees";
        internal DataTable ExecuteQueryWithData(string query)
        {
            var ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(ds);
            }
            return ds.Tables[0];
        }

        internal void Execute(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int number = command.ExecuteNonQuery();
                if (number != 0)
                {
                    Debug.WriteLine("Операция проведена");
                }
            }
        }
    }
}
