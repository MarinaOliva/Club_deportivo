namespace club_deportivo.Forms
{
    partial class FormCarnet
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
            pnlHeader = new Panel();
            lblTitulo = new Label();
            label1 = new Label();
            pnlContenido = new Panel();
            lblNumSocio = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            picLogo = new PictureBox();
            btnImprimir = new Button();
            pnlCarnet = new Panel();
            pnlHeader.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlCarnet.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Teal;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Location = new Point(65, 34);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(677, 62);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.2F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Orange;
            lblTitulo.Location = new Point(213, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(269, 46);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Carnet de Socio";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 373);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = SystemColors.ActiveCaptionText;
            pnlContenido.Controls.Add(lblNumSocio);
            pnlContenido.Controls.Add(lblApellido);
            pnlContenido.Controls.Add(lblNombre);
            pnlContenido.Location = new Point(65, 120);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(414, 270);
            pnlContenido.TabIndex = 1;
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblNumSocio.ForeColor = Color.FromArgb(255, 128, 0);
            lblNumSocio.Location = new Point(27, 167);
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(107, 23);
            lblNumSocio.TabIndex = 2;
            lblNumSocio.Text = "Num Socio: ";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblApellido.ForeColor = Color.FromArgb(255, 128, 0);
            lblApellido.Location = new Point(24, 98);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(88, 23);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(255, 128, 0);
            lblNombre.Location = new Point(26, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(86, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            // 
            // picLogo
            // 
            picLogo.BackgroundImageLayout = ImageLayout.Center;
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new Point(374, 13);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(390, 407);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = SystemColors.ButtonHighlight;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Location = new Point(315, 438);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(153, 64);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pnlCarnet
            // 
            pnlCarnet.BackColor = Color.FromArgb(0, 192, 192);
            pnlCarnet.Controls.Add(picLogo);
            pnlCarnet.Location = new Point(25, 12);
            pnlCarnet.Name = "pnlCarnet";
            pnlCarnet.Size = new Size(750, 420);
            pnlCarnet.TabIndex = 4;
            // 
            // FormCarnet
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 514);
            Controls.Add(btnImprimir);
            Controls.Add(pnlContenido);
            Controls.Add(pnlHeader);
            Controls.Add(pnlCarnet);
            Name = "FormCarnet";
            Text = "Carnet";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlCarnet.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlContenido;
        private Label label1;
        private Label lblTitulo;
        private PictureBox picLogo;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblNumSocio;
        private Button btnImprimir;
        private Panel pnlCarnet;
    }
}