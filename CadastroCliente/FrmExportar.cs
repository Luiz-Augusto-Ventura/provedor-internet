using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace CadastroCliente
{
    public partial class FrmExportar : Form
    {
        public FrmExportar()
        {
            InitializeComponent();
        }
        Conexao cn = new Conexao();
        private void FrmExportar_Load(object sender, EventArgs e)
        {
            cboTabelas.DisplayMember = "TABLE_NAME";
            cboTabelas.ValueMember = "TABLE_NAME";
            cboTabelas.DataSource = cn.FillComboBox().Tables["Tabelas"];
        }

        private DataSet Busca()
        {
            Conexao cn = new Conexao();
            cn.Conectar();
            string SQL = "SELECT * FROM " + cboTabelas.SelectedValue.ToString();
            SqlDataAdapter da = new SqlDataAdapter(SQL, cn.cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Exportacao");
            cn.Desconectar();
            return ds;
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            if (cboTabelas.SelectedValue != "")
            {
                DataSet aux = Busca();
                Write(aux.Tables["Exportacao"]);
                
            }  
        }

        private void Write(DataTable dt)
        {
            try
            {
                int[] tamColunas = new int[dt.Columns.Count];

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    tamColunas[i] = dt.Columns[i].ColumnName.Length;

                    foreach (DataRow row in dt.Rows)
                    {
                        if (!row.IsNull(i))
                        {
                            int tamanho = row[i].ToString().Length;

                            if (tamanho > tamColunas[i])
                            {
                                tamColunas[i] = tamanho;
                            }
                        }
                    }
                }
                if (ExportarArquivo.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(ExportarArquivo.FileName, FileMode.Create);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            sw.Write(dt.Columns[i].ColumnName.PadRight(tamColunas[i] + 2));
                        }

                        sw.WriteLine();
                        for (int i = 0; i < tamColunas.Length; i++)
                        {
                            for (int j = 0; j < tamColunas[i]; j++)
                                sw.Write("-");
                            if ((i + 1) < tamColunas.Length)
                                sw.Write("--");
                        }
                        sw.WriteLine();

                        foreach (DataRow row in dt.Rows)
                        {
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                if (!row.IsNull(i))
                                {
                                    sw.Write(row[i].ToString().PadRight(tamColunas[i] + 2));
                                }
                                else
                                {
                                    sw.Write(new string(' ', tamColunas[i] + 2));
                                }
                            }
                            sw.WriteLine();
                        }
                        sw.Close();
                        MessageBox.Show("Exportação concluída", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Erro ao exportar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
