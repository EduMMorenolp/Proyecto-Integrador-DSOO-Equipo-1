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
            txtDni = new TextBox();
            lblDNI = new Label();
            btnFiltrar = new Button();
            btnVerTodas = new Button();
            btnVerVencidas = new Button();
            btnVerNoVencidas = new Button();
            gbDniSocio.SuspendLayout();
            SuspendLayout();
            // 
            // gbDniSocio
            // 
            gbDniSocio.Controls.Add(txtDni);
            gbDniSocio.Controls.Add(lblDNI);
            gbDniSocio.Controls.Add(btnFiltrar);
            gbDniSocio.Location = new Point(285, 37);
            gbDniSocio.Name = "gbDniSocio";
            gbDniSocio.Size = new Size(221, 120);
            gbDniSocio.TabIndex = 2;
            gbDniSocio.TabStop = false;
            gbDniSocio.Text = "Filtrar por documento del socio";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(59, 33);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(140, 23);
            txtDni.TabIndex = 1;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(23, 36);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(76, 78);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnVerTodas
            // 
            btnVerTodas.Location = new Point(361, 190);
            btnVerTodas.Name = "btnVerTodas";
            btnVerTodas.Size = new Size(75, 23);
            btnVerTodas.TabIndex = 5;
            btnVerTodas.Text = "Ver todas";
            btnVerTodas.UseVisualStyleBackColor = true;
            // 
            // btnVerVencidas
            // 
            btnVerVencidas.Location = new Point(128, 190);
            btnVerVencidas.Name = "btnVerVencidas";
            btnVerVencidas.Size = new Size(94, 23);
            btnVerVencidas.TabIndex = 6;
            btnVerVencidas.Text = "Ver vencidas";
            btnVerVencidas.UseVisualStyleBackColor = true;
            // 
            // btnVerNoVencidas
            // 
            btnVerNoVencidas.Location = new Point(577, 190);
            btnVerNoVencidas.Name = "btnVerNoVencidas";
            btnVerNoVencidas.Size = new Size(110, 23);
            btnVerNoVencidas.TabIndex = 7;
            btnVerNoVencidas.Text = "Ver no vencidas";
            btnVerNoVencidas.UseVisualStyleBackColor = true;
            // 
            // FrmListarCuotasVencidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerNoVencidas);
            Controls.Add(btnVerVencidas);
            Controls.Add(btnVerTodas);
            Controls.Add(gbDniSocio);
            Name = "FrmListarCuotasVencidas";
            Text = "Lista Cuotas Vencidas";
            gbDniSocio.ResumeLayout(false);
            gbDniSocio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDniSocio;
        private TextBox txtDni;
        private Label lblDNI;
        private Button btnFiltrar;
        private Button btnVerTodas;
        private Button btnVerVencidas;
        private Button btnVerNoVencidas;
    }
}