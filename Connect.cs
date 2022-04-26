using System.Data.SqlClient;

namespace GreetApi
{
    public class Connect
    {

        public int myPrivateField { set; get; }

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection("Server=localhost;Database=ReaVayaDB;Trusted_Connection=True;");
            connection.Open();
            return connection;
        }

        public static SqlDataReader queryDatabase()
        {
            var connection = GetConnection();
            string sql = "SELECT * FROM dbo.Buses";
            connection = GetConnection();
            var command = new SqlCommand(sql, connection);
            return command.ExecuteReader();

        }

    }
}