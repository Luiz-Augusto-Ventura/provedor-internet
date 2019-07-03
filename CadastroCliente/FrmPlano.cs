using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class FrmPlano : CadastroCliente.FrmBase
    {
        public FrmPlano()
        {
            InitializeComponent();
        }

        Plano p = new Plano();

        public override void cmdNovo_Click(object sender, EventArgs e)
        {
            base.cmdNovo_Click(sender, e);
        }

        public override void cmdSalvar_Click(object sender, EventArgs e)
        {
            p.Valor = float.Parse(txtValor.Text);
            p.Descricao = txtDescricao.Text;
            p.Download = txtTaxaDownload.Text;
            p.Upload = txtTaxaUpload.Text;
            Cod = p.Codigo;
            Objeto = p;
            base.cmdSalvar_Click(sender, e);
        }

        public override void cmdExcluir_Click(object sender, EventArgs e)
        {
            Cod = p.Codigo;
            Objeto = p;
            base.cmdExcluir_Click(sender, e);
        }

        public override void cmdLocalizar_Click(object sender, EventArgs e)
        {
            base.cmdLocalizar_Click(sender, e);
            p.Tabela = "Radio";
            FrmLocalizar FPM = new FrmLocalizar(p);
            if (FPM.ShowDialog() == DialogResult.OK)
            {
                p.Codigo = FPM.Cod;

                string[] aux = FPM.Pesquisa.Split(new char[] { ',' });
                p.Valor = float.Parse(aux[0]);
                p.Download = aux[1];
                p.Upload = aux[2];
                p.Descricao = aux[3];

                lblCodigo.Text += ": " + FPM.Cod.ToString();
                txtValor.Text = aux[0].Replace('.',',');
                txtTaxaDownload.Text = aux[1];
                txtTaxaUpload.Text = aux[2];
                txtDescricao.Text = aux[3];
            }
            else base.fecharLocalizar();
        }
    }
}
