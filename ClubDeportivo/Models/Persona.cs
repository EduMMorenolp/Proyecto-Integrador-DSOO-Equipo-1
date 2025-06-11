using ClubDeportivo.Database; // Para DBConnection
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ClubDeportivo.Models
{
    public abstract class Persona
    {
        public int IdPersona { get; set; } // ID tabla Persona (PK, Auto_Increment)
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }

        protected Persona(string nombre, string apellido, string dni, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
        }

        protected Persona() { }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellido: {Apellido}, Dni: {Dni}, Fecha de nacimiento: {FechaNacimiento.ToShortDateString()}";
        }

        public abstract void registrarse();

        public abstract bool pagar(float monto);

        public void hacerActividad(Actividad actividad)
        {
            // TO DO
        }

        public bool ExisteEnBD()
        {
            // Usamos this.Dni para la verificación
            if (string.IsNullOrWhiteSpace(this.Dni))
            {
                // No se puede verificar sin un DNI
                return false;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Persona WHERE dni = @dni";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dni", this.Dni);

                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar DNI en la base de datos: " + ex.Message,
                                "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GuardarNuevaPersonaEnBD()
        {
            // Validaciones básicas antes de intentar insertar
            if (string.IsNullOrWhiteSpace(this.Nombre) || string.IsNullOrWhiteSpace(this.Apellido) || string.IsNullOrWhiteSpace(this.Dni))
            {
                MessageBox.Show("Nombre, Apellido y DNI son obligatorios para guardar la persona.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Persona (nombre, apellido, dni, fecha_nacimiento) " +
                                   "VALUES (@nombre, @apellido, @dni, @fecha_nacimiento); " +
                                   "SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", this.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", this.Apellido);
                    cmd.Parameters.AddWithValue("@dni", this.Dni);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", this.FechaNacimiento.Date);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        this.IdPersona = Convert.ToInt32(result); // Asignar el ID al objeto actual
                        return true;
                    }
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Error: El DNI ingresado ya existe en la base de datos.", "Error de Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error de MySQL al insertar persona: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al insertar persona: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static int ObtenerIdPorDni(string dni)
        {
            int idPersona = -1;
            string query = "SELECT id_persona FROM Persona WHERE dni = @dni";

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    var result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        idPersona = id;
                    }
                }
            }
            return idPersona;
        }

    }
}
