using MySql.Data.MySqlClient;
using ClubDeportivo.Database;

namespace ClubDeportivo.Models
{
    public class Actividad
    {
        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Profesor { get; set; }
        public string Horario { get; set; }
        public int Capacidad { get; set; }
        public decimal Costo { get; set; }

        public Actividad(string nombre, string tipo, string profesor, string horario, int capacidad, decimal costo) {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Profesor = profesor;
            this.Horario = horario;
            this.Capacidad  = capacidad;
            this.Costo = costo;
        }

        public bool inscribir(Persona persona)
        {
          // TO DO
            return true;
        }

        public static int ObtenerIdPorNombre(string nombreActividad)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id_actividad FROM Actividad WHERE nombre = @nombre";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombreActividad);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ID de actividad: " + ex.Message,
                                "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
