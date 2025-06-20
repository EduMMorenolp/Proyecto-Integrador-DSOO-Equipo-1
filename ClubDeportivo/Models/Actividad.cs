using MySql.Data.MySqlClient;
using ClubDeportivo.Database;
using System; // Para Exception, Convert, DateTime (si la usaras)
using System.Collections.Generic; // Para List<>
using System.Windows.Forms; // Para MessageBox

namespace ClubDeportivo.Models
{
    public class Actividad
    {
        public int IdActividad { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Profesor { get; set; } = string.Empty;
        public string Horario { get; set; } = string.Empty;
        public int Capacidad { get; set; }
        public decimal CostoActividad { get; set; } // Renombrada para consistencia

        // Constructor por defecto
        public Actividad() { }

        // Constructor parametrizado
        public Actividad(string nombre, string tipo, string profesor, string horario, int capacidad, decimal costoActividad)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Profesor = profesor;
            this.Horario = horario;
            this.Capacidad = capacidad;
            this.CostoActividad = costoActividad;
        }

        public bool inscribir(Persona persona)
        {
            // TO DO: Lógica para inscribir una persona a esta actividad.
            // Podría implicar verificar capacidad, registrar en NoSocio_Actividad, etc.
            Console.WriteLine($"Intentando inscribir a {persona.Nombre} en {this.Nombre}");
            return true;
        }

        public bool AgregarActividadEnBD()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Actividad 
                                     (nombre, tipo, profesor, horario, capacidad, costo_actividad) 
                                     VALUES (@nombre, @tipo, @profesor, @horario, @capacidad, @costo_actividad);
                                     SELECT LAST_INSERT_ID();"; // Para obtener el ID si lo necesitas

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", this.Nombre);
                    cmd.Parameters.AddWithValue("@tipo", this.Tipo);
                    cmd.Parameters.AddWithValue("@profesor", this.Profesor);
                    cmd.Parameters.AddWithValue("@horario", this.Horario);
                    cmd.Parameters.AddWithValue("@capacidad", this.Capacidad);
                    cmd.Parameters.AddWithValue("@costo_actividad", this.CostoActividad); // Usar propiedad renombrada

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        this.IdActividad = Convert.ToInt32(result); // Asignar el ID generado
                        return true;
                    }
                    return false; // Si LAST_INSERT_ID no devuelve nada (poco probable si el insert tuvo éxito)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la actividad: " + ex.Message,
                                "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static int ObtenerIdPorNombre(string nombreActividad)
        {
            int id = -1; // Valor por defecto si no se encuentra
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id_actividad FROM Actividad WHERE nombre = @nombre LIMIT 1"; // LIMIT 1 por si acaso
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombreActividad);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ID de actividad por nombre: " + ex.Message,
                                "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }

        public static List<Actividad> ObtenerTodas()
        {
            List<Actividad> listaActividades = new List<Actividad>();
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id_actividad, nombre, tipo, profesor, horario, capacidad, costo_actividad FROM Actividad ORDER BY nombre";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Actividad act = new Actividad();
                            act.IdActividad = Convert.ToInt32(reader["id_actividad"]);
                            act.Nombre = reader["nombre"].ToString();
                            act.Tipo = reader["tipo"].ToString();
                            act.Profesor = reader["profesor"].ToString();
                            act.Horario = reader["horario"].ToString();
                            act.Capacidad = Convert.ToInt32(reader["capacidad"]);
                            act.CostoActividad = Convert.ToDecimal(reader["costo_actividad"]);
                            listaActividades.Add(act);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de actividades: " + ex.Message,
                                "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaActividades;
        }

        public override string ToString()
        {
            return this.Nombre; // Para que el ComboBox muestre el nombre de la actividad
        }
    }
}