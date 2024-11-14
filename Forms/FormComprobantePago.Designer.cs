namespace club_deportivo.Forms
{
    partial class FormComprobantePago
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNumSocio;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pictureBoxLogo;

        private System.Windows.Forms.Label lblNombreSocio;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNumeroSocio;
        private System.Windows.Forms.Label lblMontoAbonado;
        private System.Windows.Forms.Label lblFechaPago;

        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtDNI = new TextBox();
            label1 = new Label();
            lblNombre = new Label();
            pictureBoxLogo = new PictureBox();
            txtNombre = new TextBox();
            lblDni = new Label();
            txtNumSocio = new TextBox();
            lblValor = new Label();
            txtValor = new TextBox();
            lblFecha = new Label();
            txtFecha = new TextBox();
            btnImprimir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtDNI);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(txtNumSocio);
            panel1.Controls.Add(lblValor);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(txtFecha);
            panel1.Controls.Add(btnImprimir);
            panel1.Location = new Point(100, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 400);
            panel1.TabIndex = 0;
//            panel1.Paint += panel1_Paint;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(212, 54);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(200, 30);
            txtDNI.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(20, 100);
            label1.Name = "label1";
            label1.Size = new Size(146, 24);
            label1.TabIndex = 12;
            label1.Text = "Num de socio:";
            //label1.Click += label1_Click;
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
            //lblNombre.Click += lblNombre_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(520, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(80, 80);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(212, 14);
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
            //lblDni.Click += lblDni_Click;
            // 
            // txtNumSocio
            // 
            txtNumSocio.Location = new Point(212, 94);
            txtNumSocio.Name = "txtNumSocio";
            txtNumSocio.Size = new Size(200, 30);
            txtNumSocio.TabIndex = 4;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblValor.Location = new Point(20, 140);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(165, 24);
            lblValor.TabIndex = 5;
            lblValor.Text = "Monto abonado:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(212, 138);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(200, 30);
            txtValor.TabIndex = 6;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblFecha.Location = new Point(20, 184);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(74, 24);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(212, 178);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(200, 30);
            txtFecha.TabIndex = 8;
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnImprimir.Location = new Point(154, 232);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(200, 40);
            btnImprimir.TabIndex = 11;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
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

        private Label label1;
        private TextBox txtDNI;
    }
}
