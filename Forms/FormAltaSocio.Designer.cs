using System;

namespace club_deportivo
{
    partial class FormAltaSocio
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
            label1 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtApellido = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtNumDoc = new System.Windows.Forms.TextBox();
            cmbTipoDoc = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            checkBoxApto = new System.Windows.Forms.CheckBox();
            checkBoxNoApto = new System.Windows.Forms.CheckBox();
            btnAltaSocio = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(95, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(171, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(164, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(95, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            label2.Click += label2_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(171, 81);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(164, 23);
            txtApellido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(95, 128);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(115, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de Documento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(95, 173);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 30);
            label4.TabIndex = 5;
            label4.Text = "Número de\r\n Documento:";
            label4.Click += label4_Click;
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new System.Drawing.Point(196, 180);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new System.Drawing.Size(160, 23);
            txtNumDoc.TabIndex = 7;
            // 
            // cmbTipoDoc
            // 
            cmbTipoDoc.FormattingEnabled = true;
            cmbTipoDoc.Items.AddRange(new object[] { "DNI", "Libreta de enrolamiento", "Pasaporte" });
            cmbTipoDoc.Location = new System.Drawing.Point(216, 125);
            cmbTipoDoc.Name = "cmbTipoDoc";
            cmbTipoDoc.Size = new System.Drawing.Size(121, 23);
            cmbTipoDoc.TabIndex = 8;
            cmbTipoDoc.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(95, 226);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 15);
            label5.TabIndex = 9;
            label5.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(193, 226);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(163, 23);
            txtTelefono.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(104, 275);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(44, 15);
            label6.TabIndex = 11;
            label6.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(197, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(159, 23);
            txtEmail.TabIndex = 12;
            txtEmail.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(104, 325);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 15);
            label7.TabIndex = 13;
            label7.Text = "Apto Médico:";
            // 
            // checkBoxApto
            // 
            checkBoxApto.AutoSize = true;
            checkBoxApto.Location = new System.Drawing.Point(227, 324);
            checkBoxApto.Name = "checkBoxApto";
            checkBoxApto.Size = new System.Drawing.Size(52, 19);
            checkBoxApto.TabIndex = 14;
            checkBoxApto.Text = "Apto";
            checkBoxApto.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoApto
            // 
            checkBoxNoApto.AutoSize = true;
            checkBoxNoApto.Location = new System.Drawing.Point(335, 325);
            checkBoxNoApto.Name = "checkBoxNoApto";
            checkBoxNoApto.Size = new System.Drawing.Size(71, 19);
            checkBoxNoApto.TabIndex = 15;
            checkBoxNoApto.Text = "No Apto";
            checkBoxNoApto.UseVisualStyleBackColor = true;
            // 
            // btnAltaSocio
            // 
            btnAltaSocio.Location = new System.Drawing.Point(216, 376);
            btnAltaSocio.Name = "btnAltaSocio";
            btnAltaSocio.Size = new System.Drawing.Size(130, 45);
            btnAltaSocio.TabIndex = 16;
            btnAltaSocio.Text = "Guardar";
            btnAltaSocio.UseVisualStyleBackColor = true;
            btnAltaSocio.Click += btnAltaSocio_Click;
            // 
            // FormAltaSocio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnAltaSocio);
            Controls.Add(checkBoxNoApto);
            Controls.Add(checkBoxApto);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(cmbTipoDoc);
            Controls.Add(txtNumDoc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FormAltaSocio";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxApto;
        private System.Windows.Forms.CheckBox checkBoxNoApto;
        private System.Windows.Forms.Button btnAltaSocio;
    }
}