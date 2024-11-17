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
            numero = new TextBox();
            Consulta = new Button();
            label1 = new Label();
            cmbTipoDoc = new ComboBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // numero
            // 
            numero.Location = new Point(388, 204);
            numero.Name = "numero";
            numero.Size = new Size(198, 30);
            numero.TabIndex = 0;
            // 
            // Consulta
            // 
            Consulta.Location = new Point(228, 312);
            Consulta.Name = "Consulta";
            Consulta.Size = new Size(103, 38);
            Consulta.TabIndex = 1;
            Consulta.Text = "Consultar";
            Consulta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 140);
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
            cmbTipoDoc.Location = new Point(180, 203);
            cmbTipoDoc.Name = "cmbTipoDoc";
            cmbTipoDoc.Size = new Size(151, 31);
            cmbTipoDoc.TabIndex = 3;
            cmbTipoDoc.SelectedIndexChanged += cmbTipoDoc_SelectedIndexChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(446, 317);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormConsultaSocio
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(cmbTipoDoc);
            Controls.Add(label1);
            Controls.Add(Consulta);
            Controls.Add(numero);
            Name = "FormConsultaSocio";
            Text = "Consulta";
            Load += FormConsultaSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numero;
        private Button Consulta;
        private Label label1;
        private ComboBox cmbTipoDoc;
        private Button btnSalir;
    }
}