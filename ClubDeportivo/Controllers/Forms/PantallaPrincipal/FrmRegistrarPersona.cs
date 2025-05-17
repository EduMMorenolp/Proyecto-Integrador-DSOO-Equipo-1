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
            Application.DoEvents(); // Para que el label se actualice

            // --- PASO 3: Lógica de Negocio y DAL (usando PersonaDAL) ---
            PersonaDAL personaDAL = new PersonaDAL();
            SocioDAL socioDAL = new SocioDAL(); // Crear una instancia de SocioDAL

            // 1. Verificar si la persona (DNI) ya existe en la tabla Persona
            if (personaDAL.ExistePersona(dni))
            {
                MessageBox.Show("El DNI ingresado ya se encuentra registrado.", "DNI Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblEstado.Text = "Error: DNI ya existe.";
                txtDni.Focus();
                txtDni.SelectAll();
                return;
            }

            // Si el DNI no existe, creamos el objeto base
            // Usaremos un objeto Socio para pasar a PersonaDAL, ya que Persona es abstracta
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
                personaParaInsertar.IdPersona = idPersonaGenerado; // Guardar el ID en el objeto

                if (rbSocio.Checked) // Si se seleccionó registrar como Socio
                {
                    // Antes de insertar, podríamos verificar si esta persona ya es socio (si id_persona es UNIQUE en Socio)
                    if (socioDAL.PersonaYaEsSocio(idPersonaGenerado))
                    {
                        MessageBox.Show("Esta persona ya está registrada como socio.", "Socio Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblEstado.Text = $"Persona ID: {idPersonaGenerado} ya es socio.";
                        // Podrías limpiar campos o decidir qué hacer. No insertamos de nuevo en Socio.
                        return;
                    }

                    // Llenar los datos específicos del Socio en el objeto 'personaParaInsertar' (que es un Socio)
                    personaParaInsertar.FechaAlta = dtpFechaAlta.Value; // dtpFechaAlta es el DateTimePicker de Fecha Alta
                    personaParaInsertar.FichaMedica = chkFichaMedica.Checked; // chkFichaMedica es el CheckBox
                    personaParaInsertar.TieneCarnet = false; // Por defecto al registrar un nuevo socio
                    personaParaInsertar.CuotaHasta = null;   // Se actualizará con el primer pago

                    if (socioDAL.InsertarSocio(personaParaInsertar, idPersonaGenerado))
                    {
                        // El IdSocio se genera en la BD, si lo necesitas, SocioDAL.InsertarSocio debería devolverlo.
                        // Por ahora, solo confirmamos la inserción.
                        lblEstado.Text = $"Socio '{nombre} {apellido}' registrado con ID Persona: {idPersonaGenerado}.";
                        MessageBox.Show($"¡Socio registrado exitosamente!\nID Persona: {idPersonaGenerado}",
                                        "Registro Socio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpiarCampos_Click(null, null);
                    }
                    else
                    {
                        lblEstado.Text = "Error al registrar los datos específicos del socio.";
                        // Aquí podrías considerar si quieres eliminar la entrada de Persona si falla la de Socio
                        // (requiere una transacción o un método EliminarPersona en PersonaDAL).
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
