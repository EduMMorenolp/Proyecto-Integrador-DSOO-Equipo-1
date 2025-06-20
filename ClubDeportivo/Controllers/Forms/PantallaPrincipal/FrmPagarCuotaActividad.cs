using ClubDeportivo.Database; // Para DBConnection
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
using MySql.Data.MySqlClient;
using System.Net;

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

         private void btnCancelar_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void rbMetodoTarjeta_CheckedChanged(object sender, EventArgs e)
         {
             if (rbMetodoTarjeta.Checked)
             {
                 rbMetodoTarjeta.Checked = true;
                 rbMetodoEfectivo.Enabled = false;
                 rb3Cuotas.Enabled = true;
                 rb6Cuotas.Enabled = true;
             }
         }


         private void rb3Cuotas_CheckedChanged(object sender, EventArgs e)
         {
             if (rb3Cuotas.Checked)
             {
                 rbMetodoTarjeta.Enabled = true;
                 rb3Cuotas.Enabled = true;
                 rb6Cuotas.Enabled = false;

             }
         }

         private void rb6Cuotas_CheckedChanged(object sender, EventArgs e)
         {
             if (rb6Cuotas.Checked)
             {
                 rbMetodoTarjeta.Enabled = true;
                 rb3Cuotas.Enabled = false;
                 rb6Cuotas.Enabled = true;

             }
         }


         private void rbMetodoEfectivo_CheckedChanged(object sender, EventArgs e)
         {
             if (rbMetodoEfectivo.Checked)
             {
                 rbMetodoTarjeta.Enabled = false;
                 rb3Cuotas.Enabled = false;
                 rb6Cuotas.Enabled = false;
             }
         }


         private void btnRealizar_Click(object sender, EventArgs e)
         {

             string medioPago = rbMetodoEfectivo.Checked ? "Efectivo" : "Tarjeta";


             DateTime fechaPago = dtbFechaPago.Value;

             if (rbCuota.Checked)
             {

                 if (string.IsNullOrWhiteSpace(txtDniSocio.Text) || string.IsNullOrWhiteSpace(txtMontoCuota.Text))
                 {
                     MessageBox.Show("Debe completar DNI de Socio y Monto.", "Validación Cuota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
                 }

                 string dniSocio = txtDniSocio.Text.Trim();
                 int idSocio = Socio.ObtenerIdSocioPorDni(dniSocio);

                 if (idSocio == -1)
                 {
                     MessageBox.Show("El socio con ese DNI no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }

                 if (!float.TryParse(txtMontoCuota.Text, out float montoCuota))
                 {
                     MessageBox.Show("Monto inválido para cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                 }


                 if (!rbMetodoEfectivo.Checked && !rbMetodoTarjeta.Checked && !rb3Cuotas.Checked && !rb6Cuotas.Checked)
                 {
                     MessageBox.Show("Debe seleccionar un método de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
                 }
                 // Crear y guardar objeto Cuota
                 Cuota nuevaCuota = new Cuota(idSocio, false, montoCuota, fechaPago, fechaPago.AddMonths(1), medioPago, 0);


                 bool exito = nuevaCuota.GuardarEnBD();
                 if (exito)
                 {
                     MessageBox.Show("Pago de cuota registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     //  Limpiar();
                 }
                 else
                 {
                     MessageBox.Show("Error al registrar el pago de cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }

             else if (rbActividad.Checked)
             {
                 // Validaciones para pago de actividad
                 if (string.IsNullOrWhiteSpace(txtDniNoSocio.Text) || string.IsNullOrWhiteSpace(txtActividad.Text) || string.IsNullOrWhiteSpace(txtMontoActividad.Text))
                 {
                     MessageBox.Show("Debe completar DNI, Actividad y Monto.", "Validación Actividad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
                 }
                 string dni = txtDniNoSocio.Text.Trim();
                 string nombreActividad = txtActividad.Text.Trim();
                 if (!float.TryParse(txtMontoActividad.Text, out float montoActividad))
                 {
                     MessageBox.Show("Monto inválido para actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }



                 int idPersona = Persona.ObtenerIdPorDni(dni);



                 if (idPersona == -1)
                 {
                     MessageBox.Show("No existe una persona con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }
                 int idActividad = Actividad.ObtenerIdPorNombre(nombreActividad);
                 if (idActividad == -1)
                 {
                     MessageBox.Show("Actividad no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }

                 // Crear y guardar objeto PagoActividad
                 PagoActividad nuevoPago = new PagoActividad
                 {
                     IdPersona = idPersona,
                     IdActividad = idActividad,
                     Monto = montoActividad,
                     MedioPago = medioPago,
                     FechaPago = fechaPago
                 };


                 bool exito = nuevoPago.GuardarEnBD();
                 if (exito)
                 {
                     MessageBox.Show("Pago de actividad registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     //Limpiar();
                 }
                 else
                 {
                     MessageBox.Show("Error al registrar pago de actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
             else
             {
                 // No se seleccionó ninguna opción
                 MessageBox.Show("Debe seleccionar si desea pagar una Cuota o una Actividad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }


         }

         private void dtbFechaPago_ValueChanged(object sender, EventArgs e)
         {
             DateTime fechaPago = dtbFechaPago.Value;
         }



         //ver como eliminar 
         private void txtDniSocio_TextChanged(object sender, EventArgs e)
         {

         }
         private void txtMontoCuota_TextChanged(object sender, EventArgs e)
         {

         }
         private void txtDniNoSocio_TextChanged(object sender, EventArgs e)
         {

         }
         private void lblMetodoPago_Click(object sender, EventArgs e)
         {
         }

         
    }


}
    



        

    




