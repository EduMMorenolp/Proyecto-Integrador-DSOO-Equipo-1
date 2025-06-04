using MySql.Data.MySqlClient;

namespace ClubDeportivo.Database
{
    public static class DBConnection
    {
        private static string connectionString = "datasource=localhost;Database=club_deportivo;username=root;password=admbbdd;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
