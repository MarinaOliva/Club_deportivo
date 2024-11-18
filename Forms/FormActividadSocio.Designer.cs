namespace club_deportivo.Forms
{
    partial class FormActividadSocio
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
            lblNumSocio = new Label();
            chkAikido = new CheckBox();
            btnInscribir = new Button();
            txtNumSocio = new TextBox();
            lblListaAct = new Label();
            chkAcrobacia = new CheckBox();
            chkZumba = new CheckBox();
            chkPilates = new CheckBox();
            chkYoga = new CheckBox();
            btnOut = new Button();
            btnConsultar = new Button();
            lblSocioInsc = new Label();
            SuspendLayout();
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Location = new Point(82, 44);
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(177, 23);
            lblNumSocio.TabIndex = 0;
            lblNumSocio.Text = "Ingrese el n° de socio:";
            // 
            // chkAikido
            // 
            chkAikido.AutoSize = true;
            chkAikido.Location = new Point(82, 314);
            chkAikido.Name = "chkAikido";
            chkAikido.Size = new Size(79, 27);
            chkAikido.TabIndex = 1;
            chkAikido.Text = "Aikido";
            chkAikido.UseVisualStyleBackColor = true;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = SystemColors.ButtonHighlight;
            btnInscribir.FlatStyle = FlatStyle.Flat;
            btnInscribir.Location = new Point(224, 449);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(125, 47);
            btnInscribir.TabIndex = 2;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // txtNumSocio
            // 
            txtNumSocio.Location = new Point(295, 44);
            txtNumSocio.Name = "txtNumSocio";
            txtNumSocio.Size = new Size(125, 30);
            txtNumSocio.TabIndex = 12;
            // 
            // lblListaAct
            // 
            lblListaAct.AutoSize = true;
            lblListaAct.Location = new Point(76, 251);
            lblListaAct.Name = "lblListaAct";
            lblListaAct.Size = new Size(248, 23);
            lblListaAct.TabIndex = 13;
            lblListaAct.Text = "Seleccione hasta 3 actividades: ";
            // 
            // chkAcrobacia
            // 
            chkAcrobacia.AutoSize = true;
            chkAcrobacia.Location = new Point(82, 380);
            chkAcrobacia.Name = "chkAcrobacia";
            chkAcrobacia.Size = new Size(164, 27);
            chkAcrobacia.TabIndex = 14;
            chkAcrobacia.Text = "Acrobacia en tela";
            chkAcrobacia.UseVisualStyleBackColor = true;
            // 
            // chkZumba
            // 
            chkZumba.AutoSize = true;
            chkZumba.Location = new Point(536, 314);
            chkZumba.Name = "chkZumba";
            chkZumba.Size = new Size(86, 27);
            chkZumba.TabIndex = 15;
            chkZumba.Text = "Zumba";
            chkZumba.UseVisualStyleBackColor = true;
            // 
            // chkPilates
            // 
            chkPilates.AutoSize = true;
            chkPilates.Location = new Point(339, 314);
            chkPilates.Name = "chkPilates";
            chkPilates.Size = new Size(81, 27);
            chkPilates.TabIndex = 16;
            chkPilates.Text = "Pilates";
            chkPilates.UseVisualStyleBackColor = true;
            // 
            // chkYoga
            // 
            chkYoga.AutoSize = true;
            chkYoga.Location = new Point(339, 380);
            chkYoga.Name = "chkYoga";
            chkYoga.Size = new Size(69, 27);
            chkYoga.TabIndex = 17;
            chkYoga.Text = "Yoga";
            chkYoga.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            btnOut.BackColor = SystemColors.ButtonHighlight;
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.Location = new Point(502, 449);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(110, 47);
            btnOut.TabIndex = 18;
            btnOut.Text = "Cancelar";
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = SystemColors.ButtonHighlight;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Location = new Point(502, 38);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(110, 35);
            btnConsultar.TabIndex = 19;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblSocioInsc
            // 
            lblSocioInsc.AutoSize = true;
            lblSocioInsc.Location = new Point(82, 124);
            lblSocioInsc.Name = "lblSocioInsc";
            lblSocioInsc.Size = new Size(22, 23);
            lblSocioInsc.TabIndex = 20;
            lblSocioInsc.Text = "- ";
            lblSocioInsc.Click += label1_Click;
            // 
            // FormActividadSocio
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 522);
            Controls.Add(lblSocioInsc);
            Controls.Add(btnConsultar);
            Controls.Add(btnOut);
            Controls.Add(chkYoga);
            Controls.Add(chkPilates);
            Controls.Add(chkZumba);
            Controls.Add(chkAcrobacia);
            Controls.Add(lblListaAct);
            Controls.Add(txtNumSocio);
            Controls.Add(btnInscribir);
            Controls.Add(chkAikido);
            Controls.Add(lblNumSocio);
            Name = "FormActividadSocio";
            Text = "Inscripción a actividades guiadas (socios)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumSocio;
        private CheckBox chkAikido;
        private Button btnInscribir;
        private TextBox txtNumSocio;
        private Label lblListaAct;
        private CheckBox chkAcrobacia;
        private CheckBox chkZumba;
        private CheckBox chkPilates;
        private CheckBox chkYoga;
        private Button btnOut;
        private Button btnConsultar;
        private Label lblSocioInsc;
    }
}