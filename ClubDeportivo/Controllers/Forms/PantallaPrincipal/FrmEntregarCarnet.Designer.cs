namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
    partial class FrmEntregarCarnet
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
            btnSalir = new Button();
            btnEntregar = new Button();
            btnLimpiarCampo = new Button();
            lblOutput = new Label();
            gbDniSocio.SuspendLayout();
            SuspendLayout();
            // 
            // gbDniSocio
            // 
            gbDniSocio.Controls.Add(txtDni);
            gbDniSocio.Controls.Add(lblDNI);
            gbDniSocio.Location = new Point(118, 29);
            gbDniSocio.Name = "gbDniSocio";
            gbDniSocio.Size = new Size(221, 82);
            gbDniSocio.TabIndex = 1;
            gbDniSocio.TabStop = false;
            gbDniSocio.Text = "Documento del socio";
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
            // btnSalir
            // 
            btnSalir.Location = new Point(319, 161);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(55, 161);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(75, 23);
            btnEntregar.TabIndex = 6;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampo
            // 
            btnLimpiarCampo.Location = new Point(177, 161);
            btnLimpiarCampo.Name = "btnLimpiarCampo";
            btnLimpiarCampo.Size = new Size(110, 23);
            btnLimpiarCampo.TabIndex = 8;
            btnLimpiarCampo.Text = "Limpiar Campo";
            btnLimpiarCampo.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(150, 125);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(155, 15);
            lblOutput.TabIndex = 9;
            lblOutput.Text = "mensaje de error o exito aca";
            // 
            // FrmEntregarCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 222);
            Controls.Add(lblOutput);
            Controls.Add(btnLimpiarCampo);
            Controls.Add(btnSalir);
            Controls.Add(btnEntregar);
            Controls.Add(gbDniSocio);
            Name = "FrmEntregarCarnet";
            Text = "Entrega de carnet";
            Load += FrmEntregarCarnet_Load;
            gbDniSocio.ResumeLayout(false);
            gbDniSocio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDniSocio;
        private TextBox txtDni;
        private Label lblDNI;
        private Button btnSalir;
        private Button btnEntregar;
        private Button btnLimpiarCampo;
        private Label lblOutput;
    }
}