namespace CadastroCliente
{
    partial class FrmExportar
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTabelas = new System.Windows.Forms.ComboBox();
            this.cmdExportar = new System.Windows.Forms.Button();
            this.ExportarArquivo = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a Tabela de Exportação";
            // 
            // cboTabelas
            // 
            this.cboTabelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTabelas.FormattingEnabled = true;
            this.cboTabelas.Location = new System.Drawing.Point(184, 177);
            this.cboTabelas.Name = "cboTabelas";
            this.cboTabelas.Size = new System.Drawing.Size(121, 21);
            this.cboTabelas.TabIndex = 1;
            // 
            // cmdExportar
            // 
            this.cmdExportar.Location = new System.Drawing.Point(184, 218);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(121, 23);
            this.cmdExportar.TabIndex = 2;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // ExportarArquivo
            // 
            this.ExportarArquivo.FileName = "Exportar um arquivo";
            this.ExportarArquivo.Filter = "Documentos de texto (*.txt)|*.txt";
            // 
            // FrmExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.wpid_circuit_background_in_blue_tones_23_2147507443;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 355);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.cboTabelas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmExportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar";
            this.Load += new System.EventHandler(this.FrmExportar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTabelas;
        private System.Windows.Forms.Button cmdExportar;
        private System.Windows.Forms.SaveFileDialog ExportarArquivo;
    }
}