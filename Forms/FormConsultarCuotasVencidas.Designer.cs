namespace club_deportivo.Forms
{
    partial class FormConsultarCuotasVencidas
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
            dgvCuotasVencidas = new DataGridView();
            btnVolver = new Button();
            btnPrint = new Button();
            lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCuotasVencidas).BeginInit();
            SuspendLayout();
            // 
            // dgvCuotasVencidas
            // 
            dgvCuotasVencidas.AllowUserToOrderColumns = true;
            dgvCuotasVencidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuotasVencidas.Location = new Point(173, 92);
            dgvCuotasVencidas.Name = "dgvCuotasVencidas";
            dgvCuotasVencidas.RowHeadersWidth = 51;
            dgvCuotasVencidas.Size = new Size(611, 198);
            dgvCuotasVencidas.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ButtonHighlight;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(527, 382);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(139, 50);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.ButtonHighlight;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Location = new Point(312, 382);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(143, 50);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Imprimir";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(346, 56);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(220, 23);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Cuotas vencidas a la fecha: ";
            lblHeader.Click += label1_Click;
            // 
            // FormConsultarCuotasVencidas
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 504);
            Controls.Add(lblHeader);
            Controls.Add(btnPrint);
            Controls.Add(btnVolver);
            Controls.Add(dgvCuotasVencidas);
            Name = "FormConsultarCuotasVencidas";
            Text = "Cuotas Vencidas";
            Load += FormCuotasVencidas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCuotasVencidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCuotasVencidas;
        private Button btnVolver;
        private Button btnPrint;
        private Label lblHeader;
    }
}