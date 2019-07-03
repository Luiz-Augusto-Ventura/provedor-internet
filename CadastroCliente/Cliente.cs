using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CadastroCliente
{
    class Cliente:Conexao
    {
        private int codigo;
        private string nome="";
        private string rua="";
        private int numero;
        private string bairro="";
        private string cpf = "";
        private string telefone = "";
        private string usuario = "";
        private string mac = "";
        private int codigoplano;
        private int codigoradio;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Mac
        {
            get { return mac; }
            set { mac = value; }
        }

        public int Codigoplano
        {
            get { return codigoplano; }
            set { codigoplano = value; }
        }

        public int Codigoradio
        {
            get { return codigoradio; }
            set { codigoradio = value; }
        }

        override public void Incluir()
        {
            Sql = "";
            Sql += "Insert into Clientes (Nome_cliente, Rua_cliente, NumeroCasa_cliente, Bairro_cliente, CPF_cliente, Telefone_cliente, Usuario_cliente, MACantena_cliente, Codigoplano_cliente, Codigoradio_cliente) values(";
            Sql += "'"+Nome + "','" + Rua + "', " + Numero + ", '" + Bairro + "', '"+Cpf+"', '"+Telefone+"', '"
                +Usuario+"', '"+Mac+"', "+Codigoplano+", "+Codigoradio+")";
            base.AcessarBanco();
        }

        override public void Excluir(int cod)
        {
            Sql = "";
            Sql += "Delete from Clientes";
            Sql += " where Codigo_cliente=" + cod.ToString();
            base.AcessarBanco();
        }

        override public void Alterar(int cod)
        {
            Sql = "";
            Sql += "Update Clientes";
            Sql += " set Nome_cliente='" + Nome + "',";
            Sql += " Rua_cliente='" + Rua + "',";
            Sql += " NumeroCasa_cliente=" + Numero + ",";
            Sql += " Bairro_cliente='" + Bairro + "',";
            Sql += " CPF_cliente='" + Cpf + "',";
            Sql += " Telefone_cliente='" + Telefone + "',";
            Sql += " Usuario_cliente='" + Usuario + "',";
            Sql += " MACantena_cliente='" + Mac + "',";
            Sql += " Codigoplano_cliente=" + Codigoplano + ",";
            Sql += " Codigoradio_cliente=" + Codigoradio;
            Sql += " where Codigo_cliente=" + cod;
            base.AcessarBanco();
        }

        override public DataSet Listar()
        {
            Nome = Pesquisa;
            Sql = "";
            Sql += "Select Codigo_cliente, Nome_cliente, Rua_cliente, NumeroCasa_cliente, Bairro_cliente, CPF_cliente, Telefone_cliente, Usuario_cliente, MACantena_cliente, Codigoplano_cliente, Codigoradio_cliente from Clientes where Nome_cliente like '" + Nome + "%'";
            Tabela = "Clientes";
            return base.Listar();
        }
    }
}
