namespace club_deportivo.Forms
{
    partial class FormConsultaSocio : Form
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
            txtNum = new TextBox();
            Consulta = new Button();
            label1 = new Label();
            cmbTipoDoc = new ComboBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(292, 179);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(198, 30);
            txtNum.TabIndex = 0;
            txtNum.TextChanged += numero_TextChanged;
            // 
            // Consulta
            // 
            Consulta.BackColor = SystemColors.ButtonHighlight;
            Consulta.FlatStyle = FlatStyle.Flat;
            Consulta.Location = new Point(118, 286);
            Consulta.Name = "Consulta";
            Consulta.Size = new Size(131, 54);
            Consulta.TabIndex = 1;
            Consulta.Text = "Consultar";
            Consulta.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 91);
            label1.Name = "label1";
            label1.Size = new Size(417, 23);
            label1.TabIndex = 2;
            label1.Text = "Seleccione el tipo e ingrese el número de documento";
            // 
            // cmbTipoDoc
            // 
            cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDoc.FormattingEnabled = true;
            cmbTipoDoc.Items.AddRange(new object[] { "DNI", "Cédula de Indentidad", "Pasaporte" });
            cmbTipoDoc.Location = new Point(83, 178);
            cmbTipoDoc.Name = "cmbTipoDoc";
            cmbTipoDoc.Size = new Size(151, 31);
            cmbTipoDoc.TabIndex = 3;
            cmbTipoDoc.SelectedIndexChanged += cmbTipoDoc_SelectedIndexChanged;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ButtonHighlight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(327, 286);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(131, 54);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormConsultaSocio
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 389);
            Controls.Add(btnSalir);
            Controls.Add(cmbTipoDoc);
            Controls.Add(label1);
            Controls.Add(Consulta);
            Controls.Add(txtNum);
            Name = "FormConsultaSocio";
            Text = "Consulta";
            Load += FormConsultaSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private Button Consulta;
        private Label label1;
        private ComboBox cmbTipoDoc;
        private Button btnSalir;
    }
}