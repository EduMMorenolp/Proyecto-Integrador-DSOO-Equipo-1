namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
    partial class FrmListaActividades
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
            components = new System.ComponentModel.Container();
            gpFiltros = new GroupBox();
            btnFiltrar = new Button();
            txtProfesor = new TextBox();
            label3 = new Label();
            cmbTipoActividad = new ComboBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            btnVerTodas = new Button();
            btnCerrar = new Button();
            dgvActividades = new DataGridView();
            idActividadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profesorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            actividadBindingSource = new BindingSource(components);
            gpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actividadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gpFiltros
            // 
            gpFiltros.Controls.Add(btnFiltrar);
            gpFiltros.Controls.Add(txtProfesor);
            gpFiltros.Controls.Add(label3);
            gpFiltros.Controls.Add(cmbTipoActividad);
            gpFiltros.Controls.Add(label2);
            gpFiltros.Controls.Add(txtNombre);
            gpFiltros.Controls.Add(label1);
            gpFiltros.Location = new Point(12, 25);
            gpFiltros.Name = "gpFiltros";
            gpFiltros.Size = new Size(332, 134);
            gpFiltros.TabIndex = 0;
            gpFiltros.TabStop = false;
            gpFiltros.Text = "FILTROS";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(239, 93);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtProfesor
            // 
            txtProfesor.Location = new Point(72, 93);
            txtProfesor.Name = "txtProfesor";
            txtProfesor.Size = new Size(140, 23);
            txtProfesor.TabIndex = 5;
            txtProfesor.TextChanged += txtProfesor_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Profesor:";
            // 
            // cmbTipoActividad
            // 
            cmbTipoActividad.FormattingEnabled = true;
            cmbTipoActividad.Location = new Point(72, 56);
            cmbTipoActividad.Name = "cmbTipoActividad";
            cmbTipoActividad.Size = new Size(125, 23);
            cmbTipoActividad.TabIndex = 3;
            cmbTipoActividad.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(72, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // btnVerTodas
            // 
            btnVerTodas.Location = new Point(24, 183);
            btnVerTodas.Name = "btnVerTodas";
            btnVerTodas.Size = new Size(75, 23);
            btnVerTodas.TabIndex = 1;
            btnVerTodas.Text = "Ver Todas";
            btnVerTodas.UseVisualStyleBackColor = true;
            btnVerTodas.Click += btnVerTodas_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(199, 183);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dgvActividades
            // 
            dgvActividades.AutoGenerateColumns = false;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Columns.AddRange(new DataGridViewColumn[] { idActividadDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, profesorDataGridViewTextBoxColumn, horarioDataGridViewTextBoxColumn, capacidadDataGridViewTextBoxColumn, costoDataGridViewTextBoxColumn });
            dgvActividades.DataSource = actividadBindingSource;
            dgvActividades.Location = new Point(12, 237);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.Size = new Size(575, 201);
            dgvActividades.TabIndex = 3;
            // 
            // idActividadDataGridViewTextBoxColumn
            // 
            idActividadDataGridViewTextBoxColumn.DataPropertyName = "IdActividad";
            idActividadDataGridViewTextBoxColumn.HeaderText = "IdActividad";
            idActividadDataGridViewTextBoxColumn.Name = "idActividadDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // profesorDataGridViewTextBoxColumn
            // 
            profesorDataGridViewTextBoxColumn.DataPropertyName = "Profesor";
            profesorDataGridViewTextBoxColumn.HeaderText = "Profesor";
            profesorDataGridViewTextBoxColumn.Name = "profesorDataGridViewTextBoxColumn";
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            horarioDataGridViewTextBoxColumn.DataPropertyName = "Horario";
            horarioDataGridViewTextBoxColumn.HeaderText = "Horario";
            horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            // 
            // capacidadDataGridViewTextBoxColumn
            // 
            capacidadDataGridViewTextBoxColumn.DataPropertyName = "Capacidad";
            capacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad";
            capacidadDataGridViewTextBoxColumn.Name = "capacidadDataGridViewTextBoxColumn";
            // 
            // costoDataGridViewTextBoxColumn
            // 
            costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            // 
            // actividadBindingSource
            // 
            actividadBindingSource.DataSource = typeof(Models.Actividad);
            // 
            // FrmListaActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvActividades);
            Controls.Add(btnCerrar);
            Controls.Add(btnVerTodas);
            Controls.Add(gpFiltros);
            Name = "FrmListaActividades";
            Text = "Listado de Actividades";
            gpFiltros.ResumeLayout(false);
            gpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ((System.ComponentModel.ISupportInitialize)actividadBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpFiltros;
        private Button btnFiltrar;
        private TextBox txtProfesor;
        private Label label3;
        private ComboBox cmbTipoActividad;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Button btnVerTodas;
        private Button btnCerrar;
        private DataGridView dgvActividades;
        private DataGridViewTextBoxColumn idActividadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profesorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private BindingSource actividadBindingSource;
    }
}