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
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            btnImprimir = new Button();
            pnlHeader.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightCoral;
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
            lblTitulo.Location = new Point(210, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(269, 46);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Carnet de Socio";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
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
            pnlContenido.Controls.Add(lblNumSocio);
            pnlContenido.Controls.Add(lblApellido);
            pnlContenido.Controls.Add(lblNombre);
            pnlContenido.Location = new Point(65, 120);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(411, 290);
            pnlContenido.TabIndex = 1;
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Location = new Point(27, 167);
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(103, 23);
            lblNumSocio.TabIndex = 2;
            lblNumSocio.Text = "Num Socio: ";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(24, 98);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(81, 23);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Location = new Point(492, 120);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 290);
            pnlLogo.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.BackgroundImageLayout = ImageLayout.Center;
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(247, 284);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(353, 376);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(153, 64);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // FormCarnet
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImprimir);
            Controls.Add(pnlLogo);
            Controls.Add(pnlContenido);
            Controls.Add(pnlHeader);
            Name = "FormCarnet";
            Text = "Carnet";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlContenido;
        private Panel pnlLogo;
        private Label label1;
        private Label lblTitulo;
        private PictureBox picLogo;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblNumSocio;
        private Button btnImprimir;
    }
}