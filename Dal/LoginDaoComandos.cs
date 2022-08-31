using Npgsql;
using RuralSimples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Dal
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        NpgsqlCommand cmd = new NpgsqlCommand();
        Conexao con = new Conexao();
        NpgsqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            //comandos NpgSQL para verificar se tem no banco
            cmd.CommandText = "select login, senha from pessoas where login = @login and senha = @senha and acesso_sistema = 'S'";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (NpgsqlException e)
            {
                this.mensagem = "Erro com o banco de dados! " + e.Message;
            }
            return tem;
        }

        public String cadastrar(String login, String senha, String confirmarSenha)
        {
            //Cadastrar o usuário no manco de dados
            return mensagem;
        }
    }
}
