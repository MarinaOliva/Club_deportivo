namespace club_deportivo
{
    partial class FormMenu
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
            btnConsultar = new Button();
            lblHeader = new Label();
            btnVolver_Login = new Button();
            RegistrarCliente = new Button();
            Actividades = new Button();
            btnAbonar = new Button();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.PaleTurquoise;
            btnConsultar.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnConsultar.FlatAppearance.BorderSize = 2;
            btnConsultar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnConsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnConsultar.Location = new Point(574, 314);
            btnConsultar.Margin = new Padding(4, 5, 4, 5);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(235, 116);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar Cuotas Vencidas Hoy";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 15F);
            lblHeader.Location = new Point(250, 136);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(485, 35);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Seleccione la operación que desea realizar";
            // 
            // btnVolver_Login
            // 
            btnVolver_Login.BackColor = SystemColors.ActiveBorder;
            btnVolver_Login.FlatStyle = FlatStyle.Flat;
            btnVolver_Login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnVolver_Login.Location = new Point(374, 533);
            btnVolver_Login.Margin = new Padding(4, 5, 4, 5);
            btnVolver_Login.Name = "btnVolver_Login";
            btnVolver_Login.Size = new Size(233, 63);
            btnVolver_Login.TabIndex = 4;
            btnVolver_Login.Text = "Cerrar Sesión";
            btnVolver_Login.UseVisualStyleBackColor = false;
            btnVolver_Login.Click += btnVolver_Login_Click;
            // 
            // RegistrarCliente
            // 
            RegistrarCliente.BackColor = Color.LightGreen;
            RegistrarCliente.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            RegistrarCliente.FlatAppearance.BorderSize = 2;
            RegistrarCliente.FlatAppearance.MouseDownBackColor = Color.Aquamarine;
            RegistrarCliente.FlatAppearance.MouseOverBackColor = Color.LightPink;
            RegistrarCliente.FlatStyle = FlatStyle.Flat;
            RegistrarCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            RegistrarCliente.Location = new Point(167, 185);
            RegistrarCliente.Name = "RegistrarCliente";
            RegistrarCliente.Size = new Size(242, 116);
            RegistrarCliente.TabIndex = 5;
            RegistrarCliente.Text = "Registrar Cliente";
            RegistrarCliente.UseVisualStyleBackColor = false;
            RegistrarCliente.Click += RegistrarCliente_Click;
            // 
            // Actividades
            // 
            Actividades.BackColor = Color.LightGreen;
            Actividades.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            Actividades.FlatAppearance.BorderSize = 2;
            Actividades.FlatAppearance.MouseDownBackColor = Color.Aquamarine;
            Actividades.FlatAppearance.MouseOverBackColor = Color.LightPink;
            Actividades.FlatStyle = FlatStyle.Flat;
            Actividades.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Actividades.Location = new Point(574, 185);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(235, 116);
            Actividades.TabIndex = 6;
            Actividades.Text = "Inscribir en Actividades Guiadas";
            Actividades.UseVisualStyleBackColor = false;
            Actividades.Click += Actividades_Click;
            // 
            // btnAbonar
            // 
            btnAbonar.BackColor = Color.PaleTurquoise;
            btnAbonar.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnAbonar.FlatAppearance.BorderSize = 2;
            btnAbonar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnAbonar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            btnAbonar.FlatStyle = FlatStyle.Flat;
            btnAbonar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAbonar.Location = new Point(167, 314);
            btnAbonar.Name = "btnAbonar";
            btnAbonar.Size = new Size(242, 116);
            btnAbonar.TabIndex = 7;
            btnAbonar.Text = "Abonar Cuota";
            btnAbonar.UseVisualStyleBackColor = false;
            btnAbonar.Click += btnAbonar_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 690);
            Controls.Add(btnAbonar);
            Controls.Add(Actividades);
            Controls.Add(RegistrarCliente);
            Controls.Add(btnVolver_Login);
            Controls.Add(lblHeader);
            Controls.Add(btnConsultar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMenu";
            Text = "Menú principal";
            Load += FormMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnVolver_Login;
        private Button RegistrarCliente;
        private Button Actividades;
        private Button btnAbonar;
    }
}