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
            button1 = new Button();
            btnAgregarActividad = new Button();
            btnListaActividades = new Button();
            SuspendLayout();
            // 
            // btnRegistrarPersona
            // 
            btnRegistrarPersona.Location = new Point(42, 57);
            btnRegistrarPersona.Name = "btnRegistrarPersona";
            btnRegistrarPersona.Size = new Size(167, 54);
            btnRegistrarPersona.TabIndex = 0;
            btnRegistrarPersona.Text = "REGISTRAR PERSONA";
            btnRegistrarPersona.UseVisualStyleBackColor = true;
            btnRegistrarPersona.Click += btnRegistrarPersona_Click;
            // 
            // btnEntregarCarnet
            // 
            btnEntregarCarnet.Location = new Point(263, 57);
            btnEntregarCarnet.Name = "btnEntregarCarnet";
            btnEntregarCarnet.Size = new Size(167, 54);
            btnEntregarCarnet.TabIndex = 1;
            btnEntregarCarnet.Text = "ENTREGAR CARNET";
            btnEntregarCarnet.UseVisualStyleBackColor = true;
            btnEntregarCarnet.Click += btnEntregarCarnet_Click;
            // 
            // btnPagarCuotaActividad
            // 
            btnPagarCuotaActividad.Location = new Point(42, 165);
            btnPagarCuotaActividad.Name = "btnPagarCuotaActividad";
            btnPagarCuotaActividad.Size = new Size(167, 54);
            btnPagarCuotaActividad.TabIndex = 2;
            btnPagarCuotaActividad.Text = "PAGAR CUOTA O ACTIVIDAD";
            btnPagarCuotaActividad.UseVisualStyleBackColor = true;
            btnPagarCuotaActividad.Click += btnPagarCuotaActividad_Click;
            // 
            // btnListarCuotasVencidas
            // 
            btnListarCuotasVencidas.Location = new Point(263, 165);
            btnListarCuotasVencidas.Name = "btnListarCuotasVencidas";
            btnListarCuotasVencidas.Size = new Size(167, 54);
            btnListarCuotasVencidas.TabIndex = 3;
            btnListarCuotasVencidas.Text = "LISTAR CUOTAS VENCIDAS";
            btnListarCuotasVencidas.UseVisualStyleBackColor = true;
            btnListarCuotasVencidas.Click += btnListarCuotasVencidas_Click;
            // 
            // button1
            // 
            button1.Location = new Point(196, 376);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAgregarActividad
            // 
            btnAgregarActividad.Location = new Point(42, 273);
            btnAgregarActividad.Name = "btnAgregarActividad";
            btnAgregarActividad.Size = new Size(167, 54);
            btnAgregarActividad.TabIndex = 5;
            btnAgregarActividad.Text = "AGREGAR ACTIVIDAD";
            btnAgregarActividad.UseVisualStyleBackColor = true;
            btnAgregarActividad.Click += button2_Click;
            // 
            // btnListaActividades
            // 
            btnListaActividades.Location = new Point(263, 273);
            btnListaActividades.Name = "btnListaActividades";
            btnListaActividades.Size = new Size(167, 54);
            btnListaActividades.TabIndex = 6;
            btnListaActividades.Text = "LISTA DE ACTIVIDADES";
            btnListaActividades.UseVisualStyleBackColor = true;
            btnListaActividades.Click += button3_Click;
            // 
            // FrmPantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 439);
            Controls.Add(btnListaActividades);
            Controls.Add(btnAgregarActividad);
            Controls.Add(button1);
            Controls.Add(btnListarCuotasVencidas);
            Controls.Add(btnPagarCuotaActividad);
            Controls.Add(btnEntregarCarnet);
            Controls.Add(btnRegistrarPersona);
            Name = "FrmPantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PANTALLA PRINCIPAL";
            Load += FrmPantallaPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarPersona;
        private Button btnEntregarCarnet;
        private Button btnPagarCuotaActividad;
        private Button btnListarCuotasVencidas;
        private Button button1;
        private Button btnAgregarActividad;
        private Button btnListaActividades;
    }
}