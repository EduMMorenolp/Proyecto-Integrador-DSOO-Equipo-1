﻿namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
    partial class FrmRegistrarPersona
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
            gbDatosPersonales = new GroupBox();
            chkFichaMedica = new CheckBox();
            btnVerificarDni = new Button();
            lblFichaMed = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblFechaNac = new Label();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            gbTipoVinculacion = new GroupBox();
            rbNoSocio = new RadioButton();
            rbSocio = new RadioButton();
            lblTipo = new Label();
            gbDatosSocio = new GroupBox();
            dtpFechaAlta = new DateTimePicker();
            lblFechaAlta = new Label();
            groupBox4 = new GroupBox();
            btnGuardar = new Button();
            btnLimpiarCampos = new Button();
            btnCerrar = new Button();
            lblEstado = new Label();
            gbDatosPersonales.SuspendLayout();
            gbTipoVinculacion.SuspendLayout();
            gbDatosSocio.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatosPersonales
            // 
            gbDatosPersonales.Controls.Add(chkFichaMedica);
            gbDatosPersonales.Controls.Add(btnVerificarDni);
            gbDatosPersonales.Controls.Add(lblFichaMed);
            gbDatosPersonales.Controls.Add(dtpFechaNacimiento);
            gbDatosPersonales.Controls.Add(txtDni);
            gbDatosPersonales.Controls.Add(txtApellido);
            gbDatosPersonales.Controls.Add(txtNombre);
            gbDatosPersonales.Controls.Add(lblFechaNac);
            gbDatosPersonales.Controls.Add(lblDNI);
            gbDatosPersonales.Controls.Add(lblApellido);
            gbDatosPersonales.Controls.Add(lblNombre);
            gbDatosPersonales.Location = new Point(12, 76);
            gbDatosPersonales.Name = "gbDatosPersonales";
            gbDatosPersonales.Size = new Size(413, 175);
            gbDatosPersonales.TabIndex = 0;
            gbDatosPersonales.TabStop = false;
            gbDatosPersonales.Text = "Datos Personales";
            // 
            // chkFichaMedica
            // 
            chkFichaMedica.AutoSize = true;
            chkFichaMedica.Location = new Point(333, 147);
            chkFichaMedica.Name = "chkFichaMedica";
            chkFichaMedica.Size = new Size(35, 19);
            chkFichaMedica.TabIndex = 7;
            chkFichaMedica.Text = "Sí";
            chkFichaMedica.UseVisualStyleBackColor = true;
            chkFichaMedica.CheckedChanged += chkFichaMedica_CheckedChanged;
            // 
            // btnVerificarDni
            // 
            btnVerificarDni.Location = new Point(258, 101);
            btnVerificarDni.Name = "btnVerificarDni";
            btnVerificarDni.Size = new Size(83, 23);
            btnVerificarDni.TabIndex = 7;
            btnVerificarDni.Text = "Verificar DNI";
            btnVerificarDni.UseVisualStyleBackColor = true;
            btnVerificarDni.Click += btnVerificarDni_Click;
            // 
            // lblFichaMed
            // 
            lblFichaMed.AutoSize = true;
            lblFichaMed.Location = new Point(219, 148);
            lblFichaMed.Name = "lblFichaMed";
            lblFichaMed.Size = new Size(108, 15);
            lblFichaMed.TabIndex = 6;
            lblFichaMed.Text = "Ficha Médica Apta:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(98, 142);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(101, 23);
            dtpFechaNacimiento.TabIndex = 8;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(98, 101);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(140, 23);
            txtDni.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(98, 63);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(181, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(181, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(24, 148);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(68, 15);
            lblFechaNac.TabIndex = 3;
            lblFechaNac.Text = "Fecha Nac.:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(24, 109);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(24, 66);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // gbTipoVinculacion
            // 
            gbTipoVinculacion.Controls.Add(rbNoSocio);
            gbTipoVinculacion.Controls.Add(rbSocio);
            gbTipoVinculacion.Controls.Add(lblTipo);
            gbTipoVinculacion.Location = new Point(15, 12);
            gbTipoVinculacion.Name = "gbTipoVinculacion";
            gbTipoVinculacion.Size = new Size(502, 58);
            gbTipoVinculacion.TabIndex = 1;
            gbTipoVinculacion.TabStop = false;
            gbTipoVinculacion.Text = "Tipo de Vinculación";
            // 
            // rbNoSocio
            // 
            rbNoSocio.AutoSize = true;
            rbNoSocio.Location = new Point(144, 27);
            rbNoSocio.Name = "rbNoSocio";
            rbNoSocio.Size = new Size(70, 19);
            rbNoSocio.TabIndex = 2;
            rbNoSocio.TabStop = true;
            rbNoSocio.Text = "NoSocio";
            rbNoSocio.UseVisualStyleBackColor = true;
            rbNoSocio.CheckedChanged += rbNoSocio_CheckedChanged;
            // 
            // rbSocio
            // 
            rbSocio.AutoSize = true;
            rbSocio.Checked = true;
            rbSocio.Location = new Point(66, 27);
            rbSocio.Name = "rbSocio";
            rbSocio.Size = new Size(54, 19);
            rbSocio.TabIndex = 1;
            rbSocio.TabStop = true;
            rbSocio.Text = "Socio";
            rbSocio.UseVisualStyleBackColor = true;
            rbSocio.CheckedChanged += rbSocio_CheckedChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(13, 27);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo:";
            // 
            // gbDatosSocio
            // 
            gbDatosSocio.Controls.Add(dtpFechaAlta);
            gbDatosSocio.Controls.Add(lblFechaAlta);
            gbDatosSocio.Controls.Add(groupBox4);
            gbDatosSocio.Location = new Point(12, 257);
            gbDatosSocio.Name = "gbDatosSocio";
            gbDatosSocio.Size = new Size(413, 100);
            gbDatosSocio.TabIndex = 2;
            gbDatosSocio.TabStop = false;
            gbDatosSocio.Text = "Datos de Socio";
            // 
            // dtpFechaAlta
            // 
            dtpFechaAlta.Format = DateTimePickerFormat.Short;
            dtpFechaAlta.Location = new Point(98, 30);
            dtpFechaAlta.Name = "dtpFechaAlta";
            dtpFechaAlta.Size = new Size(101, 23);
            dtpFechaAlta.TabIndex = 5;
            dtpFechaAlta.Value = new DateTime(2025, 5, 17, 0, 23, 30, 0);
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.Location = new Point(18, 36);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(65, 15);
            lblFechaAlta.TabIndex = 4;
            lblFechaAlta.Text = "Fecha Alta:";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(0, 106);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(502, 100);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos de No Socio";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(36, 397);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.Location = new Point(159, 397);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(110, 23);
            btnLimpiarCampos.TabIndex = 4;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = true;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(320, 397);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(21, 363);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";
            // 
            // FrmRegistrarPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 432);
            Controls.Add(lblEstado);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(btnGuardar);
            Controls.Add(gbDatosSocio);
            Controls.Add(gbTipoVinculacion);
            Controls.Add(gbDatosPersonales);
            Name = "FrmRegistrarPersona";
            Text = "REGISTRO DE PERSONAS Y SOCIOS";
            gbDatosPersonales.ResumeLayout(false);
            gbDatosPersonales.PerformLayout();
            gbTipoVinculacion.ResumeLayout(false);
            gbTipoVinculacion.PerformLayout();
            gbDatosSocio.ResumeLayout(false);
            gbDatosSocio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDatosPersonales;
        private GroupBox gbTipoVinculacion;
        private GroupBox gbDatosSocio;
        private GroupBox groupBox4;
        private Button btnGuardar;
        private Button btnLimpiarCampos;
        private Button btnCerrar;
        private Label lblEstado;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblFechaNac;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblTipo;
        private RadioButton rbNoSocio;
        private RadioButton rbSocio;
        private DateTimePicker dtpFechaAlta;
        private Label lblFechaAlta;
        private CheckBox chkFichaMedica;
        private Label lblFichaMed;
        private Button btnVerificarDni;
    }
}