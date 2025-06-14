using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo.Database;

namespace ClubDeportivo.Models
{
    public class Cuota
    {
        private int IdSocio { get; set; }
        private bool Tipo { get; set; }
        private float Monto { get; set; }
        private DateTime FechaPago { get; set; }
        private DateTime FechaVence { get; set; }
        private string MedioPago { get; set; }
        private int Promocion { get; set; }

        public Cuota(int idSocio, bool tipo, float monto, DateTime fechaPago, DateTime fechaVence, string medioPago, int promocion)
        {
            this.IdSocio = idSocio;
            this.Tipo = tipo;
            this.Monto = monto;
            this.FechaPago = fechaPago;
            this.FechaVence = fechaVence;
            this.MedioPago = medioPago;
            this.Promocion = promocion;
        }

        public DateTime calcularVencimiento()
        {
            // TO DO
            return new DateTime();
        }

        public bool esValida() {
            // TO DO
            return true;
        }

        public bool GuardarEnBD()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO Cuota (id_socio, monto, fecha_pago, fecha_vence, medio_pago, promocion) " +
                                   "VALUES (@id_socio, @monto, @fecha_pago, @fecha_vence, @medio_pago, @promocion)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_socio", IdSocio);
                        cmd.Parameters.AddWithValue("@monto", Monto);
                        cmd.Parameters.AddWithValue("@fecha_pago", FechaPago);
                        cmd.Parameters.AddWithValue("@fecha_vence", FechaVence);
                        cmd.Parameters.AddWithValue("@medio_pago", MedioPago);
                        cmd.Parameters.AddWithValue("@promocion", (object)Promocion ?? DBNull.Value);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error BD: " + ex.Message);
                return false;
            }
        }
    }
}
