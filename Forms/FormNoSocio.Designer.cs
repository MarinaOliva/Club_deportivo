namespace club_deportivo.Forms
{
    partial class FormNoSocio
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
            btn_Asociar = new Button();
            btn_Act = new Button();
            label_dniIng = new Label();
            btnOut = new Button();
            SuspendLayout();
            // 
            // btn_Asociar
            // 
            btn_Asociar.Location = new Point(58, 236);
            btn_Asociar.Name = "btn_Asociar";
            btn_Asociar.Size = new Size(144, 85);
            btn_Asociar.TabIndex = 0;
            btn_Asociar.Text = "Asociar";
            btn_Asociar.UseVisualStyleBackColor = true;
            // 
            // btn_Act
            // 
            btn_Act.Location = new Point(279, 236);
            btn_Act.Name = "btn_Act";
            btn_Act.Size = new Size(155, 85);
            btn_Act.TabIndex = 1;
            btn_Act.Text = "Elegir Actividad Guiada";
            btn_Act.UseVisualStyleBackColor = true;
            // 
            // label_dniIng
            // 
            label_dniIng.AutoSize = true;
            label_dniIng.Location = new Point(199, 147);
            label_dniIng.Name = "label_dniIng";
            label_dniIng.Size = new Size(235, 23);
            label_dniIng.TabIndex = 2;
            label_dniIng.Text = "N° de documento ingresado: ";
            // 
            // btnOut
            // 
            btnOut.Location = new Point(503, 236);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(155, 85);
            btnOut.TabIndex = 3;
            btnOut.Text = "Salir";
            btnOut.UseVisualStyleBackColor = true;
            // 
            // FormNoSocio
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOut);
            Controls.Add(label_dniIng);
            Controls.Add(btn_Act);
            Controls.Add(btn_Asociar);
            Name = "FormNoSocio";
            Text = "No Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Asociar;
        private Button btn_Act;
        private Label label_dniIng;
        private Button btnOut;
    }
}