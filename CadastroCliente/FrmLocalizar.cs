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
    public partial class FrmLocalizar : Form
    {
        public FrmLocalizar(Conexao pobjeto)
        {
            InitializeComponent();
            objeto = pobjeto;
        }

        private Conexao objeto = null;
        private int cod;
        private string pesquisa;

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }     

        public string Pesquisa
        {
            get { return pesquisa; }
            set { pesquisa = value; }
        }

        private void FormatarGridCategorias()
        {
            dataGridView1.Columns[0].Visible = false;
            //Segunda coluna usando toda a largura do grid
            if(dataGridView1.ColumnCount < 6)
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            dataGridView1.ScrollBars = ScrollBars.Both;
            //Coluna lateral invisível
            dataGridView1.RowHeadersVisible = false;
        }
        private void FrmLocalizar_Load(object sender, EventArgs e)
        {
            objeto.Pesquisa = "";
            dataGridView1.DataSource = objeto.Listar().Tables[objeto.Tabela];
            FormatarGridCategorias();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            objeto.Pesquisa = txtTextoDigitado.Text;
            dataGridView1.DataSource = objeto.Listar().Tables[objeto.Tabela];
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            Cod = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (objeto.Tabela == "Torre")
            {
                Pesquisa = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            if (objeto.Tabela == "Radios")
            {
                Pesquisa = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            if (objeto.Tabela == "Plano")
            {
                Pesquisa = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            if (objeto.Tabela == "Clientes")
            {
                Pesquisa = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[7].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[8].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[9].Value.ToString();
                Pesquisa += "," + dataGridView1.CurrentRow.Cells[10].Value.ToString();
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
