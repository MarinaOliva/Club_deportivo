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
            label_dniIng = new Label();
            label_nombre = new Label();
            label_apellido = new Label();
            button_carnet = new Button();
            button_out = new Button();
            SuspendLayout();
            // 
            // label_dniIng
            // 
            label_dniIng.AutoSize = true;
            label_dniIng.Location = new Point(93, 125);
            label_dniIng.Name = "label_dniIng";
            label_dniIng.Size = new Size(153, 23);
            label_dniIng.TabIndex = 0;
            label_dniIng.Text = "N° Doc ingresado: ";
            // 
            // label_nombre
            // 
            label_nombre.AutoSize = true;
            label_nombre.Location = new Point(93, 190);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(82, 23);
            label_nombre.TabIndex = 1;
            label_nombre.Text = "Nombre: ";
            // 
            // label_apellido
            // 
            label_apellido.AutoSize = true;
            label_apellido.Location = new Point(94, 252);
            label_apellido.Name = "label_apellido";
            label_apellido.Size = new Size(81, 23);
            label_apellido.TabIndex = 2;
            label_apellido.Text = "Apellido: ";
            // 
            // button_carnet
            // 
            button_carnet.Location = new Point(136, 356);
            button_carnet.Name = "button_carnet";
            button_carnet.Size = new Size(119, 46);
            button_carnet.TabIndex = 3;
            button_carnet.Text = "Ver Carnet";
            button_carnet.UseVisualStyleBackColor = true;
            // 
            // button_out
            // 
            button_out.Location = new Point(500, 356);
            button_out.Name = "button_out";
            button_out.Size = new Size(103, 46);
            button_out.TabIndex = 4;
            button_out.Text = "Salir";
            button_out.UseVisualStyleBackColor = true;
            // 
            // FormInfoSocio
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_out);
            Controls.Add(button_carnet);
            Controls.Add(label_apellido);
            Controls.Add(label_nombre);
            Controls.Add(label_dniIng);
            Name = "FormInfoSocio";
            Text = "Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_dniIng;
        private Label label_nombre;
        private Label label_apellido;
        private Button button_carnet;
        private Button button_out;
    }
}