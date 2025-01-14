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

        private string serverName = "localhost";            //localhost
        private string port = "5432";                       //porta default
        private string userName = "postgres";               //nome do administrador
        private string password = "admin";                  //senha do administrador
        private string databaseName = "rural_simples_base"; //nome do banco de dados
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
