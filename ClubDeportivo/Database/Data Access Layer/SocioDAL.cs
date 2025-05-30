using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo.Database; // Para DBConnection
using ClubDeportivo.Models;   // Para la clase Socio
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ClubDeportivo.Database.Data_Access_Layer
{
    public class SocioDAL
    {
        public bool InsertarSocio(Socio socio, int idPersona)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Socio (id_persona, fecha_alta, cuota_hasta, tiene_carnet, ficha_medica) " +
                                   "VALUES (@id_persona, @fecha_alta, @cuota_hasta, @tiene_carnet, @ficha_medica)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_persona", idPersona);
                    cmd.Parameters.AddWithValue("@fecha_alta", socio.FechaAlta.Date);

                    if (socio.CuotaHasta.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@cuota_hasta", socio.CuotaHasta.Value.Date);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@cuota_hasta", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@tiene_carnet", socio.TieneCarnet);
                    cmd.Parameters.AddWithValue("@ficha_medica", socio.FichaMedica);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                // Código de error 1062 para violación de UNIQUE constraint (ej. si id_persona fuera UNIQUE en Socio)
                // Código de error 1452 para violación de FOREIGN KEY constraint (ej. si id_persona no existe en Persona)
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Error: Esta persona ya está registrada como socio (o conflicto de clave única). " + ex.Message,
                                   "Error de Duplicado en BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 1452)
                {
                    MessageBox.Show("Error: No se puede crear el socio porque la persona asociada no existe. " + ex.Message,
                                   "Error de Clave Foránea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error de MySQL al insertar socio: " + ex.Message,
                                    "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al insertar socio: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool TieneCarnet(string dni)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "select tiene_carnet from socio where id_persona in (select id_persona from persona where dni = @dni);";
                //string query = "select id_socio from socio where id_persona in (select id_persona from persona where dni = @dni);";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    object result = cmd.ExecuteScalar();

                    // Si hay resultado y es true (1 en MySQL) devuelve true, sino false
                    return (result != null && result != DBNull.Value && Convert.ToBoolean(result));
                }
            }
        }

        public bool PersonaSocioDni(string dni)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "select id_socio from socio where id_persona in (select id_persona from persona where dni = @dni);";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    object result = cmd.ExecuteScalar();

                    // Si hay resultado y es true (1 en MySQL) devuelve true, sino false
                    return (result != null && result != DBNull.Value && Convert.ToBoolean(result));
                }
            }
        }

        
        public bool EntregarCarnetPorDNI(string dni)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Query que actualiza usando subconsulta para obtener el id_persona
                    string query = @"UPDATE Socio 
                           SET tiene_carnet = 1 
                           WHERE id_persona = (SELECT id_persona FROM persona WHERE dni = @dni)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Devuelve true si se actualizó al menos un registro
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Puedes registrar el error si es necesario
                Console.WriteLine($"Error al entregar carnet: {ex.Message}");
                return false;
            }
        }
        


        public bool PersonaYaEsSocio(int idPersona)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Socio WHERE id_persona = @id_persona";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_persona", idPersona);

                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar si la persona ya es socio: " + ex.Message,
                                "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
