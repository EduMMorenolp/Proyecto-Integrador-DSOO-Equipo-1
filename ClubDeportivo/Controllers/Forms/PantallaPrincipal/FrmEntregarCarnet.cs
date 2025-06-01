using ClubDeportivo.Database.Data_Access_Layer;
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
            //if (txtDni.Text == ""  )
            if(string.IsNullOrEmpty(txtDni.Text) /*|| txtDni.Text.Length > 10 || txtDni.Text.All(char.IsDigit)*/)
            {
                MessageBox.Show("el campo DNI no puede estar vacio, no debe superar los 10 digitos");
                lblOutput.Text = "el campo DNI no puede estar vacio";
                lblOutput.BackColor = Color.Red;

            }
            else
            {
                SocioDAL socioDal1 = new SocioDAL();
                
                if (!socioDal1.TieneCarnet(txtDni.Text) && socioDal1.PersonaSocioDni(txtDni.Text))
                {
                    lblOutput.Text = "carnet entregado con exito" + socioDal1.TieneCarnet(txtDni.Text) + " " + socioDal1.PersonaSocioDni(txtDni.Text);
                    socioDal1.EntregarCarnetPorDNI(txtDni.Text);
                    MessageBox.Show("carnet entregado con exito");
                }
                else if (socioDal1.TieneCarnet(txtDni.Text))
                {
                    lblOutput.Text = "este socio tiene carnet";

                }
                else if (!socioDal1.PersonaSocioDni(txtDni.Text))
                {
                    lblOutput.Text = "esta persona no es socio";
                }
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
