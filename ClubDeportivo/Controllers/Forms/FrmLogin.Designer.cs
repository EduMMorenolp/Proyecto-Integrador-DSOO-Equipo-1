namespace ClubDeportivo.Controllers.Forms
{
    partial class FrmLogin
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
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 20F);
            lblUsuario.Location = new Point(232, 97);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(114, 37);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 20F);
            lblContraseña.Location = new Point(189, 214);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(157, 37);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(394, 111);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(394, 228);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(125, 23);
            txtContraseña.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(394, 322);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(140, 40);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIngresar;
    }
}