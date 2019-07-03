using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CadastroCliente
{
    class Radio:Conexao
    {
        private int codigo;
        private int codigotorre;
        private string descricao = "";
        private string canal = "";

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Codigotorre
        {
            get { return codigotorre; }
            set { codigotorre = value; }
        }

        public string Canal
        {
            get { return canal; }
            set { canal = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        override public void Incluir()
        {
            Sql = "";
            Sql += "Insert into Radios(CodigoTorre_radio,Descricao_radio,Canal_radio) values(";
            Sql += Codigotorre + ",'" + Descricao + "','" + Canal + "')";
            base.AcessarBanco();
        }

        override public void Excluir(int cod)
        {
            Sql = "";
            Sql += "Delete from Radios";
            Sql += " where Codigo_radio=" + cod.ToString();
            base.AcessarBanco();
        }

        override public void Alterar(int cod)
        {
            Sql = "";
            Sql += "Update Radios";
            Sql += " set CodigoTorre_radio=" + Codigotorre + ",";
            Sql += " Descricao_radio='" + Descricao + "',";
            Sql += " Canal_radio='" + Canal + "'";
            Sql += " where Codigo_radio=" + cod.ToString();
            base.AcessarBanco();
        }

        override public  DataSet Listar()
        {
            Descricao = Pesquisa;
            Sql = "";
            Sql += "Select Codigo_radio, CodigoTorre_radio, Descricao_radio, Canal_radio from Radios where Descricao_radio like '" + Descricao + "%'";
            Tabela = "Radios";
            return base.Listar();
        }
    }
}
