namespace CadastroCliente
{
    partial class FrmLocalizar
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
            this.lblTextoDigitar = new System.Windows.Forms.Label();
            this.txtTextoDigitado = new System.Windows.Forms.TextBox();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextoDigitar
            // 
            this.lblTextoDigitar.AutoSize = true;
            this.lblTextoDigitar.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoDigitar.ForeColor = System.Drawing.Color.White;
            this.lblTextoDigitar.Location = new System.Drawing.Point(42, 135);
            this.lblTextoDigitar.Name = "lblTextoDigitar";
            this.lblTextoDigitar.Size = new System.Drawing.Size(100, 13);
            this.lblTextoDigitar.TabIndex = 0;
            this.lblTextoDigitar.Text = "Insira sua pesquisa:";
            // 
            // txtTextoDigitado
            // 
            this.txtTextoDigitado.Location = new System.Drawing.Point(148, 132);
            this.txtTextoDigitado.Name = "txtTextoDigitado";
            this.txtTextoDigitado.Size = new System.Drawing.Size(181, 20);
            this.txtTextoDigitado.TabIndex = 1;
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(345, 130);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(75, 23);
            this.cmdPesquisar.TabIndex = 2;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.UseVisualStyleBackColor = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(445, 245);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(44, 23);
            this.cmdOk.TabIndex = 3;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 168);
            this.dataGridView1.TabIndex = 4;
            // 
            // FrmLocalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.wpid_circuit_background_in_blue_tones_23_2147507443__1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.txtTextoDigitado);
            this.Controls.Add(this.lblTextoDigitar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmLocalizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar";
            this.Load += new System.EventHandler(this.FrmLocalizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoDigitar;
        private System.Windows.Forms.TextBox txtTextoDigitado;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}