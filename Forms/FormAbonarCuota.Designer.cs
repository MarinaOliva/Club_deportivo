using System.Windows.Forms;

namespace club_deportivo.Forms
{
    partial class FormAbonarCuota
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
            lblNumSocio = new Label();
            lblMonto = new Label();
            lblFecha = new Label();
            btnPagar = new Button();
            btnCancelar = new Button();
            lblVencimiento = new Label();
            dtpFechaPago = new DateTimePicker();
            SuspendLayout();
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Location = new Point(88, 71);
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(86, 23);
            lblNumSocio.TabIndex = 0;
            lblNumSocio.Text = "Socio n° : ";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(88, 155);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(169, 23);
            lblMonto.TabIndex = 1;
            lblMonto.Text = "Monto de la cuota: $";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(88, 239);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(131, 23);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha de pago: ";
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(208, 380);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(102, 48);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(461, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 48);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Location = new Point(88, 298);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(185, 23);
            lblVencimiento.TabIndex = 5;
            lblVencimiento.Text = "Fecha de vencimiento: ";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(424, 239);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(250, 30);
            dtpFechaPago.TabIndex = 6;
            dtpFechaPago.Visible = false;
            dtpFechaPago.Format = DateTimePickerFormat.Custom;
            dtpFechaPago.CustomFormat = "dd/MM/yy";
            // 
            // FormAbonarCuota
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpFechaPago);
            Controls.Add(lblVencimiento);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagar);
            Controls.Add(lblFecha);
            Controls.Add(lblMonto);
            Controls.Add(lblNumSocio);
            Name = "FormAbonarCuota";
            Text = "Abonar Cuota";
            Load += FormAbonarCuota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumSocio;
        private Label lblMonto;
        private Label lblFecha;
        private Button btnPagar;
        private Button btnCancelar;
        private Label lblVencimiento;
    }
}