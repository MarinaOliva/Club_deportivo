namespace club_deportivo.Forms
{
    partial class FormActividadNoSocio
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
            lblNombre = new Label();
            lblEleccionActividad = new Label();
            lblApellido = new Label();
            lblMonto = new Label();
            lblNumDoc = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cboAct = new ComboBox();
            comboBox2 = new ComboBox();
            txtDNI = new TextBox();
            lblTipoDoc = new Label();
            cboMonto = new ComboBox();
            btnPagar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(62, 154);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblEleccionActividad
            // 
            lblEleccionActividad.AutoSize = true;
            lblEleccionActividad.Location = new Point(62, 46);
            lblEleccionActividad.Name = "lblEleccionActividad";
            lblEleccionActividad.Size = new Size(181, 23);
            lblEleccionActividad.TabIndex = 1;
            lblEleccionActividad.Text = "Seleccione la actividad";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(379, 157);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(76, 23);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(62, 98);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(140, 23);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto a Abonar:";
            // 
            // lblNumDoc
            // 
            lblNumDoc.AutoSize = true;
            lblNumDoc.Location = new Point(62, 275);
            lblNumDoc.Name = "lblNumDoc";
            lblNumDoc.Size = new Size(150, 23);
            lblNumDoc.TabIndex = 4;
            lblNumDoc.Text = "N° de documento:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(475, 154);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 30);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 154);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 30);
            txtNombre.TabIndex = 7;
            // 
            // cboAct
            // 
            cboAct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboAct.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboAct.FormattingEnabled = true;
            cboAct.Items.AddRange(new object[] { "Pilates", "Yoga", "Zumba" });
            cboAct.Location = new Point(259, 43);
            cboAct.Name = "cboAct";
            cboAct.Size = new Size(151, 31);
            cboAct.TabIndex = 8;
            cboAct.SelectedIndexChanged += cboAct_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "DNI", "Cédula de Indentidad", "Pasaporte" });
            comboBox2.Location = new Point(233, 220);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 31);
            comboBox2.TabIndex = 9;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(233, 272);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(125, 30);
            txtDNI.TabIndex = 10;
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(62, 220);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(164, 23);
            lblTipoDoc.TabIndex = 11;
            lblTipoDoc.Text = "Tipo de documento:";
            // 
            // cboMonto
            // 
            cboMonto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMonto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMonto.FormattingEnabled = true;
            cboMonto.Items.AddRange(new object[] { "2500", "2300", "2200" });
            cboMonto.Location = new Point(259, 98);
            cboMonto.Name = "cboMonto";
            cboMonto.Size = new Size(151, 31);
            cboMonto.TabIndex = 12;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(123, 371);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(159, 58);
            btnPagar.TabIndex = 13;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(425, 371);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(159, 58);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // FormActividadNoSocio
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnPagar);
            Controls.Add(cboMonto);
            Controls.Add(lblTipoDoc);
            Controls.Add(txtDNI);
            Controls.Add(comboBox2);
            Controls.Add(cboAct);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblNumDoc);
            Controls.Add(lblMonto);
            Controls.Add(lblApellido);
            Controls.Add(lblEleccionActividad);
            Controls.Add(lblNombre);
            Name = "FormActividadNoSocio";
            Text = "Inscripción a Actividad Guiada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEleccionActividad;
        private Label lblApellido;
        private Label lblMonto;
        private Label lblNumDoc;
        private TextBox txtApellido;
        private TextBox textBox2;
        private TextBox txtNombre;
        private ComboBox cboAct;
        private ComboBox comboBox2;
        private TextBox txtDNI;
        private Label lblTipoDoc;
        private ComboBox cboMonto;
        private Button btnPagar;
        private Button btnSalir;
    }
}