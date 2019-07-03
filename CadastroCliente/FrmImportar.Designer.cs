namespace CadastroCliente
{
    partial class FrmImportar
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
            this.cmdImportar = new System.Windows.Forms.Button();
            this.ImportarArquivo = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(84, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a Tabela de Importação";
            // 
            // cboTabelas
            // 
            this.cboTabelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTabelas.FormattingEnabled = true;
            this.cboTabelas.Location = new System.Drawing.Point(253, 200);
            this.cboTabelas.Name = "cboTabelas";
            this.cboTabelas.Size = new System.Drawing.Size(134, 21);
            this.cboTabelas.TabIndex = 1;
            // 
            // cmdImportar
            // 
            this.cmdImportar.Location = new System.Drawing.Point(253, 240);
            this.cmdImportar.Name = "cmdImportar";
            this.cmdImportar.Size = new System.Drawing.Size(134, 23);
            this.cmdImportar.TabIndex = 2;
            this.cmdImportar.Text = "Importar";
            this.cmdImportar.UseVisualStyleBackColor = true;
            this.cmdImportar.Click += new System.EventHandler(this.cmdImportar_Click);
            // 
            // ImportarArquivo
            // 
            this.ImportarArquivo.FileName = "Importar arquivo";
            this.ImportarArquivo.Filter = "Documentos de texto (*.txt)|*.txt";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(157, 289);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(334, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // FrmImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.wpid_circuit_background_in_blue_tones_23_2147507443;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 444);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cmdImportar);
            this.Controls.Add(this.cboTabelas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmImportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar";
            this.Load += new System.EventHandler(this.FrmImportar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTabelas;
        private System.Windows.Forms.Button cmdImportar;
        private System.Windows.Forms.OpenFileDialog ImportarArquivo;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}