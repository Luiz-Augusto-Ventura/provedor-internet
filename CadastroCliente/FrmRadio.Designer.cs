namespace CadastroCliente
{
    partial class FrmRadio
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
            this.lblCodigoTorre = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCanal = new System.Windows.Forms.Label();
            this.txtCodigoTorre = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCanal = new System.Windows.Forms.TextBox();
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(73, 151);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCodigoTorre
            // 
            this.lblCodigoTorre.AutoSize = true;
            this.lblCodigoTorre.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoTorre.ForeColor = System.Drawing.Color.White;
            this.lblCodigoTorre.Location = new System.Drawing.Point(73, 183);
            this.lblCodigoTorre.Name = "lblCodigoTorre";
            this.lblCodigoTorre.Size = new System.Drawing.Size(71, 13);
            this.lblCodigoTorre.TabIndex = 2;
            this.lblCodigoTorre.Text = "Codigo Torre:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(73, 219);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.BackColor = System.Drawing.Color.Transparent;
            this.lblCanal.ForeColor = System.Drawing.Color.White;
            this.lblCanal.Location = new System.Drawing.Point(73, 256);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(37, 13);
            this.lblCanal.TabIndex = 4;
            this.lblCanal.Text = "Canal:";
            // 
            // txtCodigoTorre
            // 
            this.txtCodigoTorre.Location = new System.Drawing.Point(156, 180);
            this.txtCodigoTorre.Name = "txtCodigoTorre";
            this.txtCodigoTorre.Size = new System.Drawing.Size(199, 20);
            this.txtCodigoTorre.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(156, 216);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(199, 20);
            this.txtDescricao.TabIndex = 6;
            // 
            // txtCanal
            // 
            this.txtCanal.Location = new System.Drawing.Point(156, 253);
            this.txtCanal.Name = "txtCanal";
            this.txtCanal.Size = new System.Drawing.Size(199, 20);
            this.txtCanal.TabIndex = 7;
            // 
            // lblCabecalho
            // 
            this.lblCabecalho.AutoSize = true;
            this.lblCabecalho.BackColor = System.Drawing.Color.Transparent;
            this.lblCabecalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecalho.ForeColor = System.Drawing.Color.White;
            this.lblCabecalho.Location = new System.Drawing.Point(89, 110);
            this.lblCabecalho.Name = "lblCabecalho";
            this.lblCabecalho.Size = new System.Drawing.Size(257, 31);
            this.lblCabecalho.TabIndex = 8;
            this.lblCabecalho.Text = "Cadastro de Radio";
            // 
            // FrmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.wpid_circuit_background_in_blue_tones_23_21475074431;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 327);
            this.Controls.Add(this.lblCabecalho);
            this.Controls.Add(this.txtCanal);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigoTorre);
            this.Controls.Add(this.lblCanal);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCodigoTorre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmRadio";
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblCodigoTorre, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.lblCanal, 0);
            this.Controls.SetChildIndex(this.txtCodigoTorre, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.txtCanal, 0);
            this.Controls.SetChildIndex(this.lblCabecalho, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigoTorre;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.TextBox txtCodigoTorre;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCanal;
        private System.Windows.Forms.Label lblCabecalho;
    }
}
