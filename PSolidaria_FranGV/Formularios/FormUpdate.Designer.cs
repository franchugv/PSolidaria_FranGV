namespace PSolidaria_FranGV.Formularios
{
    partial class FormUpdate
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.comboBoxListaParticipantes = new System.Windows.Forms.ComboBox();
            this.textBoxTiempoAnterior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTiempoAntiguo = new System.Windows.Forms.Label();
            this.labelNMinutos = new System.Windows.Forms.Label();
            this.textBoxNewMin = new System.Windows.Forms.TextBox();
            this.textBoxNewSegundos = new System.Windows.Forms.TextBox();
            this.labelNSegundos = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(85, 28);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(141, 39);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Agregar Tiempo Participante\r\n*******************************\r\n\r\n";
            // 
            // comboBoxListaParticipantes
            // 
            this.comboBoxListaParticipantes.FormattingEnabled = true;
            this.comboBoxListaParticipantes.Location = new System.Drawing.Point(115, 70);
            this.comboBoxListaParticipantes.Name = "comboBoxListaParticipantes";
            this.comboBoxListaParticipantes.Size = new System.Drawing.Size(228, 21);
            this.comboBoxListaParticipantes.TabIndex = 6;
            this.comboBoxListaParticipantes.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaParticipantes_SelectedIndexChanged);
            // 
            // textBoxTiempoAnterior
            // 
            this.textBoxTiempoAnterior.Enabled = false;
            this.textBoxTiempoAnterior.Location = new System.Drawing.Point(115, 106);
            this.textBoxTiempoAnterior.Name = "textBoxTiempoAnterior";
            this.textBoxTiempoAnterior.Size = new System.Drawing.Size(82, 20);
            this.textBoxTiempoAnterior.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista Participantes:";
            // 
            // labelTiempoAntiguo
            // 
            this.labelTiempoAntiguo.AutoSize = true;
            this.labelTiempoAntiguo.Location = new System.Drawing.Point(25, 109);
            this.labelTiempoAntiguo.Name = "labelTiempoAntiguo";
            this.labelTiempoAntiguo.Size = new System.Drawing.Size(84, 13);
            this.labelTiempoAntiguo.TabIndex = 10;
            this.labelTiempoAntiguo.Text = "Tiempo Anterior:";
            // 
            // labelNMinutos
            // 
            this.labelNMinutos.AutoSize = true;
            this.labelNMinutos.Location = new System.Drawing.Point(13, 142);
            this.labelNMinutos.Name = "labelNMinutos";
            this.labelNMinutos.Size = new System.Drawing.Size(87, 13);
            this.labelNMinutos.TabIndex = 11;
            this.labelNMinutos.Text = "Nuevos Minutos:";
            // 
            // textBoxNewMin
            // 
            this.textBoxNewMin.Enabled = false;
            this.textBoxNewMin.Location = new System.Drawing.Point(115, 139);
            this.textBoxNewMin.Name = "textBoxNewMin";
            this.textBoxNewMin.Size = new System.Drawing.Size(82, 20);
            this.textBoxNewMin.TabIndex = 12;
            // 
            // textBoxNewSegundos
            // 
            this.textBoxNewSegundos.Enabled = false;
            this.textBoxNewSegundos.Location = new System.Drawing.Point(115, 176);
            this.textBoxNewSegundos.Name = "textBoxNewSegundos";
            this.textBoxNewSegundos.Size = new System.Drawing.Size(82, 20);
            this.textBoxNewSegundos.TabIndex = 14;
            // 
            // labelNSegundos
            // 
            this.labelNSegundos.AutoSize = true;
            this.labelNSegundos.Location = new System.Drawing.Point(2, 179);
            this.labelNSegundos.Name = "labelNSegundos";
            this.labelNSegundos.Size = new System.Drawing.Size(98, 13);
            this.labelNSegundos.TabIndex = 13;
            this.labelNSegundos.Text = "Nuevos Segundos:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(28, 221);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(338, 23);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Actualizar Tiempos";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 267);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxNewSegundos);
            this.Controls.Add(this.labelNSegundos);
            this.Controls.Add(this.textBoxNewMin);
            this.Controls.Add(this.labelNMinutos);
            this.Controls.Add(this.labelTiempoAntiguo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTiempoAnterior);
            this.Controls.Add(this.comboBoxListaParticipantes);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormUpdate";
            this.Text = "FormAgregarTiempo";
            this.Load += new System.EventHandler(this.FormUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ComboBox comboBoxListaParticipantes;
        private System.Windows.Forms.TextBox textBoxTiempoAnterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTiempoAntiguo;
        private System.Windows.Forms.Label labelNMinutos;
        private System.Windows.Forms.TextBox textBoxNewMin;
        private System.Windows.Forms.TextBox textBoxNewSegundos;
        private System.Windows.Forms.Label labelNSegundos;
        private System.Windows.Forms.Button buttonUpdate;
    }
}