using MySql.Data.MySqlClient;
using ClubDeportivo.Database;

namespace ClubDeportivo.Models
{
    internal class Administrador
    {
        public int IdAdmin { get; set; }
        public int IdPersona { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public static bool ValidarAdministrador(string nombreUsuario, string contrasenaIngresada)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT contrasena FROM Administrador WHERE nombre_usuario = @usuario";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", nombreUsuario);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            string contrasenaGuardada = resultado.ToString();

                            return contrasenaGuardada == contrasenaIngresada;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar administrador: {ex.Message}");
            }

            return false;
        }
    }
}
