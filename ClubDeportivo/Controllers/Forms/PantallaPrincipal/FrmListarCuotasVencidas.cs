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
    public partial class FrmListarCuotasVencidas : Form
    {
        public FrmListarCuotasVencidas()
        {
            InitializeComponent();
        }

        // TO DO:
        // Al hacer click en filtrar:
        // - Validar que el valor del campo sea un numero y que sea menor a 10 digitos
        // - Verificar que el socio existe
        // - Crear un groupBox dinamicamente con el DNI del usuario y si la cuota esta vencida o no

        // Al hacer click en ver vencidas:
        // - Obtener de la base de datos el DNI de los socios cuya cuota esta vencida
        // - Crear un groupBox dinamicamente por cada socio donde se vea el DNI y que la cuota esta vencida

        // Al hacer click en ver no vencidas:
        // - Obtener de la base de datos el DNI de los socios cuya cuota NO esta vencida
        // - Crear un groupBox dinamicamente por cada socio donde se vea el DNI y que la cuota NO esta vencida

        // Al hacer click en ver todas:
        // - Obtener de la base de datos el DNI de todos los socios
        // - Crear un groupBox dinamicamente por cada socio donde se vea el DNI y si la cuota esta o no vencida
    }
}
