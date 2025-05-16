using ClubDeportivo.Models;

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
            string nombreUsuario = txtUsuario.Text.Trim();
            string contrasena = txtContraseña.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor complete ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ClubDeportivo.Models.Administrador.ValidarAdministrador(nombreUsuario, contrasena))
            {
                MessageBox.Show("¡Bienvenido, Administrador!", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FrmPantallaPrincipal pantallaPrincipal = new FrmPantallaPrincipal();
                pantallaPrincipal.FormClosed += (s, args) => this.Close();
                pantallaPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtContraseña.Focus();
            }
        }
    }
}
