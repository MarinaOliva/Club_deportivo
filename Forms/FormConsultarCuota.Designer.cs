namespace club_deportivo.Forms
{
    partial class FormConsultarCuota
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
            lbl_instruccion = new Label();
            btnContinuar = new Button();
            txtNumeroSocio = new TextBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lbl_instruccion
            // 
            lbl_instruccion.AutoSize = true;
            lbl_instruccion.Location = new Point(88, 96);
            lbl_instruccion.Name = "lbl_instruccion";
            lbl_instruccion.Size = new Size(177, 23);
            lbl_instruccion.TabIndex = 0;
            lbl_instruccion.Text = "Ingrese el n° de socio:";
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(185, 248);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(94, 29);
            btnContinuar.TabIndex = 1;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Location = new Point(356, 93);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.Size = new Size(199, 30);
            txtNumeroSocio.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(535, 248);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormConsultarCuota
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(txtNumeroSocio);
            Controls.Add(btnContinuar);
            Controls.Add(lbl_instruccion);
            Name = "FormConsultarCuota";
            Text = "Consultar Cuota";
            Load += FormConsultarCuota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_instruccion;
        private Button btnContinuar;
        private TextBox txtNumeroSocio;
        private Button btnSalir;
    }
}