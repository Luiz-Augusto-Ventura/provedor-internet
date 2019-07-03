using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CadastroCliente
{
    class Torre:Conexao
    {
        private int codigo;
        private string descricao = "";

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

        override public void Incluir()
        {
            Sql = "";
            Sql += "Insert into Torre (Descricao_torre) values(";
            Sql += "'" + Descricao + "')";
            base.AcessarBanco();
        }

        override public void Excluir(int cod)
        {
            Sql = "";
            Sql += "Delete from Torre";
            Sql += " where Codigo_torre=" + cod.ToString();
            base.AcessarBanco();
        }

        override public void Alterar(int cod)
        {
            Sql = "";
            Sql += "Update Torre";
            Sql += " set Descricao_torre='" + Descricao + "'";
            Sql += " where Codigo_torre=" + cod.ToString();
            base.AcessarBanco();
        }

        override public DataSet Listar()
        {
            Descricao = Pesquisa;
            Sql = "";
            Sql += "Select Codigo_torre, Descricao_torre from Torre where Descricao_torre like '" + Descricao + "%'";
            Tabela = "Torre";
            return base.Listar();
        }
    }
}
