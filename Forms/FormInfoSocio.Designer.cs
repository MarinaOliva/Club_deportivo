﻿namespace club_deportivo.Forms
{
    partial class FormInfoSocio
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
            lblDNI = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            btnCarnet = new Button();
            btnOut = new Button();
            lblCuota = new Label();
            lblAct = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lblValidez = new Label();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(94, 29);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(153, 23);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "N° Doc ingresado: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(94, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 23);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre: ";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(94, 136);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(81, 23);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido: ";
            // 
            // btnCarnet
            // 
            btnCarnet.Location = new Point(204, 491);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(119, 46);
            btnCarnet.TabIndex = 3;
            btnCarnet.Text = "Ver Carnet";
            btnCarnet.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(452, 491);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(103, 46);
            btnOut.TabIndex = 4;
            btnOut.Text = "Salir";
            btnOut.UseVisualStyleBackColor = true;
            // 
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Location = new Point(94, 190);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new Size(60, 23);
            lblCuota.TabIndex = 5;
            lblCuota.Text = "Cuota:";
            // 
            // lblAct
            // 
            lblAct.AutoSize = true;
            lblAct.Location = new Point(94, 248);
            lblAct.Name = "lblAct";
            lblAct.Size = new Size(189, 23);
            lblAct.TabIndex = 6;
            lblAct.Text = "Actividades Reservadas:";
            lblAct.Click += label2_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(148, 288);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(28, 23);
            lbl1.TabIndex = 8;
            lbl1.Text = "1. ";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(148, 330);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(23, 23);
            lbl2.TabIndex = 9;
            lbl2.Text = "2.";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(148, 371);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(23, 23);
            lbl3.TabIndex = 10;
            lbl3.Text = "3.";
            // 
            // lblValidez
            // 
            lblValidez.AutoSize = true;
            lblValidez.Location = new Point(94, 436);
            lblValidez.Name = "lblValidez";
            lblValidez.Size = new Size(185, 23);
            lblValidez.TabIndex = 11;
            lblValidez.Text = "Fecha de validez hasta:";
            lblValidez.Click += label7_Click;
            // 
            // FormInfoSocio
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 563);
            Controls.Add(lblValidez);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lblAct);
            Controls.Add(lblCuota);
            Controls.Add(btnOut);
            Controls.Add(btnCarnet);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDNI);
            Name = "FormInfoSocio";
            Text = "Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDNI;
        private Label lblNombre;
        private Label lblApellido;
        private Button btnCarnet;
        private Button btnOut;
        private Label lblCuota;
        private Label lblAct;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lblValidez;
    }
}