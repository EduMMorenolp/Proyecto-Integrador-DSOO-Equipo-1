 using ClubDeportivo.Database; // Para DBConnection
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClubDeportivo.Models
{
    public class Socio : Persona
    {
        public int IdSocio { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? CuotaHasta { get; set; } // Nullable DateTime por si socio nuevo no ha pagado su primera cuota
        public bool TieneCarnet { get; set; }
        public bool FichaMedica { get; set; }

        public List<Actividad> Actividades { get; set; }

        public Socio(string nombre, string apellido, string dni, DateTime fechaNacimiento,
            DateTime fechaAlta, bool tieneCarnet, bool fichaMedica, List<Actividad> actividades, DateTime? cuotaHasta = null)
            : base(nombre, apellido, dni, fechaNacimiento)
        {
            FechaAlta = fechaAlta;
            CuotaHasta = cuotaHasta;
            TieneCarnet = tieneCarnet;
            FichaMedica = fichaMedica;
            Actividades = actividades ?? new List<Actividad>();
        }

        public Socio() : base()
        {
            Actividades = new List<Actividad>();
        }
        public DateTime ObtenerVencimientoCuota()
        {
            // TO DO
            return new DateTime();
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

        public bool GuardarNuevoSocioEnBD()
        {
            if (this.IdPersona <= 0) // Verificar que la parte Persona tenga un ID válido
            {
                MessageBox.Show("No se puede guardar el socio sin un ID de persona válido. Guarde la persona primero.", "Error de Lógica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Socio (id_persona, fecha_alta, cuota_hasta, tiene_carnet, ficha_medica) " +
                                   "VALUES (@id_persona, @fecha_alta, @cuota_hasta, @tiene_carnet, @ficha_medica); " +
                                   "SELECT LAST_INSERT_ID();"; // Para obtener el id_socio

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_persona", this.IdPersona); // Usa el ID de la instancia actual
                    cmd.Parameters.AddWithValue("@fecha_alta", this.FechaAlta.Date);
                    cmd.Parameters.AddWithValue("@cuota_hasta", this.CuotaHasta.HasValue ? (object)this.CuotaHasta.Value.Date : DBNull.Value);
                    cmd.Parameters.AddWithValue("@tiene_carnet", this.TieneCarnet);
                    cmd.Parameters.AddWithValue("@ficha_medica", this.FichaMedica);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        this.IdSocio = Convert.ToInt32(result); // Asignar el ID al objeto actual
                        return true;
                    }
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Error: Esta persona ya está registrada como socio (conflicto de clave única en Socio). " + ex.Message,
                                   "Error de Duplicado en BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 1452)
                {
                    MessageBox.Show("Error: No se puede crear el socio porque la persona asociada (ID: " + this.IdPersona + ") no existe. " + ex.Message,
                                   "Error de Clave Foránea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error de MySQL al insertar socio: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al insertar socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool PersonaYaEsSocioEnBD(int idPersonaBuscada)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Socio WHERE id_persona = @id_persona";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_persona", idPersonaBuscada);

                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar si la persona ya es socio: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static int ObtenerIdSocioPorDni(string dni)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    // Paso 1: Obtener id_persona desde Persona
                    string queryPersona = "SELECT id_persona FROM Persona WHERE dni = @dni";
                    int idPersona = -1;
                    using (var cmd = new MySqlCommand(queryPersona, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                            idPersona = Convert.ToInt32(result);
                        else
                          
                        return -1;
                    }

                    // Paso 2: Obtener id_socio desde Socio
                    string querySocio = "SELECT id_socio FROM Socio WHERE id_persona = @idPersona";
                    using (var cmd = new MySqlCommand(querySocio, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPersona", idPersona);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                            return Convert.ToInt32(result);
                        else
                            return -1; // No es socio
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener socio: " + ex.Message);
                return -1;
            }
        }
        public static bool ActualizarCarnet(string dni)
        {
            if (string.IsNullOrEmpty(dni) || dni.Length > 10 || !long.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Consulta para obtener si es socio y si ya tiene carnet
                    string query = @"SELECT s.id_socio, s.tiene_carnet 
                             FROM Socio s
                             JOIN Persona p ON s.id_persona = p.id_persona
                             WHERE p.dni = @dni";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dni", dni);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No se encontró ningún socio con ese DNI.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        if (reader.Read())
                        {
                            bool tieneCarnet = Convert.ToBoolean(reader["tiene_carnet"]);
                            int idSocio = Convert.ToInt32(reader["id_socio"]);

                            if (tieneCarnet)
                            {
                                MessageBox.Show("Este socio ya tiene carnet entregado.", "Carnet ya entregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }

                            // Salgo del lector antes de hacer UPDATE
                            reader.Close();

                            // Ahora hacemos la actualización
                            string updateQuery = "UPDATE Socio SET tiene_carnet = TRUE WHERE id_socio = @id_socio";
                            MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                            updateCmd.Parameters.AddWithValue("@id_socio", idSocio);

                            int filasAfectadas = updateCmd.ExecuteNonQuery();

                            return filasAfectadas > 0;
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("No se encontró ningún socio con ese DNI.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el carnet: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}


