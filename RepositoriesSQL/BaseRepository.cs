using Microsoft.Data.SqlClient;
using System.Data;

namespace RepositoriesSQL
{
    public abstract class BaseRepository
    {
        internal string connectionString = $"Data Source=DESKTOP-GA8U1F2\\SQLEXPRESS;Initial Catalog=TestMaxiForm10;Integrated Security=True;TrustServerCertificate=True";
        internal const string TableNamePositions = "Positions";
        internal const string TableNameDepartments = "Departments";
        internal const string TableNameEmployees = "Employees";
        internal DataTable ExecuteQueriWithData(string query)
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
    }
}
