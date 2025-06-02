using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Controllers.Forms.PantallaPrincipal;

namespace ClubDeportivo.Controllers.Forms
{
    public partial class FrmPantallaPrincipal : Form
    {
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarPersona_Click(object sender, EventArgs e)
        {
            FrmRegistrarPersona frm = new FrmRegistrarPersona();
            frm.ShowDialog(this);
        }

        private void btnEntregarCarnet_Click(object sender, EventArgs e)
        {
            FrmEntregarCarnet frm = new FrmEntregarCarnet();
            frm.ShowDialog(this);
        }

        private void btnPagarCuotaActividad_Click(object sender, EventArgs e)
        {
            FrmPagarCuotaActividad frm = new FrmPagarCuotaActividad();
            frm.ShowDialog(this);
        }

        private void btnListarCuotasVencidas_Click(object sender, EventArgs e)
        {
            FrmListarCuotasVencidas frm = new FrmListarCuotasVencidas();
            frm.ShowDialog(this);
        }

        private void FrmPantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir de la aplicación?",
                                                         "Confirmar Salida",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void FrmPantallaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
