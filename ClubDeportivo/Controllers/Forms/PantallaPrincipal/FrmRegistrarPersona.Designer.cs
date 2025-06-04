namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
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
            chkFichaMedica = new CheckBox();
            lblFichaMed = new Label();
            dtpFechaAlta = new DateTimePicker();
            lblFechaAlta = new Label();
            groupBox4 = new GroupBox();
            btnGuardar = new Button();
            btnLimpiarCampos = new Button();
            btnCerrar = new Button();
            lblEstado = new Label();
            gbDatosNoSocio = new GroupBox();
            gbDatosPersonales.SuspendLayout();
            gbTipoVinculacion.SuspendLayout();
            gbDatosSocio.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatosPersonales
            // 
            gbDatosPersonales.Controls.Add(dtpFechaNacimiento);
            gbDatosPersonales.Controls.Add(txtDni);
            gbDatosPersonales.Controls.Add(txtApellido);
            gbDatosPersonales.Controls.Add(txtNombre);
            gbDatosPersonales.Controls.Add(lblFechaNac);
            gbDatosPersonales.Controls.Add(lblDNI);
            gbDatosPersonales.Controls.Add(lblApellido);
            gbDatosPersonales.Controls.Add(lblNombre);
            gbDatosPersonales.Location = new Point(17, 20);
            gbDatosPersonales.Margin = new Padding(4, 5, 4, 5);
            gbDatosPersonales.Name = "gbDatosPersonales";
            gbDatosPersonales.Padding = new Padding(4, 5, 4, 5);
            gbDatosPersonales.Size = new Size(717, 292);
            gbDatosPersonales.TabIndex = 0;
            gbDatosPersonales.TabStop = false;
            gbDatosPersonales.Text = "Datos Personales";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(140, 237);
            dtpFechaNacimiento.Margin = new Padding(4, 5, 4, 5);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(143, 31);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(140, 168);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(198, 31);
            txtDni.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(140, 105);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(374, 31);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 45);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(374, 31);
            txtNombre.TabIndex = 4;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(34, 247);
            lblFechaNac.Margin = new Padding(4, 0, 4, 0);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(100, 25);
            lblFechaNac.TabIndex = 3;
            lblFechaNac.Text = "Fecha Nac.:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(34, 182);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(47, 25);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(34, 110);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(34, 50);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // gbTipoVinculacion
            // 
            gbTipoVinculacion.Controls.Add(rbNoSocio);
            gbTipoVinculacion.Controls.Add(rbSocio);
            gbTipoVinculacion.Controls.Add(lblTipo);
            gbTipoVinculacion.Location = new Point(17, 322);
            gbTipoVinculacion.Margin = new Padding(4, 5, 4, 5);
            gbTipoVinculacion.Name = "gbTipoVinculacion";
            gbTipoVinculacion.Padding = new Padding(4, 5, 4, 5);
            gbTipoVinculacion.Size = new Size(717, 97);
            gbTipoVinculacion.TabIndex = 1;
            gbTipoVinculacion.TabStop = false;
            gbTipoVinculacion.Text = "Tipo de Vinculación";
            // 
            // rbNoSocio
            // 
            rbNoSocio.AutoSize = true;
            rbNoSocio.Location = new Point(206, 45);
            rbNoSocio.Margin = new Padding(4, 5, 4, 5);
            rbNoSocio.Name = "rbNoSocio";
            rbNoSocio.Size = new Size(105, 29);
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
            rbSocio.Location = new Point(94, 45);
            rbSocio.Margin = new Padding(4, 5, 4, 5);
            rbSocio.Name = "rbSocio";
            rbSocio.Size = new Size(81, 29);
            rbSocio.TabIndex = 1;
            rbSocio.TabStop = true;
            rbSocio.Text = "Socio";
            rbSocio.UseVisualStyleBackColor = true;
            rbSocio.CheckedChanged += rbSocio_CheckedChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(19, 45);
            lblTipo.Margin = new Padding(4, 0, 4, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(51, 25);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo:";
            // 
            // gbDatosSocio
            // 
            gbDatosSocio.Controls.Add(chkFichaMedica);
            gbDatosSocio.Controls.Add(lblFichaMed);
            gbDatosSocio.Controls.Add(dtpFechaAlta);
            gbDatosSocio.Controls.Add(lblFechaAlta);
            gbDatosSocio.Controls.Add(groupBox4);
            gbDatosSocio.Location = new Point(17, 428);
            gbDatosSocio.Margin = new Padding(4, 5, 4, 5);
            gbDatosSocio.Name = "gbDatosSocio";
            gbDatosSocio.Padding = new Padding(4, 5, 4, 5);
            gbDatosSocio.Size = new Size(717, 167);
            gbDatosSocio.TabIndex = 2;
            gbDatosSocio.TabStop = false;
            gbDatosSocio.Text = "Datos de Socio";
            // 
            // chkFichaMedica
            // 
            chkFichaMedica.AutoSize = true;
            chkFichaMedica.Location = new Point(236, 110);
            chkFichaMedica.Margin = new Padding(4, 5, 4, 5);
            chkFichaMedica.Name = "chkFichaMedica";
            chkFichaMedica.Size = new Size(83, 29);
            chkFichaMedica.TabIndex = 7;
            chkFichaMedica.Text = "Sí/No";
            chkFichaMedica.UseVisualStyleBackColor = true;
            // 
            // lblFichaMed
            // 
            lblFichaMed.AutoSize = true;
            lblFichaMed.Location = new Point(26, 112);
            lblFichaMed.Margin = new Padding(4, 0, 4, 0);
            lblFichaMed.Name = "lblFichaMed";
            lblFichaMed.Size = new Size(210, 25);
            lblFichaMed.TabIndex = 6;
            lblFichaMed.Text = "Ficha Médica Presentada:";
            // 
            // dtpFechaAlta
            // 
            dtpFechaAlta.Format = DateTimePickerFormat.Short;
            dtpFechaAlta.Location = new Point(140, 50);
            dtpFechaAlta.Margin = new Padding(4, 5, 4, 5);
            dtpFechaAlta.Name = "dtpFechaAlta";
            dtpFechaAlta.Size = new Size(143, 31);
            dtpFechaAlta.TabIndex = 5;
            dtpFechaAlta.Value = new DateTime(2025, 6, 3, 0, 0, 0, 0);
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.Location = new Point(26, 60);
            lblFechaAlta.Margin = new Padding(4, 0, 4, 0);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(97, 25);
            lblFechaAlta.TabIndex = 4;
            lblFechaAlta.Text = "Fecha Alta:";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(0, 177);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(717, 167);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos de No Socio";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(30, 862);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 38);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.Location = new Point(200, 862);
            btnLimpiarCampos.Margin = new Padding(4, 5, 4, 5);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(157, 38);
            btnLimpiarCampos.TabIndex = 4;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = true;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(407, 862);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(107, 38);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(30, 905);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(70, 25);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";
            // 
            // gbDatosNoSocio
            // 
            gbDatosNoSocio.Location = new Point(17, 605);
            gbDatosNoSocio.Margin = new Padding(4, 5, 4, 5);
            gbDatosNoSocio.Name = "gbDatosNoSocio";
            gbDatosNoSocio.Padding = new Padding(4, 5, 4, 5);
            gbDatosNoSocio.Size = new Size(717, 167);
            gbDatosNoSocio.TabIndex = 7;
            gbDatosNoSocio.TabStop = false;
            gbDatosNoSocio.Text = "Datos de No Socio";
            gbDatosNoSocio.Visible = false;
            // 
            // FrmRegistrarPersona
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 945);
            Controls.Add(gbDatosNoSocio);
            Controls.Add(lblEstado);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(btnGuardar);
            Controls.Add(gbDatosSocio);
            Controls.Add(gbTipoVinculacion);
            Controls.Add(gbDatosPersonales);
            Margin = new Padding(4, 5, 4, 5);
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
        private GroupBox gbDatosNoSocio;
    }
}