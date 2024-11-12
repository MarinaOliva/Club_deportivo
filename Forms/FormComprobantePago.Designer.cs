namespace club_deportivo.Forms
{
    partial class FormComprobantePago
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.TextBox txtAdministrador;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pictureBoxLogo;

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblValor = new Label();
            txtValor = new TextBox();
            lblFecha = new Label();
            txtFecha = new TextBox();
            lblAdministrador = new Label();
            txtAdministrador = new TextBox();
            btnImprimir = new Button();
            pictureBoxLogo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(lblValor);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(txtFecha);
            panel1.Controls.Add(lblAdministrador);
            panel1.Controls.Add(txtAdministrador);
            panel1.Controls.Add(btnImprimir);
            panel1.Location = new Point(100, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 400);
            panel1.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblNombre.Location = new Point(20, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(91, 24);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 30);
            txtNombre.TabIndex = 2;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblDni.Location = new Point(20, 60);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(50, 24);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(150, 60);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(200, 30);
            txtDni.TabIndex = 4;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblValor.Location = new Point(20, 100);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(65, 24);
            lblValor.TabIndex = 5;
            lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(150, 100);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(200, 30);
            txtValor.TabIndex = 6;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblFecha.Location = new Point(20, 140);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(74, 24);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(150, 140);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(200, 30);
            txtFecha.TabIndex = 8;
            // 
            // lblAdministrador
            // 
            lblAdministrador.AutoSize = true;
            lblAdministrador.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblAdministrador.Location = new Point(20, 180);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(150, 24);
            lblAdministrador.TabIndex = 9;
            lblAdministrador.Text = "Administrador:";
            // 
            // txtAdministrador
            // 
            txtAdministrador.Location = new Point(150, 180);
            txtAdministrador.Name = "txtAdministrador";
            txtAdministrador.Size = new Size(200, 30);
            txtAdministrador.TabIndex = 10;
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnImprimir.Location = new Point(150, 220);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(200, 40);
            btnImprimir.TabIndex = 11;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            //btnImprimir.Click += btnImprimir_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(520, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(80, 80);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // FormComprobantePago
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormComprobantePago";
            Text = "Comprobante de Pago";
            Load += FormComprobantePago_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }
    }
}
