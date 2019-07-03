using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class FrmCliente : CadastroCliente.FrmBase
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        Cliente c = new Cliente();

        public override void cmdNovo_Click(object sender, EventArgs e)
        {
            base.cmdNovo_Click(sender, e);
        }

        public override void cmdSalvar_Click(object sender, EventArgs e)
        {
            c.Nome = txtNome.Text;
            c.Cpf = txtCPF.Text;
            c.Rua = txtRua.Text;
            c.Numero = int.Parse(txtNumeroCasa.Text);
            c.Bairro = txtBairro.Text;
            c.Telefone = txtTelefone.Text;
            c.Usuario = txtUsuario.Text;
            c.Mac = txtMAC.Text;
            c.Codigoplano = int.Parse(txtCodigoPlano.Text);
            c.Codigoradio = int.Parse(txtCodigoRadio.Text);
            Cod = c.Codigo;
            Objeto = c;
            base.cmdSalvar_Click(sender, e);
        }

        public override void cmdExcluir_Click(object sender, EventArgs e)
        {
            Cod = c.Codigo;
            Objeto = c;
            base.cmdExcluir_Click(sender, e);
        }

        public override void cmdLocalizar_Click(object sender, EventArgs e)
        {
            base.cmdLocalizar_Click(sender, e);
            c.Tabela = "Clientes";
            FrmLocalizar FPM = new FrmLocalizar(c);
            if (FPM.ShowDialog() == DialogResult.OK)
            {
                c.Codigo = FPM.Cod;

                string[] aux = FPM.Pesquisa.Split(new char[] { ',' });
                c.Nome = aux[0];
                c.Rua = aux[1];
                c.Numero = int.Parse(aux[2]);
                c.Bairro = aux[3];
                c.Cpf=aux[4];
                c.Telefone = aux[5];
                c.Usuario = aux[6];
                c.Mac = aux[7];
                c.Codigoplano = int.Parse(aux[8]);
                c.Codigoradio = int.Parse(aux[9]);
               
                lblCodigo.Text += ": " + FPM.Cod.ToString();
                txtNome.Text = aux[0];
                txtRua.Text = aux[1];
                txtNumeroCasa.Text = aux[2];
                txtBairro.Text = aux[3];
                txtCPF.Text = aux[4];
                txtTelefone.Text = aux[5];
                txtUsuario.Text = aux[6];
                txtMAC.Text=aux[7];
                txtCodigoPlano.Text = aux[8];
                txtCodigoRadio.Text = aux[9];
            }
            else base.fecharLocalizar();
        }
    }
}
