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
            btnCancelar = new Button();
            btnRealizar = new Button();
            gpTipo.SuspendLayout();
            gbCuota.SuspendLayout();
            gbActividad.SuspendLayout();
            SuspendLayout();
            // 
            // gpTipo
            // 
            gpTipo.Controls.Add(rbActividad);
            gpTipo.Controls.Add(rbCuota);
            gpTipo.Location = new Point(17, 20);
            gpTipo.Margin = new Padding(4, 5, 4, 5);
            gpTipo.Name = "gpTipo";
            gpTipo.Padding = new Padding(4, 5, 4, 5);
            gpTipo.Size = new Size(680, 98);
            gpTipo.TabIndex = 0;
            gpTipo.TabStop = false;
            gpTipo.Text = "Tipo de Pago";
            // 
            // rbActividad
            // 
            rbActividad.AutoSize = true;
            rbActividad.Location = new Point(330, 37);
            rbActividad.Margin = new Padding(4, 5, 4, 5);
            rbActividad.Name = "rbActividad";
            rbActividad.Size = new Size(111, 29);
            rbActividad.TabIndex = 1;
            rbActividad.TabStop = true;
            rbActividad.Text = "Actividad";
            rbActividad.UseVisualStyleBackColor = true;
            rbActividad.CheckedChanged += rbActividad_CheckedChanged;
            // 
            // rbCuota
            // 
            rbCuota.AutoSize = true;
            rbCuota.Location = new Point(30, 37);
            rbCuota.Margin = new Padding(4, 5, 4, 5);
            rbCuota.Name = "rbCuota";
            rbCuota.Size = new Size(84, 29);
            rbCuota.TabIndex = 0;
            rbCuota.TabStop = true;
            rbCuota.Text = "Cuota";
            rbCuota.UseVisualStyleBackColor = true;
            rbCuota.CheckedChanged += rbCuota_CheckedChanged;
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
            gbCuota.Location = new Point(17, 128);
            gbCuota.Margin = new Padding(4, 5, 4, 5);
            gbCuota.Name = "gbCuota";
            gbCuota.Padding = new Padding(4, 5, 4, 5);
            gbCuota.Size = new Size(680, 305);
            gbCuota.TabIndex = 1;
            gbCuota.TabStop = false;
            gbCuota.Text = "Cuota";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(14, 243);
            lblFechaPago.Margin = new Padding(4, 0, 4, 0);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(131, 25);
            lblFechaPago.TabIndex = 11;
            lblFechaPago.Text = "Fecha de Pago:";
            // 
            // dtbFechaPago
            // 
            dtbFechaPago.Format = DateTimePickerFormat.Short;
            dtbFechaPago.Location = new Point(147, 233);
            dtbFechaPago.Margin = new Padding(4, 5, 4, 5);
            dtbFechaPago.Name = "dtbFechaPago";
            dtbFechaPago.Size = new Size(135, 31);
            dtbFechaPago.TabIndex = 10;
            dtbFechaPago.ValueChanged += dtbFechaPago_ValueChanged;
            // 
            // rb6Cuotas
            // 
            rb6Cuotas.AutoSize = true;
            rb6Cuotas.Location = new Point(286, 190);
            rb6Cuotas.Margin = new Padding(4, 5, 4, 5);
            rb6Cuotas.Name = "rb6Cuotas";
            rb6Cuotas.Size = new Size(107, 29);
            rb6Cuotas.TabIndex = 9;
            rb6Cuotas.TabStop = true;
            rb6Cuotas.Text = "6 Cuotas";
            rb6Cuotas.UseVisualStyleBackColor = true;
            rb6Cuotas.CheckedChanged += rb6Cuotas_CheckedChanged;
            // 
            // rb3Cuotas
            // 
            rb3Cuotas.AutoSize = true;
            rb3Cuotas.Location = new Point(143, 192);
            rb3Cuotas.Margin = new Padding(4, 5, 4, 5);
            rb3Cuotas.Name = "rb3Cuotas";
            rb3Cuotas.Size = new Size(107, 29);
            rb3Cuotas.TabIndex = 8;
            rb3Cuotas.TabStop = true;
            rb3Cuotas.Text = "3 Cuotas";
            rb3Cuotas.UseVisualStyleBackColor = true;
            rb3Cuotas.CheckedChanged += rb3Cuotas_CheckedChanged;
            // 
            // lblCuotaTarjeta
            // 
            lblCuotaTarjeta.AutoSize = true;
            lblCuotaTarjeta.Location = new Point(14, 195);
            lblCuotaTarjeta.Margin = new Padding(4, 0, 4, 0);
            lblCuotaTarjeta.Name = "lblCuotaTarjeta";
            lblCuotaTarjeta.Size = new Size(126, 25);
            lblCuotaTarjeta.TabIndex = 7;
            lblCuotaTarjeta.Text = "Cuotas Tarjeta:";
            // 
            // rbMetodoTarjeta
            // 
            rbMetodoTarjeta.AutoSize = true;
            rbMetodoTarjeta.Location = new Point(267, 148);
            rbMetodoTarjeta.Margin = new Padding(4, 5, 4, 5);
            rbMetodoTarjeta.Name = "rbMetodoTarjeta";
            rbMetodoTarjeta.Size = new Size(175, 29);
            rbMetodoTarjeta.TabIndex = 6;
            rbMetodoTarjeta.TabStop = true;
            rbMetodoTarjeta.Text = "Tarjeta de Credito";
            rbMetodoTarjeta.UseVisualStyleBackColor = true;
            rbMetodoTarjeta.CheckedChanged += rbMetodoTarjeta_CheckedChanged;
            // 
            // rbMetodoEfectivo
            // 
            rbMetodoEfectivo.AutoSize = true;
            rbMetodoEfectivo.Location = new Point(163, 148);
            rbMetodoEfectivo.Margin = new Padding(4, 5, 4, 5);
            rbMetodoEfectivo.Name = "rbMetodoEfectivo";
            rbMetodoEfectivo.Size = new Size(99, 29);
            rbMetodoEfectivo.TabIndex = 5;
            rbMetodoEfectivo.TabStop = true;
            rbMetodoEfectivo.Text = "Efectivo";
            rbMetodoEfectivo.UseVisualStyleBackColor = true;
            rbMetodoEfectivo.CheckedChanged += rbMetodoEfectivo_CheckedChanged;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(14, 152);
            lblMetodoPago.Margin = new Padding(4, 0, 4, 0);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(150, 25);
            lblMetodoPago.TabIndex = 4;
            lblMetodoPago.Text = "Metodo de Pago:";
            lblMetodoPago.Click += lblMetodoPago_Click;
            // 
            // txtMontoCuota
            // 
            txtMontoCuota.Location = new Point(110, 97);
            txtMontoCuota.Margin = new Padding(4, 5, 4, 5);
            txtMontoCuota.Name = "txtMontoCuota";
            txtMontoCuota.Size = new Size(194, 31);
            txtMontoCuota.TabIndex = 3;
            txtMontoCuota.TextChanged += txtMontoCuota_TextChanged;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(14, 107);
            lblMonto.Margin = new Padding(4, 0, 4, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(70, 25);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto:";
            // 
            // txtDniSocio
            // 
            txtDniSocio.Location = new Point(110, 48);
            txtDniSocio.Margin = new Padding(4, 5, 4, 5);
            txtDniSocio.Name = "txtDniSocio";
            txtDniSocio.Size = new Size(194, 31);
            txtDniSocio.TabIndex = 1;
            txtDniSocio.TextChanged += txtDniSocio_TextChanged;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(13, 53);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(96, 25);
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
            gbActividad.Location = new Point(17, 443);
            gbActividad.Margin = new Padding(4, 5, 4, 5);
            gbActividad.Name = "gbActividad";
            gbActividad.Padding = new Padding(4, 5, 4, 5);
            gbActividad.Size = new Size(680, 225);
            gbActividad.TabIndex = 2;
            gbActividad.TabStop = false;
            gbActividad.Text = "Actividad";
            // 
            // txtMontoActividad
            // 
            txtMontoActividad.Location = new Point(139, 142);
            txtMontoActividad.Margin = new Padding(4, 5, 4, 5);
            txtMontoActividad.Name = "txtMontoActividad";
            txtMontoActividad.Size = new Size(141, 31);
            txtMontoActividad.TabIndex = 5;
            // 
            // lblMontoActividad
            // 
            lblMontoActividad.AutoSize = true;
            lblMontoActividad.Location = new Point(13, 147);
            lblMontoActividad.Margin = new Padding(4, 0, 4, 0);
            lblMontoActividad.Name = "lblMontoActividad";
            lblMontoActividad.Size = new Size(70, 25);
            lblMontoActividad.TabIndex = 4;
            lblMontoActividad.Text = "Monto:";
            // 
            // txtActividad
            // 
            txtActividad.Location = new Point(139, 88);
            txtActividad.Margin = new Padding(4, 5, 4, 5);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(141, 31);
            txtActividad.TabIndex = 3;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(13, 93);
            lblActividad.Margin = new Padding(4, 0, 4, 0);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(90, 25);
            lblActividad.TabIndex = 2;
            lblActividad.Text = "Actividad:";
            // 
            // txtDniNoSocio
            // 
            txtDniNoSocio.Location = new Point(139, 37);
            txtDniNoSocio.Margin = new Padding(4, 5, 4, 5);
            txtDniNoSocio.Name = "txtDniNoSocio";
            txtDniNoSocio.Size = new Size(141, 31);
            txtDniNoSocio.TabIndex = 1;
            txtDniNoSocio.TextChanged += txtDniNoSocio_TextChanged;
            // 
            // lblDniNoSocio
            // 
            lblDniNoSocio.AutoSize = true;
            lblDniNoSocio.Location = new Point(13, 42);
            lblDniNoSocio.Margin = new Padding(4, 0, 4, 0);
            lblDniNoSocio.Name = "lblDniNoSocio";
            lblDniNoSocio.Size = new Size(125, 25);
            lblDniNoSocio.TabIndex = 0;
            lblDniNoSocio.Text = "DNI No Socio:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(480, 852);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 38);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRealizar
            // 
            btnRealizar.Location = new Point(127, 852);
            btnRealizar.Margin = new Padding(4, 5, 4, 5);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(134, 38);
            btnRealizar.TabIndex = 3;
            btnRealizar.Text = "Realizar Pago";
            btnRealizar.UseVisualStyleBackColor = true;
            btnRealizar.Click += btnRealizar_Click;
            // 
            // FrmPagarCuotaActividad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 925);
            Controls.Add(btnCancelar);
            Controls.Add(gbActividad);
            Controls.Add(gbCuota);
            Controls.Add(gpTipo);
            Controls.Add(btnRealizar);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button btnCancelar;
        private Button btnRealizar;
    }
}