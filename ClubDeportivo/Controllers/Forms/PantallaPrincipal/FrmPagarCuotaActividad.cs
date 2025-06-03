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
    public partial class FrmPagarCuotaActividad : Form
    {
        public FrmPagarCuotaActividad()
        {
            InitializeComponent();
        }

        private void FrmPagarCuotaActividad_Load(object sender, EventArgs e)
        {
            dtbFechaPago.Value = DateTime.Now;
            rbCuota.Checked = true;
            ActualizarVisibilidadPaneles();
        }
        private void rbCuota_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVisibilidadPaneles();
        }
        private void rbActividad_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarVisibilidadPaneles();
        }
        private void ActualizarVisibilidadPaneles()
        {
            if (rbCuota.Checked)
            {
                gbCuota.Visible = true;
                gbActividad.Visible = false;
            }
            else if (rbActividad.Checked)
            {
                gbCuota.Visible = false;
                gbActividad.Visible = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



