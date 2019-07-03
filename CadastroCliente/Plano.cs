using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CadastroCliente
{
    class Plano:Conexao
    {
        private int codigo;
        private float valor;
        private string descricao = "";
        private string download = "";
        private string upload = "";

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Download
        {
            get { return download; }
            set { download = value; }
        }

        public string Upload
        {
            get { return upload; }
            set { upload = value; }
        }

        override public void Incluir()
        {
            Sql = "";
            Sql += "Insert into Plano (Valor_plano,TaxaDownload_plano,TaxaUpload_plano,Descricao_plano) values(";
            Sql += Valor.ToString().Replace(',','.') + ",'"+Download+"','"+Upload+"','"+Descricao+"')";                             
            base.AcessarBanco();
        }

        override public void Excluir(int cod)
        {
            Sql = "";
            Sql += "Delete from Plano";
            Sql += " where Codigo_plano=" + cod.ToString();
            base.AcessarBanco();
        }

        override public void Alterar(int cod)
        {
            Sql = "";
            Sql += "Update Plano";
            Sql += " set Valor_plano = "+ Valor.ToString().Replace(',', '.') + ",";
            Sql += " TaxaDownload_plano = '" + Download + "',";
            Sql += " TaxaUpload_plano = '" + Upload + "',";
            Sql += " Descricao_plano = '" + Descricao + "'";
            Sql += " where Codigo_plano = " + cod;
            base.AcessarBanco();
        }

        override public DataSet Listar()
        {
            Descricao = Pesquisa;
            Sql = "";
            Sql += "Select Codigo_plano, FORMAT(Valor_plano, 'N2'), TaxaDownload_plano, TaxaUpload_plano, Descricao_plano from Plano where Descricao_plano like '" + Descricao + "%'";
            Tabela = "Plano";
            return base.Listar();
        }
    }
}
