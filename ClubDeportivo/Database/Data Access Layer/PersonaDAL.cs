using ClubDeportivo.Database;
using ClubDeportivo.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Database.Data_Access_Layer
{
    public class PersonaDAL
    {
        public bool ExistePersona(string dni)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Persona WHERE dni = @dni";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dni", dni);

                    long count = (long)cmd.ExecuteScalar(); // ExecuteScalar devuelve un object, castear a long
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

        

        public int InsertarPersona(Persona persona) // Acepta cualquier objeto que SEA una Persona (Socio, NoSocio)
        {
            int idPersonaGenerado = 0;
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Persona (nombre, apellido, dni, fecha_nacimiento) " +
                                   "VALUES (@nombre, @apellido, @dni, @fecha_nacimiento); " +
                                   "SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", persona.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", persona.Apellido);
                    cmd.Parameters.AddWithValue("@dni", persona.Dni);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", persona.FechaNacimiento.Date);

                    object result = cmd.ExecuteScalar(); // Ejecuta la inserción y el SELECT LAST_INSERT_ID()
                    if (result != null)
                    {
                        idPersonaGenerado = Convert.ToInt32(result);
                    }
                }
            }
            catch (MySqlException ex) // Capturar excepciones específicas de MySQL
            {
                // El código de error 1062 es para entradas duplicadas (UNIQUE constraint en DNI)
                if (ex.Number == 1062)
                {
                    // Este caso debería ser prevenido por la llamada previa a ExistePersona(),
                    // pero es una buena salvaguarda.
                    MessageBox.Show("Error Crítico: Intento de insertar un DNI que ya existe. " + ex.Message,
                                    "Error de Duplicado en BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error de MySQL al insertar persona: " + ex.Message,
                                    "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                idPersonaGenerado = 0; // Indicar fallo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al insertar persona: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idPersonaGenerado = 0; // Indicar fallo
            }
            return idPersonaGenerado;
        }   
    }
}
