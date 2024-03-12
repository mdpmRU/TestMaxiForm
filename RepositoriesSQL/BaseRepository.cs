using Microsoft.Data.SqlClient;

namespace RepositoriesSQL

{
    public abstract class BaseRepository
    {
        internal string connectionString = $"Data Source=DESKTOP-GA8U1F2\\SQLEXPRESS;Initial Catalog=TestMaxiForm7;Integrated Security=True;TrustServerCertificate=True";
        internal const string TableNamePositions = "Positions";
        internal const string TableNameDepartments = "Departments";
        internal const string TableNameEmployees = "Employees";
        internal void ExecuteQueriWithData(string query)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            var command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
            }
            //нужно ли?
            reader.Close();
        }
    }
}
