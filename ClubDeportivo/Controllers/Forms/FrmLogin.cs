using System.Data;

namespace ClubDeportivo.Controllers.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // 1. Obtener los valores de los TextBox
            string nombreUsuario = txtUsuario.Text.Trim(); // .Trim() quita espacios al inicio y final
            string contrasena = txtContraseña.Text;

            // 2. Validar que los campos no estén vacíos (validación básica)
            if (string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("Por favor, ingrese su nombre de usuario.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese su contraseña.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return;
            }
            DataTable tablaLogin = new DataTable();
            // tablaLogin = dato.Log_Usu(txtUsuario.Text, txtContraseña.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("¡Login Exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el formulario del Menú Principal
                FrmPantallaPrincipal menuForm = new FrmPantallaPrincipal(); // Asume que tienes un frmMenuPrincipal
                menuForm.Show(); // Muestra el nuevo formulario

                this.Hide(); // Oculta el formulario de Login
                             // O si quieres cerrar completamente el login y que la app termine si se cierra el menú:
                             // this.Close();
                             // Y en Program.cs, Application.Run(new frmLogin()); y luego frmLogin decide si abrir otro o cerrar la app.
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();       // Limpia los campos
                txtContraseña.Clear();
                txtUsuario.Focus();       // Pone el foco en el usuario
            }
        }

        // Opcional: Permitir ingresar con la tecla Enter en el campo de contraseña
        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(sender, e); // Llama al mismo método del botón
                e.SuppressKeyPress = true; // Evita el "ding" de Windows
            }
        }

        // Opcional: Asegurar que la aplicación se cierre si este formulario se cierra
        // y no se ha abierto otro principal.
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Si el formulario se cierra por el usuario (ej. botón X) y no se ha abierto
            // el menú principal (o sea, el login no fue exitoso), entonces cierra la aplicación.
            // Esto requiere una forma de saber si el login fue exitoso.
            // Una manera es tener una bandera o verificar si hay otros formularios abiertos.
            // Si el menú principal maneja Application.Exit() al cerrarse, esto puede no ser necesario.
            // if (this.Visible == false && Application.OpenForms.Count == 0) // Ejemplo simplificado
            // {
            //    Application.Exit();
            // }
        }
    }
}
