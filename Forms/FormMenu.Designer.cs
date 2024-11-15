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
            label1 = new Label();
            btnVolver_Login = new Button();
            RegistrarCliente = new Button();
            Actividades = new Button();
            btnAbonar = new Button();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(574, 314);
            btnConsultar.Margin = new Padding(4, 5, 4, 5);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(235, 116);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar cuotas vencidas hoy";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 140);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(332, 23);
            label1.TabIndex = 3;
            label1.Text = "Seleccione la operación que desea realizar";
            // 
            // btnVolver_Login
            // 
            btnVolver_Login.Location = new Point(403, 561);
            btnVolver_Login.Margin = new Padding(4, 5, 4, 5);
            btnVolver_Login.Name = "btnVolver_Login";
            btnVolver_Login.Size = new Size(220, 35);
            btnVolver_Login.TabIndex = 4;
            btnVolver_Login.Text = "Cerrar Sesión";
            btnVolver_Login.UseVisualStyleBackColor = true;
            btnVolver_Login.Click += btnVolver_Login_Click;
            // 
            // RegistrarCliente
            // 
            RegistrarCliente.Location = new Point(167, 185);
            RegistrarCliente.Name = "RegistrarCliente";
            RegistrarCliente.Size = new Size(242, 116);
            RegistrarCliente.TabIndex = 5;
            RegistrarCliente.Text = "Registrar Cliente";
            RegistrarCliente.UseVisualStyleBackColor = true;
            RegistrarCliente.Click += RegistrarCliente_Click;
            // 
            // Actividades
            // 
            Actividades.Location = new Point(574, 185);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(235, 116);
            Actividades.TabIndex = 6;
            Actividades.Text = "Inscribir en Actividades Guiadas";
            Actividades.UseVisualStyleBackColor = true;
            // 
            // btnAbonar
            // 
            btnAbonar.Location = new Point(167, 314);
            btnAbonar.Name = "btnAbonar";
            btnAbonar.Size = new Size(242, 116);
            btnAbonar.TabIndex = 7;
            btnAbonar.Text = "Abonar cuota";
            btnAbonar.UseVisualStyleBackColor = true;
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
            Controls.Add(label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver_Login;
        private Button RegistrarCliente;
        private Button Actividades;
        private Button btnAbonar;
    }
}