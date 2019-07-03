using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroCliente
{
    public delegate void meuDelegate(int prog, ProgressBar pb);
    public partial class FrmImportar : Form
    {
        public FrmImportar()
        {
            InitializeComponent();
        }
        private Conexao cn = new Conexao();
        private string[] aux;
        private int Progresso;
        const int Delay = 2000;
        BackgroundWorker b = new BackgroundWorker();
        
        private void FrmImportar_Load(object sender, EventArgs e)
        {
            cboTabelas.DisplayMember = "TABLE_NAME";
            cboTabelas.ValueMember = "TABLE_NAME";
            cboTabelas.DataSource = cn.FillComboBox().Tables["Tabelas"];
        }

        private void BarraProgresso()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Progresso++;
            meuDelegate Atualiza = new meuDelegate(this.AtualizaProgresso);
            this.Invoke((Atualiza),Progresso, progressBar1);
        }

        private void AtualizaProgresso(int prog, ProgressBar pb)
        {
            pb.Value = prog;
            Thread.Sleep(Delay);
        }

        private void cmdImportar_Click(object sender, EventArgs e)
        {
            Importar(cboTabelas.SelectedValue.ToString());
            
        }

        private void Importar(string tabela)
        {    
            if (ImportarArquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                aux = System.IO.File.ReadAllLines(ImportarArquivo.FileName); 
            }
            
            try
            {
                if (aux != null)
                {
                    progressBar1.Visible = true;
                    List<string> Campos = new List<string>();
                    for (int i = 0; i < aux.Count(); i++)
                    {
                        Campos.Add(aux[i]);
                    }
                    List<string>[] Dados = new List<string>[Campos.Count()];
                    for (int j = 0; j < Campos.Count(); j++)
                    {
                        Dados[j] = Campos[j].Split(',').ToList();
                    }
                    Progresso = 0;
                    progressBar1.Maximum = Dados.GetLength(0);
                    switch (tabela)
                    {
                        case "Clientes":
                            Cliente C = new Cliente();
                            for (int i = 0; i < Dados.GetLength(0); i++)
                            {
                                C.Nome = Dados[i][0];
                                C.Rua = Dados[i][1];
                                C.Numero = int.Parse(Dados[i][2]);
                                C.Bairro = Dados[i][3];
                                C.Cpf = Dados[i][4];
                                C.Telefone = Dados[i][5];
                                C.Usuario = Dados[i][6];
                                C.Mac = Dados[i][7];
                                C.Codigoplano = int.Parse(Dados[i][8]);
                                C.Codigoradio = int.Parse(Dados[i][9].Replace(";", ""));
                                C.Incluir();
                                Thread Atualizar = new Thread(BarraProgresso);
                                Atualizar.Start();
                            }
                            break;
                        case "Plano":
                            Plano P = new Plano();
                            for (int i = 0; i < Dados.GetLength(0); i++)
                            {
                                P.Valor = float.Parse(Dados[i][0].Replace('.',','));
                                P.Download = Dados[i][1];
                                P.Upload = Dados[i][2];
                                P.Descricao = Dados[i][3].Replace(";", "");
                                P.Incluir();
                                Thread Atualizar = new Thread(BarraProgresso);
                                Atualizar.Start();
                            }
                            break;
                        case "Radios":
                            Radio R = new Radio();
                            for (int i = 0; i < Dados.GetLength(0); i++)
                            {
                                R.Codigotorre = int.Parse(Dados[i][0]);
                                R.Descricao = Dados[i][1];
                                R.Canal = Dados[i][2].Replace(";", "");
                                R.Incluir();
                                Thread Atualizar = new Thread(BarraProgresso);
                                Atualizar.Start();
                            }
                            break;
                        case "Torre":
                            Torre T = new Torre();
                            for (int i = 0; i < Dados.GetLength(0); i++)
                            {
                                T.Descricao = Dados[i][0].Replace(";", "");
                                T.Incluir();
                                Thread Atualizar = new Thread(BarraProgresso);
                                Atualizar.Start();
                            }
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show("Importação bem sucedida", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao importar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Value = 0;
                progressBar1.Visible = false;
            }
        }
    }
}
