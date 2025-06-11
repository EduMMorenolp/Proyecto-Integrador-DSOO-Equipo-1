using MySql.Data.MySqlClient;
using ClubDeportivo.Database;

namespace ClubDeportivo.Models
{
    public class PagoActividad
    {
        public int IdPersona { get; set; }
        public int IdActividad { get; set; }
        public DateTime FechaPago { get; set; }
        public float Monto { get; set; }
        public string MedioPago { get; set; }

        public void generarRecibo(DateTime fechaActual, float monto)
        {
            // TO DO
        }

        public bool GuardarEnBD()
        {
            string query = @"INSERT INTO PagoActividad (id_persona, id_actividad, fecha_pago, monto, medio_pago) 
                     VALUES (@id_persona, @id_actividad, @fecha_pago, @monto, @medio_pago)";

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_persona", IdPersona);
                    cmd.Parameters.AddWithValue("@id_actividad", IdActividad);
                    cmd.Parameters.AddWithValue("@fecha_pago", FechaPago);
                    cmd.Parameters.AddWithValue("@monto", Monto);
                    cmd.Parameters.AddWithValue("@medio_pago", MedioPago);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}


