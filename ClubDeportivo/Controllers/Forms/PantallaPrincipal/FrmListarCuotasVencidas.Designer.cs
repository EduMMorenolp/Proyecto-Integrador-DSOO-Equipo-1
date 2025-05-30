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
            txtBusqueda = new TextBox();
            lblDNI = new Label();
            btnFiltrar = new Button();
            btnVerTodas = new Button();
            btnVerVencidas = new Button();
            btnVerNoVencidas = new Button();
            dataGridView1 = new DataGridView();
            lblResultados = new Label();
            gbDniSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbDniSocio
            // 
            gbDniSocio.Controls.Add(txtBusqueda);
            gbDniSocio.Controls.Add(lblDNI);
            gbDniSocio.Controls.Add(btnFiltrar);
            gbDniSocio.Location = new Point(285, 37);
            gbDniSocio.Name = "gbDniSocio";
            gbDniSocio.Size = new Size(221, 120);
            gbDniSocio.TabIndex = 2;
            gbDniSocio.TabStop = false;
            gbDniSocio.Text = "FILTRO";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(59, 33);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(140, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(23, 36);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI:";
            lblDNI.Visible = false;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(76, 78);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Visible = false;
            // 
            // btnVerTodas
            // 
            btnVerTodas.Location = new Point(361, 190);
            btnVerTodas.Name = "btnVerTodas";
            btnVerTodas.Size = new Size(75, 23);
            btnVerTodas.TabIndex = 5;
            btnVerTodas.Text = "Ver todas";
            btnVerTodas.UseVisualStyleBackColor = true;
            btnVerTodas.Click += btnVerTodas_Click;
            // 
            // btnVerVencidas
            // 
            btnVerVencidas.Location = new Point(128, 190);
            btnVerVencidas.Name = "btnVerVencidas";
            btnVerVencidas.Size = new Size(94, 23);
            btnVerVencidas.TabIndex = 6;
            btnVerVencidas.Text = "Ver vencidas";
            btnVerVencidas.UseVisualStyleBackColor = true;
            btnVerVencidas.Click += btnVerVencidas_Click;
            // 
            // btnVerNoVencidas
            // 
            btnVerNoVencidas.Location = new Point(577, 190);
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
            dataGridView1.Size = new Size(776, 219);
            dataGridView1.TabIndex = 8;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(540, 112);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(38, 15);
            lblResultados.TabIndex = 9;
            lblResultados.Text = "label1";
            // 
            // FrmListarCuotasVencidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultados);
            Controls.Add(dataGridView1);
            Controls.Add(btnVerNoVencidas);
            Controls.Add(btnVerVencidas);
            Controls.Add(btnVerTodas);
            Controls.Add(gbDniSocio);
            Name = "FrmListarCuotasVencidas";
            Text = "Lista Cuotas Vencidas";
            gbDniSocio.ResumeLayout(false);
            gbDniSocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDniSocio;
        private TextBox txtBusqueda;
        private Label lblDNI;
        private Button btnFiltrar;
        private Button btnVerTodas;
        private Button btnVerVencidas;
        private Button btnVerNoVencidas;
        private DataGridView dataGridView1;
        private Label lblResultados;
    }
}