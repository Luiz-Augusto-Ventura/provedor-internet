using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CadastroCliente
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private Conexao objeto;
        private int cod;

        public Conexao Objeto
        {
            get { return objeto; }
            set { objeto = value; }
        }

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public enum statusCadastro
        {
            scInserindo,
            scNavegando,
            scEditando
        }

        private statusCadastro sStatus;

        private void HabilitaDesabilitaControles(bool bValue)
        {
            //percorre os controles da tela e os habilita ou desabilita
            foreach (Control ctr in this.Controls)
            {
                if (ctr is ToolStrip)
                    continue;
                ctr.Enabled = bValue;
            }
            //habilitar os botoes

            //Novo sera habilitado somente quando for navegacao
            cmdNovo.Enabled = (sStatus == statusCadastro.scNavegando);
            //Salvar
            cmdSalvar.Enabled = (sStatus == statusCadastro.scEditando || sStatus == statusCadastro.scInserindo);
            //Excluir
            cmdExcluir.Enabled = (sStatus == statusCadastro.scEditando);
            //Localizar
            cmdLocalizar.Enabled = (sStatus == statusCadastro.scNavegando || sStatus == statusCadastro.scEditando || sStatus == statusCadastro.scInserindo);
            //fechar
            cmdFechar.Enabled = true;
        }

        private void LimpaControles()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    (ctr as TextBox).Text = "";
                if (ctr is ComboBox)
                    (ctr as ComboBox).DataSource = null;
                if (ctr is Label && ctr.Name == "lblCodigo")
                    (ctr as Label).Text = "Código";
            }
        }

        virtual public void cmdNovo_Click(object sender, EventArgs e)
        {
            sStatus = statusCadastro.scInserindo;
            HabilitaDesabilitaControles(true);
            LimpaControles();
        }

        virtual public void cmdSalvar_Click(object sender, EventArgs e)
        {
            if (sStatus == statusCadastro.scInserindo)
            {
                objeto.Incluir();
            }
            else if (sStatus == statusCadastro.scEditando)
            {
                objeto.Alterar(Cod);
            }
            if (objeto.Status)
            {
                sStatus = statusCadastro.scNavegando;
                LimpaControles();
                HabilitaDesabilitaControles(false);
                MessageBox.Show("Registro salvo com sucesso", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Registro não foi salvo, por favor verifique os erros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fecharLocalizar()
        {
            sStatus = statusCadastro.scNavegando;
            HabilitaDesabilitaControles(false);
            LimpaControles();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            sStatus = statusCadastro.scNavegando;
            HabilitaDesabilitaControles(false);
            LimpaControles();
        }

        virtual public void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public virtual void cmdLocalizar_Click(object sender, EventArgs e)
        {
            sStatus = statusCadastro.scEditando;
            HabilitaDesabilitaControles(true);
        }

        public virtual void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (sStatus == statusCadastro.scEditando)
            {
                objeto.Excluir(Cod);
            }
            if (objeto.Status)
            {
                sStatus = statusCadastro.scNavegando;
                LimpaControles();
                HabilitaDesabilitaControles(false);
                MessageBox.Show("Registro excluido com sucesso", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O registro não foi excluido, por favor verifique os erros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
