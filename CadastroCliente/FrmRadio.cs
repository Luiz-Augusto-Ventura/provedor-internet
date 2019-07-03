using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class FrmRadio : CadastroCliente.FrmBase
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        Radio r = new Radio();

        public override void cmdNovo_Click(object sender, EventArgs e)
        {
 	        base.cmdNovo_Click(sender, e);
        }

        public override void cmdSalvar_Click(object sender, EventArgs e)
        {
            r.Codigotorre = int.Parse(txtCodigoTorre.Text);
            r.Descricao = txtDescricao.Text;
            r.Canal = txtCanal.Text;
            Cod = r.Codigo;
            Objeto = r;
 	        base.cmdSalvar_Click(sender, e);
        }

        public override void cmdExcluir_Click(object sender, EventArgs e)
        {
            Cod = r.Codigo;
            Objeto = r;
 	        base.cmdExcluir_Click(sender, e);
        }

        public override void cmdLocalizar_Click(object sender, EventArgs e)
        {
            base.cmdLocalizar_Click(sender, e);
            r.Tabela = "Radios";
            FrmLocalizar FPM = new FrmLocalizar(r);
            if (FPM.ShowDialog() == DialogResult.OK)
            {
                r.Codigo = FPM.Cod;

                string[] aux = FPM.Pesquisa.Split(new char[] { ',' });
                r.Codigotorre = int.Parse(aux[0]);
                r.Descricao = aux[1];
                r.Canal = aux[2];

                lblCodigo.Text += ": " + FPM.Cod.ToString();
                txtCodigoTorre.Text = aux[0];
                txtDescricao.Text = aux[1];
                txtCanal.Text = aux[2];
            }
            else base.fecharLocalizar();
        }
    }
}
