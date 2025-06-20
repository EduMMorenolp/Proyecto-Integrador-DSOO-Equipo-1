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
            txtMontoCuota = new TextBox();
            lblMonto = new Label();
            txtDniSocio = new TextBox();
            lblDNI = new Label();
            rb6Cuotas = new RadioButton();
            rb3Cuotas = new RadioButton();
            lblCuotaTarjeta = new Label();
            rbMetodoTarjeta = new RadioButton();
            rbMetodoEfectivo = new RadioButton();
            lblMetodoPago = new Label();
            gbActividad = new GroupBox();
            cmbActividad = new ComboBox();
            txtMontoActividad = new TextBox();
            lblMontoActividad = new Label();
            lblActividad = new Label();
            txtDniNoSocio = new TextBox();
            lblDniNoSocio = new Label();
            btnRealizar = new Button();
            btnCerrar = new Button();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            dtbFechaPago = new DateTimePicker();
            gpTipo.SuspendLayout();
            gbCuota.SuspendLayout();
            gbActividad.SuspendLayout();
            groupBox1.SuspendLayout();
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
            rbActividad.CheckedChanged += rbActividad_CheckedChanged;
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
            rbCuota.CheckedChanged += rbCuota_CheckedChanged;
            // 
            // gbCuota
            // 
            gbCuota.Controls.Add(txtMontoCuota);
            gbCuota.Controls.Add(lblMonto);
            gbCuota.Controls.Add(txtDniSocio);
            gbCuota.Controls.Add(lblDNI);
            gbCuota.Location = new Point(12, 226);
            gbCuota.Name = "gbCuota";
            gbCuota.Size = new Size(476, 95);
            gbCuota.TabIndex = 1;
            gbCuota.TabStop = false;
            gbCuota.Text = "Cuota";
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
            // rb6Cuotas
            // 
            rb6Cuotas.AutoSize = true;
            rb6Cuotas.Location = new Point(191, 64);
            rb6Cuotas.Name = "rb6Cuotas";
            rb6Cuotas.Size = new Size(71, 19);
            rb6Cuotas.TabIndex = 9;
            rb6Cuotas.TabStop = true;
            rb6Cuotas.Text = "6 Cuotas";
            rb6Cuotas.UseVisualStyleBackColor = true;
            rb6Cuotas.CheckedChanged += rb6Cuotas_CheckedChanged;
            // 
            // rb3Cuotas
            // 
            rb3Cuotas.AutoSize = true;
            rb3Cuotas.Location = new Point(114, 64);
            rb3Cuotas.Name = "rb3Cuotas";
            rb3Cuotas.Size = new Size(71, 19);
            rb3Cuotas.TabIndex = 8;
            rb3Cuotas.TabStop = true;
            rb3Cuotas.Text = "3 Cuotas";
            rb3Cuotas.UseVisualStyleBackColor = true;
            rb3Cuotas.CheckedChanged += rb3Cuotas_CheckedChanged;
            // 
            // lblCuotaTarjeta
            // 
            lblCuotaTarjeta.AutoSize = true;
            lblCuotaTarjeta.Location = new Point(10, 66);
            lblCuotaTarjeta.Name = "lblCuotaTarjeta";
            lblCuotaTarjeta.Size = new Size(84, 15);
            lblCuotaTarjeta.TabIndex = 7;
            lblCuotaTarjeta.Text = "Cuotas Tarjeta:";
            // 
            // rbMetodoTarjeta
            // 
            rbMetodoTarjeta.AutoSize = true;
            rbMetodoTarjeta.Location = new Point(187, 34);
            rbMetodoTarjeta.Name = "rbMetodoTarjeta";
            rbMetodoTarjeta.Size = new Size(117, 19);
            rbMetodoTarjeta.TabIndex = 6;
            rbMetodoTarjeta.TabStop = true;
            rbMetodoTarjeta.Text = "Tarjeta de Credito";
            rbMetodoTarjeta.UseVisualStyleBackColor = true;
            rbMetodoTarjeta.CheckedChanged += rbMetodoTarjeta_CheckedChanged;
            // 
            // rbMetodoEfectivo
            // 
            rbMetodoEfectivo.AutoSize = true;
            rbMetodoEfectivo.Location = new Point(114, 34);
            rbMetodoEfectivo.Name = "rbMetodoEfectivo";
            rbMetodoEfectivo.Size = new Size(67, 19);
            rbMetodoEfectivo.TabIndex = 5;
            rbMetodoEfectivo.TabStop = true;
            rbMetodoEfectivo.Text = "Efectivo";
            rbMetodoEfectivo.UseVisualStyleBackColor = true;
            rbMetodoEfectivo.CheckedChanged += rbMetodoEfectivo_CheckedChanged;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(10, 36);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(98, 15);
            lblMetodoPago.TabIndex = 4;
            lblMetodoPago.Text = "Metodo de Pago:";
            // 
            // gbActividad
            // 
            gbActividad.Controls.Add(cmbActividad);
            gbActividad.Controls.Add(txtMontoActividad);
            gbActividad.Controls.Add(lblMontoActividad);
            gbActividad.Controls.Add(lblActividad);
            gbActividad.Controls.Add(txtDniNoSocio);
            gbActividad.Controls.Add(lblDniNoSocio);
            gbActividad.Location = new Point(12, 327);
            gbActividad.Name = "gbActividad";
            gbActividad.Size = new Size(476, 120);
            gbActividad.TabIndex = 2;
            gbActividad.TabStop = false;
            gbActividad.Text = "Actividad";
            gbActividad.Enter += gbActividad_Enter;
            // 
            // cmbActividad
            // 
            cmbActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActividad.FormattingEnabled = true;
            cmbActividad.Location = new Point(97, 53);
            cmbActividad.Name = "cmbActividad";
            cmbActividad.Size = new Size(117, 23);
            cmbActividad.TabIndex = 6;
            cmbActividad.SelectedIndexChanged += cmbActividad_SelectedIndexChanged_1;
            // 
            // txtMontoActividad
            // 
            txtMontoActividad.Location = new Point(97, 85);
            txtMontoActividad.Name = "txtMontoActividad";
            txtMontoActividad.ReadOnly = true;
            txtMontoActividad.Size = new Size(117, 23);
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
            txtDniNoSocio.Size = new Size(117, 23);
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
            btnRealizar.Location = new Point(66, 482);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(94, 23);
            btnRealizar.TabIndex = 3;
            btnRealizar.Text = "Realizar Pago";
            btnRealizar.UseVisualStyleBackColor = true;
            btnRealizar.Click += btnRealizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(372, 482);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(199, 482);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(126, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtbFechaPago);
            groupBox1.Controls.Add(lblMetodoPago);
            groupBox1.Controls.Add(rbMetodoEfectivo);
            groupBox1.Controls.Add(rb6Cuotas);
            groupBox1.Controls.Add(rbMetodoTarjeta);
            groupBox1.Controls.Add(rb3Cuotas);
            groupBox1.Controls.Add(lblCuotaTarjeta);
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 144);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 100);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 13;
            label1.Text = "Fecha de Pago:";
            // 
            // dtbFechaPago
            // 
            dtbFechaPago.Format = DateTimePickerFormat.Short;
            dtbFechaPago.Location = new Point(114, 94);
            dtbFechaPago.Name = "dtbFechaPago";
            dtbFechaPago.Size = new Size(96, 23);
            dtbFechaPago.TabIndex = 12;
            // 
            // FrmPagarCuotaActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 539);
            Controls.Add(groupBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private RadioButton rb6Cuotas;
        private RadioButton rb3Cuotas;
        private Label lblCuotaTarjeta;
        private RadioButton rbMetodoTarjeta;
        private RadioButton rbMetodoEfectivo;
        private GroupBox gbActividad;
        private Label lblDniNoSocio;
        private TextBox txtMontoActividad;
        private Label lblMontoActividad;
        private Label lblActividad;
        private TextBox txtDniNoSocio;
        private Button btnRealizar;
        private Button btnCerrar;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dtbFechaPago;
        private ComboBox cmbActividad;
    }
}