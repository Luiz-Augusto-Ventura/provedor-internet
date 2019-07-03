using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace CadastroCliente
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void cmdRelatorio_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Relatório";
            pd.PrintPage += Imprimir;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ((Form)ppd).WindowState = FormWindowState.Maximized;
            ppd.PrintPreviewControl.Zoom = 100 / 100f;
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void Imprimir(object sender, PrintPageEventArgs ev)
        {
            Conexao cx = new Conexao();
            cx.Conectar();
            string sql = "";
            sql += "SELECT Clientes.Nome_cliente AS \"Nome do cliente\", Plano.Descricao_plano AS \"Plano\",";
            sql += " Radios.Descricao_radio AS \"Rádio\", Radios.Canal_radio AS \"Canal do rádio\",";
            sql += " Torre.Descricao_torre AS \"Torre\"";
            sql += " FROM(Clientes INNER JOIN Plano ON Clientes.Codigoplano_cliente = Plano.Codigo_plano";
            sql += " INNER JOIN Radios ON Clientes.Codigoradio_cliente = Radios.Codigo_radio)";
            sql += " INNER JOIN Torre ON Radios.CodigoTorre_radio = Torre.Codigo_torre";


            SqlCommand cd = new SqlCommand(sql, cx.cn);
            SqlDataReader dr = cd.ExecuteReader();
          
            //Configurações da página
            float linhasPorPagina = 0;
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsquerda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;
            string linha = "";
            Font fonte = new Font("Arial", 10);
            alturaFonte = fonte.GetHeight(ev.Graphics);
            linhasPorPagina = ev.MarginBounds.Height / alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            //Título
            linha = "Relatório";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, 375 , posicaoVertical);
            contador += 2;

            while (dr.Read())
            {
                linha = "Nome do cliente: " + dr["Nome do cliente"].ToString();
                posicaoVertical = margemSuperior + contador * alturaFonte;
                ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
                contador++;

                linha = "Plano               : " + dr["Plano"].ToString();
                posicaoVertical = margemSuperior + contador * alturaFonte;
                ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
                contador++;

                linha = "Rádio               : " + dr["Rádio"].ToString();
                posicaoVertical = margemSuperior + contador * alturaFonte;
                ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
                contador++;

                linha = "Canal do rádio  : " + dr["Canal do rádio"].ToString();
                posicaoVertical = margemSuperior + contador * alturaFonte;
                ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
                contador++;

                linha = "Torre                : " + dr["Torre"].ToString();
                posicaoVertical = margemSuperior + contador * alturaFonte;
                ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
                contador++;
                contador++;

            }

            cx.Desconectar();
        }
    }
}
