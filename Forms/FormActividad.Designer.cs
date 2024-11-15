namespace club_deportivo.Forms
{
    partial class FormActividad
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
            label4 = new Label();
            lblDoc = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            cboAct = new ComboBox();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
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
            lblNombre.Click += label1_Click;
            // 
            // lblEleccionActividad
            // 
            lblEleccionActividad.AutoSize = true;
            lblEleccionActividad.Location = new Point(62, 46);
            lblEleccionActividad.Name = "lblEleccionActividad";
            lblEleccionActividad.Size = new Size(181, 23);
            lblEleccionActividad.TabIndex = 1;
            lblEleccionActividad.Text = "Seleccione la actividad";
            lblEleccionActividad.Click += label2_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 98);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 3;
            label4.Text = "Monto a Abonar:";
            label4.Click += label4_Click;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(62, 275);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(150, 23);
            lblDoc.TabIndex = 4;
            lblDoc.Text = "N° de documento:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(475, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 30);
            textBox3.TabIndex = 7;
            // 
            // cboAct
            // 
            cboAct.FormattingEnabled = true;
            cboAct.Items.AddRange(new object[] { "Musculación", "Pilates", "Yoga", "Zumba", "Natación" });
            cboAct.Location = new Point(259, 43);
            cboAct.Name = "cboAct";
            cboAct.Size = new Size(151, 31);
            cboAct.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(233, 220);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 31);
            comboBox2.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(233, 272);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 30);
            textBox4.TabIndex = 10;
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(62, 220);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(164, 23);
            lblTipoDoc.TabIndex = 11;
            lblTipoDoc.Text = "Tipo de documento:";
            lblTipoDoc.Click += label1_Click_1;
            // 
            // cboMonto
            // 
            cboMonto.FormattingEnabled = true;
            cboMonto.Items.AddRange(new object[] { "2000", "2500", "2300", "2200", "3000" });
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
            // FormActividad
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnPagar);
            Controls.Add(cboMonto);
            Controls.Add(lblTipoDoc);
            Controls.Add(textBox4);
            Controls.Add(comboBox2);
            Controls.Add(cboAct);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(lblDoc);
            Controls.Add(label4);
            Controls.Add(lblApellido);
            Controls.Add(lblEleccionActividad);
            Controls.Add(lblNombre);
            Name = "FormActividad";
            Text = "Inscripción a Actividad Guiada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEleccionActividad;
        private Label lblApellido;
        private Label label4;
        private Label lblDoc;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox cboAct;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private Label lblTipoDoc;
        private ComboBox cboMonto;
        private Button btnPagar;
        private Button btnSalir;
    }
}