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
    public partial class FrmAgregarActividad : Form
    {
        public FrmAgregarActividad()
        {
            InitializeComponent();
        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreActividad.Clear();
            txtTipo.Clear();
            txtProfesor.Clear();
            textHorario.Clear();
            numericUpDownCapacidad.Value = numericUpDownCapacidad.Minimum;
            numericUpDownCosto.Value = numericUpDownCosto.Minimum;
        }
    }
}
