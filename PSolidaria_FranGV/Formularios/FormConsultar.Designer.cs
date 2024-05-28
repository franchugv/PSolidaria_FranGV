namespace PSolidaria_FranGV.Formularios
{
    partial class FormConsultar
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
            this.listBoxListaParticipantes = new System.Windows.Forms.ListBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxEdadMedia = new System.Windows.Forms.TextBox();
            this.labelMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxListaParticipantes
            // 
            this.listBoxListaParticipantes.FormattingEnabled = true;
            this.listBoxListaParticipantes.Location = new System.Drawing.Point(40, 69);
            this.listBoxListaParticipantes.Name = "listBoxListaParticipantes";
            this.listBoxListaParticipantes.Size = new System.Drawing.Size(341, 160);
            this.listBoxListaParticipantes.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(174, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(55, 26);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Consultas\r\n************\r\n";
            // 
            // textBoxEdadMedia
            // 
            this.textBoxEdadMedia.Enabled = false;
            this.textBoxEdadMedia.Location = new System.Drawing.Point(110, 245);
            this.textBoxEdadMedia.Name = "textBoxEdadMedia";
            this.textBoxEdadMedia.Size = new System.Drawing.Size(61, 20);
            this.textBoxEdadMedia.TabIndex = 2;
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Location = new System.Drawing.Point(37, 248);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(67, 13);
            this.labelMedia.TabIndex = 3;
            this.labelMedia.Text = "Edad Media:";
            // 
            // FormConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 298);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.textBoxEdadMedia);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.listBoxListaParticipantes);
            this.Name = "FormConsultar";
            this.Text = "FormConsultar";
            this.Load += new System.EventHandler(this.FormConsultar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListaParticipantes;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxEdadMedia;
        private System.Windows.Forms.Label labelMedia;
    }
}