using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Model
{
    public class Conexao
    {
        private NpgsqlConnection conexao = new NpgsqlConnection();
        private NpgsqlTransaction transacao;

        private string serverName = "34.151.203.114";                //localhost
        private string port = "5432";                                //porta default
        private string userName = "postgres";                        //nome do administrador
        private string password = "^GRnI5ts3B*9m#jR";                //senha do administrador
        private string databaseName = "RS_FAZENDA_UNIAO";            //nome do banco de dados
        //Constructor
        public Conexao()
        {
            conexao.ConnectionString = String.Format("Server = {0}; Port = {1}; DataBase = {2}; User Id = {3}; Password = {4};", serverName, port, databaseName, userName, password);
        }
        //Conect
        public NpgsqlConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
                transacao = (NpgsqlTransaction)conexao.BeginTransaction();
            }
            return conexao;
        }
        //Desconect
        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                transacao.Commit();
                conexao.Close();
            }
        }
      
        public void CancelarTransacao()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                transacao.Rollback();
                conexao.Close();
            }
        }
    }
}
