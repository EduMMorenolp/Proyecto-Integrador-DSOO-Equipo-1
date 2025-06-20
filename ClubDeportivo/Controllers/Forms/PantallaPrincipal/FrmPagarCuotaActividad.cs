
using ClubDeportivo.Models;
using ClubDeportivo.Database;
using MySql.Data.MySqlClient; 
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            PoblarComboActividades();
            ActualizarVisibilidadPaneles();
            cmbActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            txtMontoActividad.ReadOnly = true;
        }

        private void PoblarComboActividades()
        {
            List<Actividad> actividades = Actividad.ObtenerTodas();

            cmbActividad.Items.Clear();
            Actividad placeholder = new Actividad { IdActividad = 0, Nombre = "Seleccione una actividad..." };
            cmbActividad.Items.Add(placeholder);

            if (actividades != null && actividades.Count > 0)
            {
                foreach (Actividad act in actividades)
                {
                    cmbActividad.Items.Add(act);
                }
            }

            cmbActividad.DisplayMember = "Nombre";
            cmbActividad.ValueMember = "IdActividad";
            cmbActividad.SelectedIndex = 0;
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
                groupBox1.Visible = true;
                gbActividad.Visible = false;
                rb3Cuotas.Enabled = rbMetodoTarjeta.Checked;
                rb6Cuotas.Enabled = rbMetodoTarjeta.Checked;
            }
            else if (rbActividad.Checked)
            {
                groupBox1.Visible = true;
                gbCuota.Visible = false;
                gbActividad.Visible = true;
                rb3Cuotas.Enabled = false;
                rb6Cuotas.Enabled = false;
                rb3Cuotas.Checked = false;
                rb6Cuotas.Checked = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMetodoTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuota.Checked)
            {
                rb3Cuotas.Enabled = rbMetodoTarjeta.Checked;
                rb6Cuotas.Enabled = rbMetodoTarjeta.Checked;
                if (!rbMetodoTarjeta.Checked)
                {
                    rb3Cuotas.Checked = false;
                    rb6Cuotas.Checked = false;
                }
            }
        }

        private void rbMetodoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMetodoEfectivo.Checked)
            {
                rb3Cuotas.Enabled = false;
                rb6Cuotas.Enabled = false;
                rb3Cuotas.Checked = false;
                rb6Cuotas.Checked = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            if (cmbActividad.Items.Count > 0)
            {
                cmbActividad.SelectedIndex = 0;
            }
            txtMontoActividad.Text = string.Empty;

            txtDniNoSocio.Text = string.Empty;
            txtDniSocio.Text = string.Empty;
            txtMontoCuota.Text = string.Empty;

            rbMetodoEfectivo.Checked = false;
            rbMetodoTarjeta.Checked = false;
            rb3Cuotas.Checked = false;
            rb6Cuotas.Checked = false;
            rb3Cuotas.Enabled = false;
            rb6Cuotas.Enabled = false;


            rbCuota.Checked = true;
            dtbFechaPago.Value = DateTime.Now;
            ActualizarVisibilidadPaneles();
        }
        private void cmbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActividad.SelectedItem is Actividad actividadSeleccionada && actividadSeleccionada.IdActividad != 0)
            {
                txtMontoActividad.Text = actividadSeleccionada.CostoActividad.ToString("N2");
            }
            else
            {
                txtMontoActividad.Text = string.Empty;
            }
        }


        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (!rbMetodoEfectivo.Checked && !rbMetodoTarjeta.Checked)
            {
                MessageBox.Show("Debe seleccionar un método de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string medioPago = rbMetodoEfectivo.Checked ? "Efectivo" : "Tarjeta";
            int? promocion = null;

            if (rbMetodoTarjeta.Checked)
            {
                if (rb3Cuotas.Checked) promocion = 3;
                else if (rb6Cuotas.Checked) promocion = 6;
            }

            DateTime fechaPago = dtbFechaPago.Value;

            if (rbCuota.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtDniSocio.Text) || string.IsNullOrWhiteSpace(txtMontoCuota.Text))
                {
                    MessageBox.Show("Debe completar DNI de Socio y Monto.", "Validación Cuota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string dniSocio = txtDniSocio.Text.Trim();
                if (!float.TryParse(txtMontoCuota.Text, out float montoCuota))
                {
                    MessageBox.Show("Monto inválido para cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idSocio = Socio.ObtenerIdSocioPorDni(dniSocio);
                if (idSocio == -1)
                {
                    MessageBox.Show("El socio con ese DNI no está registrado o el DNI es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime nuevaFechaVenceCuota = fechaPago.AddMonths(1);
                Cuota nuevaCuota = new Cuota(idSocio, false, montoCuota, fechaPago, nuevaFechaVenceCuota, medioPago, promocion ?? 0);

                if (nuevaCuota.GuardarEnBD())
                {
                    Socio socioAActualizar = Socio.ObtenerSocioPorId(idSocio);
                    if (socioAActualizar != null)
                    {
                        if (socioAActualizar.ActualizarCuotaHastaEnBD(nuevaFechaVenceCuota))
                        {
                            MessageBox.Show("Pago de cuota registrado y fecha de socio actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Pago de cuota registrado, pero hubo un error al actualizar la fecha del socio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pago de cuota registrado, pero no se pudo encontrar el socio para actualizar su fecha.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Error al registrar el pago de cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbActividad.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtDniNoSocio.Text) ||
                    (cmbActividad.SelectedItem == null || (cmbActividad.SelectedItem as Actividad)?.IdActividad == 0))
                {
                    MessageBox.Show("Debe completar DNI y seleccionar una Actividad válida.", "Validación Actividad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string dni = txtDniNoSocio.Text.Trim();
                Actividad actividadSeleccionada = cmbActividad.SelectedItem as Actividad;
                decimal montoActividad = actividadSeleccionada.CostoActividad;

                int idPersona = Persona.ObtenerIdPorDni(dni);
                if (idPersona == -1)
                {
                    MessageBox.Show("No existe una persona (No Socio) con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idNoSocio = NoSocio.ObtenerIdNoSocioPorIdPersona(idPersona);
                if (idNoSocio == -1)
                {
                    MessageBox.Show("Esta persona no está registrada como No Socio. Regístrela primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool exitoSimuladoPagoActividad = true; // Simulación para el botón Registrar Pago Actividad

                if (exitoSimuladoPagoActividad)
                {
                    
                    string mensajeExito = $"Pago por Actividad '{actividadSeleccionada.Nombre}' registrado exitosamente.\n\n" +
                                          $"DNI No Socio: {dni}\n" +
                                          $"Monto Pagado: {montoActividad:C2}\n" +
                                          $"Medio de Pago: {medioPago}\n" +
                                          $"Fecha de Pago: {fechaPago:dd/MM/yyyy}";

                    MessageBox.Show(mensajeExito, "Pago de Actividad Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Hubo un error al intentar registrar el pago de la actividad.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar si desea pagar una Cuota o una Actividad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cmbActividad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbActividad.SelectedItem is Actividad actividadSeleccionada && actividadSeleccionada.IdActividad != 0)
            {
                txtMontoActividad.Text = actividadSeleccionada.CostoActividad.ToString("N2");
            }
            else
            {
                txtMontoActividad.Text = string.Empty;
            }
        }
        private void gbActividad_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void rb6Cuotas_CheckedChanged(object sender, EventArgs e) { }
        private void rb3Cuotas_CheckedChanged(object sender, EventArgs e) { }
    }
}