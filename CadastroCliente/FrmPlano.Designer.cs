namespace CadastroCliente
{
    partial class FrmPlano
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTaxaDownload = new System.Windows.Forms.Label();
            this.lblTaxaUpload = new System.Windows.Forms.Label();
            this.txtTaxaUpload = new System.Windows.Forms.TextBox();
            this.txtTaxaDownload = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(69, 171);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código: ";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(69, 204);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(69, 238);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblTaxaDownload
            // 
            this.lblTaxaDownload.AutoSize = true;
            this.lblTaxaDownload.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxaDownload.ForeColor = System.Drawing.Color.White;
            this.lblTaxaDownload.Location = new System.Drawing.Point(69, 273);
            this.lblTaxaDownload.Name = "lblTaxaDownload";
            this.lblTaxaDownload.Size = new System.Drawing.Size(85, 13);
            this.lblTaxaDownload.TabIndex = 4;
            this.lblTaxaDownload.Text = "Taxa Download:";
            // 
            // lblTaxaUpload
            // 
            this.lblTaxaUpload.AutoSize = true;
            this.lblTaxaUpload.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxaUpload.ForeColor = System.Drawing.Color.White;
            this.lblTaxaUpload.Location = new System.Drawing.Point(69, 309);
            this.lblTaxaUpload.Name = "lblTaxaUpload";
            this.lblTaxaUpload.Size = new System.Drawing.Size(71, 13);
            this.lblTaxaUpload.TabIndex = 5;
            this.lblTaxaUpload.Text = "Taxa Upload:";
            // 
            // txtTaxaUpload
            // 
            this.txtTaxaUpload.Location = new System.Drawing.Point(164, 306);
            this.txtTaxaUpload.Name = "txtTaxaUpload";
            this.txtTaxaUpload.Size = new System.Drawing.Size(193, 20);
            this.txtTaxaUpload.TabIndex = 6;
            // 
            // txtTaxaDownload
            // 
            this.txtTaxaDownload.Location = new System.Drawing.Point(164, 270);
            this.txtTaxaDownload.Name = "txtTaxaDownload";
            this.txtTaxaDownload.Size = new System.Drawing.Size(193, 20);
            this.txtTaxaDownload.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(164, 235);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(193, 20);
            this.txtDescricao.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(164, 201);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(193, 20);
            this.txtValor.TabIndex = 9;
            // 
            // lblCabecalho
            // 
            this.lblCabecalho.AutoSize = true;
            this.lblCabecalho.BackColor = System.Drawing.Color.Transparent;
            this.lblCabecalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecalho.ForeColor = System.Drawing.Color.White;
            this.lblCabecalho.Location = new System.Drawing.Point(93, 130);
            this.lblCabecalho.Name = "lblCabecalho";
            this.lblCabecalho.Size = new System.Drawing.Size(255, 31);
            this.lblCabecalho.TabIndex = 10;
            this.lblCabecalho.Text = "Cadastro de Plano";
            // 
            // FrmPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.wpid_circuit_background_in_blue_tones_23_21475074431;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 386);
            this.Controls.Add(this.lblCabecalho);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTaxaDownload);
            this.Controls.Add(this.txtTaxaUpload);
            this.Controls.Add(this.lblTaxaUpload);
            this.Controls.Add(this.lblTaxaDownload);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmPlano";
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblValor, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.lblTaxaDownload, 0);
            this.Controls.SetChildIndex(this.lblTaxaUpload, 0);
            this.Controls.SetChildIndex(this.txtTaxaUpload, 0);
            this.Controls.SetChildIndex(this.txtTaxaDownload, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.Controls.SetChildIndex(this.lblCabecalho, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTaxaDownload;
        private System.Windows.Forms.Label lblTaxaUpload;
        private System.Windows.Forms.TextBox txtTaxaUpload;
        private System.Windows.Forms.TextBox txtTaxaDownload;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblCabecalho;
    }
}
