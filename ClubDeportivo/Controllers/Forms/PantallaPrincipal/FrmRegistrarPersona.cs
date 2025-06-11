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
            }
            else if (rbNoSocio.Checked)
            {
                gbDatosSocio.Visible = false;
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

            if (!chkFichaMedica.Checked)
            {
                MessageBox.Show("Para registrar Socio, debe presentar la Ficha médica.", "Validación Ficha Médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

            Persona personaAProcesar; // Usar el tipo base para la lógica común

            if (rbSocio.Checked)
            {
                Socio nuevoSocio = new Socio
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Dni = dni,
                    FechaNacimiento = fechaNacimiento,
                    FechaAlta = dtpFechaAlta.Value,
                    FichaMedica = chkFichaMedica.Checked,
                    TieneCarnet = false, // Valor inicial
                    CuotaHasta = null    // Valor inicial
                };
                personaAProcesar = nuevoSocio;
            }
            else // rbNoSocio.Checked
            {
                NoSocio nuevoNoSocio = new NoSocio // Asumiendo que tienes NoSocio.cs similar a Socio.cs
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Dni = dni,
                    FechaNacimiento = fechaNacimiento
                    // No hay datos específicos de NoSocio para la tabla NoSocio en tu BD actual
                };
                personaAProcesar = nuevoNoSocio;
            }

            // --- PASO 3: Lógica de Persistencia usando métodos del objeto ---


            if (personaAProcesar.ExisteEnBD())
            {
                MessageBox.Show("El DNI ingresado ya se encuentra registrado en la tabla Persona.", "DNI Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblEstado.Text = "Error: DNI ya existe como Persona.";
                txtDni.Focus();
                txtDni.SelectAll();
                return;
            }


            if (personaAProcesar.GuardarNuevaPersonaEnBD()) // Este método asigna IdPersona al objeto personaAProcesar
            {

                if (personaAProcesar is Socio socioParaGuardar)
                {
                    if (Socio.PersonaYaEsSocioEnBD(socioParaGuardar.IdPersona))
                    {
                        MessageBox.Show("Esta persona ya está registrada como socio.", "Socio Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblEstado.Text = $"Persona ID: {socioParaGuardar.IdPersona} ya es socio.";
                        return;
                    }

                    if (socioParaGuardar.GuardarNuevoSocioEnBD())
                    {
                        lblEstado.Text = $"Socio '{socioParaGuardar.Nombre} {socioParaGuardar.Apellido}' registrado. PersonaID: {socioParaGuardar.IdPersona}, SocioID: {socioParaGuardar.IdSocio}.";
                        MessageBox.Show($"¡Socio registrado exitosamente!\nID Persona: {socioParaGuardar.IdPersona}\nID Socio: {socioParaGuardar.IdSocio}",
                                        "Registro Socio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpiarCampos_Click(null, null);
                    }
                    else
                    {
                        lblEstado.Text = "Error al registrar los datos específicos del socio.";
                        MessageBox.Show("La persona fue creada, pero hubo un error al registrarla como Socio. Revise los logs o mensajes de error de la BD.", "Error Parcial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (personaAProcesar is NoSocio noSocioParaGuardar)
                {
                    if (NoSocio.PersonaYaEsNoSocioEnBD(noSocioParaGuardar.IdPersona))
                    {
                        MessageBox.Show("Esta persona ya está registrada como No Socio.", "No Socio Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblEstado.Text = $"Persona ID: {noSocioParaGuardar.IdPersona} ya es No Socio.";
                        return;
                    }

                    if (noSocioParaGuardar.GuardarNuevoNoSocioEnBD())
                    {
                        lblEstado.Text = $"No Socio '{noSocioParaGuardar.Nombre} {noSocioParaGuardar.Apellido}' registrado. PersonaID: {noSocioParaGuardar.IdPersona}, NoSocioID: {noSocioParaGuardar.IdNoSocio}.";
                        MessageBox.Show($"¡No Socio registrado exitosamente!\nID Persona: {noSocioParaGuardar.IdPersona}\nID No Socio: {noSocioParaGuardar.IdNoSocio}",
                                        "Registro No Socio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpiarCampos_Click(null, null);
                    }
                    else
                    {
                        lblEstado.Text = "Error al registrar los datos específicos del No Socio.";
                        MessageBox.Show("La persona fue creada, pero hubo un error al registrarla como No Socio. Revise los logs o mensajes de error de la BD.", "Error Parcial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // El error al guardar en Persona ya fue (o debería ser) mostrado por personaAProcesar.GuardarNuevaPersonaEnBD()
                if (!lblEstado.Text.Contains("Error:"))
                {
                    lblEstado.Text = "Error: No se pudo registrar la persona.";
                }
            }

        }

        private void btnVerificarDni_Click(object sender, EventArgs e)
        {
            string dniAVerificar = txtDni.Text.Trim();

            // Validación básica del campo DNI antes de consultar la BD
            if (string.IsNullOrWhiteSpace(dniAVerificar))
            {
                MessageBox.Show("Por favor, ingrese un DNI para verificar.", "DNI Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDni.Focus();
                return;
            }
            if (!long.TryParse(dniAVerificar, out _))
            {
                MessageBox.Show("El DNI solo debe contener números.", "Formato DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                txtDni.SelectAll();
                return;
            }
            if (dniAVerificar.Length < 7 || dniAVerificar.Length > 8)
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos.", "Longitud DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                txtDni.SelectAll();
                return;
            }
            lblEstado.Text = "Verificando DNI...";
            Application.DoEvents();
            NoSocio personaParaVerificar = new NoSocio();
            personaParaVerificar.Dni = dniAVerificar; // Asignamos el DNI que queremos verificar

            if (personaParaVerificar.ExisteEnBD()) // Llamamos al método de instancia del objeto
            {
                lblEstado.Text = "DNI ya registrado.";
                MessageBox.Show("El DNI ingresado ya se encuentra registrado en la base de datos.",
                                "DNI Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                txtDni.SelectAll();
            }
            else
            {
                lblEstado.Text = "DNI disponible para registro.";
                dtpFechaNacimiento.Focus(); // Mover foco al siguiente campo relevante
            }
        }

        private void chkFichaMedica_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

