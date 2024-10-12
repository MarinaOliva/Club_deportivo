namespace club_Deportivo
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            txtUsuario = new System.Windows.Forms.TextBox();
            txtContrasena = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(439, 397);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(148, 32);
            btnClear.TabIndex = 5;
            btnClear.Text = "Borrar";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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