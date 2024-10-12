namespace club_Deportivo
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
            btnAltaSocio = new System.Windows.Forms.Button();
            btnAltaNoSocio = new System.Windows.Forms.Button();
            btnConsultar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnVolver_Login = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnAltaSocio
            // 
            btnAltaSocio.Location = new System.Drawing.Point(254, 134);
            btnAltaSocio.Name = "btnAltaSocio";
            btnAltaSocio.Size = new System.Drawing.Size(156, 23);
            btnAltaSocio.TabIndex = 0;
            btnAltaSocio.Text = "Ingresar Nuevo Socio";
            btnAltaSocio.UseVisualStyleBackColor = true;
            btnAltaSocio.Click += btnAltaSocio_Click;
            // 
            // btnAltaNoSocio
            // 
            btnAltaNoSocio.Location = new System.Drawing.Point(254, 184);
            btnAltaNoSocio.Name = "btnAltaNoSocio";
            btnAltaNoSocio.Size = new System.Drawing.Size(156, 23);
            btnAltaNoSocio.TabIndex = 1;
            btnAltaNoSocio.Text = "Ingresar Nuevo No Socio";
            btnAltaNoSocio.UseVisualStyleBackColor = true;
            btnAltaNoSocio.Click += btnAltaNoSocio_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new System.Drawing.Point(254, 228);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new System.Drawing.Size(183, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar cuotas vencidas hoy";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(254, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(227, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccione la operación que desea realizar";
            label1.Click += label1_Click;
            // 
            // btnVolver_Login
            // 
            btnVolver_Login.Location = new System.Drawing.Point(254, 273);
            btnVolver_Login.Name = "btnVolver_Login";
            btnVolver_Login.Size = new System.Drawing.Size(171, 23);
            btnVolver_Login.TabIndex = 4;
            btnVolver_Login.Text = "Volver al Menú Principal";
            btnVolver_Login.UseVisualStyleBackColor = true;
            btnVolver_Login.Click += btnVolver_Login_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnVolver_Login);
            Controls.Add(label1);
            Controls.Add(btnConsultar);
            Controls.Add(btnAltaNoSocio);
            Controls.Add(btnAltaSocio);
            Name = "FormMenu";
            Text = "Form1";
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