using MySql.Data.MySqlClient;

namespace ClubDeportivo.Database
{
    public static class DBConnection
    {
        private static string connectionString = "Server=localhost;Database=club_deportivo;Uid=root;Pwd=tu_contraseña;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
