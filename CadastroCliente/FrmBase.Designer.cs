namespace CadastroCliente
{
    partial class FrmBase
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdNovo = new System.Windows.Forms.ToolStripButton();
            this.cmdSalvar = new System.Windows.Forms.ToolStripButton();
            this.cmdExcluir = new System.Windows.Forms.ToolStripButton();
            this.cmdLocalizar = new System.Windows.Forms.ToolStripButton();
            this.cmdFechar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNovo,
            this.cmdSalvar,
            this.cmdExcluir,
            this.cmdLocalizar,
            this.cmdFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(528, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdNovo
            // 
            this.cmdNovo.Image = global::CadastroCliente.Properties.Resources.buttonnew;
            this.cmdNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(56, 22);
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Image = global::CadastroCliente.Properties.Resources.buttonsave;
            this.cmdSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(58, 22);
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Image = global::CadastroCliente.Properties.Resources.buttondelete;
            this.cmdExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(61, 22);
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdLocalizar
            // 
            this.cmdLocalizar.Image = global::CadastroCliente.Properties.Resources.buttonsearch;
            this.cmdLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdLocalizar.Name = "cmdLocalizar";
            this.cmdLocalizar.Size = new System.Drawing.Size(73, 22);
            this.cmdLocalizar.Text = "Localizar";
            this.cmdLocalizar.Click += new System.EventHandler(this.cmdLocalizar_Click);
            // 
            // cmdFechar
            // 
            this.cmdFechar.Image = global::CadastroCliente.Properties.Resources.buttonexit;
            this.cmdFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(62, 22);
            this.cmdFechar.Text = "Fechar";
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.wpid_circuit_background_in_blue_tones_23_21475074431;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 303);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navegação";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdNovo;
        private System.Windows.Forms.ToolStripButton cmdSalvar;
        private System.Windows.Forms.ToolStripButton cmdExcluir;
        private System.Windows.Forms.ToolStripButton cmdLocalizar;
        private System.Windows.Forms.ToolStripButton cmdFechar;
    }
}