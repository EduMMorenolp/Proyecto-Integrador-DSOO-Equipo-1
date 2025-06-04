namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
    partial class FrmAgregarActividad
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
            numericUpDownCosto = new NumericUpDown();
            numericUpDownCapacidad = new NumericUpDown();
            lblCostoActividad = new Label();
            lblCapacidad = new Label();
            textHorario = new TextBox();
            lblHorario = new Label();
            txtProfesor = new TextBox();
            txtTipo = new TextBox();
            txtNombreActividad = new TextBox();
            lblProfesor = new Label();
            lblTipo = new Label();
            lblNombreActividad = new Label();
            btnCerrar = new Button();
            btnLimpiarCampos = new Button();
            btnGuardar = new Button();
            gbDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacidad).BeginInit();
            SuspendLayout();
            // 
            // gbDatosPersonales
            // 
            gbDatosPersonales.Controls.Add(numericUpDownCosto);
            gbDatosPersonales.Controls.Add(numericUpDownCapacidad);
            gbDatosPersonales.Controls.Add(lblCostoActividad);
            gbDatosPersonales.Controls.Add(lblCapacidad);
            gbDatosPersonales.Controls.Add(textHorario);
            gbDatosPersonales.Controls.Add(lblHorario);
            gbDatosPersonales.Controls.Add(txtProfesor);
            gbDatosPersonales.Controls.Add(txtTipo);
            gbDatosPersonales.Controls.Add(txtNombreActividad);
            gbDatosPersonales.Controls.Add(lblProfesor);
            gbDatosPersonales.Controls.Add(lblTipo);
            gbDatosPersonales.Controls.Add(lblNombreActividad);
            gbDatosPersonales.Location = new Point(12, 12);
            gbDatosPersonales.Name = "gbDatosPersonales";
            gbDatosPersonales.Size = new Size(365, 259);
            gbDatosPersonales.TabIndex = 1;
            gbDatosPersonales.TabStop = false;
            gbDatosPersonales.Text = "Datos Actividad";
            // 
            // numericUpDownCosto
            // 
            numericUpDownCosto.Location = new Point(132, 197);
            numericUpDownCosto.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownCosto.Name = "numericUpDownCosto";
            numericUpDownCosto.Size = new Size(78, 23);
            numericUpDownCosto.TabIndex = 14;
            // 
            // numericUpDownCapacidad
            // 
            numericUpDownCapacidad.Location = new Point(132, 168);
            numericUpDownCapacidad.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownCapacidad.Name = "numericUpDownCapacidad";
            numericUpDownCapacidad.Size = new Size(78, 23);
            numericUpDownCapacidad.TabIndex = 13;
            // 
            // lblCostoActividad
            // 
            lblCostoActividad.AutoSize = true;
            lblCostoActividad.Location = new Point(32, 200);
            lblCostoActividad.Name = "lblCostoActividad";
            lblCostoActividad.Size = new Size(94, 15);
            lblCostoActividad.TabIndex = 11;
            lblCostoActividad.Text = "Costo Actividad:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(60, 171);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(66, 15);
            lblCapacidad.TabIndex = 9;
            lblCapacidad.Text = "Capacidad:";
            // 
            // textHorario
            // 
            textHorario.Location = new Point(132, 139);
            textHorario.Name = "textHorario";
            textHorario.Size = new Size(199, 23);
            textHorario.TabIndex = 8;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(76, 142);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(50, 15);
            lblHorario.TabIndex = 7;
            lblHorario.Text = "Horario:";
            // 
            // txtProfesor
            // 
            txtProfesor.Location = new Point(132, 113);
            txtProfesor.Name = "txtProfesor";
            txtProfesor.Size = new Size(199, 23);
            txtProfesor.TabIndex = 6;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(132, 84);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(199, 23);
            txtTipo.TabIndex = 5;
            // 
            // txtNombreActividad
            // 
            txtNombreActividad.Location = new Point(132, 55);
            txtNombreActividad.Name = "txtNombreActividad";
            txtNombreActividad.Size = new Size(199, 23);
            txtNombreActividad.TabIndex = 4;
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Location = new Point(72, 113);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(54, 15);
            lblProfesor.TabIndex = 2;
            lblProfesor.Text = "Profesor:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(93, 87);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo:";
            lblTipo.Click += lblApellido_Click;
            // 
            // lblNombreActividad
            // 
            lblNombreActividad.AutoSize = true;
            lblNombreActividad.Location = new Point(72, 58);
            lblNombreActividad.Name = "lblNombreActividad";
            lblNombreActividad.Size = new Size(54, 15);
            lblNombreActividad.TabIndex = 0;
            lblNombreActividad.Text = "Nombre:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(303, 289);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.Location = new Point(144, 289);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(110, 23);
            btnLimpiarCampos.TabIndex = 7;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = true;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 289);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmAgregarActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 338);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(btnGuardar);
            Controls.Add(gbDatosPersonales);
            Name = "FrmAgregarActividad";
            Text = "Agregar Actividad";
            gbDatosPersonales.ResumeLayout(false);
            gbDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatosPersonales;
        private TextBox txtProfesor;
        private TextBox txtTipo;
        private TextBox txtNombreActividad;
        private Label lblProfesor;
        private Label lblTipo;
        private Label lblNombreActividad;
        private TextBox textHorario;
        private Label lblHorario;
        private Label lblCapacidad;
        private Label lblCostoActividad;
        private Button btnCerrar;
        private Button btnLimpiarCampos;
        private Button btnGuardar;
        private NumericUpDown numericUpDownCosto;
        private NumericUpDown numericUpDownCapacidad;
    }
}