namespace club_deportivo.Forms
{
    partial class FormConectarBD
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
            lblHeading = new Label();
            txtHost = new TextBox();
            txtPuerto = new TextBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtBaseDatos = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnConectar_1 = new Button();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(49, 16);
            lblHeading.Margin = new Padding(4, 0, 4, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(357, 23);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "¡Bienvenido/a! Conéctese a su Base de Datos:";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(235, 76);
            txtHost.Margin = new Padding(4, 5, 4, 5);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(127, 30);
            txtHost.TabIndex = 1;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(235, 148);
            txtPuerto.Margin = new Padding(4, 5, 4, 5);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(127, 30);
            txtPuerto.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(235, 214);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(127, 30);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(235, 280);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(127, 30);
            txtContraseña.TabIndex = 4;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Location = new Point(235, 351);
            txtBaseDatos.Margin = new Padding(4, 5, 4, 5);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(127, 30);
            txtBaseDatos.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 23);
            label2.TabIndex = 6;
            label2.Text = "Host:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 7;
            label3.Text = "Puerto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 219);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 8;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 282);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 9;
            label5.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 354);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 23);
            label6.TabIndex = 10;
            label6.Text = "Nombre de la BD:";
            // 
            // btnConectar_1
            // 
            btnConectar_1.Location = new Point(149, 420);
            btnConectar_1.Margin = new Padding(4, 5, 4, 5);
            btnConectar_1.Name = "btnConectar_1";
            btnConectar_1.Size = new Size(140, 58);
            btnConectar_1.TabIndex = 11;
            btnConectar_1.Text = "Conectar";
            btnConectar_1.UseVisualStyleBackColor = true;
            btnConectar_1.Click += btnConectar_1_Click;
            // 
            // FormConectarBD
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 515);
            Controls.Add(btnConectar_1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBaseDatos);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(txtPuerto);
            Controls.Add(txtHost);
            Controls.Add(lblHeading);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormConectarBD";
            Text = "Conexión a base de datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private TextBox txtHost;
        private TextBox txtPuerto;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private TextBox txtBaseDatos;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnConectar_1;
    }
}