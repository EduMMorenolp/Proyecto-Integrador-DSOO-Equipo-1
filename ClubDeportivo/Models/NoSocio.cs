using MySql.Data.MySqlClient;
using ClubDeportivo.Database;

namespace ClubDeportivo.Models
{
    public class NoSocio : Persona
    {
        public int IdNoSocio { get; set; }
        public List<Actividad> ActividadesInscriptas { get; set; } = new();
        public List<DateTime> DiasPagados { get; set; } = new();

        public NoSocio(string nombre, string apellido, string dni, DateTime fechaNacimiento, List<Actividad> actividades, List<DateTime> diasPagados) : base(nombre, apellido, dni, fechaNacimiento)
        {
            ActividadesInscriptas = actividades ?? new List<Actividad>();
            DiasPagados = diasPagados ?? new List<DateTime>();
        }

        public NoSocio() : base() // Llama al constructor por defecto de Persona
        {
            ActividadesInscriptas = new List<Actividad>();
            DiasPagados = new List<DateTime>();
        }

        public bool GuardarNuevoNoSocioEnBD()
        {
            if (this.IdPersona <= 0) // Verificar que la parte Persona tenga un ID válido
            {
                MessageBox.Show("No se puede guardar el NoSocio sin un ID de persona válido. Guarde la persona primero.", "Error de Lógica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    // Tu tabla NoSocio solo tiene id_no_socio (autoincremental) y id_persona
                    string query = "INSERT INTO NoSocio (id_persona) VALUES (@id_persona); " +
                                   "SELECT LAST_INSERT_ID();"; // Para obtener el id_no_socio

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_persona", this.IdPersona); // Usa el ID de la instancia actual

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        this.IdNoSocio = Convert.ToInt32(result); // Asignar el ID al objeto actual
                        return true;
                    }
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                // Código de error 1062 para violación de UNIQUE constraint (ej. si id_persona fuera UNIQUE en NoSocio)
                // Código de error 1452 para violación de FOREIGN KEY constraint (ej. si id_persona no existe en Persona)
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Error: Esta persona ya está registrada como NoSocio (o conflicto de clave única). " + ex.Message,
                                   "Error de Duplicado en BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 1452)
                {
                    MessageBox.Show("Error: No se puede crear el NoSocio porque la persona asociada (ID: " + this.IdPersona + ") no existe. " + ex.Message,
                                   "Error de Clave Foránea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error de MySQL al insertar NoSocio: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al insertar NoSocio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool PersonaYaEsNoSocioEnBD(int idPersonaBuscada)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM NoSocio WHERE id_persona = @id_persona";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_persona", idPersonaBuscada);

                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar si la persona ya es NoSocio: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public override void registrarse()
        {
            // TO DO
        }
        public override bool pagar(float monto)
        {
            // TO DO
            return true;
        }

        public static int ObtenerIdNoSocioPorIdPersona(int idPersona)
        {
            int idNoSocio = -1; // Valor por defecto si no se encuentra
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection()) // Asegúrate que DBConnection es accesible
                {
                    conn.Open();
                    string query = "SELECT id_no_socio FROM NoSocio WHERE id_persona = @idPersona";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idPersona", idPersona);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idNoSocio = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ID de NoSocio por IdPersona: " + ex.Message,
                                "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Devolver -1 o propagar la excepción según tu manejo de errores
            }
            return idNoSocio;
        }
    }
}


