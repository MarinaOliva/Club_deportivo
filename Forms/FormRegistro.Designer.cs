using System;

namespace club_deportivo
{
    partial class FormRegistro
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
            label1 = new Label();
            AptaF = new Label();
            cmbDoc = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label5 = new Label();
            txtNumDoc = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnAltaNoSocio = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            btnSalir = new Button();
            lblFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 189);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Documento:";
            // 
            // AptaF
            // 
            AptaF.AutoSize = true;
            AptaF.Location = new Point(127, 359);
            AptaF.Margin = new Padding(4, 0, 4, 0);
            AptaF.Name = "AptaF";
            AptaF.Size = new Size(101, 23);
            AptaF.TabIndex = 1;
            AptaF.Text = "Apta Físico: ";
            // 
            // cmbDoc
            // 
            cmbDoc.FormattingEnabled = true;
            cmbDoc.Items.AddRange(new object[] { "DNI", "Cédula de Identidad", "Pasaporte" });
            cmbDoc.Location = new Point(313, 189);
            cmbDoc.Margin = new Padding(4, 5, 4, 5);
            cmbDoc.Name = "cmbDoc";
            cmbDoc.Size = new Size(154, 31);
            cmbDoc.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 52);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 5;
            label4.Text = "Apellido:";
            label4.Click += label4_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(298, 52);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(189, 30);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(298, 113);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(189, 30);
            txtApellido.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 189);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(196, 23);
            label5.TabIndex = 8;
            label5.Text = "Número de Documento:";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(698, 189);
            txtNumDoc.Margin = new Padding(4, 5, 4, 5);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(196, 30);
            txtNumDoc.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(213, 269);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(196, 30);
            txtTelefono.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(566, 269);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(328, 30);
            txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 269);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 12;
            label6.Text = "Teléfono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(496, 269);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 23);
            label7.TabIndex = 13;
            label7.Text = "E-Mail:";
            // 
            // btnAltaNoSocio
            // 
            btnAltaNoSocio.Location = new Point(127, 557);
            btnAltaNoSocio.Margin = new Padding(4, 5, 4, 5);
            btnAltaNoSocio.Name = "btnAltaNoSocio";
            btnAltaNoSocio.Size = new Size(235, 73);
            btnAltaNoSocio.TabIndex = 14;
            btnAltaNoSocio.Text = "Registrar";
            btnAltaNoSocio.UseVisualStyleBackColor = true;
            btnAltaNoSocio.Click += btnAltaNoSocio_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(235, 359);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(97, 27);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Presenta";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(235, 392);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(107, 27);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pendiente";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(663, 557);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(231, 73);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(127, 456);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(63, 23);
            lblFecha.TabIndex = 18;
            lblFecha.Text = "Fecha: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/mm/YY";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(213, 456);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 30);
            dateTimePicker1.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(400, 557);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(235, 73);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 690);
            Controls.Add(btnLimpiar);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFecha);
            Controls.Add(btnSalir);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btnAltaNoSocio);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtNumDoc);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbDoc);
            Controls.Add(AptaF);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormRegistro";
            Text = "Registro de Nuevos Socios";
            Load += FormRegistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label AptaF;
        private ComboBox cmbDoc;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido; 
        private Label label5;
        private TextBox txtNumDoc;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label label6;
        private Label label7;
        private Button btnAltaNoSocio;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btnSalir;
        private Label lblFecha;
        private DateTimePicker dateTimePicker1;
        private Button btnLimpiar;
    }
}
