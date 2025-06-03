namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
    partial class FrmListarCuotasVencidas
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
            gbDniSocio = new GroupBox();
            btnFiltrar = new Button();
            label1 = new Label();
            txtBusqueda = new TextBox();
            btnVerTodas = new Button();
            btnVerVencidas = new Button();
            btnVerNoVencidas = new Button();
            dataGridView1 = new DataGridView();
            btnCerrar = new Button();
            gbDniSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbDniSocio
            // 
            gbDniSocio.Controls.Add(btnFiltrar);
            gbDniSocio.Controls.Add(label1);
            gbDniSocio.Controls.Add(txtBusqueda);
            gbDniSocio.Location = new Point(159, 29);
            gbDniSocio.Name = "gbDniSocio";
            gbDniSocio.Size = new Size(288, 120);
            gbDniSocio.TabIndex = 2;
            gbDniSocio.TabStop = false;
            gbDniSocio.Text = "FILTRO";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(116, 77);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 36);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "DNI :";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(82, 33);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(140, 23);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnVerTodas
            // 
            btnVerTodas.Location = new Point(203, 178);
            btnVerTodas.Name = "btnVerTodas";
            btnVerTodas.Size = new Size(75, 23);
            btnVerTodas.TabIndex = 5;
            btnVerTodas.Text = "Ver todas";
            btnVerTodas.UseVisualStyleBackColor = true;
            btnVerTodas.Click += btnVerTodas_Click;
            // 
            // btnVerVencidas
            // 
            btnVerVencidas.Location = new Point(69, 178);
            btnVerVencidas.Name = "btnVerVencidas";
            btnVerVencidas.Size = new Size(94, 23);
            btnVerVencidas.TabIndex = 6;
            btnVerVencidas.Text = "Ver vencidas";
            btnVerVencidas.UseVisualStyleBackColor = true;
            btnVerVencidas.Click += btnVerVencidas_Click;
            // 
            // btnVerNoVencidas
            // 
            btnVerNoVencidas.Location = new Point(312, 178);
            btnVerNoVencidas.Name = "btnVerNoVencidas";
            btnVerNoVencidas.Size = new Size(110, 23);
            btnVerNoVencidas.TabIndex = 7;
            btnVerNoVencidas.Text = "Ver no vencidas";
            btnVerNoVencidas.UseVisualStyleBackColor = true;
            btnVerNoVencidas.Click += btnVerNoVencidas_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(576, 219);
            dataGridView1.TabIndex = 8;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(448, 178);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmListarCuotasVencidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 456);
            Controls.Add(gbDniSocio);
            Controls.Add(btnCerrar);
            Controls.Add(dataGridView1);
            Controls.Add(btnVerNoVencidas);
            Controls.Add(btnVerVencidas);
            Controls.Add(btnVerTodas);
            Name = "FrmListarCuotasVencidas";
            Text = "Lista Cuotas Vencidas";
            gbDniSocio.ResumeLayout(false);
            gbDniSocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDniSocio;
        private TextBox txtBusqueda;
        private Button btnVerTodas;
        private Button btnVerVencidas;
        private Button btnVerNoVencidas;
        private DataGridView dataGridView1;
        private Button btnCerrar;
        private Button btnFiltrar;
        private Label label1;
    }
}