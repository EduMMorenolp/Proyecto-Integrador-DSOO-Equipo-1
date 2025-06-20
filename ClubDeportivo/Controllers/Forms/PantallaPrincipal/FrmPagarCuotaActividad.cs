
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
                panelCuotas.Visible = false;
                rb3Cuotas.Enabled = false;
                rb6Cuotas.Enabled = false;
            }
            else if (rbActividad.Checked)
            {
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
                panelCuotas.Visible = true;
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
                panelCuotas.Visible = false;
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
    }
}



