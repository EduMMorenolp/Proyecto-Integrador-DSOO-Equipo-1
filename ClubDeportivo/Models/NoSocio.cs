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

        public bool InscribirEnActividadBD(int idActividadAInscribir)
        {
            if (this.IdNoSocio <= 0 || idActividadAInscribir <= 0)
            {
                MessageBox.Show("ID de No Socio o ID de Actividad no válidos para la inscripción.", "Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    // Verificar primero si ya existe para evitar error de PK duplicada
                    string checkQuery = "SELECT COUNT(*) FROM NoSocio_Actividad WHERE id_no_socio = @idNoSocio AND id_actividad = @idActividad";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@idNoSocio", this.IdNoSocio); // Usa el ID de la instancia actual
                    checkCmd.Parameters.AddWithValue("@idActividad", idActividadAInscribir);
                    long count = (long)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("El No Socio ya está inscripto en esta actividad.", "Inscripción Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true; // Ya está inscripto, consideramos éxito
                    }

                    // Si no existe, insertar
                    string query = "INSERT INTO NoSocio_Actividad (id_no_socio, id_actividad) VALUES (@idNoSocio, @idActividad)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idNoSocio", this.IdNoSocio); // Usa el ID de la instancia actual
                    cmd.Parameters.AddWithValue("@idActividad", idActividadAInscribir);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Opcional: Actualizar la lista local del objeto si la usas
                        // Actividad actividadInscrita = Actividad.ObtenerPorId(idActividadAInscribir); // Necesitarías este método en Actividad.cs
                        // if (actividadInscrita != null) this.ActividadesInscriptas.Add(actividadInscrita);
                        return true;
                    }
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Error: El No Socio ya está inscripto en esta actividad (conflicto de clave).", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error de MySQL al inscribir NoSocio en Actividad: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al inscribir NoSocio en Actividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static NoSocio ObtenerNoSocioPorIdPersona(int idPersona)
        {
            NoSocio noSocio = null;
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    // Asumimos que quieres los datos de Persona también para el objeto
                    string query = @"SELECT ns.id_no_socio, p.id_persona, p.nombre, p.apellido, p.dni, p.fecha_nacimiento
                               FROM NoSocio ns
                               JOIN Persona p ON ns.id_persona = p.id_persona
                               WHERE ns.id_persona = @idPersona";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idPersona", idPersona);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            noSocio = new NoSocio
                            {
                                IdNoSocio = Convert.ToInt32(reader["id_no_socio"]),
                                IdPersona = Convert.ToInt32(reader["id_persona"]), // Asignar IdPersona de la clase base
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Dni = reader["dni"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(reader["fecha_nacimiento"])
                                // Las listas ActividadesInscriptas y DiasPagados se inicializan vacías
                                // por el constructor por defecto de NoSocio si las dejas así,
                                // o podrías cargarlas aquí si fuera necesario.
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener NoSocio por IdPersona: " + ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return noSocio;
        }
        public override void registrarse()
        {

        }
        public override bool pagar(float monto)
        {

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


