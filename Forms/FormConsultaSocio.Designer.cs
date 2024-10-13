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
            tipo_doc = new ComboBox();
            SuspendLayout();
            // 
            // numero
            // 
            numero.Location = new Point(388, 204);
            numero.Name = "numero";
            numero.Size = new Size(198, 30);
            numero.TabIndex = 0;
            //numero.TextChanged += this.textBox1_TextChanged;
            // 
            // Consulta
            // 
            Consulta.Location = new Point(313, 302);
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
            // tipo_doc
            // 
            tipo_doc.DropDownStyle = ComboBoxStyle.DropDownList;
            tipo_doc.FormattingEnabled = true;
            tipo_doc.Items.AddRange(new object[] { "DNI", "Cédula de Indentidad", "Pasaporte" });
            tipo_doc.Location = new Point(180, 203);
            tipo_doc.Name = "tipo_doc";
            tipo_doc.Size = new Size(151, 31);
            tipo_doc.TabIndex = 3;
            // 
            // FormConsultaSocio
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tipo_doc);
            Controls.Add(label1);
            Controls.Add(Consulta);
            Controls.Add(numero);
            Name = "FormConsultaSocio";
            Text = "Consulta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numero;
        private Button Consulta;
        private Label label1;
        private ComboBox tipo_doc;
    }
}