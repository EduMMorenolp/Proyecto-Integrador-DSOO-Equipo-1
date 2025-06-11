
using ClubDeportivo.Models;

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
                groupBox1.Visible = true;
                gbActividad.Visible = false;
                rb3Cuotas.Enabled = false;
                rb6Cuotas.Enabled = false;
            }
            else if (rbActividad.Checked)
            {
                groupBox1.Visible = true;
                gbCuota.Visible = false;
                gbActividad.Visible = true;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rbMetodoTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMetodoTarjeta.Checked)
            {
                rb3Cuotas.Enabled = true;
                rb6Cuotas.Enabled = true;
            }
        }
        private void rb3Cuotas_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rbMetodoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMetodoEfectivo.Checked)
            {
                rb3Cuotas.Enabled = false;
                rb6Cuotas.Enabled = false;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtActividad.Text = string.Empty;
            txtDniNoSocio.Text = string.Empty;
            txtDniSocio.Text = string.Empty;
            txtMontoActividad.Text = string.Empty;
            txtMontoCuota.Text = string.Empty;
            rbMetodoTarjeta.Checked = false;
            rbMetodoEfectivo.Checked = false;
            rbCuota.Checked = true;
            dtbFechaPago.Value = DateTime.Now;
            ActualizarVisibilidadPaneles();
        }
        private void btnRealizar_Click(object sender, EventArgs e)
        {
            // PASO 1: Validaciones mínimas
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

            // PASO 2: Determinar tipo de pago
            if (rbCuota.Checked)
            {
                // Validaciones específicas de CUOTA
                if (string.IsNullOrWhiteSpace(txtDniSocio.Text) || string.IsNullOrWhiteSpace(txtMontoCuota.Text))
                {
                    MessageBox.Show("Debe completar DNI de Socio y Monto.", "Validación Cuota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Recolección de datos
                string dniSocio = txtDniSocio.Text.Trim();
                if (!float.TryParse(txtMontoCuota.Text, out float montoCuota))
                {
                    MessageBox.Show("Monto inválido para cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idSocio = Socio.ObtenerIdSocioPorDni(dniSocio);

                if (idSocio == -1)
                {
                    MessageBox.Show("El socio con ese DNI no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Cuota nuevaCuota = new Cuota(idSocio, false, montoCuota, fechaPago, fechaPago.AddMonths(1), medioPago, promocion ?? 0);

                if (nuevaCuota.GuardarEnBD())
                {
                    MessageBox.Show("Pago de cuota registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al registrar el pago de cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbActividad.Checked)
            {
                // Validaciones específicas de ACTIVIDAD
                if (string.IsNullOrWhiteSpace(txtDniNoSocio.Text) || string.IsNullOrWhiteSpace(txtActividad.Text) || string.IsNullOrWhiteSpace(txtMontoActividad.Text))
                {
                    MessageBox.Show("Debe completar DNI, Actividad y Monto.", "Validación Actividad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string dni = txtDniNoSocio.Text.Trim();
                string nombreActividad = txtActividad.Text.Trim();

                if (!float.TryParse(txtMontoActividad.Text, out float montoActividad))
                {
                    MessageBox.Show("Monto inválido para actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idPersona = Persona.ObtenerIdPorDni(dni); // Busca en tabla Persona
                if (idPersona == -1)
                {
                    MessageBox.Show("No existe una persona con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idActividad = Actividad.ObtenerIdPorNombre(nombreActividad);
                if (idActividad == -1)
                {
                    MessageBox.Show("Actividad no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lógica: Registrar pago de actividad
                PagoActividad nuevoPago = new PagoActividad
                {
                    IdPersona = idPersona,
                    IdActividad = idActividad,
                    Monto = montoActividad,
                    MedioPago = medioPago,
                    FechaPago = fechaPago
                };

                if (nuevoPago.GuardarEnBD())
                {
                    MessageBox.Show("Pago de actividad registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al registrar pago de actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gbActividad_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rb6Cuotas_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}



