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
            btnAltaSocio = new Button();
            btnAltaNoSocio = new Button();
            btnConsultar = new Button();
            label1 = new Label();
            btnVolver_Login = new Button();
            SuspendLayout();
            // 
            // btnAltaSocio
            // 
            btnAltaSocio.Location = new Point(327, 205);
            btnAltaSocio.Margin = new Padding(4, 5, 4, 5);
            btnAltaSocio.Name = "btnAltaSocio";
            btnAltaSocio.Size = new Size(201, 35);
            btnAltaSocio.TabIndex = 0;
            btnAltaSocio.Text = "Ingresar Nuevo Socio";
            btnAltaSocio.UseVisualStyleBackColor = true;
            btnAltaSocio.Click += btnAltaSocio_Click;
            // 
            // btnAltaNoSocio
            // 
            btnAltaNoSocio.Location = new Point(327, 282);
            btnAltaNoSocio.Margin = new Padding(4, 5, 4, 5);
            btnAltaNoSocio.Name = "btnAltaNoSocio";
            btnAltaNoSocio.Size = new Size(201, 35);
            btnAltaNoSocio.TabIndex = 1;
            btnAltaNoSocio.Text = "Ingresar Nuevo No Socio";
            btnAltaNoSocio.UseVisualStyleBackColor = true;
            btnAltaNoSocio.Click += btnAltaNoSocio_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(327, 350);
            btnConsultar.Margin = new Padding(4, 5, 4, 5);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(235, 35);
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
            btnVolver_Login.Location = new Point(327, 419);
            btnVolver_Login.Margin = new Padding(4, 5, 4, 5);
            btnVolver_Login.Name = "btnVolver_Login";
            btnVolver_Login.Size = new Size(220, 35);
            btnVolver_Login.TabIndex = 4;
            btnVolver_Login.Text = "Volver al Menú Principal";
            btnVolver_Login.UseVisualStyleBackColor = true;
            btnVolver_Login.Click += btnVolver_Login_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 690);
            Controls.Add(btnVolver_Login);
            Controls.Add(label1);
            Controls.Add(btnConsultar);
            Controls.Add(btnAltaNoSocio);
            Controls.Add(btnAltaSocio);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMenu";
            Text = "Form1";
            Load += FormMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAltaSocio;
        private System.Windows.Forms.Button btnAltaNoSocio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver_Login;
    }
}