using ClubDeportivo.Database; // Para DBConnection
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Models;
using MySql.Data.MySqlClient;
using System.Net;

namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
    public partial class FrmPagarCuotaActividad : Form
    {
        public FrmPagarCuotaActividad()
        {
            InitializeComponent();
        }

        
        private void FrmPagarCuotaActividad_Load(object sender, EventArgs e)
        {
            dtbFechaPago.Value = DateTime.Now;
            rbCuota.Checked = true;
            ActualizarVisibilidadPaneles();
        }
        private void rbCuota_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVisibilidadPaneles();
        }
        private void rbActividad_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVisibilidadPaneles();
        }
        private void ActualizarVisibilidadPaneles()
        {
            if (rbCuota.Checked)
            {
                gbCuota.Visible = true;
                gbActividad.Visible = false;
            }
            else if (rbActividad.Checked)
            {
                gbCuota.Visible = false;
                gbActividad.Visible = true;
            }
        }


        private void BtnRealizar_Click(object sender, EventArgs e)
        {

                try
                {
                    using (MySqlConnection conn = DBConnection.GetConnection())
                    {
                        conn.Open();

                        if (rbCuota.Checked)
                        {
                            string dni = txtDniSocio.Text.Trim();
                            DateTime fechaPago = dtbFechaPago.Value;
                            float monto = float.Parse(txtMontoCuota.Text);
                            string medioPago = lblMetodoPago.Text.Trim();

                            // Buscar ID del socio
                            string querySocio = @"SELECT s.id_socio 
                                      FROM Socio s
                                      JOIN Persona p ON s.id_persona = p.id_persona
                                      WHERE p.dni = @dni";

                            MySqlCommand cmdSocio = new MySqlCommand(querySocio, conn);
                            cmdSocio.Parameters.AddWithValue("@dni", dni);
                            var idSocioObj = cmdSocio.ExecuteScalar();

                            if (idSocioObj == null)
                            {
                                MessageBox.Show("El DNI ingresado no corresponde a un socio registrado.");
                                return;
                            }

                            int idSocio = Convert.ToInt32(idSocioObj);

                            // Insertar el pago de cuota
                            string insertCuota = @"INSERT INTO Cuota (id_socio, monto, fecha_pago, fecha_vence, medio_pago, promocion)
                                       VALUES (@id_socio, @monto, @fecha_pago, @fecha_vence, @medio_pago, @promocion)";
                            MySqlCommand cmdInsert = new MySqlCommand(insertCuota, conn);
                            cmdInsert.Parameters.AddWithValue("@id_socio", idSocio);
                            cmdInsert.Parameters.AddWithValue("@monto", monto);
                            cmdInsert.Parameters.AddWithValue("@fecha_pago", fechaPago);
                            cmdInsert.Parameters.AddWithValue("@fecha_vence", DateTime.Now.AddMonths(1)); // o como definas fecha_vence
                            cmdInsert.Parameters.AddWithValue("@medio_pago", medioPago);
                            cmdInsert.Parameters.AddWithValue("@promocion", 0); // ajusta si tenés promoción

                            cmdInsert.ExecuteNonQuery();

                            // Actualizar Socio
                            string updateSocio = @"UPDATE Socio SET cuota_hasta = @fecha_vence WHERE id_socio = @id_socio";
                            MySqlCommand cmdUpdate = new MySqlCommand(updateSocio, conn);
                            cmdUpdate.Parameters.AddWithValue("@fecha_vence", DateTime.Now.AddMonths(1));
                            cmdUpdate.Parameters.AddWithValue("@id_socio", idSocio);

                            cmdUpdate.ExecuteNonQuery();

                            MessageBox.Show("Pago de cuota registrado correctamente.");
                        }
                        else if (rbActividad.Checked)
                        {
                            string dniNoSocio = txtDniNoSocio.Text.Trim();

                            // Obtener id_persona
                            string queryPersona = @"SELECT id_persona FROM Persona WHERE dni = @dni";
                            MySqlCommand cmdPersona = new MySqlCommand(queryPersona, conn);
                            cmdPersona.Parameters.AddWithValue("@dni", dniNoSocio);
                            var idPersonaObj = cmdPersona.ExecuteScalar();

                            if (idPersonaObj == null)
                            {
                                MessageBox.Show("No se encontró una persona con ese DNI.");
                                return;
                            }

                            int idPersona = Convert.ToInt32(idPersonaObj);

                            // Verificar que sea no socio
                            string sqlNoSocio = "SELECT id_no_socio FROM NoSocio WHERE id_persona = @id_persona";
                            MySqlCommand cmdNoSocio = new MySqlCommand(sqlNoSocio, conn);
                            cmdNoSocio.Parameters.AddWithValue("@id_persona", idPersona);
                            var idNoSocioObj = cmdNoSocio.ExecuteScalar();

                            if (idNoSocioObj == null)
                            {
                                MessageBox.Show("Esta persona no es un no socio.");
                                return;
                            }

                            int idNoSocio = Convert.ToInt32(idNoSocioObj);

                            // Obtener id_actividad (según nombre de actividad ingresado)
                            string actividadNombre = txtActividad.Text.Trim();
                            string queryActividad = "SELECT id_actividad FROM Actividad WHERE nombre = @nombre";
                            MySqlCommand cmdAct = new MySqlCommand(queryActividad, conn);
                            cmdAct.Parameters.AddWithValue("@nombre", actividadNombre);
                            var idActividadObj = cmdAct.ExecuteScalar();

                            if (idActividadObj == null)
                            {
                                MessageBox.Show("La actividad ingresada no existe.");
                                return;
                            }

                            int idActividad = Convert.ToInt32(idActividadObj);

                            decimal montoActividad;
                            if (!decimal.TryParse(txtMontoActividad.Text.Trim(), out montoActividad))
                            {
                                MessageBox.Show("Ingrese un monto válido.");
                                return;
                            }

                            DateTime fechaPago = dtbFechaPago.Value;

                            // Insertar pago de actividad
                            string insertPago = @"
                    INSERT INTO PagoActividad (id_no_socio, id_actividad, fecha_pago, monto_a_pagar)
                    VALUES (@idNoSocio, @idActividad, @fechaPago, @monto)";
                            using (var cmd = new MySqlCommand(insertPago, conn))
                            {
                                cmd.Parameters.AddWithValue("@idNoSocio", idNoSocio);
                                cmd.Parameters.AddWithValue("@idActividad", idActividad);
                                cmd.Parameters.AddWithValue("@fechaPago", fechaPago);
                                cmd.Parameters.AddWithValue("@monto", montoActividad);

                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Pago de actividad registrado exitosamente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }



        

    




