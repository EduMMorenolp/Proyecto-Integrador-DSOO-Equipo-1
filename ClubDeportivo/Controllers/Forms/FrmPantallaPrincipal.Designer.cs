namespace ClubDeportivo.Controllers.Forms
{
    partial class FrmPantallaPrincipal
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
            btnRegistrarPersona = new Button();
            btnEntregarCarnet = new Button();
            btnPagarCuotaActividad = new Button();
            btnListarCuotasVencidas = new Button();
            SuspendLayout();
            // 
            // btnRegistrarPersona
            // 
            btnRegistrarPersona.Location = new Point(183, 97);
            btnRegistrarPersona.Name = "btnRegistrarPersona";
            btnRegistrarPersona.Size = new Size(125, 40);
            btnRegistrarPersona.TabIndex = 0;
            btnRegistrarPersona.Text = "REGISTRAR PERSONA";
            btnRegistrarPersona.UseVisualStyleBackColor = true;
            btnRegistrarPersona.Click += btnRegistrarPersona_Click;
            // 
            // btnEntregarCarnet
            // 
            btnEntregarCarnet.Location = new Point(423, 97);
            btnEntregarCarnet.Name = "btnEntregarCarnet";
            btnEntregarCarnet.Size = new Size(125, 40);
            btnEntregarCarnet.TabIndex = 1;
            btnEntregarCarnet.Text = "  ENTREGAR     CARNET";
            btnEntregarCarnet.UseVisualStyleBackColor = true;
            btnEntregarCarnet.Click += btnEntregarCarnet_Click;
            // 
            // btnPagarCuotaActividad
            // 
            btnPagarCuotaActividad.Location = new Point(183, 228);
            btnPagarCuotaActividad.Name = "btnPagarCuotaActividad";
            btnPagarCuotaActividad.Size = new Size(125, 40);
            btnPagarCuotaActividad.TabIndex = 2;
            btnPagarCuotaActividad.Text = "PAGAR CUOTA O ACTIVIDAD";
            btnPagarCuotaActividad.UseVisualStyleBackColor = true;
            btnPagarCuotaActividad.Click += btnPagarCuotaActividad_Click;
            // 
            // btnListarCuotasVencidas
            // 
            btnListarCuotasVencidas.Location = new Point(423, 228);
            btnListarCuotasVencidas.Name = "btnListarCuotasVencidas";
            btnListarCuotasVencidas.Size = new Size(125, 40);
            btnListarCuotasVencidas.TabIndex = 3;
            btnListarCuotasVencidas.Text = "LISTAR CUOTAS VENCIDAS";
            btnListarCuotasVencidas.UseVisualStyleBackColor = true;
            btnListarCuotasVencidas.Click += btnListarCuotasVencidas_Click;
            // 
            // FrmPantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListarCuotasVencidas);
            Controls.Add(btnPagarCuotaActividad);
            Controls.Add(btnEntregarCarnet);
            Controls.Add(btnRegistrarPersona);
            Name = "FrmPantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PANTALLA PRINCIPAL";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarPersona;
        private Button btnEntregarCarnet;
        private Button btnPagarCuotaActividad;
        private Button btnListarCuotasVencidas;
    }
}