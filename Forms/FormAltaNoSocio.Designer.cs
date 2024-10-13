using System;

namespace club_deportivo
{
    partial class FormAltaNoSocio
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
            label2 = new System.Windows.Forms.Label();
            cmbTipoDoc = new System.Windows.Forms.ComboBox();
            cmbActividad = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApelido = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtNumDoc = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            btnAltaNoSocio = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(99, 123);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(108, 310);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Actividad:";
            // 
            // cmbTipoDoc
            // 
            cmbTipoDoc.FormattingEnabled = true;
            cmbTipoDoc.Location = new System.Drawing.Point(247, 123);
            cmbTipoDoc.Name = "cmbTipoDoc";
            cmbTipoDoc.Size = new System.Drawing.Size(121, 23);
            cmbTipoDoc.TabIndex = 2;
            cmbTipoDoc.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbActividad
            // 
            cmbActividad.FormattingEnabled = true;
            cmbActividad.Location = new System.Drawing.Point(207, 302);
            cmbActividad.Name = "cmbActividad";
            cmbActividad.Size = new System.Drawing.Size(121, 23);
            cmbActividad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(99, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(99, 78);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(232, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(148, 23);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtApelido
            // 
            txtApelido.Location = new System.Drawing.Point(232, 70);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new System.Drawing.Size(148, 23);
            txtApelido.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(99, 175);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(136, 15);
            label5.TabIndex = 8;
            label5.Text = "Número de Documento:";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new System.Drawing.Point(261, 171);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new System.Drawing.Size(153, 23);
            txtNumDoc.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(261, 215);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(153, 23);
            txtTelefono.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(261, 257);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(153, 23);
            txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(96, 219);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 15);
            label6.TabIndex = 12;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(101, 258);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(44, 15);
            label7.TabIndex = 13;
            label7.Text = "E-Mail:";
            // 
            // btnAltaNoSocio
            // 
            btnAltaNoSocio.Location = new System.Drawing.Point(259, 384);
            btnAltaNoSocio.Name = "btnAltaNoSocio";
            btnAltaNoSocio.Size = new System.Drawing.Size(175, 43);
            btnAltaNoSocio.TabIndex = 14;
            btnAltaNoSocio.Text = "Guardar";
            btnAltaNoSocio.UseVisualStyleBackColor = true;
            btnAltaNoSocio.Click += btnAltaNoSocio_Click;
            // 
            // FormAltaNoSocio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnAltaNoSocio);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtNumDoc);
            Controls.Add(label5);
            Controls.Add(txtApelido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbActividad);
            Controls.Add(cmbTipoDoc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAltaNoSocio";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAltaNoSocio;
    }
}