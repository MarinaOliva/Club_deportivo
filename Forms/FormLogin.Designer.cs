namespace club_deportivo
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
			this.SuspendLayout();
			
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            txtUsuario = new System.Windows.Forms.TextBox();
            txtContrasena = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
           
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Club_Deportivo;
            pictureBox1.Location = new System.Drawing.Point(299, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(237, 228);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(267, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(301, 15);
            label1.TabIndex = 1;
            label1.Text = "Bienvenid@s al sistema ingrese su nombre y contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(159, 349);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(228, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new System.Drawing.Point(439, 349);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new System.Drawing.Size(227, 23);
            txtContrasena.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(239, 397);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(148, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click); // Asegúrate de tener el evento click
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(439, 397);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(148, 32);
            btnClear.TabIndex = 5;
            btnClear.Text = "Borrar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += new System.EventHandler(this.btnClear_Click); // Asegúrate de tener el evento click
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnLogin);
            this.Controls.Add(txtContrasena);
            this.Controls.Add(txtUsuario);
            this.Controls.Add(label1);
            this.Controls.Add(pictureBox1);
            this.Name = "FormLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
    }
}
