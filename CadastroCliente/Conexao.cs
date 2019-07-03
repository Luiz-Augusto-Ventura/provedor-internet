using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CadastroCliente
{
    public class Conexao
    {
        public SqlConnection cn = new SqlConnection();
        private bool status = false;
        private string sql;
        private string tabela;
        private string pesquisa;

        public string Pesquisa
        {
            get { return pesquisa; }
            set { pesquisa = value; }
        }

        public string Tabela
        {
            get { return tabela; }
            set { tabela = value; }
        }

        public string Sql
        {
            get { return sql; }
            set { sql = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        public void Conectar()
        {
            string s = "";
            s = "Server=127.0.0.1,1433\\MSSQL$SQLEXPRESS;Database=Integradoras;UID=sa;PWD=12345678;";
            cn.ConnectionString = s;
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
        }

        public void AcessarBanco()
        {
            try
            {
                Conectar();
                SqlCommand cd = new SqlCommand();
                cd.Connection = cn;
                cd.CommandText = Sql;
                cd.ExecuteNonQuery();
                Desconectar();
                Status = true;
            }
            catch(SqlException x)
            {
                Status = false;
            }
        }

        virtual public DataSet Listar()
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter(Sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, Tabela);
            Desconectar();
            return ds;
        }

        public DataSet FillComboBox()
        {
            Conexao cn = new Conexao();
            cn.Conectar();
            string SQL = "SELECT TABLE_NAME FROM Integradoras.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME != 'sysdiagrams';";
            SqlDataAdapter da = new SqlDataAdapter(SQL, cn.cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tabelas");
            cn.Desconectar();
            return ds;
        }

        virtual public void Incluir() { }

        virtual public void Excluir(int cod) { }

        virtual public void Alterar(int cod) { }

    }
}
