﻿namespace club_deportivo.Forms
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
            pnlContenido = new Panel();
            lblFecha = new Label();
            lblMonto = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            btnPrint = new Button();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlContenido.SuspendLayout();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 11);
            label1.Name = "label1";
            label1.Size = new Size(377, 46);
            label1.TabIndex = 0;
            label1.Text = "Comprobante de Pago";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new Point(544, 86);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(228, 288);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(lblFecha);
            pnlContenido.Controls.Add(lblMonto);
            pnlContenido.Controls.Add(lblDNI);
            pnlContenido.Controls.Add(lblNombre);
            pnlContenido.Location = new Point(39, 86);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(472, 288);
            pnlContenido.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(19, 240);
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
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(377, 395);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(134, 43);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Imprimir";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // FormComprobante
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrint);
            Controls.Add(pnlContenido);
            Controls.Add(picLogo);
            Controls.Add(pnlTitulo);
            Name = "FormComprobante";
            Text = "FormComprobante";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label label1;
        private PictureBox picLogo;
        private Panel pnlContenido;
        private Label lblFecha;
        private Label lblMonto;
        private Label lblDNI;
        private Label lblNombre;
        private Button btnPrint;
    }
}