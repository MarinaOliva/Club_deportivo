namespace club_deportivo.Forms
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
            lblValidez = new Label();
            lblTipoDoc = new Label();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(297, 42);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(153, 23);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "N° Doc ingresado: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(47, 88);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 23);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre: ";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(47, 136);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(81, 23);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido: ";
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = SystemColors.ButtonHighlight;
            btnCarnet.FlatStyle = FlatStyle.Flat;
            btnCarnet.Location = new Point(145, 471);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(136, 63);
            btnCarnet.TabIndex = 3;
            btnCarnet.Text = "Ver Carnet";
            btnCarnet.UseVisualStyleBackColor = false;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // btnOut
            // 
            btnOut.BackColor = SystemColors.ButtonHighlight;
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.Location = new Point(340, 471);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(124, 63);
            btnOut.TabIndex = 4;
            btnOut.Text = "Salir";
            btnOut.UseVisualStyleBackColor = false;
            // 
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Location = new Point(47, 190);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new Size(60, 23);
            lblCuota.TabIndex = 5;
            lblCuota.Text = "Cuota:";
            // 
            // lblAct
            // 
            lblAct.AutoSize = true;
            lblAct.Location = new Point(47, 248);
            lblAct.Name = "lblAct";
            lblAct.Size = new Size(189, 23);
            lblAct.TabIndex = 6;
            lblAct.Text = "Actividades Reservadas:";
            lblAct.Click += label2_Click;
            // 
            // lblValidez
            // 
            lblValidez.AutoSize = true;
            lblValidez.Location = new Point(47, 389);
            lblValidez.Name = "lblValidez";
            lblValidez.Size = new Size(185, 23);
            lblValidez.TabIndex = 11;
            lblValidez.Text = "Fecha de validez hasta:";
            lblValidez.Click += label7_Click;
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(47, 42);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(109, 23);
            lblTipoDoc.TabIndex = 12;
            lblTipoDoc.Text = "Tipo de doc: ";
            // 
            // FormInfoSocio
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 557);
            Controls.Add(lblTipoDoc);
            Controls.Add(lblValidez);
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
        private Label lblValidez;
        private Label lblTipoDoc;
    }
}