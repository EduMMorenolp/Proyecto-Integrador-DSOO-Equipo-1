using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo.Database; // Para DBConnection
using ClubDeportivo.Models;   // Para la clase Socio
using MySql.Data.MySqlClient;
using System.Windows.Forms;     // Para MessageBox

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
                    // No necesitamos SELECT LAST_INSERT_ID() aquí si id_socio es autoincremental y
                    // no lo necesitas inmediatamente después de esta inserción específica.
                    // Si necesitaras el id_socio, añadirías "; SELECT LAST_INSERT_ID();" y usarías ExecuteScalar.

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_persona", idPersona);
                    cmd.Parameters.AddWithValue("@fecha_alta", socio.FechaAlta.Date); // Solo la fecha

                    // Manejo de DateTime? para cuota_hasta
                    if (socio.CuotaHasta.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@cuota_hasta", socio.CuotaHasta.Value.Date);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@cuota_hasta", DBNull.Value); // Insertar NULL si no tiene valor
                    }

                    cmd.Parameters.AddWithValue("@tiene_carnet", socio.TieneCarnet);
                    cmd.Parameters.AddWithValue("@ficha_medica", socio.FichaMedica);

                    int rowsAffected = cmd.ExecuteNonQuery(); // ExecuteNonQuery devuelve el número de filas afectadas
                    return rowsAffected > 0; // Si se afectó al menos una fila, la inserción fue exitosa
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
