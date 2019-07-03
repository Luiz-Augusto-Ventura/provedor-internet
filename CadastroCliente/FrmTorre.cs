using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class FrmTorre : CadastroCliente.FrmBase
    {
        public FrmTorre()
        {
            InitializeComponent();
        }

        Torre t = new Torre();

        public override void cmdNovo_Click(object sender, EventArgs e)
        {
 	         base.cmdNovo_Click(sender, e);
        }

        public override void cmdSalvar_Click(object sender, EventArgs e)
        {
            t.Descricao = txtDescricao.Text;
            Cod = t.Codigo;
            Objeto = t;
            base.cmdSalvar_Click(sender, e);
        }

        public override void cmdExcluir_Click(object sender, EventArgs e)
        {
            Cod = t.Codigo;
            Objeto = t;
            base.cmdExcluir_Click(sender, e);
        }

        public override void cmdLocalizar_Click(object sender, EventArgs e)
        {
            base.cmdLocalizar_Click(sender, e);
            t.Tabela = "Torre";
            FrmLocalizar FPM = new FrmLocalizar(t);
            if (FPM.ShowDialog() == DialogResult.OK)
            {
                txtDescricao.Text = FPM.Pesquisa;
                lblCodigo.Text += ": " + FPM.Cod.ToString();
                t.Codigo = FPM.Cod;
                t.Descricao = FPM.Pesquisa;
            }
            else base.fecharLocalizar();
        }
    }
}
