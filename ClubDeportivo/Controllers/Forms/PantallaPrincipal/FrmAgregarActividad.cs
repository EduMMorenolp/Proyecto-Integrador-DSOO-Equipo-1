using ClubDeportivo.Models;

namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
    public partial class FrmAgregarActividad : Form
    {
        public FrmAgregarActividad()
        {
            InitializeComponent();
        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreActividad.Clear();
            txtTipo.Clear();
            txtProfesor.Clear();
            textHorario.Clear();
            numericUpDownCapacidad.Value = numericUpDownCapacidad.Minimum;
            numericUpDownCosto.Value = numericUpDownCosto.Minimum;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Actividad nuevaActividad = new Actividad(
            txtNombreActividad.Text,
            txtTipo.Text,
            txtProfesor.Text,
            textHorario.Text,
            (int)numericUpDownCapacidad.Value,
            (decimal)numericUpDownCosto.Value
        );

            bool resultado = nuevaActividad.AgregarActividadEnBD();

            if (resultado)
            {
                MessageBox.Show("✅ La actividad fue agregada correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar los campos después de agregar la actividad
                btnLimpiarCampos_Click(sender, e);
            }
            else
            {
                MessageBox.Show("❌ No se pudo agregar la actividad.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
