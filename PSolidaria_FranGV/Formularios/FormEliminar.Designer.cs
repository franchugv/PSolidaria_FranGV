namespace PSolidaria_FranGV.Formularios
{
    partial class FormEliminar
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelListaParticipantes = new System.Windows.Forms.Label();
            this.comboBoxListaParticipantes = new System.Windows.Forms.ComboBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(23, 114);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(338, 23);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Eliminar participante";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelListaParticipantes
            // 
            this.labelListaParticipantes.AutoSize = true;
            this.labelListaParticipantes.Location = new System.Drawing.Point(20, 68);
            this.labelListaParticipantes.Name = "labelListaParticipantes";
            this.labelListaParticipantes.Size = new System.Drawing.Size(96, 13);
            this.labelListaParticipantes.TabIndex = 19;
            this.labelListaParticipantes.Text = "Lista Participantes:";
            // 
            // comboBoxListaParticipantes
            // 
            this.comboBoxListaParticipantes.FormattingEnabled = true;
            this.comboBoxListaParticipantes.Location = new System.Drawing.Point(122, 68);
            this.comboBoxListaParticipantes.Name = "comboBoxListaParticipantes";
            this.comboBoxListaParticipantes.Size = new System.Drawing.Size(228, 21);
            this.comboBoxListaParticipantes.TabIndex = 17;
            this.comboBoxListaParticipantes.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaParticipantes_SelectedIndexChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(92, 26);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(102, 52);
            this.labelTitulo.TabIndex = 16;
            this.labelTitulo.Text = "Eliminar Participante\r\n**********************\r\n\r\n\r\n";
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 159);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelListaParticipantes);
            this.Controls.Add(this.comboBoxListaParticipantes);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormEliminar";
            this.Text = "FormEliminar";
            this.Load += new System.EventHandler(this.FormEliminar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelListaParticipantes;
        private System.Windows.Forms.ComboBox comboBoxListaParticipantes;
        private System.Windows.Forms.Label labelTitulo;
    }
}