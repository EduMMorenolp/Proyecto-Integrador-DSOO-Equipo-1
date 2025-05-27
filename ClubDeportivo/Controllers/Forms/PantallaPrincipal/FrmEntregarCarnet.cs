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

        }

        // TO DO Backend:
        // Cuando el usuario le da click al boton limpiar campo:
        // - Vaciar el campo

        // Cuando el usuario le da click al boton salir:
        // - Cerrar formulario

        // Cuando el usuario le da click al boton enviar:
        // - Validar que el valor del campo sea un numero y que sea menor a 10 digitos
        // - Verificar que el socio existe en la tabla socios, usando el DNI
        // - Verificar que el socio tenga el valor de tieneCarnet en falso
        // - Cambiar el valor por verdadero
        // - Mostrar los mensajes de exito o error en la label lblOutput
    }
}
