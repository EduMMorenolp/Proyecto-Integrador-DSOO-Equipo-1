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
    public partial class FrmEntregarCarnet : Form
    {
        public FrmEntregarCarnet()
        {
            InitializeComponent();
        }

        private void FrmEntregarCarnet_Load(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();

            bool resultado = Socio.ActualizarCarnet(dni);

            if (resultado)
            {
                lblOutput.Text = "Carnet entregado con éxito.";
                lblOutput.BackColor = Color.Green;
                MessageBox.Show("Carnet entregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // El mensaje ya fue mostrado dentro del método
                lblOutput.Text = "Hubo un error al entregar el carnet.";
                lblOutput.BackColor = Color.Red;
            }
        }

        private void btnLimpiarCampo_Click(object sender, EventArgs e)
        {
            txtDni.Text = "";
            lblOutput.Text = "";
            
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TO DO Backend:
        // Cuando el usuario le da click al boton limpiar campo:
        // - Vaciar el campo --- listo

        // Cuando el usuario le da click al boton salir:
        // - Cerrar formulario --- listo

        // Cuando el usuario le da click al boton enviar:
        // - Validar que el valor del campo sea un numero y que sea menor a 10 digitos -- listo 
        // - Verificar que el socio existe en la tabla socios, usando el DNI ---- listo
        // - Verificar que el socio tenga el valor de tieneCarnet en falso ---- listo
        // - Cambiar el valor por verdadero ----- listo
        // - Mostrar los mensajes de exito o error en la label lblOutput ---- listo 
    }
}
