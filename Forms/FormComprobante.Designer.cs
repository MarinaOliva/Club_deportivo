namespace club_deportivo.Forms
{
    partial class FormComprobante
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
            pnlTitulo = new Panel();
            label1 = new Label();
            pnlContenido = new Panel();
            lblFecha = new Label();
            lblMonto = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            btnPrint = new Button();
            pnlComp = new Panel();
            picLogo = new PictureBox();
            pnlTitulo.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.Teal;
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Font = new Font("Segoe UI", 20.2F, FontStyle.Bold);
            pnlTitulo.Location = new Point(39, 12);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(733, 68);
            pnlTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(176, 11);
            label1.Name = "label1";
            label1.Size = new Size(377, 46);
            label1.TabIndex = 0;
            label1.Text = "Comprobante de Pago";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = SystemColors.ActiveCaptionText;
            pnlContenido.Controls.Add(lblFecha);
            pnlContenido.Controls.Add(lblMonto);
            pnlContenido.Controls.Add(lblDNI);
            pnlContenido.Controls.Add(lblNombre);
            pnlContenido.Location = new Point(39, 86);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(422, 288);
            pnlContenido.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblFecha.ForeColor = Color.Red;
            lblFecha.Location = new Point(19, 240);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(60, 23);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblMonto.ForeColor = Color.Red;
            lblMonto.Location = new Point(16, 172);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(143, 23);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto abonado:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDNI.ForeColor = Color.Red;
            lblDNI.Location = new Point(19, 102);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(51, 23);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblNombre.ForeColor = Color.Red;
            lblNombre.Location = new Point(17, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(86, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.ButtonHighlight;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Location = new Point(327, 408);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(134, 43);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Imprimir";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // pnlComp
            // 
            pnlComp.BackColor = Color.FromArgb(0, 192, 192);
            pnlComp.Controls.Add(picLogo);
            pnlComp.Location = new Point(21, 12);
            pnlComp.Name = "pnlComp";
            pnlComp.Size = new Size(767, 390);
            pnlComp.TabIndex = 4;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new Point(338, -16);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(486, 418);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // FormComprobante
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(btnPrint);
            Controls.Add(pnlContenido);
            Controls.Add(pnlTitulo);
            Controls.Add(pnlComp);
            Name = "FormComprobante";
            Text = "FormComprobante";
            Load += FormComprobante_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            pnlComp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label label1;
        private Panel pnlContenido;
        private Label lblFecha;
        private Label lblMonto;
        private Label lblDNI;
        private Label lblNombre;
        private Button btnPrint;
        private Panel pnlComp;
        private PictureBox picLogo;
    }
}