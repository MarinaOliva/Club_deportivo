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
            picLogo = new PictureBox();
            panel1 = new Panel();
            lblFecha = new Label();
            lblMonto = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            btnPrint = new Button();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.Moccasin;
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Font = new Font("Segoe UI", 20.2F, FontStyle.Bold);
            pnlTitulo.Location = new Point(39, 12);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(733, 68);
            pnlTitulo.TabIndex = 0;
            //pnlTitulo.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 11);
            label1.Name = "label1";
            label1.Size = new Size(377, 46);
            label1.TabIndex = 0;
            label1.Text = "Comprobante de Pago";
            //label1.Click += label1_Click;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new Point(544, 112);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(228, 213);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            //picLogo.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblMonto);
            panel1.Controls.Add(lblDNI);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(39, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 288);
            panel1.TabIndex = 2;
            //panel1.Paint += panel1_Paint_1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(20, 240);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(58, 23);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(16, 172);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(138, 23);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto abonado:";
            //lblMonto.Click += label4_Click;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(19, 102);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(49, 23);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            //lblNombre.Click += label2_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(377, 395);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(134, 43);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Imprimir";
            btnPrint.UseVisualStyleBackColor = true;
            //btnPrint.Click += button1_Click;
            // 
            // FormComprobante
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrint);
            Controls.Add(panel1);
            Controls.Add(picLogo);
            Controls.Add(pnlTitulo);
            Name = "FormComprobante";
            Text = "FormComprobante";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label label1;
        private PictureBox picLogo;
        private Panel panel1;
        private Label lblFecha;
        private Label lblMonto;
        private Label lblDNI;
        private Label lblNombre;
        private Button btnPrint;
    }
}