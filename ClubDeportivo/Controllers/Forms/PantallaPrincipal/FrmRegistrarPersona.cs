using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Database.Data_Access_Layer;
using ClubDeportivo.Models;

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
            dtpFechaAlta.Value = DateTime.Now;
            rbSocio.Checked = true;
            ActualizarVisibilidadPaneles();
            lblEstado.Text = "";
        }

        private void rbSocio_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVisibilidadPaneles();
        }

        private void rbNoSocio_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVisibilidadPaneles();
        }

        private void ActualizarVisibilidadPaneles()
        {
            if (rbSocio.Checked)
            {
                gbDatosSocio.Visible = true;
                gbDatosNoSocio.Visible = false;
            }
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
            dtpFechaNacimiento.Value = DateTime.Now;
            rbSocio.Checked = true;
            dtpFechaAlta.Value = DateTime.Now;
            chkFichaMedica.Checked = false;
            lblEstado.Text = "Campos limpiados.";
            txtNombre.Focus();
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
            else
            {
                // Validación de formato DNI: solo números
                if (!long.TryParse(txtDni.Text, out _)) // Intenta convertir a long, si falla no son solo números
                {
                    MessageBox.Show("El DNI solo debe contener números.", "Validación DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDni.Focus();
                    txtDni.SelectAll(); // Seleccionar todo el texto para fácil corrección
                    return;
                }

                // Validación de longitud DNI: entre 7 y 8 dígitos
                if (txtDni.Text.Length < 7 || txtDni.Text.Length > 8)
                {
                    MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos.", "Validación DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDni.Focus();
                    txtDni.SelectAll();
                    return;
                }
            }

            DateTime fechaNacimientoSeleccionada = dtpFechaNacimiento.Value;
            int edadMinima = 3; // Puedes ajustar esto
            if (fechaNacimientoSeleccionada.AddYears(edadMinima) > DateTime.Now)
            {
                MessageBox.Show($"La persona debe tener al menos {edadMinima} años.", "Validación Edad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaNacimiento.Focus();
                return;
            }

            // --- PASO 2: Recolección de Datos ---
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;

            lblEstado.Text = "Procesando...";
            Application.DoEvents();

            //Lógica de Negocio y DAL (usando PersonaDAL) ---
            PersonaDAL personaDAL = new PersonaDAL();
            SocioDAL socioDAL = new SocioDAL();

            if (personaDAL.ExistePersona(dni))
            {
                MessageBox.Show("El DNI ingresado ya se encuentra registrado.", "DNI Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblEstado.Text = "Error: DNI ya existe.";
                txtDni.Focus();
                txtDni.SelectAll();
                return;
            }

            Socio personaParaInsertar = new Socio
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                FechaNacimiento = fechaNacimiento
            };

            int idPersonaGenerado = personaDAL.InsertarPersona(personaParaInsertar);

            if (idPersonaGenerado > 0)
            {
                personaParaInsertar.IdPersona = idPersonaGenerado;

                if (rbSocio.Checked)
                {
                    if (socioDAL.PersonaYaEsSocio(idPersonaGenerado))
                    {
                        MessageBox.Show("Esta persona ya está registrada como socio.", "Socio Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblEstado.Text = $"Persona ID: {idPersonaGenerado} ya es socio.";
                        return;
                    }

                    // Llenar los datos específicos del Socio en el objeto 'personaParaInsertar' (que es un Socio)
                    personaParaInsertar.FechaAlta = dtpFechaAlta.Value;
                    personaParaInsertar.FichaMedica = chkFichaMedica.Checked;
                    personaParaInsertar.TieneCarnet = false; // Por defecto al registrar un nuevo socio
                    personaParaInsertar.CuotaHasta = null;   // Se actualizará con el primer pago

                    if (socioDAL.InsertarSocio(personaParaInsertar, idPersonaGenerado))
                    {
                        lblEstado.Text = $"Socio '{nombre} {apellido}' registrado con ID Persona: {idPersonaGenerado}.";
                        MessageBox.Show($"¡Socio registrado exitosamente!\nID Persona: {idPersonaGenerado}",
                                        "Registro Socio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpiarCampos_Click(null, null);
                    }
                    else
                    {
                        lblEstado.Text = "Error al registrar los datos específicos del socio.";
                        MessageBox.Show("La persona fue creada, pero hubo un error al registrarla como Socio.",
                                        "Error Parcial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // No se seleccionó Socio (implica NoSocio)
                {
                    lblEstado.Text = $"Persona (No Socio) '{nombre} {apellido}' registrada con ID: {idPersonaGenerado}.";
                    MessageBox.Show($"¡Persona (No Socio) registrada exitosamente!\nID Asignado: {idPersonaGenerado}",
                                    "Registro Persona Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpiarCampos_Click(null, null);
                }
            }
            else
            {
                if (!lblEstado.Text.Contains("Error:"))
                {
                    lblEstado.Text = "Error: No se pudo registrar la persona.";
                }
            }
        }
    }
}
