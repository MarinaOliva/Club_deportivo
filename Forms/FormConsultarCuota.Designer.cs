namespace club_deportivo.Forms
{
    partial class FormConsultarCuota
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
            lbl_instruccion = new Label();
            btnContinuar = new Button();
            txtDNI = new TextBox();
            label1 = new Label();
            txtNumeroSocio = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbl_instruccion
            // 
            lbl_instruccion.AutoSize = true;
            lbl_instruccion.Location = new Point(88, 96);
            lbl_instruccion.Name = "lbl_instruccion";
            lbl_instruccion.Size = new Size(177, 23);
            lbl_instruccion.TabIndex = 0;
            lbl_instruccion.Text = "Ingrese el n° de socio:";           
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(305, 248);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(94, 29);
            btnContinuar.TabIndex = 1;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += this.btnContinuar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(356, 187);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(199, 30);
            txtDNI.TabIndex = 2;
            //txtDNI.TextChanged += this.textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 190);
            label1.Name = "label1";
            label1.Size = new Size(226, 23);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el n° de documento:";
            //
            //label1.Click += this.label1_Click_1;
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Location = new Point(356, 93);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.Size = new Size(199, 30);
            txtNumeroSocio.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 141);
            label2.Name = "label2";
            label2.Size = new Size(20, 23);
            label2.TabIndex = 5;
            label2.Text = "ó";
            //label2.Click += this.label2_Click;
            // 
            // FormConsultarCuota
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtNumeroSocio);
            Controls.Add(label1);
            Controls.Add(txtDNI);
            Controls.Add(btnContinuar);
            Controls.Add(lbl_instruccion);
            Name = "FormConsultarCuota";
            Text = "Consultar Cuota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_instruccion;
        private Button btnContinuar;
        private TextBox txtDNI;
        private Label label1;
        private TextBox txtNumeroSocio;
        private Label label2;
    }
}