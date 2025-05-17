using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
    public partial class FrmRegistrarPersona : Form
    {
        public FrmRegistrarPersona()
        {
            InitializeComponent();
        }

        private void frmRegistrarPersona_Load(object sender, EventArgs e)
        {
            // Configurar valores por defecto al cargar el formulario
            dtpFechaAlta.Value = DateTime.Now; // Fecha de alta por defecto es hoy
            rbSocio.Checked = true; // Asegurar que Socio esté seleccionado por defecto
            ActualizarVisibilidadPaneles(); // Llamar al método para ajustar la visibilidad
            lblEstado.Text = ""; // Limpiar mensaje de estado
        }

        // Evento que se dispara cuando cambia el estado de selección de rbSocio
        private void rbSocio_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVisibilidadPaneles();
        }

        // Evento que se dispara cuando cambia el estado de selección de rbNoSocio
        private void rbNoSocio_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVisibilidadPaneles();
        }

        private void ActualizarVisibilidadPaneles()
        {
            // Si el RadioButton "Socio" está seleccionado, mostrar el GroupBox de Datos de Socio
            // y ocultar el de Datos de No Socio.
            if (rbSocio.Checked)
            {
                gbDatosSocio.Visible = true;
                gbDatosNoSocio.Visible = false;
            }
            // Si el RadioButton "No Socio" está seleccionado, hacer lo contrario.
            else if (rbNoSocio.Checked)
            {
                gbDatosSocio.Visible = false;
                gbDatosNoSocio.Visible = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            dtpFechaNacimiento.Value = DateTime.Now; // O una fecha por defecto que consideres
            rbSocio.Checked = true; // Vuelve a la selección por defecto
            dtpFechaAlta.Value = DateTime.Now;
            chkFichaMedica.Checked = false;
            lblEstado.Text = "Campos limpiados.";
            txtNombre.Focus(); // Poner el foco en el primer campo
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // --- PASO 1: Validación de Campos Obligatorios ---
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("El campo DNI es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return;
            }
            // añadir más validaciones (formato de DNI, fecha de nacimiento no futura, etc.)


            // --- PASO 2: Recolección de Datos ---
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;

            lblEstado.Text = "Procesando...";

            // Por ahora, solo un mensaje de simulación, PENDIENTE!!
            if (rbSocio.Checked)
            {
                lblEstado.Text = $"Simulando registro de Socio: {nombre} {apellido}";
            }
            else
            {
                lblEstado.Text = $"Simulando registro de No Socio: {nombre} {apellido}";
            }
            MessageBox.Show("Operación de guardado (simulada) completada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
