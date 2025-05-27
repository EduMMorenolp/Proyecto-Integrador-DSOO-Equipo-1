namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
    partial class FrmPagarCuotaActividad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpTipo = new GroupBox();
            rbActividad = new RadioButton();
            rbCuota = new RadioButton();
            gbCuota = new GroupBox();
            lblFechaPago = new Label();
            dtbFechaPago = new DateTimePicker();
            rb6Cuotas = new RadioButton();
            rb3Cuotas = new RadioButton();
            lblCuotaTarjeta = new Label();
            rbMetodoTarjeta = new RadioButton();
            rbMetodoEfectivo = new RadioButton();
            lblMetodoPago = new Label();
            txtMontoCuota = new TextBox();
            lblMonto = new Label();
            txtDniSocio = new TextBox();
            lblDNI = new Label();
            gbActividad = new GroupBox();
            txtMontoActividad = new TextBox();
            lblMontoActividad = new Label();
            txtActividad = new TextBox();
            lblActividad = new Label();
            txtDniNoSocio = new TextBox();
            lblDniNoSocio = new Label();
            btnRealizar = new Button();
            btnCancelar = new Button();
            gpTipo.SuspendLayout();
            gbCuota.SuspendLayout();
            gbActividad.SuspendLayout();
            SuspendLayout();
            // 
            // gpTipo
            // 
            gpTipo.Controls.Add(rbActividad);
            gpTipo.Controls.Add(rbCuota);
            gpTipo.Location = new Point(12, 12);
            gpTipo.Name = "gpTipo";
            gpTipo.Size = new Size(476, 59);
            gpTipo.TabIndex = 0;
            gpTipo.TabStop = false;
            gpTipo.Text = "Tipo de Pago";
            // 
            // rbActividad
            // 
            rbActividad.AutoSize = true;
            rbActividad.Location = new Point(231, 22);
            rbActividad.Name = "rbActividad";
            rbActividad.Size = new Size(75, 19);
            rbActividad.TabIndex = 1;
            rbActividad.TabStop = true;
            rbActividad.Text = "Actividad";
            rbActividad.UseVisualStyleBackColor = true;
            // 
            // rbCuota
            // 
            rbCuota.AutoSize = true;
            rbCuota.Location = new Point(21, 22);
            rbCuota.Name = "rbCuota";
            rbCuota.Size = new Size(57, 19);
            rbCuota.TabIndex = 0;
            rbCuota.TabStop = true;
            rbCuota.Text = "Cuota";
            rbCuota.UseVisualStyleBackColor = true;
            // 
            // gbCuota
            // 
            gbCuota.Controls.Add(lblFechaPago);
            gbCuota.Controls.Add(dtbFechaPago);
            gbCuota.Controls.Add(rb6Cuotas);
            gbCuota.Controls.Add(rb3Cuotas);
            gbCuota.Controls.Add(lblCuotaTarjeta);
            gbCuota.Controls.Add(rbMetodoTarjeta);
            gbCuota.Controls.Add(rbMetodoEfectivo);
            gbCuota.Controls.Add(lblMetodoPago);
            gbCuota.Controls.Add(txtMontoCuota);
            gbCuota.Controls.Add(lblMonto);
            gbCuota.Controls.Add(txtDniSocio);
            gbCuota.Controls.Add(lblDNI);
            gbCuota.Location = new Point(12, 77);
            gbCuota.Name = "gbCuota";
            gbCuota.Size = new Size(476, 183);
            gbCuota.TabIndex = 1;
            gbCuota.TabStop = false;
            gbCuota.Text = "Cuota";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(10, 146);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(87, 15);
            lblFechaPago.TabIndex = 11;
            lblFechaPago.Text = "Fecha de Pago:";
            // 
            // dtbFechaPago
            // 
            dtbFechaPago.Format = DateTimePickerFormat.Short;
            dtbFechaPago.Location = new Point(103, 140);
            dtbFechaPago.Name = "dtbFechaPago";
            dtbFechaPago.Size = new Size(96, 23);
            dtbFechaPago.TabIndex = 10;
            // 
            // rb6Cuotas
            // 
            rb6Cuotas.AutoSize = true;
            rb6Cuotas.Location = new Point(200, 114);
            rb6Cuotas.Name = "rb6Cuotas";
            rb6Cuotas.Size = new Size(71, 19);
            rb6Cuotas.TabIndex = 9;
            rb6Cuotas.TabStop = true;
            rb6Cuotas.Text = "6 Cuotas";
            rb6Cuotas.UseVisualStyleBackColor = true;
            // 
            // rb3Cuotas
            // 
            rb3Cuotas.AutoSize = true;
            rb3Cuotas.Location = new Point(100, 115);
            rb3Cuotas.Name = "rb3Cuotas";
            rb3Cuotas.Size = new Size(71, 19);
            rb3Cuotas.TabIndex = 8;
            rb3Cuotas.TabStop = true;
            rb3Cuotas.Text = "3 Cuotas";
            rb3Cuotas.UseVisualStyleBackColor = true;
            // 
            // lblCuotaTarjeta
            // 
            lblCuotaTarjeta.AutoSize = true;
            lblCuotaTarjeta.Location = new Point(10, 117);
            lblCuotaTarjeta.Name = "lblCuotaTarjeta";
            lblCuotaTarjeta.Size = new Size(84, 15);
            lblCuotaTarjeta.TabIndex = 7;
            lblCuotaTarjeta.Text = "Cuotas Tarjeta:";
            // 
            // rbMetodoTarjeta
            // 
            rbMetodoTarjeta.AutoSize = true;
            rbMetodoTarjeta.Location = new Point(187, 89);
            rbMetodoTarjeta.Name = "rbMetodoTarjeta";
            rbMetodoTarjeta.Size = new Size(117, 19);
            rbMetodoTarjeta.TabIndex = 6;
            rbMetodoTarjeta.TabStop = true;
            rbMetodoTarjeta.Text = "Tarjeta de Credito";
            rbMetodoTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbMetodoEfectivo
            // 
            rbMetodoEfectivo.AutoSize = true;
            rbMetodoEfectivo.Location = new Point(114, 89);
            rbMetodoEfectivo.Name = "rbMetodoEfectivo";
            rbMetodoEfectivo.Size = new Size(67, 19);
            rbMetodoEfectivo.TabIndex = 5;
            rbMetodoEfectivo.TabStop = true;
            rbMetodoEfectivo.Text = "Efectivo";
            rbMetodoEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(10, 91);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(98, 15);
            lblMetodoPago.TabIndex = 4;
            lblMetodoPago.Text = "Metodo de Pago:";
            // 
            // txtMontoCuota
            // 
            txtMontoCuota.Location = new Point(77, 58);
            txtMontoCuota.Name = "txtMontoCuota";
            txtMontoCuota.Size = new Size(137, 23);
            txtMontoCuota.TabIndex = 3;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(10, 64);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(46, 15);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto:";
            // 
            // txtDniSocio
            // 
            txtDniSocio.Location = new Point(77, 29);
            txtDniSocio.Name = "txtDniSocio";
            txtDniSocio.Size = new Size(137, 23);
            txtDniSocio.TabIndex = 1;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(9, 32);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(62, 15);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI Socio:";
            // 
            // gbActividad
            // 
            gbActividad.Controls.Add(txtMontoActividad);
            gbActividad.Controls.Add(lblMontoActividad);
            gbActividad.Controls.Add(txtActividad);
            gbActividad.Controls.Add(lblActividad);
            gbActividad.Controls.Add(txtDniNoSocio);
            gbActividad.Controls.Add(lblDniNoSocio);
            gbActividad.Location = new Point(12, 266);
            gbActividad.Name = "gbActividad";
            gbActividad.Size = new Size(476, 135);
            gbActividad.TabIndex = 2;
            gbActividad.TabStop = false;
            gbActividad.Text = "Actividad";
            // 
            // txtMontoActividad
            // 
            txtMontoActividad.Location = new Point(97, 85);
            txtMontoActividad.Name = "txtMontoActividad";
            txtMontoActividad.Size = new Size(100, 23);
            txtMontoActividad.TabIndex = 5;
            // 
            // lblMontoActividad
            // 
            lblMontoActividad.AutoSize = true;
            lblMontoActividad.Location = new Point(9, 88);
            lblMontoActividad.Name = "lblMontoActividad";
            lblMontoActividad.Size = new Size(46, 15);
            lblMontoActividad.TabIndex = 4;
            lblMontoActividad.Text = "Monto:";
            // 
            // txtActividad
            // 
            txtActividad.Location = new Point(97, 53);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(100, 23);
            txtActividad.TabIndex = 3;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(9, 56);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(60, 15);
            lblActividad.TabIndex = 2;
            lblActividad.Text = "Actividad:";
            // 
            // txtDniNoSocio
            // 
            txtDniNoSocio.Location = new Point(97, 22);
            txtDniNoSocio.Name = "txtDniNoSocio";
            txtDniNoSocio.Size = new Size(100, 23);
            txtDniNoSocio.TabIndex = 1;
            // 
            // lblDniNoSocio
            // 
            lblDniNoSocio.AutoSize = true;
            lblDniNoSocio.Location = new Point(9, 25);
            lblDniNoSocio.Name = "lblDniNoSocio";
            lblDniNoSocio.Size = new Size(81, 15);
            lblDniNoSocio.TabIndex = 0;
            lblDniNoSocio.Text = "DNI No Socio:";
            // 
            // btnRealizar
            // 
            btnRealizar.Location = new Point(89, 511);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(94, 23);
            btnRealizar.TabIndex = 3;
            btnRealizar.Text = "Realizar Pago";
            btnRealizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(336, 511);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmPagarCuotaActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 555);
            Controls.Add(btnCancelar);
            Controls.Add(btnRealizar);
            Controls.Add(gbActividad);
            Controls.Add(gbCuota);
            Controls.Add(gpTipo);
            Name = "FrmPagarCuotaActividad";
            Text = "Pago Cuota Actividad";
            Load += FrmPagarCuotaActividad_Load;
            gpTipo.ResumeLayout(false);
            gpTipo.PerformLayout();
            gbCuota.ResumeLayout(false);
            gbCuota.PerformLayout();
            gbActividad.ResumeLayout(false);
            gbActividad.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpTipo;
        private RadioButton rbActividad;
        private RadioButton rbCuota;
        private GroupBox gbCuota;
        private Label lblMetodoPago;
        private TextBox txtMontoCuota;
        private Label lblMonto;
        private TextBox txtDniSocio;
        private Label lblDNI;
        private Label lblFechaPago;
        private DateTimePicker dtbFechaPago;
        private RadioButton rb6Cuotas;
        private RadioButton rb3Cuotas;
        private Label lblCuotaTarjeta;
        private RadioButton rbMetodoTarjeta;
        private RadioButton rbMetodoEfectivo;
        private GroupBox gbActividad;
        private Label lblDniNoSocio;
        private TextBox txtMontoActividad;
        private Label lblMontoActividad;
        private TextBox txtActividad;
        private Label lblActividad;
        private TextBox txtDniNoSocio;
        private Button btnRealizar;
        private Button btnCancelar;
    }
}